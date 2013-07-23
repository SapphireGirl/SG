using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Data.Entity;


namespace SG.StateManagement
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
      
        

        static BaseContext()
        {
            // Need to use this here with multiple bounded contexts
            // But this Null Initializer should 
            // be used after the database is fully
            // completed

       //     Database.SetInitializer<TContext>(null);
           
        }

        protected BaseContext()
            : base("name = SGBoundedDatabase")
        {
            ((IObjectContextAdapter)this).ObjectContext
                .ObjectMaterialized += (sender, args) =>
                                           {
                                               var entity = args.Entity as IObjectWithState;
                                               if (entity != null)
                                               {
                                                   entity.State = State.Unchanged;
                                               }
                                           };
        }
        // Was a static method: This is a base class so we do not want to use 
        // a static method here.
        public EntityState ConvertState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Modified:
                    return EntityState.Modified;
                case State.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

        // Was a static method: This is a base class so we do not want to use 
        // a static method here.
        // Question: Make ApplyChanges happen automatically by
        // implementing INotifyPropertyChanges
        public void ApplyChanges<TEntity>(TEntity root) where TEntity : class, IObjectWithState
        {
            using (var context = new BaseContext<TContext>())
            {
                context.Set<TEntity>().Add(root);

                CheckForEntitiesWithoutStateInterface(context);

                foreach (var entry in context.ChangeTracker.Entries<IObjectWithState>())
                {
                    IObjectWithState stateInfo = entry.Entity;
                    entry.State = ConvertState(stateInfo.State);
                }

                context.SaveChanges();
            }
        }

        private void CheckForEntitiesWithoutStateInterface(BaseContext<TContext> context)
        {
            var entitiesWithoutState =
                from e in context.ChangeTracker.Entries()
                where !(e.Entity is IObjectWithState)
                select e;

            if (entitiesWithoutState.Any())
            {
                throw new NotSupportedException("All Entities must implement IObjectWithState");
            }
        }

    }
}

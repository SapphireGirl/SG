using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;


namespace SG.StateManagement.ForTests
{
    public class BaseContext_Test<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext_Test()
        {
            // Need to use this here with multiple bounded contexts
            //Database.SetInitializer<TContext>(null);

        }

        protected BaseContext_Test()
            : base("name = DatabaseContext_Test")
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
            using (var context = new BaseContext_Test<TContext>())
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

        private void CheckForEntitiesWithoutStateInterface(BaseContext_Test<TContext> context)
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

using System.Data.Entity.Infrastructure;
using SG.StateManagement;
using System.Data.Entity;
using SG.Mapping;
using SG.Model;
using SG.Util;

namespace SG.CoopBoundedContext
{
    public class CoopContext : BaseContext<CoopContext>, ICoopContext
    {

        public DbSet<Coop> Coops { get; set; }
        public DbSet<Produce> Produce { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<ShareLineItem> ShareLineItems { get; set; }
        //public DbSet<ShareReference> ShareReferences { get; set; }
        public DbSet<Payment> Payments { get; set; }


        public CoopContext()
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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Coop Context
            modelBuilder.Configurations.Add(new CoopConfig());
            modelBuilder.Configurations.Add(new VegetableConfig());
            modelBuilder.Configurations.Add(new FruitConfig());
            modelBuilder.Configurations.Add(new ShareConfig());
            modelBuilder.Configurations.Add(new ShareLineItemConfig());
            //modelBuilder.Configurations.Add(new ShareReferenceConfig());
            modelBuilder.Configurations.Add(new ProduceConfig());
            modelBuilder.Configurations.Add(new PaymentConfig());
        }
    }
}

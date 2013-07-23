using System;
using System.Data.Entity;
using SG.Mapping;
using SG.Model;
//using SG.StateManagement;
using SG.StateManagement.ForTests;

namespace SG.SGDatabaseContext
{

    //  ✌
    public class DatabaseContext_Test : BaseContext_Test<DatabaseContext>
    {
        // User Bounded Context
        public DbSet<User> Users { get; set; }
        public DbSet<PersonalInfo> PersonalInfomation { get; set; }


        // Coop Bounded Context

        public DbSet<Coop> Coops { get; set; }
       // public DbSet<Produce> Produce { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<Fruit> Fruits { get; set; } 

        public DatabaseContext_Test()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.ComplexType<Address>();
            modelBuilder.ComplexType<ShareType>();

            // Coop Context
            
            modelBuilder.Configurations.Add(new CoopConfig());
            modelBuilder.Configurations.Add(new VegetableConfig());
            modelBuilder.Configurations.Add(new FruitConfig());
            modelBuilder.Configurations.Add(new ShareConfig());
            modelBuilder.Configurations.Add(new ShareLineItemConfig());
            modelBuilder.Configurations.Add(new ProduceConfig());
            modelBuilder.Configurations.Add(new PaymentConfig());


        }
    }
}




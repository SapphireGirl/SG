using System;
using System.Data.Entity;
using SG.Mapping;
using SG.Model;
//using SG.StateManagement;
using SG.StateManagement.ForTests;

namespace SG.SGDatabaseContext
{

    //  ✌
    public class DatabaseContext : BaseContext_Test<DatabaseContext>
    {
        // User Bounded Context
        public DbSet<User> Users { get; set; }
        public DbSet<PersonalInfo> PersonalInfomation { get; set; }
       

        // Coop Bounded Context

        public DbSet<Coop> Coops { get; set; }
        public DbSet<Produce> Produce { get; set; } 
        public DbSet<Share> Shares { get; set; }
        public DbSet<ShareLineItem> ShareLineItems { get; set; }
        //public DbSet<ShareReference> ShareReferences { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DatabaseContext()
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Console.WriteLine("User Config");
            modelBuilder.Configurations.Add(new UserConfig());

            Console.WriteLine("Address Config");
            modelBuilder.ComplexType<Address>();

            Console.WriteLine("ShareType Config");
            modelBuilder.ComplexType<ShareType>();

            // Coop Context
            Console.WriteLine("Coop Config");
            modelBuilder.Configurations.Add(new CoopConfig());
            Console.WriteLine("Vegetable Config");
            modelBuilder.Configurations.Add(new VegetableConfig());
            Console.WriteLine("Fruit Config");
            modelBuilder.Configurations.Add(new FruitConfig());
            Console.WriteLine("Share Config");
            modelBuilder.Configurations.Add(new ShareConfig());
            Console.WriteLine("ShareLineItem Config");
            modelBuilder.Configurations.Add(new ShareLineItemConfig());
            Console.WriteLine("Produce Config");
            modelBuilder.Configurations.Add(new ProduceConfig());
            Console.WriteLine("Payment Config");
            modelBuilder.Configurations.Add(new PaymentConfig());


        }
    }
}




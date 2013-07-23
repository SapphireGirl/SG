using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using SG.Model;
using SG.Mapping;
using SG.StateManagement;


namespace SG.UserBoundedContext
{
    // User Bounded context
   /// <summary>
   /// UserContext is used to maintain the set of User Entities in our SQL database.
   /// Users can be added, removed, and updated.
   /// A UserAdmin can add and remove a user as well as Update.
   /// Individual users can update their information once they have created their account.
   /// </summary>
    public class UserContext :  BaseContext<UserContext>
    {

        public DbSet<User> Users { get; set; }
        public DbSet<PersonalInfo> PersonalInfomation { get; set; } 

        public UserContext()
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

           
            modelBuilder.Configurations.Add(new UserConfig());
          
          //  modelBuilder.Configurations.Add(new AddressConfig());
            modelBuilder.ComplexType<Address>();
          
            modelBuilder.Configurations.Add(new PersonalInfoConfig());
         
           
        }
    }
}

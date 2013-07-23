using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using SG.Model;
using SG.SGDatabaseContext;
using SG.StateManagement;
using Should.Fluent;

namespace SG.Test
{
   
    
    [TestClass]
    public class DatabaseContext_Tests
    {
        [TestInitialize]
        public void Create_DatabaseContext_Database()
        {
            Database.SetInitializer<DatabaseContext>(new InitializeSGDatabaseWithSeedData());
            using (var context = new DatabaseContext())
                Assert.IsTrue(context.Database.Exists());
        }


        [TestMethod]
        public void User_SeededCorrectly()
        {
            using (var context = new DatabaseContext())
            {

                var query = from u in context.Users
                            where u.FirstName == "Justine"
                            select u;
                var J = query.SingleOrDefault();
  
                Assert.IsNotNull(J);
                

            }
                
        }

        [TestMethod]
        public void TestEntityStateIsUnchangedWhenReturnedFromDatabase()
        {
            using (var context = new DatabaseContext())
            {
                foreach (var user in context.Users)
                {
                    Assert.AreEqual(user.State, State.Unchanged);
                }
                
            }
        }
        [TestMethod()]
        public void PersonFullNameReturnsFirstNamePlusLastName()
        {
            var person = new User
            {
                FirstName = "Barak",
                LastName = "Obama"
            };
            Assert.AreEqual(person.FullName, "Barak Obama");
        }

        [TestMethod()]
        public void DateCreatedNotNull()
        {
            using (var context = new DatabaseContext())
            {
                var user = context.Users.FirstOrDefault();
                user.DateCreated.ToShortDateString();
                Assert.AreEqual(user.DateCreated,"lllll");

            }
        }

        [TestMethod()]
        public void UserAddress_Is_Seeded_Correctly_In_DatabaseContext()
        {
            using (var context = new DatabaseContext())
            {
                var query = from user in context.Users
                            where user.FirstName == "Justine"
                            select user;

                //Assert()

            }
        }
    }
}

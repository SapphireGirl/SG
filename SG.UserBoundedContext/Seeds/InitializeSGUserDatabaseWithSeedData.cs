using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SG.Model;

namespace SG.UserBoundedContext
{
    public class InitializeSGUserDatabaseWithSeedData : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            base.Seed(context);

            // User 1
            Console.WriteLine("InitializeSGDatabaseWithSeedData");
            // User
            context.Users.Add(new User
            {
                FirstName = "Harry",
                LastName = "Reid",
                DateCreated = DateTime.Now,
                UserAddress = 
                {
                    StreetAddress = "Demo2LoserVille",
                    City = "Houston",
                    Region = "Texas",
                    ZipCode = "77777"
                },
                Info =
                {
                    Bio = "I am a spineless Democrat who has lost their identity.  I am a nothing Blob",
                    PoliticalAffiliation = "Democrat",
                    SocialSecurityNumber = 255674685,
                },

            });

            // User
            context.Users.Add(new User
            {
                FirstName = "George",
                LastName = "Bush",
                DateCreated = DateTime.Now,
                UserAddress =
                {
                    StreetAddress = "RepubLoserVille",
                    City = "Houston",
                    Region = "Texas",
                    ZipCode = "77777"
                },
                Info =
                {
                    Bio = "I am a lonely Republican! Why didn't I vote for Obama.  I need to go hate more",
                    PoliticalAffiliation = "Republican",
                    SocialSecurityNumber = 255674685,
                },
            });
        }
    }
}

using System;
using System.Data.Entity;
using SG.UserBoundedContext;
using SG.Configurations;


namespace SG.ConsoleApp
{
    public class UserContextMethods
    {
        public delegate void UserDatabaseDelegate();

    //    public ISGLogger logger = ServiceLocator.GetService<ISGLogger>("Logging");

        public static void UserDatabaseTests()
        {
            UserDatabaseDelegate user_delegate = new UserDatabaseDelegate(CreateUserContextDatabase);
            

            user_delegate();
        }


        //----------------------------------------------------------------
        // 2. CreateUserContextDatabase
        //----------------------------------------------------------------
        public static void CreateUserContextDatabase()
        {
            Console.WriteLine("CreateUserContextDatabase:");

            Database.SetInitializer<UserContext>(
                new InitializeSGUserDatabaseWithSeedData());

            
            using (var context = new UserContext())
            {
                if (context.Database.Exists())
                {
                    var doesItExist = context.Database.Exists().ToString();

                    Console.WriteLine("Database.Exists is {0}", doesItExist);
                    Configurations.Configurations.PrintSGDatabaseConnectionStringToConsole();

                }
                else
                {
                    Console.WriteLine("User Database does Not Exist Wahhhh");
                    Console.WriteLine("Check Connection String in Logs");

                    
                }
            }

        }
     

    }
}

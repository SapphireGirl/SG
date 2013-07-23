using System;
using System.Data.Entity;
using SG.CoopBoundedContext;

namespace SG.ConsoleApp
{
    public abstract class CoopContextMethods
    {
        public delegate void CoopDatabaseDelegate();

        public static void CoopDatabaseTests()
        {
            CoopDatabaseDelegate coop_delegate = new CoopDatabaseDelegate(CreateCoopContextDatabase);

            coop_delegate();
        }


        public static void CreateCoopContextDatabase()
        {
            Console.WriteLine("CreateUserContextDatabase:");

            Database.SetInitializer<CoopContext>(
                new InitializeSGCoopDatabaseWithSeedData());

            using (var context = new CoopContext())
            {
                if (context.Database.Exists())
                {
                    var doesItExist = context.Database.Exists().ToString();
                    Console.WriteLine("Database.Exists is {0}", doesItExist);
                }
                else
                {
                    Console.WriteLine("Coop does not Exist Wahhhhh");
                }
            }
        }
    }
}

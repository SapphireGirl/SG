using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using SG.Model;
using SG.SGDatabaseContext;
using SG.Logging;
using Microsoft.Practices.Unity;


namespace SG.ConsoleApp
{

    public delegate void GeneralDatabaseDelegate();
  
    public abstract class DatabaseContextMethods
    {
        public static void GeneralDatabaseTests()
        {
            GeneralDatabaseDelegate general_delegate = new GeneralDatabaseDelegate(CreateDatabaseContextDatabase);
            general_delegate += Print_FirstUser_Returned_From_Seeded_Database;
            general_delegate += Print_All_Users_FullName_In_SeedData;
            general_delegate += Print_Short_Date_String_From_All_Seeded_User;
            general_delegate += Print_All_User_And_Address_From_All_Seeded_Data;
            general_delegate += Print_First_Coop_Returned_From_Seeded_Database;
            general_delegate += Print_Vegetable_List_From_Seeded_Database;
            general_delegate += Print_ShareTypes_From_SeededData;
            general_delegate += Print_Share_From_SeededData;
            general_delegate += Test_Share_ShareLineItems_LazyLoading;

            general_delegate();
        }


        //----------------------------------------------------------------
        // 1. CreateDatabaseContextDatabase
        //----------------------------------------------------------------
        public static void CreateDatabaseContextDatabase()
        {
            Console.WriteLine("CreateDatabaseContextDatabase:");


            // Get the name of the database and the connection string from the app.config file.
            Database.SetInitializer<DatabaseContext>(
                new InitializeSGDatabaseWithSeedData());

            using (var context = new DatabaseContext())
            {
                if (context.Database.Exists())
                {
                    var DoesItExist = context.Database.Exists().ToString();

                    Console.WriteLine("Database.Exists is {0}", DoesItExist);

                }
                else
                {
                    Console.WriteLine("Testing Database does not Exist Wahhhhh");
                }
            }

        }


        //----------------------------------------------------------------
        // 2. Print_FirstUser_Returned_From_Seeded_Database
        //----------------------------------------------------------------
        public static void Print_FirstUser_Returned_From_Seeded_Database()
        {
            Console.WriteLine("Print_FirstUser_Returned_From_Seeded_Database:");
            using (var context = new DatabaseContext())
            {
                var user = context.Users.FirstOrDefault();
                if (user != null)
                    Console.WriteLine("{0} {1}", user.FirstName, user.LastName);
                else
                    Console.WriteLine("User is Null: Using FirstOrDefault: Sadness");
            }
        }

        //----------------------------------------------------------------
        // 3. Print_All_Users_In_SeedData
        //----------------------------------------------------------------
        public static void Print_All_Users_FullName_In_SeedData()
        {
            Console.WriteLine("Print_All_Users_FullName_In_SeedData:");
            using (var context = new DatabaseContext())
            {
                var query = from u in context.Users
                            orderby u.LastName
                            select u;
                foreach (var user in query)
                {
                    Console.WriteLine("User ID: {0}", user.UserId);
                    Console.WriteLine("User Name: {0}", user.FullName);
                }
            }
        }

        //----------------------------------------------------------------
        // 4. Print_Short_Date_String_From_Seeded_User
        //----------------------------------------------------------------
        public static void Print_Short_Date_String_From_All_Seeded_User()
        {
            Console.WriteLine("Print_Short_Date_String_From_All_Seeded_User:");
            using (var context = new DatabaseContext())
            {
                var query = from u in context.Users
                            orderby u.LastName
                            select u.DateCreated;

                foreach (var dateTime in query)
                {
                    Console.WriteLine("{0}", dateTime.ToShortDateString());
                }
            }
        }

        //----------------------------------------------------------------
        // 5. Print_All_User_And_Address_From_All_Seeded_Data
        //----------------------------------------------------------------
        public static void Print_All_User_And_Address_From_All_Seeded_Data()
        {
            Console.WriteLine("Print_Initial_State_From_All_Seeded_Data:");

            using (var context = new DatabaseContext())
            {
                var query = from d in context.Users
                            orderby d.LastName
                            select d;

                foreach (var user in query)
                {

                    Console.WriteLine("{0}", PrintUser(user));
                }

            }

        }

        //----------------------------------------------------------------
        // Static Methods
        // PrintUser
        //----------------------------------------------------------------
        public static string PrintUser(User user)
        {
            StringBuilder ustring = new StringBuilder(
                user.UserId + " " +
                user.FirstName + "\n" +
                user.LastName + "\n" +
                user.FullName + "\n" +
                user.State + "\n" +
                user.DateCreated + "\n" +
                user.UserAddress.StreetAddress + "\n" +
                user.UserAddress.City + "\n" +
                user.UserAddress.Region + "\n" +
                user.UserAddress.ZipCode + "\n");

            return ustring.ToString();
        }

        //******************************************************************
        //----------------------------------------------------------------
        // Coop Tests
        //----------------------------------------------------------------
        public static void Print_First_Coop_Returned_From_Seeded_Database()
        {
            Console.WriteLine("Print_First_Coop_Returned_From_Seeded_Database");

            using (var context = new DatabaseContext())
            {
                foreach (var coop in context.Coops)
                {
                    Console.WriteLine(coop.CoopId);
                    Console.WriteLine(coop.Name);
                    Console.WriteLine(coop.CoopAddress.StreetAddress);
                    Console.WriteLine(coop.CoopAddress.City);
                    Console.WriteLine(coop.CoopAddress.Region);
                    Console.WriteLine(coop.CoopAddress.ZipCode);
                }
            }
        }

        //******************************************************************
        //----------------------------------------------------------------
        // Vegi Tests
        //----------------------------------------------------------------
        public static void Print_Vegetable_List_From_Seeded_Database()
        {
            Console.WriteLine("Print_Vegetable_List_From_Seeded_Database");

            using (var context = new DatabaseContext())
            {
                foreach (var vegi in context.Produce)
                {
                    Console.WriteLine(vegi.ProduceId);
                    Console.WriteLine(vegi.Name);
                    Console.WriteLine(vegi.PricePerEach);
                    Console.WriteLine(vegi.PricePerFlat);
                    Console.WriteLine(vegi.PricePerPound);


                }
            }
        }

        //******************************************************************
        // ----------------------------------------------------------------
        // Share Tests
        // ----------------------------------------------------------------    

        public static void Print_Share_From_SeededData()
        {
            Console.WriteLine("******************** Shares ************************");
            Console.WriteLine("Print_Share_From_SeededData");

            using (var context = new DatabaseContext())
            {
                var query = from shares in context.Shares
                            orderby shares.ShareDate
                            select shares;

                foreach (var share in query)
                {
                    Console.WriteLine("{0} Share:", share.ShareId);
                    Console.WriteLine("Date: {0} ", share.ShareDate);
                    Console.WriteLine("Day of Week: {0} ", share.Day);


                }
            }

        }
        //******************************************************************
        // ----------------------------------------------------------------
        // ShareLineItems Tests
        // ----------------------------------------------------------------    
        public static void PrintShareLineItemsInShare_Using_LazyLoading()
        {
            Console.WriteLine("PrintShareLineItemsInShare_Using_LazyLoading");
            using (var context = new DatabaseContext())
            {
                // Load all shares into memory
                context.Shares.Load();

                var sharesWithShareLines = from d in context.Shares.Local
                                           orderby d.ShareId
                                           select d;

                foreach (var sharelines in sharesWithShareLines)
                {
                    Console.WriteLine("{0}", sharelines);

                }

            }
        }
        public static void Print_ShareTypes_From_SeededData()
        {
            using (var context = new DatabaseContext())
            {

                Console.WriteLine("Print_ShareTypes_From_SeededData");
                //var halfBoxCustomers = context.Shares.Where(t => t.ShareSize.Value == (int) ShareTypes.Half).ToList();

                var halfBoxCustomers = context.Shares.Where(t => t.Value == (int)ShareTypes.Half).ToList();

                var wholeBoxCustomers = context.Shares.Where(t => t.Value == (int)ShareTypes.Whole).ToList();

                Console.WriteLine("Half: {0}", halfBoxCustomers);
                Console.WriteLine("Whole: {0}", wholeBoxCustomers);


            }
        }

        private static void Test_Share_ShareLineItems_LazyLoading()
        {
            using (var context = new DatabaseContext())
            {
                var query = from s in context.Shares
                            where s.ShareId == 1
                            select s;

                var share = query.Single();
                Console.WriteLine("ShareDay: {0} ShareLineItem is :", share.Day);
                if (share.ShareLineItems != null)
                {
                    foreach (var sharelines in share.ShareLineItems)
                    {
                        Console.WriteLine(sharelines.LineProduce.Name);
                    }
                }
            }
        }

    }// End of class
}

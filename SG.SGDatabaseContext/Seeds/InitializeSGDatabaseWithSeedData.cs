using System;
using System.Collections.Generic;
using System.Data.Entity;
using SG.Model;

namespace SG.SGDatabaseContext
{
    public class InitializeSGDatabaseWithSeedData : DropCreateDatabaseAlways<DatabaseContext>
    {

        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

     //       Console.WriteLine("InitializeSGDatabaseWithSeedData");
            // User
            context.Users.Add(new User
            {
                FirstName = "Justine",
                LastName = "AndJanie",
                DateCreated = DateTime.Now,
                UserAddress =
                {
                    StreetAddress = "Downtown",
                    City = "Houston",
                    Region = "Texas",
                    ZipCode = "77777"
                },
                Info =
                {
                    Bio = "I am a lonely Republican! ",
                    PoliticalAffiliation = "Republican",
                    SocialSecurityNumber = 255674683,
                },
            });

//            Console.WriteLine("After 1st User Seeded");

            context.Users.Add(new User
            {
                FirstName = "Janie",
                LastName = "McDonald",
                DateCreated = DateTime.Now,
                UserAddress =
                {
                    StreetAddress = "Heights",
                    City = "New York",
                    Region = "New York",
                    ZipCode = "111111"
                },
                Info =
                {
                    Bio = "I am a lonely Independent!",
                    PoliticalAffiliation = "Independent",
                    SocialSecurityNumber = 255674694,
                },
            });

  //          Console.WriteLine("After 2nd User Seeded");

            context.Users.Add(new User
            {
                FirstName = "Kaye",
                LastName = "Petit",
                DateCreated = DateTime.Now,
                UserAddress =
                {
                    StreetAddress = "SkyLine Dr",
                    City = "Albuquerque",
                    Region = "NM",
                    ZipCode = "87112"
                },
                Info =
                {
                    Bio = "I am a lonely Democrat!",
                    PoliticalAffiliation = "Democrat",
                    SocialSecurityNumber = 255674605,
                },
            });

  //          Console.WriteLine("Seeding Coop");

            // Coops
            context.Coops.Add(new Coop
                                  {
                                      Name = "Rawfully Organic",
                                      CoopAddress =
                                          {
                                              StreetAddress = "Arboretum Dr",
                                              City = "Houston",
                                              Region = "TX",
                                              ZipCode = "97117"
                                          },

                                  });

            // Vegetables
       //     Console.WriteLine("Seeding Vegi");

            context.Produce.Add(new Vegetable
            {
                Name = "Zucchini",
                PricePerEach = (decimal)0.25,
                PricePerFlat = (decimal)7.25,
                PricePerPound = (decimal)1.25,
                VegiSubstitutions = new List<Vegetable>()
                                       {
                                           new Vegetable(){ Name = "Eggplant",
                                            PricePerEach = (decimal)2.25,
                                            PricePerFlat = (decimal)12.25,
                                            PricePerPound = (decimal)1.39,
                                           },
                                           new Vegetable(){ Name = "Parsnip",
                                            PricePerEach = (decimal)0.39,
                                            PricePerFlat = (decimal)4.25,
                                            PricePerPound = (decimal)0.79,
                                           }

                                       }
            });

            // Fruit
      //      Console.WriteLine("Seeding Fruit");

            context.Produce.Add(new Fruit
            {
                Name = "Apple",
                PricePerEach = (decimal)0.25,
                PricePerFlat = (decimal)40.00,
                PricePerPound = (decimal)1.25,
                FruitSubstitutions = new List<Fruit>()
                                       {
                                           new Fruit(){ 
                                                Name = "Oranges",
                                                PricePerEach = (decimal)0.75,
                                                PricePerFlat = (decimal)40.25,
                                                PricePerPound = (decimal)0.98,
                                           },
                                           new Fruit(){ Name = "Blueberries",
                                            PricePerEach = (decimal)2.39,
                                            PricePerFlat = (decimal)20.25,
                                          //  PricePerPound = (decimal)0.79,
                                           }

                                       }
            });

            // Shares
   //         Console.WriteLine("Seeding Shares");

            context.Shares.Add(
                new Share
                    {
                        ShareSize = new ShareType((int)ShareTypes.Whole),
                        //       HalfSharePrice = (decimal?)48.50,
                        FullSharePrice = (decimal?)98.50,
                        Day = DayOfWeek.Saturday,
                        ShareDate = System.DateTime.Today.ToShortDateString(),
                        ShareLineItems = new List<ShareLineItem>()
                                             {
                                                 new ShareLineItem()
                                                     {
                                                         LineProduce = new Vegetable()
                                                                         { 
                                                                            Name = "Chives",
                                                                            PricePerEach = (decimal)0.39,
                                                                            PricePerFlat = (decimal)4.25,
                                                                            PricePerPound = (decimal)0.79,
                                                                         },
                                                        
                                                     },
                                                     new ShareLineItem()
                                                     {
                                                         LineProduce = new Fruit()
                                                                         { 
                                                                            Name = "Pomegranite",
                                                                            PricePerEach = (decimal)0.39,
                                                                            PricePerFlat = (decimal)4.25,
                                                                            PricePerPound = (decimal)0.79,
                                                                         },
                                                        
                                                     }
                                             }


                    });
     //       Console.WriteLine("Seeding Shares 2");

            context.Shares.Add(
                    new Share
                        {
                            ShareSize = new ShareType((int)ShareTypes.Whole),
                            //       HalfSharePrice = (decimal?)48.50,
                            FullSharePrice = (decimal?)98.50,
                            Day = DayOfWeek.Tuesday,
                            ShareDate = System.DateTime.Today.ToShortDateString(),
                            ShareLineItems = new List<ShareLineItem>()
                                             {
                                                 new ShareLineItem()
                                                     {
                                                         LineProduce = new Vegetable()
                                                                         { 
                                                                            Name = "Swiss Chard",
                                                                            PricePerEach = (decimal)1.19,
                                                                            PricePerFlat = (decimal)12.00,
                                                                            PricePerPound = (decimal)0.0,
                                                                         },
                                                        
                                                     },
                                                     new ShareLineItem()
                                                     {
                                                         LineProduce = new Fruit()
                                                                         { 
                                                                            Name = "Pinapple",
                                                                            PricePerEach = (decimal)3.39,
                                                                            PricePerFlat = (decimal)0.0,
                                                                            PricePerPound = (decimal)0.0,
                                                                         },
                                                        
                                                     }
                                             } // End of ShareLineItems
                        } ); // End of New Second Share


  //          Console.WriteLine("End of Seeding");


        } // End of Seed Method
    } // End of InitializeSGDatabaseWithSeedData class
}

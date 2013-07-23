using System;
using System.Collections.Generic;
using System.Data.Entity;
using SG.Model;


namespace SG.CoopBoundedContext
{
    public class InitializeSGCoopDatabaseWithSeedData : DropCreateDatabaseAlways<CoopContext>
    {
        protected override void Seed(CoopContext context)
        {
            base.Seed(context);

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
                    }); // End of New Second Share
                  


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using SG.Model;
using SG.Logging;
using SG.Logging;
// TODO: Use Enterprise Library Logging
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace SG.ConsoleApp
{
    public class Program
    {

        private static LogWriter writer = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();
        private TraceManager traceMgr = EnterpriseLibraryContainer.Current.GetInstance<TraceManager>();

        private IUnityContainer _container;

        static void Main(string[] args)
        {
           
           

            // Set up Container


            
        
           writer.Write("Setting up a new log");

            Console.WriteLine("Choose Your Context");

            Console.WriteLine("Choose General Context : 1");
            Console.WriteLine("Choose User Context     : 2");
            Console.WriteLine("Choose Coop Context     : 3");
          

            var choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Choice: {0}", choice);

            switch (choice)
            {
                case 1:
                    
                    DatabaseContextMethods.GeneralDatabaseTests();
                    break;
                case 2:
                    UserContextMethods.UserDatabaseTests();
                    break;
                case 3:
                    CoopContextMethods.CoopDatabaseTests();
                    break;
             
                default:
                    {
                        Console.WriteLine("Invalid Choice");
                        break;
                    }


            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}

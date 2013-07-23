using System;
using System.Configuration;
using System.Text;

namespace SG.Configurations
{
    public abstract class Configurations
    {
        // Changing Configuration Files for Deployment
        public static void UseTestingConfigurations()
        {
            
        }
        public static void  PrintAllConnectionStringtoConsole()
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {

                foreach (ConnectionStringSettings cs in settings)
                {
                    StringBuilder builder = new StringBuilder();
                    Console.WriteLine("----------");
                    Console.WriteLine(cs.Name);
                    Console.WriteLine(cs.ProviderName);
                    Console.WriteLine(cs.ConnectionString);
                    builder.Append(cs.Name).Append(cs.ProviderName).Append(cs.ConnectionString);
                    Console.WriteLine(builder);
                }
            }

        }

        public static void PrintSGDatabaseConnectionStringToConsole()
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {

                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.Name == "SGBoundedDatabase")
                    {
                        StringBuilder builder = new StringBuilder();
                        Console.WriteLine("SGBoundedDatabase is:");
                        Console.WriteLine(cs.Name);
                        Console.WriteLine(cs.ProviderName);
                        Console.WriteLine(cs.ConnectionString);
                        builder.Append(cs.Name).Append(cs.ProviderName).Append(cs.ConnectionString);
                        Console.WriteLine(builder);
                    }
                }
            }

        }
    }
}

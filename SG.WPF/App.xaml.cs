using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using SG.SGDatabaseContext;
using System.Data.Entity;

namespace SG.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Lets get the DB ready

            Database.SetInitializer<DatabaseContext>(new InitializeSGDatabaseWithSeedData());

            // Set up Bootstrapper
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }

    }
}

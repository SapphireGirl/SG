using System.Windows;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Unity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;
using SG.BannerModule;
using SG.ContentModule;
using SG.Logging;
using SG.MenuModule;
using SG.SocialModule;
using SG.Util;
using SG.VideoModule;

namespace SG.WPF
{
    public class Bootstrapper : UnityBootstrapper
    {

        protected override DependencyObject CreateShell()
        {
            var Shell = Container.Resolve<Shell>();
            return Shell;
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window) Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<IShellViewModel, ShellViewModel>();


            Container.AddNewExtension<EnterpriseLibraryCoreExtension>();
            Container.RegisterType<ISGLogger, SGLogger>(new ContainerControlledLifetimeManager());
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog mCatalog = new ModuleCatalog();
            mCatalog.AddModule(typeof (BannerModuleMain));
            mCatalog.AddModule(typeof(MenuModuleMain));
            mCatalog.AddModule(typeof(ContentModuleMain));
            mCatalog.AddModule(typeof(SocialModuleMain));
            mCatalog.AddModule(typeof(VideoModuleMain));

            return mCatalog;
        }
    }
}

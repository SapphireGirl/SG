using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using SG.MenuModule.ViewModels;
using SG.MenuModule.Views;
using SG.Util;
using SG.CoopBoundedContext;

namespace SG.MenuModule
{
    public class MenuModuleMain : ModuleBase
    {

        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;
        private ISGLogger _logger;

        public int ErrorCode { get; set; }
        public MenuModuleMain(IUnityContainer container, IRegionManager regionManager) : base(container, regionManager)
        {
            _container = container;
            _regionManager = regionManager;
            _logger = _container.Resolve<ISGLogger>();
        }

        protected override void RegisterTypes()
        {
            _container.RegisterType<IMenuViewModel, MenuViewModel>();
            _container.RegisterType<IMenuView, MenuView>();
            _container.RegisterType<ICoopContext, CoopContext>();

        }

        protected override void RegisterViewsWithRegionAndResolveVM()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof (MenuView));
            IRegion mRegion = _regionManager.Regions[RegionNames.MenuRegion];

            if (mRegion != null)
            {
                var v = _container.Resolve<IMenuView>();
                v.ViewModel = _container.Resolve<IMenuViewModel>();
                mRegion.Add(v);
            }
            else
            {
                _logger.WriteToLog("RegisterViewsWithRegionAndResolveVM: bRegion is null, not returned from regionManager");
            }
        }
    }
}

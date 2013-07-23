using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using SG.PriceShopModule.ViewModels;
using SG.PriceShopModule.Views;
using SG.Util;

namespace SG.PriceShop
{
    public class PriceShopModuleMain: ModuleBase
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;
        private ISGLogger _logger;

        public int ErrorCode { get; set; }

        public PriceShopModuleMain(IUnityContainer container, IRegionManager regionManager): base(container, regionManager)
        {
            
        }

        protected override void RegisterTypes()
        {
            _container.RegisterType<IPriceShopViewModel, PriceShopViewModel>();
            _container.RegisterType<IPriceShopView, PriceShopView>();

            // TODO: Register controls within PriceShopViews
        }
        protected override void RegisterViewsWithRegionAndResolveVM()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.PriceShopRegion, typeof(PriceShopView));

            IRegion psRegion = _regionManager.Regions[RegionNames.PriceShopRegion];

            if (psRegion != null)
            {
                var v = _container.Resolve<IPriceShopView>();
                v.ViewModel = _container.Resolve<IPriceShopViewModel>();
                psRegion.Add(v);
            }
            else
            {
                _logger.WriteToLog("PriceShopModuleMain: RegisterViewsWithRegionAndResolveVM: psRegion is Null, not returned from _regionManager");
            }
        }

    }
}

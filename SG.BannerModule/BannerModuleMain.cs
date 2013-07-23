using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using SG.BannerModule.ViewModels;
using SG.BannerModule.Views;
using SG.Util;

namespace SG.BannerModule
{
    public class BannerModuleMain : ModuleBase
    {

        private IUnityContainer _container;
        private IRegionManager _regionManager;
        private ISGLogger _logger;

        public int ErrorCode { get; set; }
        public BannerModuleMain(IUnityContainer container, IRegionManager regionManager) : base(container, regionManager)
        {
            _container = container;
            _regionManager = regionManager;
            _logger = _container.Resolve<ISGLogger>();
        }

        protected override void RegisterTypes()
        {
            _container.RegisterType<IBannerViewModel, BannerViewModel>();
            _container.RegisterType<IBannerView, BannerView>();
        }

        protected override void RegisterViewsWithRegionAndResolveVM()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.BannerRegion, typeof (BannerView));
            IRegion bRegion = _regionManager.Regions[RegionNames.BannerRegion];

            if (bRegion != null)
            {
                var v = _container.Resolve<IBannerView>();
                v.ViewModel = _container.Resolve<IBannerViewModel>();

                bRegion.Add(v);
               // var sb = new StringBuilder();
               // sb.Append("RegisterViewsWithRegionAndResolveVM: \n");
               
               //sb.Append("bRegion returned from regionManager");
               //sb.Append("v.BannerUri: ", v.ViewModel.BannerImageUri);
               // _logger.WriteToLog("");
               // _logger.WriteToLog("RegisterViewsWithRegionAndResolveVM: bRegion is null, not returned from regionManager");

            }
            else
            {
                _logger.WriteToLog("RegisterViewsWithRegionAndResolveVM: bRegion is null, not returned from regionManager");
            }
        }
    }
}

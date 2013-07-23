using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using SG.ContentModule.ViewModels;
using SG.ContentModule.Views;
using SG.Util;

namespace SG.ContentModule
{
    public class ContentModuleMain : ModuleBase
    {

        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;
        private ISGLogger _logger;

        public int ErrorCode { get; set; }


        // Need to inject your services into your view model
        public ContentModuleMain(IUnityContainer container, IRegionManager regionManager) : base(container, regionManager)
        {
            this._container = container;
            this._regionManager = regionManager;
            this._logger = _container.Resolve<ISGLogger>();
        }

        protected override void RegisterTypes()
        {
            _container.RegisterType<IContentViewModel, ContentViewModel>();
            _container.RegisterType<IContentView, ContentView>();
        }

        protected override void RegisterViewsWithRegionAndResolveVM()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof (ContentView));
            IRegion bRegion = _regionManager.Regions[RegionNames.ContentRegion];

            if (bRegion != null)
            {
                var v = _container.Resolve<IContentView>();
                v.ViewModel = _container.Resolve<IContentViewModel>();

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

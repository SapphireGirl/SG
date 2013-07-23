using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using SG.VideoModule.ViewModels;
using SG.VideoModule.Views;
using SG.Util;

namespace SG.VideoModule
{
    public class VideoModuleMain : ModuleBase
    {

        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;
        private ISGLogger _logger;

        private bool designTime;

        public int ErrorCode { get; set; }
        public VideoModuleMain(IUnityContainer container, IRegionManager regionManager) : base(container, regionManager)
        {
            _container = container;
            _regionManager = regionManager;
            _logger = _container.Resolve<ISGLogger>();

            designTime = true;
        }

        protected override void RegisterTypes()
        {
            _container.RegisterType<IVideoViewModel, VideoViewModel>();
            _container.RegisterType<IVideoView, VideoView>();
        }

        protected override void RegisterViewsWithRegionAndResolveVM()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.VideoRegion, typeof (VideoView));
            IRegion bRegion = _regionManager.Regions[RegionNames.VideoRegion];

            if (bRegion != null)
            {
                var v = _container.Resolve<IVideoView>();
                v.ViewModel = _container.Resolve<IVideoViewModel>();

                bRegion.Add(v);
                // TODO Test if Region content is loaded
//                if (v._contentLoaded)
                //if (_regionManager.Regions.ContainsRegionWithName())
                if (designTime)
                    _logger.WriteToLog("RegisterViewsWithRegionAndResolveVM: Added View to Region");


            }
            else
            {
                _logger.WriteToLog("RegisterViewsWithRegionAndResolveVM: bRegion is null, not returned from regionManager");
            }
        }
    }
}

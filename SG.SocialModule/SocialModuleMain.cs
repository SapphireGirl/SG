using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using SG.SocialModule.ViewModels;
using SG.SocialModule.Views;
using SG.Util;

namespace SG.SocialModule
{
    public class SocialModuleMain : ModuleBase
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;
        private ISGLogger _logger;

        public int ErrorCode { get; set; }
        public SocialModuleMain(IUnityContainer container, IRegionManager regionManager)
            : base(container, regionManager)
        {
            _container = container;
            _regionManager = regionManager;
            _logger = _container.Resolve<ISGLogger>();
        }

        protected override void RegisterTypes()
        {
            _container.RegisterType<ISocialViewModel, SocialViewModel>();
            _container.RegisterType<ISocialView, SocialView>();
        }

        protected override void RegisterViewsWithRegionAndResolveVM()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.SocialRegion, typeof(SocialView));
            IRegion bRegion = _regionManager.Regions[RegionNames.SocialRegion];

            if (bRegion != null)
            {
                var v = _container.Resolve<ISocialView>();
                v.ViewModel = _container.Resolve<ISocialViewModel>();
                bRegion.Add(v);
            }
            else
            {
                _logger.WriteToLog("RegisterViewsWithRegionAndResolveVM: bRegion is null, not returned from regionManager");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using SG.BannerModule.Views;
using SG.Util;

namespace SG.BannerModule.ViewModels
{
    public class BannerViewModel : ViewModelBase, IBannerViewModel
    {
        private IUnityContainer _container;
        private ISGLogger _logger;
        private Uri _bannerImageUri;

        public Uri BannerImageUri
        {
            get { return new Uri("pack://SG.BannerModule:,,,/Assets/SGBannerVector_WPF.jpg"); }
            // TODO: Need to make this private/Immutable
            // readonly?
            set
            {
                if (value != _bannerImageUri)
                {
                    _bannerImageUri = value;
                    OnPropertyChanged("BannerImageUri");
                }

            }
        }

      

        #region Constructors

        // Here our View and our Container will not change: Thus they are immutable and we
        // can set them in our constructor
        // Where as a URI for our banner can change depending on our layout.  Do not set here.
        // Constructors are used only to set required and immutable properties
        public BannerViewModel(IBannerView bannerView,IUnityContainer container): base(bannerView)
        {
            View = bannerView;
            _container = container;
            _logger = _container.Resolve<ISGLogger>();

            
        }

        #endregion
        #region Commands

        #endregion

    }
}

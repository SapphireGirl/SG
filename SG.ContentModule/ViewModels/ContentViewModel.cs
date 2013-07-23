using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using SG.ContentModule.Views;
using SG.Util;

namespace SG.ContentModule.ViewModels
{
    public class ContentViewModel : ViewModelBase, IContentViewModel
    {
        private IUnityContainer _container;
        private ISGLogger _logger;
       

      

        #region Constructors

        // Here our View and our Container will not change: Thus they are immutable and we
        // can set them in our constructor
        // Where as a URI for our banner can change depending on our layout.  Do not set here.
        // Constructors are used only to set required and immutable properties
        public ContentViewModel(IContentView contentView,IUnityContainer container): base(contentView)
        {
            View = contentView;
            _container = container;
            _logger = _container.Resolve<ISGLogger>();

            
        }


        #endregion
        #region Commands

        #endregion

    }
}

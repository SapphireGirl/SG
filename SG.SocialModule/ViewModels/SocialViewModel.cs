using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using SG.SocialModule.Views;
using SG.Util;

namespace SG.SocialModule.ViewModels
{
    public class SocialViewModel : ViewModelBase, ISocialViewModel
    {
        private IUnityContainer _container;
        private ISGLogger _logger;
       
        #region Constructors

        // Here our View and our Container will not change: Thus they are immutable and we
        // can set them in our constructor
       // Ask about resolving our Logger in the constructor?
        // Constructors are used only to set required and immutable properties
        public SocialViewModel(ISocialView socialView,IUnityContainer container): base(socialView)
        {
            View = socialView;
            _container = container;
            _logger = _container.Resolve<ISGLogger>();
        }

        #endregion
        #region Commands

        #endregion

    }
}

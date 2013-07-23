using System;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using SG.CoopBoundedContext;
using SG.MenuModule.Views;
using SG.Util;

namespace SG.MenuModule.ViewModels
{
    public class MenuViewModel : ViewModelBase, IMenuViewModel
    {
        private IUnityContainer _container;
        private ISGLogger _logger;

        public DelegateCommand<CoopContext> SwitchMainContentCommand { get; set; }
      

        #region Constructors

        // Here our View and our Container will not change: Thus they are immutable and we
        // can set them in our constructor
        // Where as a URI for our banner can change depending on our layout.  Do not set here.
        // Constructors are used only to set required and immutable properties
        public MenuViewModel(IMenuView menuView, IUnityContainer container)
            : base(menuView)
        {
            View = menuView;
            _container = container;
            _logger = _container.Resolve<ISGLogger>();

            
        }

        #endregion
        #region Commands

        #endregion

    }
}

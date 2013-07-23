using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using SG.PriceShopModule.Views;
using SG.Util;

namespace SG.PriceShopModule.ViewModels
{
    public class PriceShopViewModel : ViewModelBase, IPriceShopViewModel
    {

        private IUnityContainer _container;
        private ISGLogger _logger;

        #region Constructors
		 
        public PriceShopViewModel(IPriceShopView priceShopView, IUnityContainer container) : base(priceShopView)
        {
            View = priceShopView;
            _container = container;
            _logger = _container.Resolve<ISGLogger>();
        }
	    #endregion
       
    }
}

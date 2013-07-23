using System.Windows.Controls;
using SG.PriceShopModule.ViewModels;
using SG.Util;

namespace SG.PriceShopModule.Views
{
    /// <summary>
    /// Interaction logic for PriceShopView.xaml
    /// </summary>
    public partial class PriceShopView : UserControl, IPriceShopView
    {
        public PriceShopView()
        {
            InitializeComponent();
        }

        public IViewModel ViewModel
        {
            get { return (IPriceShopViewModel) DataContext; }
            set { DataContext = value; }
        }
    }
}

using System.Windows.Controls;
using SG.MenuModule.ViewModels;
using SG.Util;

namespace SG.MenuModule.Views
{
   
    public partial class MenuView : UserControl, IMenuView
    {
        public MenuView()
        {
            InitializeComponent();
        }

        public IViewModel ViewModel
        {
            get { return (IMenuViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}

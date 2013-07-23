using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SG.BannerModule.ViewModels;
using SG.Util;

namespace SG.BannerModule.Views
{
    /// <summary>
    /// Interaction logic for BannerView.xaml
    /// </summary>
    public partial class BannerView : UserControl, IBannerView
    {
        public BannerView()
        {
            InitializeComponent();
            
            
        }

        public IViewModel ViewModel
        {
            get { return (IBannerViewModel) DataContext; }
            set { DataContext = value; }
        }
    }
}

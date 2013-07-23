using System.Windows.Controls;
using SG.SocialModule.ViewModels;
using SG.Util;

namespace SG.SocialModule.Views
{
   
    public partial class SocialView : UserControl, ISocialView
    {
        public SocialView()
        {
            InitializeComponent();
        }

        public IViewModel ViewModel
        {
            get { return (ISocialViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}

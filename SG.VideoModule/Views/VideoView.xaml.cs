using System.Windows.Controls;
using SG.Util;
using SG.VideoModule.ViewModels;


namespace SG.VideoModule.Views
{
   
    public partial class VideoView : UserControl , IVideoView
    {
        public VideoView()
        {
            InitializeComponent();
        }

        public IViewModel ViewModel
        {
            get { return (IVideoViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}

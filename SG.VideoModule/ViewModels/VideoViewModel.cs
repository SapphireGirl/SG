using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using SG.VideoModule.Properties;
using SG.VideoModule.Views;
using SG.Util;
using System.ComponentModel;

namespace SG.VideoModule.ViewModels
{
    public class VideoViewModel : ViewModelBase, IVideoViewModel
    {
        private readonly IUnityContainer _container;
        private ISGLogger _logger;
        private Uri _videoUri;
        // Not sure I need this?
        private string _displayName ;
        private Image _videoPreview;


        public string DisplayName
        {
            get { return _displayName;}
            set
            {
                _displayName = value;
            }
        }
        private Video _video;
        public Video Video
        {
            get { return _video; }
            set 
            {
                _video = value;
                _video.PropertyChanged += Video_PropertyChanged;
                OnPropertyChanged("Video");
            }
        }



       
        public Uri VideoUri
        {
            get { return new Uri("pack://SG.VideoModule:,,,/Assets/CatheJanie.mp4"); }
            // TODO: Need to make this private/Immutable
            // readonly?
            set
            {
                if (value != _videoUri)
                {
                    _videoUri = value;
                    OnPropertyChanged("VideoImageUri");
                }

            }
        }

        

      

        #region Constructors

        // Here our View and our Container will not change: Thus they are immutable and we
        // can set them in our constructor
        // Where as a URI for our banner can change depending on our layout.  Do not set here.
        // Constructors are used only to set required and immutable properties
        public VideoViewModel(IVideoView videoView,IUnityContainer container): base(videoView)
        {
            View = videoView;
            _container = container;
            _logger = _container.Resolve<ISGLogger>();
        //    DisplayName = (string) Application.Current.Resources["VideoDisplay"];
            CreateVideo();
            PlayCommand = new DelegateCommand<Video>(Play, CanPlay);

            
        }

        #endregion
        #region Methods
        //public void PlayVideo(object sender, RoutedEventArgs e)
        //{
        //    View.VideoPreview.Visibility = Visibility.Collapsed;
        //    IntroVideo.Visibility = Visibility.Visible;
        //    IntroVideo.Play();

        //}
        private void CreateVideo()
        {
            Video = new Video()
            {
                PlayTime = DateTime.Now,
                VideoUrl = "Assets/CatheJanie.mp4"
            };
        }

        #endregion

        #region Commands
        public DelegateCommand<Video> PlayCommand { get; set; }

        public void Play(Video video)
        {
            video.PlayTime = DateTime.Now;
        }

       private bool CanPlay(Video video)
       {
           return Video.Error == null;
       }

         void  Video_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PlayCommand.RaiseCanExecuteChanged();
        }
        
        #endregion

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SG.VideoModule.ViewModels
{
    public class Video : IVideo, INotifyPropertyChanged, IDataErrorInfo
    {
        
        public string VideoUrl { get; set; }
          private DateTime? _playTime;
        public DateTime? PlayTime
        {
            get { return _playTime; }
            set
            {
                _playTime = value;
                OnPropertyChanged("LastUpdated");
            }
        }
    

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        #region IDataErrorInfo

        private string _Error;
        public string Error
        {
            get { return _Error; }
            private set 
            { 
                _Error = value;
                OnPropertyChanged("Error");
            }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }
        // Example of how to implement for Error Validations
        //public string this[string columnName]
        //{
        //    get
        //    {
        //        string error = null;

        //        switch (columnName)
        //        {
        //            case "FirstName":
        //                if (string.IsNullOrEmpty(_firstName))
        //                {
        //                    error = "First Name required";
        //                }
        //                break;
        //            case "LastName":
        //                if (string.IsNullOrEmpty(_lastName))
        //                {
        //                    error = "Last Name required";
        //                }
        //                break;
        //            case "Age":
        //                if ((_age < 18) || (_age > 85))
        //                {
        //                    error = "Age out of range.";
        //                }
        //                break;
        //        }
        //        Error = error;
        //        return (Error);
        //    }
        //}
        #endregion
      
}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SG.Util
{
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        public IView View { get; set; }
      
        // Constructors
        public ViewModelBase() {}

        public ViewModelBase(IView view)
        {
            View = view;
            View.ViewModel = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            else
            {
                {
                    // TODO: Log this
                }
            }
        }

    }
}

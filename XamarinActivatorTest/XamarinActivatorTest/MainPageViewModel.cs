using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinActivatorTest
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy; set
            {
                _isBusy = value;
                RaisePropertyChanged("IsBusy");
            }
        }
        public MainPageViewModel()
        {
            _isBusy = false;
        }

    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public RelayCommand SendCommand { get; set; }

        public List<String> MyData { get; set; }

        private bool isFlyoutOpen;
        public bool IsFlyoutOpen
        {
            get { return isFlyoutOpen; }
            set { this.Set(() => IsFlyoutOpen, ref isFlyoutOpen, value); }
        }

        public MainPageViewModel()
        {
            SendCommand = new RelayCommand(() =>
            {
                // Doing processing...
                IsFlyoutOpen = false;
            });
            MyData = new List<string> { "winffee", "123", "this Data" };
        }
    }
}

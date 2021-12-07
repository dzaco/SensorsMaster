using SensorsMaster.Common.Interfaces;
using SensorsMaster.Device.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.AppSettings.ViewModel
{
    public class SettingsViewModel : ViewModelBase
    {
        public Settings Settings { get; set; }
        public SettingsViewModel()
        {
            Settings = Settings.GetInstance();
        }

        public POICollection POICollection
        {
            get { return this.Settings.POICollection; }
            set
            {
                this.Settings.POICollection = value;
                OnPropertyChanged("Collection");
            }
        }
    }
}

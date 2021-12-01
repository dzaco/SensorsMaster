using SensorsMaster.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.AppSettings.ViewModel
{
    public class SizeSettingsViewModel : ViewModelBase
    {
        Settings settings = Settings.GetInstance();
        public double Width
        {
            get { return settings.SizeSettings.Width; }
            set
            {
                settings.SizeSettings.Width = value;
                OnPropertyChanged(settings.SizeSettings);
            }
        }
        public double Height
        {
            get { return settings.SizeSettings.Height; }
            set
            {
                settings.SizeSettings.Height = value;
                OnPropertyChanged(settings.SizeSettings);
            }
        }
        public double Scale
        {
            get { return settings.SizeSettings.Scale; }
            set
            {
                settings.SizeSettings.Scale = value;
                OnPropertyChanged(settings.SizeSettings);
            }
        }
    }
}

using SensorsMaster.AppSettings.Model;
using SensorsMaster.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.AppSettings.ViewModel
{
    public class SensorSettingsViewModel : ViewModelBase
    {
        public SensorSettings SensorSettings { get; set; }
        public SensorSettingsViewModel()
        {
            SensorSettings = SensorSettings.GetInstance();
        }
    }
}

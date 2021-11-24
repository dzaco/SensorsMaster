using SensorsMaster.Common.Interfaces;
using SensorsMaster.Device.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Device.ViewModel
{
    public class SensorViewModel : ViewModelBase
    {
        public Sensor Sensor { get; set; }
        public SensorViewModel(Sensor sensor)
        {
            Sensor = sensor;
        }
    }
}

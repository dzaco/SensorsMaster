using SensorsMaster.AppSettings;
using SensorsMaster.Common.Enums;
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
        public Settings Settings { get; set; }

        public SensorViewModel(Sensor sensor)
        {
            Sensor = sensor;
            Settings = Settings.GetInstance();
        }

        public double HalfRange => (Sensor.Range / 2);
        public double Left => Sensor.Point.X - HalfRange;
        public double Top => Sensor.Point.Y - HalfRange;
        public double Width => Sensor.Range * 2 * Settings.SizeSettings.Scale;

        public string PositionAsMargin => $"{Left} {Top} 0 0";

        public string Color => Sensor.Battery.Power == Power.On ? "Green" : "Red";
        public double Opacisty => Sensor.Battery.Power == Power.On ? 0.4 : 0.2 ;
    }
}

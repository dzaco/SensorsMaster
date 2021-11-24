using SensorsMaster.AppSettings;
using SensorsMaster.Common.Enums;
using Newtonsoft.Json;

namespace SensorsMaster.Device.Model
{
    public class Battery
    {
        #region Properties
        [JsonIgnore]
        public Settings Settings => Settings.GetInstance();

        public Power Power { get; set; }

        public double Capacity { get; set; } 
        #endregion

        #region Constructors
        public Battery()
        {
            Capacity = Settings.SensorSettings.BatteryCapacity;
        } 
        #endregion

    }
}

using System;
using Newtonsoft.Json;

namespace SensorsMaster.AppSettings.Model
{
    public class SensorSettings
    {
        #region Singleton
        private static SensorSettings _instance;
        private static readonly object _lock = new object();
        public static SensorSettings GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SensorSettings();
                    }
                }
            }
            return _instance;
        }
        #endregion
        private SensorSettings()
        {

        }
        public double Range { get; set; } = 20;
        public double Count { get; set; } = 5;
        public double BatteryCapacity { get; set; } = 100;
    }
}

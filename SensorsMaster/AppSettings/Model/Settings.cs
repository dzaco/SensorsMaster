using SensorsMaster.AppSettings.Model;
using SensorsMaster.Common;
using Newtonsoft.Json;

namespace SensorsMaster.AppSettings
{
    public class Settings
    {
        #region Singleton
        private static Settings _instance;
        private static readonly object _lock = new object();
        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Settings();
                    }
                }
            }
            return _instance;
        }
        #endregion

        private Settings()
        {
        }

        public string ConfigPath { get; set; } = FileManager.ConfigFile;

        public SensorSettings SensorSettings { get; set; } = SensorSettings.GetInstance();
        public double Scale { get; set; } = 5;
    }
}

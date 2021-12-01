using SensorsMaster.AppSettings.Model;
using SensorsMaster.Common;
using Newtonsoft.Json;
using System;
using SensorsMaster.Common.Interfaces;

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
            this.SensorSettings = SensorSettings.GetInstance();
            this.SizeSettings = new SizeSettings();
        }

        public string ConfigPath = FileManager.ConfigFile;
        public SensorSettings SensorSettings { get; set; }
        public SizeSettings SizeSettings { get; set; }
    }
}

using SensorsMaster.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SensorsMaster.Settings.Model
{
    [XmlRoot()]
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

        [XmlElement]
        public string ConfigPath { get; set; } = FileManager.ConfigFile;

        [XmlElement]
        public SensorSettings SensorSettings { get; set; } = SensorSettings.GetInstance();
    }
}

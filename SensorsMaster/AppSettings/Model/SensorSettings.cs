using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SensorsMaster.AppSettings.Model
{
    [XmlRoot(nameof(SensorSettings))]
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
        [XmlElement]
        public double Range { get; set; } = 20;
        [XmlElement]
        public double Count { get; set; } = 5;

    }
}

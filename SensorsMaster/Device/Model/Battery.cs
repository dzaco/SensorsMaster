using SensorsMaster.AppSettings;
using SensorsMaster.Common.Enums;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model
{
    [XmlRoot]
    public class Battery
    {
        #region Properties
        [XmlIgnore]
        public Settings Settings => Settings.GetInstance();

        [XmlAttribute]
        public Power Power { get; set; }

        [XmlAttribute]
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

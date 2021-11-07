using SensorsMaster.AppSettings;
using SensorsMaster.Common.Enums;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model
{
    [XmlRoot]
    public class Battery
    {
        [XmlIgnore]
        public Settings Settings => Settings.GetInstance();

        [XmlAttribute]
        public Power Power { get; set; }

        [XmlElement]
        public double Capacity { get; set; }

        public Battery() 
        { 
            
        }

    }
}

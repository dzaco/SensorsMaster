using SensorsMaster.AppSettings;
using SensorsMaster.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model
{
    [XmlRoot(nameof(Sensor), IsNullable = false)]
    public class Sensor : BoardElement
    {
        #region Constructors
        public Sensor()
        {
            Id = Count++;
            this.Battery = new Battery();
            this.Range = this.Settings.SensorSettings.Range;
            this.POIInRange = new POICollection();
        } 
        public Sensor(Coordinates coordinates, double range, Power power) : this()
        {
            this.Coordinates = coordinates;
            this.Range = range;
            this.Battery.Power = power;
        }
        #endregion
        
        #region Properties
        [XmlIgnore]
        public static int Count { get; private set; }

        [XmlElement]
        public Battery Battery { get; set; }

        [XmlAttribute]
        public double Range { get; set; }

        [XmlArray]
        public POICollection POIInRange { get; set; }
        #endregion
    }
}

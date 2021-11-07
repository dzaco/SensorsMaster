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
        [XmlElement]
        public double Range { get; set; }

        [XmlArray]
        public POICollection POIInRange { get; set; }

        public Sensor()
        {
            this.POIInRange = new POICollection();
        }

    }
}

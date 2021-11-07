using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model
{
    [XmlRoot(nameof(POI), IsNullable = false)]
    public class POI : BoardElement
    {
        public POI() : base() { }
        public POI(Coordinates coordinates) : base(coordinates) { }

        [XmlElement]
        public bool IsCovered { get; set; }

    }
}

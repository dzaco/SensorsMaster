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
        #region Constructors
        public POI() : base()
        {
            Id = Count++;
        }
        public POI(Coordinates coordinates) : base(coordinates) { }
        #endregion

        #region Properties
        [XmlIgnore]
        public static int Count { get; private set; }

        [XmlElement]
        public bool IsCovered { get; set; } 
        #endregion

    }
}

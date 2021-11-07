using SensorsMaster.AppSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model.Collection
{
    [XmlRoot(nameof(SensorCollection))]
    public class SensorCollection : List<Sensor>
    {
        [XmlIgnore]
        public Settings Settings => Settings.GetInstance();
    }
}

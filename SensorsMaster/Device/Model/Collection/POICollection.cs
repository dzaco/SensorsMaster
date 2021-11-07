using System.Collections.Generic;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model
{
    [XmlRoot(nameof(POICollection), IsNullable = false)]
    public class POICollection : List<POI>
    {
        public void Add(POI poi, bool isCovered)
        {
            poi.IsCovered = isCovered;
            base.Add(poi);
        }
        public void AddRange(IEnumerable<POI> pois, bool isCovered)
        {
            foreach (var poi in pois)
                this.Add(poi, isCovered);
        }
    }
}
using SensorsMaster.AppSettings;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model
{
    [XmlRoot(nameof(POICollection), IsNullable = false)]
    public class POICollection : List<POI>
    {
        #region Properties
        [XmlIgnore]
        public Settings Settings => Settings.GetInstance();
        #endregion
        
        #region Methods
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
        #endregion

    }
}
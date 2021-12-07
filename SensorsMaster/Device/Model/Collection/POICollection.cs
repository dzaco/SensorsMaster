using SensorsMaster.AppSettings;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections;

namespace SensorsMaster.Device.Model
{
    public class POICollection : List<POI>
    {
        public POICollection()
        {
            
        }
        #region Properties
        [JsonIgnore]
        public Settings Settings => Settings.GetInstance();
        #endregion

        #region Methods
        public void Add(POI poi, bool? isCovered = null)
        {
            if (isCovered.HasValue)
                poi.IsCovered = isCovered.Value;
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
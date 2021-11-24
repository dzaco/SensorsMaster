using SensorsMaster.AppSettings;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SensorsMaster.Device.Model.Collection
{
    public class SensorCollection : List<Sensor>
    {
        #region Properties
        [JsonIgnore]
        public Settings Settings => Settings.GetInstance(); 
        #endregion
    }
}

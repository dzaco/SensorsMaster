using System;
using Newtonsoft.Json;

namespace SensorsMaster.Device.Model
{
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
        [JsonIgnore]
        public static int Count { get; private set; }

        public bool IsCovered { get; set; } 
        #endregion

    }
}

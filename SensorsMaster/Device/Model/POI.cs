using System;
using System.Windows;
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
        public POI(Point coordinates) : base(coordinates) { }
        public POI(double x, double y) : base(x, y) { }
        #endregion

        #region Properties
        [JsonIgnore]
        public static int Count { get; private set; }

        public bool IsCovered { get; set; } 
        #endregion

    }
}

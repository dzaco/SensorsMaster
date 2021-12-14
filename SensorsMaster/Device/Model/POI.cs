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
            Id = AutoIncrement++;
        }
        public POI(Point coordinates) : base(coordinates) 
        {
            Id = AutoIncrement++;
        }
        public POI(double x, double y) : this(new Point(x,y)) { }
        #endregion

        #region Properties
        [JsonIgnore]
        public static int AutoIncrement { get; set; }

        public bool IsCovered { get; set; } 
        #endregion

    }
}

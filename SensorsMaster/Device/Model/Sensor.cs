using SensorsMaster.Common.Enums;
using System;
using Newtonsoft.Json;

namespace SensorsMaster.Device.Model
{
    public class Sensor : BoardElement
    {
        #region Constructors
        public Sensor()
        {
            Id = Count++;
            this.Battery = new Battery();
            this.Range = this.Settings.SensorSettings.Range;
            this.POIInRange = new POICollection();
        } 
        public Sensor(Coordinates coordinates, double range, Power power) : this()
        {
            this.Coordinates = coordinates;
            this.Range = range;
            this.Battery.Power = power;
        }
        #endregion

        #region Properties
        [JsonIgnore]
        public static int Count { get; private set; }

        public Battery Battery { get; set; }

        public double Range { get; set; }

        public POICollection POIInRange { get; set; }
        #endregion
    }
}

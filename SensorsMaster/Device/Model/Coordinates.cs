using System.Windows;
using Newtonsoft.Json;

namespace SensorsMaster.Device.Model
{
    public class Coordinates
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; } 
        #endregion

        #region Constructors
        public Coordinates()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Coordinates(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        #endregion

        #region Methods
        public double Distance(Coordinates coordinates)
        {
            Point p1 = new Point(this.X, this.Y);
            Point p2 = new Point(coordinates.X, coordinates.Y);

            return Point.Subtract(p2, p1).Length;
        } 
        #endregion
    }
}
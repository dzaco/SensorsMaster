using System.Windows;
using System.Xml.Serialization;

namespace SensorsMaster.Device.Model
{
    [XmlRoot(nameof(Coordinates))]
    public class Coordinates
    {
        #region Properties
        [XmlAttribute]
        public double X { get; set; }
        [XmlAttribute]
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
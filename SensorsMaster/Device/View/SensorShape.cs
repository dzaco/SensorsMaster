using SensorsMaster.AppSettings;
using SensorsMaster.AppSettings.Model;
using SensorsMaster.Common.Enums;
using SensorsMaster.Common.Extensions;
using SensorsMaster.Device.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SensorsMaster.Device.View
{
    public class SensorShape : DeviceShape
    {
        public static readonly DependencyProperty SensorProperty =
        DependencyProperty.Register(
            name: "Sensor",
            propertyType: typeof(Sensor),
            ownerType: typeof(SensorShape),
            typeMetadata: new FrameworkPropertyMetadata(defaultValue: new Sensor()));

        public Sensor Sensor
        {
            get
            {
                return (Sensor)GetValue(SensorProperty);
            }
            set
            {
                SetValue(SensorProperty, value);
                Refresh();
            }
        }

        public override Geometry CreateGeometry()
        {
            GeometryGroup group = new GeometryGroup();
            var scale = Settings.SizeSettings.Scale;
            var point = Sensor.Point.Factor(scale);
            var range = Sensor.Range * scale;

            group.Children.Add(CreateCircle(point, 2));
            group.Children.Add(CreateCircle(point, range));

            this.Fill = new SolidColorBrush(GetColorFor(Sensor.Battery.Power));
            return group;
        }

        private Geometry CreateCircle(Point point, double range)
        {
            var rangeGeometry = new EllipseGeometry();
            rangeGeometry.Center = new Point(point.X, point.Y);
            rangeGeometry.RadiusX = range;
            rangeGeometry.RadiusY = range;
   
            return rangeGeometry;
        }

        private Color GetColorFor(Power power)
        {
            if(power == Power.On)
                return Color.FromArgb(100, (byte)0, (byte)255, (byte)0);
            else
                return Color.FromArgb(30, (byte)255, (byte)0, (byte)0);
        }
    }
}

using SensorsMaster.AppSettings;
using SensorsMaster.Common.Extensions;
using SensorsMaster.Common.Interfaces;
using SensorsMaster.Device.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SensorsMaster.Device.View
{
    public class POIShape : DeviceShape
    {
        public static readonly DependencyProperty POIProperty =
        DependencyProperty.Register(
            name: "POI",
            propertyType: typeof(POI),
            ownerType: typeof(POIShape),
            typeMetadata: new FrameworkPropertyMetadata(defaultValue: new POI()));

        public POIShape(POI poi)
        {
            this.POI = poi;
        }
        public POI POI
        {
            get
            {
                return (POI)GetValue(POIProperty);
            }
            set 
            { 
                SetValue(POIProperty, value);
                Refresh();
            }
        }
        public override Geometry CreateGeometry()
        {
            var scale = Settings.SizeSettings.Scale;
            var center = CreateSquere(POI.Point.Factor(scale), Size);
            if (POI.IsCovered)
                this.Fill = System.Windows.Media.Brushes.Green;
            else
                this.Fill = System.Windows.Media.Brushes.Transparent;

            return center;
        }

        private Geometry CreateSquere(Point point, double size)
        {
            var halfSize = size / 2;
            var leftTop = new Point(point.X - halfSize, point.Y + halfSize);
            var rightBottom = new Point(point.X + halfSize, point.Y - halfSize);

            var center = new RectangleGeometry();
            center.Rect = new Rect(leftTop, rightBottom);

            return center;
        }

    }
}

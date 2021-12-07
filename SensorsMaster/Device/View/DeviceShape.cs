using SensorsMaster.AppSettings;
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
    public abstract class DeviceShape : Shape
    {
        public Settings Settings = Settings.GetInstance();

        public static readonly DependencyProperty SizeProperty =
        DependencyProperty.Register(
            name: "Size",
            propertyType: typeof(double),
            ownerType: typeof(DeviceShape),
            typeMetadata: new FrameworkPropertyMetadata(defaultValue: 5.0));

        public double Size
        {
            get => (double)GetValue(SizeProperty);
            set => SetValue(SizeProperty, value);
        }


        public DeviceShape()
        {
            this.Stroke = Brushes.Black;
            Settings.SizeSettings.PropertyChanged += Refresh;
        }

        protected override Geometry DefiningGeometry
        {
            get
            {
                if (this.CustomGeometry is null)
                    CustomGeometry = CreateGeometry();

                return this.CustomGeometry;
            }
        }
        public abstract Geometry CreateGeometry();
        public Geometry CustomGeometry { get; set; }
        public void Refresh(object sender = null, PropertyChangedEventArgs e = null)
        {
            CustomGeometry = CreateGeometry();
        }

        protected Geometry CreateSquere(Point point, double size)
        {
            var halfSize = size / 2;
            var leftTop = new Point(point.X - halfSize, point.Y + halfSize);
            var rightBottom = new Point(point.X + halfSize, point.Y - halfSize);

            var center = new RectangleGeometry();
            center.Rect = new Rect(leftTop, rightBottom);

            return center;
        }
        protected Geometry CreateCircle(Point point, double range)
        {
            var rangeGeometry = new EllipseGeometry();
            rangeGeometry.Center = new Point(point.X, point.Y);
            rangeGeometry.RadiusX = range;
            rangeGeometry.RadiusY = range;

            return rangeGeometry;
        }
    }
}

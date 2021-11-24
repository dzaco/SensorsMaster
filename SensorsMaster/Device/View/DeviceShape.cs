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
    public abstract class DeviceShape : Shape
    {
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
        }

    }
}

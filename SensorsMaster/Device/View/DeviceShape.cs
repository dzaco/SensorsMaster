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
    }
}

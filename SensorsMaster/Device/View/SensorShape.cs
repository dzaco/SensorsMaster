﻿using SensorsMaster.AppSettings;
using SensorsMaster.AppSettings.Model;
using SensorsMaster.Common.Enums;
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
            get => (Sensor)GetValue(SensorProperty);
            set => SetValue(SensorProperty, value);
        }
        
        protected override Geometry DefiningGeometry
        {
            get
            {
                GeometryGroup group = new GeometryGroup();
                group.Children.Add(CreateCircle(Sensor.Point, 2));
                group.Children.Add(CreateCircle(Sensor.Point, Sensor.Range));
                
                this.Fill = new SolidColorBrush(GetColorFor(Sensor.Battery.Power));
                return group;
            }
        }

        private Geometry CreateCircle(Point point, double range)
        {
            var rangeGeometry = new EllipseGeometry();
            rangeGeometry.Center = point;
            rangeGeometry.RadiusX = range;
            rangeGeometry.RadiusY = range;
   
            return rangeGeometry;
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

        private Color GetColorFor(Power power)
        {
            if(power == Power.On)
                return Color.FromArgb(100, (byte)0, (byte)255, (byte)0);
            else
                return Color.FromArgb(30, (byte)255, (byte)0, (byte)0);
        }
    }
}

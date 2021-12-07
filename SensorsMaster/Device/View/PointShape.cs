using SensorsMaster.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SensorsMaster.Device.View
{
    public class PointShape : DeviceShape
    {
        public PointShape(Point point)
        {
            Point = point;
        }

        public Point Point { get; }

        public override Geometry CreateGeometry()
        {
            var scale = Settings.SizeSettings.Scale;
            var center = CreateSquere(Point.Factor(scale), Size);
            return center;
        }
    }
}

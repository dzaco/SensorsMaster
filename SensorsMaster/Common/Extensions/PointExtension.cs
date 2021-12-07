﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SensorsMaster.Common.Extensions
{
    public static class PointExtension
    {
        public static Point Factor(this Point point, double scale)
        {
            return new Point(point.X * scale, point.Y * scale);
        }
    }
}
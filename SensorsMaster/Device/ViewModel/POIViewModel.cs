using SensorsMaster.AppSettings;
using SensorsMaster.Common.Interfaces;
using SensorsMaster.Device.Model;
using SensorsMaster.Device.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SensorsMaster.Device.ViewModel
{
    public class POIViewModel : ViewModelBase
    {
        public POI POI { get; set; }

        public POIViewModel(POI poi)
        {
            this.POI = poi;
        }
        //public double Width { get; set; } = 5;
        //public double Left => POI.Point.X - (Width / 2);
        //public double Top => POI.Point.Y - (Width / 2);
        //public string PositionAsMargin => $"{Left} {Top} 0 0";

    }
}

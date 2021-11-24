using SensorsMaster.Common.Interfaces;
using SensorsMaster.Device.Model;
using SensorsMaster.Device.View;
using System;
using System.Collections.Generic;
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
    }
}

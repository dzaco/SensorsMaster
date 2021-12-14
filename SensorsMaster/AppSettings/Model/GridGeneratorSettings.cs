using SensorsMaster.Common.Enums;
using SensorsMaster.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.AppSettings.Model
{
    public class GridGeneratorSettings : ViewModelBase
    {
        private GridShape gridShape;
        private double distance;
        private POIGenerateStrategy poiGenerateStrategy;

        public GridGeneratorSettings()
        {
            gridShape = GridShape.Square;
            distance = 20;
            poiGenerateStrategy = new POIGenerateStrategy();
        }

        public GridShape GridShape
        {
            get { return gridShape; }
            set
            {
                gridShape = value;
                OnPropertyChanged(GridShape);
            }
        }
        public double Distance
        {
            get { return distance; }
            set
            {
                distance = value;
                OnPropertyChanged(distance);
            }
        }
    }
}

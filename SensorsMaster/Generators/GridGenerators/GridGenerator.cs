using SensorsMaster.AppSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Generators.GridGenerators
{
    public abstract class GridGenerator
    {
        public abstract GridNodes Generate();
        public Settings Settings;

        public double Width { get; }
        public double Height { get; }
        public double Rows { get; }
        public double Columns { get; }
        public GridNodes GridNodes { get; }
        public double Distance { get; }

        public GridGenerator(double distance)
        {
            Settings = Settings.GetInstance();
            GridNodes = new GridNodes();
            Distance = distance;
            Width = Settings.SizeSettings.Width;
            Height = Settings.SizeSettings.Height;
            Rows = (Height / distance)-1;
            Columns = (Width / distance)-1;
        }
    }
}

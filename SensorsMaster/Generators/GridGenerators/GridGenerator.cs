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
        public int Rows { get; }
        public int Columns { get; }
        public GridNodes GridNodes { get; }
        public double Distance { get; }

        public GridGenerator(double distance)
        {
            Settings = Settings.GetInstance();
            Distance = distance;
            Width = Settings.SizeSettings.Width;
            Height = Settings.SizeSettings.Height;
            Rows = (int) (Height / distance)-1;
            Columns = (int) (Width / distance)-1;
            GridNodes = new GridNodes(Distance, Rows, Columns);
        }
    }
}

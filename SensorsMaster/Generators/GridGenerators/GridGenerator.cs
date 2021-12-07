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
        public double DistanceHorizontally { get; }
        public double DistanceVertically { get; }
        public int Rows { get; }
        public int Columns { get; }
        public GridNodes GridNodes { get; }

        public GridGenerator(int rows, int cols)
        {
            Settings = Settings.GetInstance();
            GridNodes = new GridNodes(rows,cols);
            Width = Settings.SizeSettings.Width;
            Height = Settings.SizeSettings.Height;
            Rows = rows;
            Columns = cols;
            DistanceHorizontally = Width / (Columns+1);
            DistanceVertically = Height / (Rows+1);
        }
    }
}

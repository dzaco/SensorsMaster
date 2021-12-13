using SensorsMaster.AppSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SensorsMaster.Generators.GridGenerators
{
    public class SquareGridGenerator : GridGenerator
    {
        public SquareGridGenerator(double distance) : base(distance)
        { }
        public SquareGridGenerator() : this(Settings.GetInstance().GridGeneratorSettings.Distance)
        { }

        public override GridNodes Generate()
        {
            for(int row = 0; row < Rows; row++)
            {
                for(int col = 0; col < Columns; col++)
                {
                    var p = new Point((col+1) * Distance, (row+1) * Distance);
                    var node = new GridNode(row, p, isFirstInRow: col == 0, isLastInRow: col == Columns-1);
                    GridNodes.Add(node);
                }
            }
            return GridNodes;
        }
    }
}

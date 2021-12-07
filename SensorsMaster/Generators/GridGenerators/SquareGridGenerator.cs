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
        public SquareGridGenerator(int rows, int cols) : base(rows, cols)
        { }

        public override GridNodes Generate()
        {
            for(int row = 0; row < Rows; row++)
            {
                for(int col = 0; col < Columns; col++)
                {
                    var p = new Point((col+1) * DistanceHorizontally, (row+1) * DistanceVertically);
                    GridNodes[row, col] = p;
                }
            }
            return GridNodes;
        }
    }
}

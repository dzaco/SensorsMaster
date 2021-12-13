using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SensorsMaster.Generators.GridGenerators
{
    public class GridNode
    {
        public GridNode(int row, Point point, bool isFirstInRow = false, bool isLastInRow = false)
        {
            Point = point;
            Row = row;
            IsFirstInRow = isFirstInRow;
            IsLastInRow = isLastInRow;
        }
        public Point Point { get; set; }
        public int Row { get; internal set; }
        public bool IsFirstInRow { get; set; }
        public bool IsLastInRow { get; set; }
    }
}

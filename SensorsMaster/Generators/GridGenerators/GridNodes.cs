using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace SensorsMaster.Generators.GridGenerators
{
    public class GridNodes : IEnumerable<GridNode>
    {
        private List<GridNode> nodes;
        public GridNodes()
        {
            nodes = new List<GridNode>();
        }

        public int Rows { get; private set; }
        public void Add(GridNode node)
        {
            if (node.Row > Rows)
                Rows = node.Row;
            nodes.Add(node);
        }

        public GridNode this[int row, int col] => nodes.Where(node => node.Row == row).ElementAt(col);
        public void Console()
        {
            int currRow = 0;
            foreach(var node in nodes)
            {
                Debug.Write($"[{node.Point.X}, {node.Point.Y}]\t");
                //if(node.Row != currRow)
                if(node.IsLastInRow)
                {
                    currRow = node.Row;
                    Debug.Write("\n");
                }
            }
        }

        public IEnumerator<GridNode> GetEnumerator()
        {
            return nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return nodes.GetEnumerator();
        }
    }
}
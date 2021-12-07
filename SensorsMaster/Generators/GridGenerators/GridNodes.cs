using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace SensorsMaster.Generators.GridGenerators
{
    public class GridNodes
    {
        private Point[,] points;
        public GridNodes(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            points = new Point[rows,cols];
        }

        public int Rows { get; }
        public int Cols { get; }

        public Point this[int row,int col]
        {
            get { return this.points[row, col]; }
            set { this.points[row, col] = value; }
        }

        public void Console()
        {
            int col = 0;
            foreach(var point in points)
            {
                Debug.Write($"[{point.X}, {point.Y}]\t");
                col++;
                if (col == Cols)
                {
                    col = 0;
                    Debug.Write("\n");
                }
            }
        }

        
    }
}
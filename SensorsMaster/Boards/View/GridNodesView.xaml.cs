using SensorsMaster.Device.View;
using SensorsMaster.Generators.GridGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SensorsMaster.Boards.View
{
    /// <summary>
    /// Interaction logic for GridNodesView.xaml
    /// </summary>
    public partial class GridNodesView : UserControl
    {
        public GridNodes Grid { get; set; }
        public GridNodesView()
        {
            Grid = new SquareGridGenerator(5,5).Generate();
            this.DataContext = Grid;
            InitializeComponent();
            DrawShapes();
        }

        private void DrawShapes(object sender = null, PropertyChangedEventArgs e = null)
        {
            this.Canvas.Children.Clear();
            for(var row = 0; row < Grid.Rows; row++)
            {
                for(var col = 0; col < Grid.Cols; col++)
                {
                    var point = Grid[row, col];
                    this.Canvas.Children.Add(new PointShape(point));
                }
            }
        }
    }
}

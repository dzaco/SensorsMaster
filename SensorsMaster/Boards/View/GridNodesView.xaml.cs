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
            Grid = new SquareGridGenerator().Generate();
            this.DataContext = Grid;
            InitializeComponent();
            DrawShapes();
        }

        private void DrawShapes(object sender = null, PropertyChangedEventArgs e = null)
        {
            this.Canvas.Children.Clear();
            foreach (var node in Grid)
            {
                this.Canvas.Children.Add(new PointShape(node.Point));
            }
        }
    }
}

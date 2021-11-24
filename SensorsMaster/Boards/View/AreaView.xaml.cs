using SensorsMaster.Boards.ViewModel;
using SensorsMaster.Common.Enums;
using SensorsMaster.Device.Model;
using SensorsMaster.Device.View;
using SensorsMaster.Device.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AreaView.xaml
    /// </summary>
    public partial class AreaView : UserControl
    {
        public AreaViewModel Area;
        public ObservableCollection<POIViewModel> POICollection { get; private set; }
        public ObservableCollection<SensorViewModel> SensorCollection { get; private set; }
        public AreaView()
        {
            POICollection = new ObservableCollection<POIViewModel>
            {
                new POIViewModel( new POI(10,10){ IsCovered = true } ),
                new POIViewModel( new POI(20,10) ),
                new POIViewModel( new POI(30,10) ),
                new POIViewModel( new POI(40,10) )
            };

            SensorCollection = new ObservableCollection<SensorViewModel>
            {
                new SensorViewModel( new Sensor( new Point(30,30), 30, Power.On) ),
                new SensorViewModel( new Sensor( new Point(60,30), 30, Power.Off) )
            };

            InitializeComponent();
            DataContext = this;
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement fe = e.OriginalSource as FrameworkElement;

            MessageBox.Show(fe.ToolTip.ToString(), "Info");
        }

    }
}

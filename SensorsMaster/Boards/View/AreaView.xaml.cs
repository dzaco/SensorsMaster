using SensorsMaster.AppSettings;
using SensorsMaster.AppSettings.ViewModel;
using SensorsMaster.Boards.ViewModel;
using SensorsMaster.Common.Enums;
using SensorsMaster.Device.Model;
using SensorsMaster.Device.Model.Collection;
using SensorsMaster.Device.View;
using SensorsMaster.Device.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AreaView.xaml
    /// </summary>
    public partial class AreaView : UserControl
    {
        public Settings Settings => Settings.GetInstance();
        public SettingsViewModel SettingsVM;

        public AreaViewModel Area;
        public ObservableCollection<POIViewModel> POICollection { get; private set; }
        public ObservableCollection<SensorViewModel> SensorCollection { get; private set; }
        public AreaView()
        {
            SettingsVM = new SettingsViewModel();
            POICollection = CreatePOICollection(Settings.POICollection);
            SensorCollection = CreateSensorCollection(Settings.SensorCollection);

            InitializeComponent();
            DataContext = this;

            DetectChanges();
            DrawShapes();
        }

        private void DetectChanges()
        {
            this.Settings.PropertyChanged += Refresh;
            this.Settings.SizeSettings.PropertyChanged += DrawShapes;
        }

        private void Refresh(object sender, PropertyChangedEventArgs e)
        {
            POICollection = CreatePOICollection(Settings.POICollection);
            SensorCollection = CreateSensorCollection(Settings.SensorCollection);
            DrawShapes();
        }
        private void DrawShapes(object sender = null, PropertyChangedEventArgs e = null)
        {
            this.AreaCanvas.Children.Clear();
            foreach (var poi in this.POICollection)
            {
                this.AreaCanvas.Children.Add(new POIShape(poi.POI) );
            }

        }
        private ObservableCollection<SensorViewModel> CreateSensorCollection(SensorCollection sensorCollection)
        {
            var result = new ObservableCollection<SensorViewModel>();
            foreach (var sensor in sensorCollection)
                result.Add(new SensorViewModel(sensor));
            return result;
        }

        private ObservableCollection<POIViewModel> CreatePOICollection(POICollection collection)
        {
            var result = new ObservableCollection<POIViewModel>();
            foreach (var poi in collection)
                result.Add(new POIViewModel(poi));

            return result;
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement fe = e.OriginalSource as FrameworkElement;

            MessageBox.Show(fe.ToolTip.ToString(), "Info");
        }

    }
}

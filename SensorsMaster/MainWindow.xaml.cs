using SensorsMaster.AppSettings;
using SensorsMaster.AppSettings.ViewModel;
using SensorsMaster.Common;
using SensorsMaster.Common.Enums;
using SensorsMaster.Common.Helpers;
using SensorsMaster.Device.Model;
using SensorsMaster.Device.Model.Collection;
using SensorsMaster.View;
using System;
using System.Collections.Generic;
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

namespace SensorsMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Settings Settings { get; set; }
        public MainWindow()
        {
            Settings = Settings.GetInstance();
            InitializeComponent();
            WindowState = WindowState.Maximized;
            this.DataContext = Settings;
        }

        private void SaveStateClick(object sender, RoutedEventArgs e)
        {
        }
        private void LoadStateClick(object sender, RoutedEventArgs e)
        {
            var path = FileManager.GetLoadPathFromDialog(Extension.JSON);
            var stream = FileManager.ReadStream(path);
            var collection = SerializationHelper.JsonDeserialize<POICollection, POICollectionJsonAdapter>(stream);
            this.Settings.POICollection = collection;
        }

        private void TestClick(object sender, RoutedEventArgs e)
        {
            var testWindow = new TestWindow();
            testWindow.Show();
        }
    }
}

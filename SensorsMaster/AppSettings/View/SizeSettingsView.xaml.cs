using SensorsMaster.AppSettings.ViewModel;
using SensorsMaster.Common;
using SensorsMaster.Common.Enums;
using SensorsMaster.Common.Helpers;
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

namespace SensorsMaster.AppSettings.View
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SizeSettingsView : UserControl
    {
        public SizeSettingsViewModel SettingsVM;
        public SizeSettingsView()
        {
            SettingsVM = new SizeSettingsViewModel();
            this.DataContext = this.SettingsVM;
            InitializeComponent();
        }

    }
}

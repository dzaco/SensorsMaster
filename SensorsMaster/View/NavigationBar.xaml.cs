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

namespace SensorsMaster.View
{
    /// <summary>
    /// Interaction logic for NavigationBar.xaml
    /// </summary>
    public partial class NavigationBar : UserControl
    {
        //private List<Expander> expanders;

        public NavigationBar()
        {
            InitializeComponent();
            //expanders = new List<Expander>();
            //expanders.Add( FindName("SettingsExpander") as Expander );
            //expanders.Add( FindName("SensorSettingsExpander") as Expander );
        }
    }
}

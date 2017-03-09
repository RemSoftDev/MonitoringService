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

namespace ProMonitoringService_WPFClient.Controls.ACLPopups
{
    /// <summary>
    /// Interaction logic for Processes_ACLPopup.xaml
    /// </summary>
    public partial class Processes_ACLPopup : UserControl
    {
        public Processes_ACLPopup()
        {
            InitializeComponent();
        }

        private void IP_Poty_Input_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Text = "";
        }
    }
}

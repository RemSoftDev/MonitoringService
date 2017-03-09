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
    /// Interaction logic for Only_IP_Field_ACLPopup.xaml
    /// </summary>
    public partial class Only_IP_Field_ACLPopup : UserControl
    {
        public Only_IP_Field_ACLPopup()
        {
            InitializeComponent();
        }

        private void IP_Address_Input_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if((sender as TextBox).Text == "Enter IP address...")
            {
                (sender as TextBox).Text = "";
            }
        }
    }
}

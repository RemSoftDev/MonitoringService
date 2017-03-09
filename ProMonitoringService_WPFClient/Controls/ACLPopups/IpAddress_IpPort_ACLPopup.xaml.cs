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
    /// Interaction logic for IpAddress_IpPort_ACLPopup.xaml
    /// </summary>
    public partial class IpAddress_IpPort_ACLPopup : UserControl
    {
        public IpAddress_IpPort_ACLPopup()
        {
            InitializeComponent();
            IP_Address_Input_TextBox.GotFocus += new RoutedEventHandler(IpAddress_GotFocus);
            IP_Port_Input_TextBox.GotFocus += new RoutedEventHandler(IpPort_GotFocus);
        }

        private void IpAddress_GotFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Enter IP address...")
            {
                (sender as TextBox).Text = "";
            }
        }

        private void IpPort_GotFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Enter IP port...")
            {
                (sender as TextBox).Text = "";
            }
        }
    }
}

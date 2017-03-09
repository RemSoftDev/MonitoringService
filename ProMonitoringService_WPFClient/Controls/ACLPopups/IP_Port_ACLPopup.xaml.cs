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
    /// Interaction logic for IP_Port_ACLPopup.xaml
    /// </summary>
    public partial class IP_Port_ACLPopup : UserControl
    {
        public IP_Port_ACLPopup()
        {
            InitializeComponent();
            IP_Address_Input_TextBox.GotFocus += new RoutedEventHandler(RemovePlaceholder);
            IP_Port_Input_TextBox.GotFocus += new RoutedEventHandler(RemovePlaceholder);
            //IP_Address_Input_TextBox.LostFocus += new RoutedEventHandler(ReenterPlaceholder);
            //IP_Port_Input_TextBox.LostFocus += new RoutedEventHandler(ReenterPlaceholder);
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }

        //private void ReenterPlaceholder(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
        //    {
        //        (sender as TextBox).Text = "";
        //    }
        //}
    }
}

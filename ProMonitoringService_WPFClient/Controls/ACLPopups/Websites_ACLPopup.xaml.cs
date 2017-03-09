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
    /// Interaction logic for Websites_ACLPopup.xaml
    /// </summary>
    public partial class Websites_ACLPopup : UserControl
    {
        public Websites_ACLPopup()
        {
            InitializeComponent();
            Input_TextBox.GotFocus += new RoutedEventHandler(TextBox_GotFocus);
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            if((sender as TextBox).Text == "Domain...")
            {
                (sender as TextBox).Text = "";
            }
        }
    }
}

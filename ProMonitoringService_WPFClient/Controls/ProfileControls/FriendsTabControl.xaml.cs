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

namespace ProMonitoringService_WPFClient.Controls.ProfileControls
{
    /// <summary>
    /// Interaction logic for FriendsTabControl.xaml
    /// </summary>
    public partial class FriendsTabControl : UserControl
    {
        public FriendsTabControl()
        {
            InitializeComponent();
        }

        private void searchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search for friends")
            {
                searchBox.Text = "";
            }
        }

        private void searchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search for friends";
            }
        }
    }
}

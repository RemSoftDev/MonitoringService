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

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for CloudView.xaml
    /// </summary>
    public partial class CloudView : UserControl
    {
        public CloudView()
        {
            InitializeComponent();
           
        }

        private void DeleteCloud_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Current cloud deletion logic here!");
        }

        private void RemoveTunnel_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Premium_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Route_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Internet_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sponsoring_Button_Click(object sender, RoutedEventArgs e)
        {
            SponsorPage page = new SponsorPage();
            page.Show();
        }

        private void Server_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            TunnelsView_ListBox.ItemsSource = PaginationHelper.Page1;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TunnelsView_ListBox.ItemsSource = PaginationHelper.Page2;
        }

        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            TunnelsView_ListBox.ItemsSource = PaginationHelper.Page3;

        }
    }
}

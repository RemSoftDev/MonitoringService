using ProMonitoringService_WPFClient.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for ConnectivityManager.xaml
    /// </summary>
    public partial class ConnectivityManager : UserControl
    {
        public List<Cloud_VM> Clouds { get; set; }
        public ConnectivityManager()
        {
            InitializeComponent();
#if DEBUG
            Clouds =
                new List<Cloud_VM>
                {
                    new Cloud_VM
                {
                        Name = "First cloud",
                        TotalCost = 680,
                    Tunnels = PaginationHelper.Page1
                    },
                    new Cloud_VM
                {
                        Name = "Second cloud",
                        TotalCost = 1900,
                    Tunnels = PaginationHelper.Page2
                    }
                };

            Clouds_ComboBox.ItemsSource = Clouds;
#endif
        }


        private void CreateCloud_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New cloud creation logic here!");
        }

        private void Clouds_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Clouds_ComboBox.IsDropDownOpen = false;
            RenderSelectedCloud();
            
            e.Handled = true;
        }

        private void RenderSelectedCloud()
        {
            if (Clouds_ComboBox.SelectedItem != null)
            {
                CloudViewPlaceholder_ContentControl.Content = new CloudView
                {
                    DataContext = (Clouds_ComboBox.SelectedItem as Cloud_VM).Tunnels
                };
            }
            else
            {
                CloudViewPlaceholder_ContentControl.Content = null;
            }

        }

        private void Clouds_ComboBox_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            (sender as ComboBox).Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Clouds_ComboBox_DropDownOpened(object sender, System.EventArgs e)
        {
            (sender as ComboBox).Background = new SolidColorBrush(Colors.LightGray);
        }
    }
}

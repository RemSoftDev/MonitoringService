using System.Windows;
using System.Windows.Controls;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for LogOutView.xaml
    /// </summary>
    public partial class LogOutView : UserControl
    {
        public LogOutView()
        {
            InitializeComponent();
        }

        private async void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            var logoutButton = sender as Button;
            logoutButton.IsEnabled = false;
            //await LoginLogoutManager.Singleton.Logout();
            logoutButton.IsEnabled = true;

            e.Handled = true;
        }
    }
}

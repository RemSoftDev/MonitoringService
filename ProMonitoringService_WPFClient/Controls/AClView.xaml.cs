using ProMonitoringService_WPFClient.Controls.ACLPopups;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for AClView.xaml
    /// </summary>
    public partial class ACLView : UserControl
    {
        public ACLView()
        {
            InitializeComponent();
            
        }

        #region IsSource
        public bool IsSource
        {
            get { return (bool)GetValue(IsSourceProperty); }
            set { SetValue(IsSourceProperty, value); }
        }

        public static readonly DependencyProperty IsSourceProperty =
            DependencyProperty.Register(
                nameof(IsSource),
                typeof(bool),
                typeof(ACLView),
                new PropertyMetadata(false));
        #endregion

        private void SearchACL_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowPopupIfNecessary(object sender, string popupTitle, UserControl popupContent)
        {
            var isChecked = (sender as ToggleButton).IsChecked;
            if (isChecked.HasValue)
            {
                if ((bool)isChecked)
                {
                    new ACLView_PopupWindow(popupTitle, popupContent).ShowDialog();
                }
            }
        }

        private MessageBoxResult ShowWarning(string title, string content)
        {
            MessageBoxResult result = MessageBox.Show("Are you want to clear all data?", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            return result;
        }

        private void IP_PortOption_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "ACL Settings", new IP_Port_ACLPopup());

        private void ProcessOption_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Processes", new Processes_ACLPopup());

        private void AppOption_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Applications", new Processes_ACLPopup()); // wrong content

        private void NewDst_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "ACL Settings", new Only_IP_Field_ACLPopup());

        private void SpecificTunnelOption_FWD_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Select tunnel", new Tunnels_ACLPopup());

        private void Shaping_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "ACL Settings", new ACLSettings_ACLPopup());

        private void Apps_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Applications", new Processes_ACLPopup()); // wrong content

        private void IP_PortProtocol_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "ACL Settings", new IP_Port_ACLPopup());

        private void WebSites_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Websites", new Websites_ACLPopup());

        private void Processes_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Processes", new Processes_ACLPopup());

        private void Apps_Firewall_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Application", new Processes_ACLPopup()); // wrong content

        private void Processes_Binding_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Applications", new Processes_ACLPopup());

        private void Apps_Binding_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Application", new Processes_ACLPopup()); // wrong content

        private void SpecificTunnelOption_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Select Tunnel", new Select_Tunnel_ACLPopup());

        private void SpecificGroupOption_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "Select Group", new Select_Group_ACLPopup());

        private void NewDst_Aliasing_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "ACL Settings", new IpAddress_IpPort_ACLPopup());

        private void Shaping_QOS_ToggleButton_Checked(object sender, RoutedEventArgs e) =>
            ShowPopupIfNecessary(sender, "ACL Settings", new ACLSettings_ACLPopup());

        private void Image_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
            ShowWarning("Warning", "Are you want to clear all data?");

        private void Image_MouseUp_1(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
            ShowWarning("Warning", "Are you sure want to change ACL base?");

        private void Image_MouseUp_2(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
            ShowWarning("Warning", "Are you sure want to delete?");

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text == "ACL_name 1" || (sender as TextBox).Text == "Destination ACL")
            {
                (sender as TextBox).Text = "";
            }
        }

        private void TextBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text == "Some description" || (sender as TextBox).Text == "Description of destination ACL")
            {
                (sender as TextBox).Text = "";
            }
        }
    }
}

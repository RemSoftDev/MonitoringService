using System.Windows;
using System.Windows.Controls;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for ChangePasswordForm.xaml
    /// </summary>
    public partial class ChangePasswordForm : UserControl
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        #region Validation
        public bool IsValid(string oldPassword, string newPassword, string confirmNewPassword, ref string errorMessage) =>
            OldPasswordIsValid(oldPassword, ref errorMessage) &
            NewPassowordIsValid(newPassword, confirmNewPassword, ref errorMessage);

        private bool OldPasswordIsValid(string oldPassword, ref string errorMessage)
        {
            var isValid = LoginLogoutManager.Singleton.CurrentUser.PasswordHashCode.Equals(oldPassword.GetHashCode());

            if (!isValid) errorMessage += "Old password does not match!\r\n";

            return isValid;
        }

        private bool NewPassowordIsValid(string newPassword, string confirmNewPassword, ref string errorMessage)
        {

            var isValid = newPassword.Equals(confirmNewPassword);

            if (!isValid)
            {
                errorMessage += "New password and its confirmations does not match!\r\n";
                return isValid;
            }

            isValid = InputValidationHelper.PasswordValidator.IsMatch(newPassword) &
                      InputValidationHelper.PasswordValidator.IsMatch(confirmNewPassword);

            if (!isValid) errorMessage += "New password is not valid!\r\n";

            return isValid;
        }
        #endregion

        private void UpdatePassword_Button_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = string.Empty;

            if (IsValid(OldPassword_TextBox.Text, NewPassword_TextBox.Text, ConfirmNewPassword_TextBox.Text, ref errorMessage))
            {
                UpdatePassword_Button.IsEnabled = false;
                // update password logic here
                UpdatePassword_Button.IsEnabled = true;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }

            e.Handled = true;
        }
    }
}

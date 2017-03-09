using ProMonitoringService_WPFClient.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for EditProfile.xaml
    /// </summary>
    public partial class EditProfileForm : UserControl
    {
        public EditProfileForm()
        {
            InitializeComponent();
        }

        #region Validation
        private UserData_VM AssembleNewUserData() => new UserData_VM
        {
            Name = Name_TextBox.Text,
            DisplayName = DisplayName_TextBox.Text,
            Email = Email_TextBox.Text,
            RecoveryEmail = RecoveryEmail_TextBox.Text,
            PhoneNumber = GetPhoneNumber()
        };

        private UserData_VM.PhoneNumberData GetPhoneNumber()
        {
            var phoneNumber = default(UserData_VM.PhoneNumberData);
            if (UserData_VM.PhoneNumberData.TryParse(PhoneNumber_TextBox.Text, ref phoneNumber)) return phoneNumber;
            else return UserData_VM.PhoneNumberData.Fake;
        }

        private bool IsValid(UserData_VM newUserData, ref string errorMessage) =>
            NameIsValid(newUserData, ref errorMessage) &
            DispayNameIsValid(newUserData, ref errorMessage) &
            PhoneNumberIsValid(newUserData, ref errorMessage) &
            EmailIsValid(newUserData, ref errorMessage) &
            RecoveryEmailIsValid(newUserData, ref errorMessage);

        private bool NameIsValid(UserData_VM newUserData, ref string errorMessage)
        {
            var isValid = InputValidationHelper.NameValidator.IsMatch(newUserData.Name);

            if (!isValid) errorMessage += "Name is not valid!\r\n";

            return isValid;
        }

        private bool DispayNameIsValid(UserData_VM newUserData, ref string errorMessage)
        {
            var isValid = InputValidationHelper.DisplayNameValidator.IsMatch(newUserData.DisplayName);

            if (!isValid) errorMessage += "Display name is not valid!\r\n";

            return isValid;
        }

        private bool PhoneNumberIsValid(UserData_VM newUserData, ref string errorMessage)
        {
            var isValid = InputValidationHelper.PhoneNumberValidator.IsMatch(newUserData.PhoneNumber.ToString());

            if (!isValid) errorMessage += "Phone number is not valid!\r\n";

            return isValid;
        }

        private bool EmailIsValid(UserData_VM newUserData, ref string errorMessage)
        {
            var isValid = InputValidationHelper.EmailValidator.IsMatch(newUserData.Email);

            if (!isValid) errorMessage += "E-mail is not valid!\r\n";

            return isValid;
        }

        private bool RecoveryEmailIsValid(UserData_VM newUserData, ref string errorMessage)
        {
            var isValid = InputValidationHelper.EmailValidator.IsMatch(newUserData.RecoveryEmail);

            if (!isValid) errorMessage += "Recovery e-mail is not valid!\r\n";

            return isValid;
        }
        #endregion

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = string.Empty;
            if (IsValid(AssembleNewUserData(), ref errorMessage))
            {
                Save_Button.IsEnabled = false;
                // saving logic here
                Save_Button.IsEnabled = true;
            }
            else MessageBox.Show(errorMessage);

            e.Handled = true;
        }
    }
}

using ProMonitoringService_WPFClient.CommunicationWithServer;
using ProMonitoringService_WPFClient.CommunicationWithServer.UrlParameters;
using ProMonitoringService_WPFClient.Contracts;
using ProMonitoringService_WPFClient.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeLoginService(new DefaultLoginLogoutService());

#if DEBUG
            EmailInput_TextBox.Text = "abcd1@gmail.com";
            PasswordInput_TextBox.Text = "123456";
#endif
        }

        #region LoginService
        private iLoginLogoutService _loginService;
        private void InitializeLoginService(iLoginLogoutService loginService) => _loginService = loginService;
        #endregion

        #region Login_Button_Click
        private async void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = string.Empty;
            var loginParameters = GetLoginParametes();

            if (IsValid(loginParameters, ref errorMessage))
            {
                Login_Button.IsEnabled = false;

                var loginResponse = await _loginService.TryLogin(loginParameters);
                if (loginResponse.Success)
                {
                    LoginLogoutManager.Singleton.CurrentUser = UserData_VM.FromLoginResponse(loginResponse, loginParameters);
                    new MainWindow().Show();
                    ((Parent as Grid).Parent as LoginWindow).Close();
                }
                else
                {
                    MessageBox.Show(
                        "Login failed!\r\n" +
                        "Most probably - wrong e-mail or password... but also might be server problem.\r\n" +
                        "Retry once again!");
                }

                Login_Button.IsEnabled = true;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
            
            e.Handled = true;
        }

        private LoginParameters GetLoginParametes() =>
            new LoginParameters {
                Email = EmailInput_TextBox.Text,
                Password = PasswordInput_TextBox.Text };
        #endregion

        #region Validation

        /// <summary>
        /// Uses regexes to determine whether given inputs are valid or not.
        /// If not, specifies kind of error in 'errorMessage' parameter.
        /// </summary>
        /// <param name="loginParameters"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        private bool IsValid(LoginParameters loginParameters, ref string errorMessage) => 
            EmailInputIsValid(loginParameters, ref errorMessage) & 
            PasswordInputIsValid(loginParameters, ref errorMessage);

        private bool EmailInputIsValid(LoginParameters loginParameters, ref string errorMessage)
        {
            var isValid = InputValidationHelper.EmailValidator.IsMatch(EmailInput_TextBox.Text);

            if (!isValid) errorMessage += "Not valid e-mail.\r\n";

            return isValid;
        }

        private bool PasswordInputIsValid(LoginParameters loginParameters, ref string errorMessage)
        {
            var isValid = InputValidationHelper.PasswordValidator.IsMatch(loginParameters.Password);

            if (!isValid) errorMessage += "Not valid passoword.\r\n";

            return isValid;
        }
        #endregion

        private void InputTextBox_GotMouseCapture(object sender, MouseEventArgs e) =>
            CommonEventsHandling.GotMouseCapture(sender, e);
    }
}

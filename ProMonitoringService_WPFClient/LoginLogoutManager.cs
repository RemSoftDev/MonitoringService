using ProMonitoringService_WPFClient.Contracts;
using ProMonitoringService_WPFClient.ViewModels;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ProMonitoringService_WPFClient
{
    public class LoginLogoutManager : INotifyPropertyChanged
    {
        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

        #region Singleton
        private LoginLogoutManager() { }

        private static readonly LoginLogoutManager _Singleton = new LoginLogoutManager();

        public static LoginLogoutManager GetSingleton() => _Singleton;
        public static LoginLogoutManager Singleton => _Singleton;
        #endregion

        #region CurrentUser
        private UserData_VM _currentUser;
        public UserData_VM CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (!IsLoggedIn | value == null)
                {
                    _currentUser = value;
                    _currentUser.ImageSrc = new System.Uri("pack://application:,,,/Resources/demo-user.jpg", System.UriKind.Absolute);
                    OnPropertyChanged(nameof(IsLoggedIn));
                    OnPropertyChanged(nameof(CurrentUser));
                }
            }
        }
        #endregion

        public bool IsLoggedIn => _currentUser != null;

        public async Task Logout(iLoginLogoutService logoutService)
        {
            await logoutService.Logout(CurrentUser);
            _currentUser = null;
        }
    }
}
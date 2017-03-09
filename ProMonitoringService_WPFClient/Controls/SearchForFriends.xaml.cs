using ProMonitoringService_WPFClient.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for SearchForFriends.xaml
    /// </summary>
    public partial class SearchForFriends : UserControl
    {
        public SearchForFriends()
        {
            InitializeComponent();
            _foundFriends = new ObservableCollection<UserData_VM>();

#if DEBUG
            _foundFriends = LoginLogoutManager.Singleton.CurrentUser.Friends;
#endif
        }

        #region FoundFriend
        private ObservableCollection<UserData_VM> _foundFriends;
        public ObservableCollection<UserData_VM> FoundFriends => _foundFriends;
        #endregion

        private void SearchQuery_TextBox_GotMouseCapture(object sender, MouseEventArgs e) =>
            CommonEventsHandling.GotMouseCapture(sender, e);

        #region DeleteFriend
        private async void DeleteFriend_Button_Click(object sender, RoutedEventArgs e)
        {
            var deleteButton = sender as Button;

            deleteButton.IsEnabled = false;

            await DeleteFriend(deleteButton.Tag as UserData_VM);

            deleteButton.IsEnabled = true;

            e.Handled = true;
        }

        private async Task DeleteFriend(UserData_VM friend)
        {
            MessageBox.Show("Delete was clicked!");
        }
        #endregion
    }
}

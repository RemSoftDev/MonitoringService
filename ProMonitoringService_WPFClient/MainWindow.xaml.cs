using ProMonitoringService_WPFClient.CommunicationWithServer;
using ProMonitoringService_WPFClient.CommunicationWithServer.UrlParameters;
using System.Collections.ObjectModel;
using System.Windows;

namespace ProMonitoringService_WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
//#if DEBUG
//            LoginLogoutManager.Singleton.CurrentUser = new UserData_VM
//            {
//                Email = "email@address.com",
//                Name = "UserName",
//                DisplayName = "DisplayUserName",
//                PhoneNumber = new UserData_VM.PhoneNumberData {
//                    CountryCode = "xx",
//                    OperatorCode = "xxx",
//                    Number = "xxxxxxx" },
//                ImageSrc = TemporaryHelpers.GetDefaultImgSrc(),
//                PasswordHashCode = "password".GetHashCode(),
//                Friends = new ObservableCollection<UserData_VM>
//                {
//                    new UserData_VM
//                        {
//                            Name = "Friend1",
//                            DisplayName = "DisplayName_Friend1",
//                            PhoneNumber = new UserData_VM.PhoneNumberData {
//                                CountryCode = "xx",
//                                OperatorCode = "xxx",
//                                Number = "xxxxxxx" },
//                            Email = "friend1@email.com",
//                            ImageSrc = TemporaryHelpers.GetDefaultImgSrc(),
//                            PasswordHashCode = "anotherPassword".GetHashCode()
//                        },
//                    new UserData_VM
//                        {
//                            Name = "Friend2",
//                            DisplayName = "DisplayName_Friend2",
//                            PhoneNumber = new UserData_VM.PhoneNumberData {
//                                CountryCode = "xx",
//                                OperatorCode = "xxx",
//                                Number = "xxxxxxx" },
//                            Email = "friend2@email.com",
//                            ImageSrc = TemporaryHelpers.GetDefaultImgSrc(),
//                            PasswordHashCode = "anotherPassword1".GetHashCode()
//                        }
//                }
//            };

//            //var webSocket = new ClientWebSocket();
//            //webSocket.ConnectAsync(new Uri("ws://198.211.127.72:8880"), CancellationToken.None).Wait();
//            //MessageBox.Show(webSocket.State.ToString());
//            //webSocket.SendAsync(
//            //    new ArraySegment<byte>(Encoding.UTF8.GetBytes(request_url + parameters)), 
//            //    WebSocketMessageType.Text, 
//            //    true, 
//            //    CancellationToken.None)
//            //    .Wait();
//            //var bytesReceived = new ArraySegment<byte>(new byte[1024]);
//            //var task = webSocket.ReceiveAsync(bytesReceived, CancellationToken.None);
//            //task.Wait();
//            //var result = task.Result;
//            //MessageBox.Show(Encoding.UTF8.GetString(bytesReceived.Array, 0, result.Count));
//#endif
            InitializeComponent();
            _notifications = new ObservableCollection<Notification>();
        }

        #region Notifications
        private ObservableCollection<Notification> _notifications;
        public ObservableCollection<Notification> Notifications => _notifications;

        public void ShowError(string errorMessage)
        {
            var errorNotification = new Notification { Message = errorMessage };
            _notifications.Add(errorNotification);
            //using (var timer = new Timer(_ => _notifications.Remove(errorNotification), null, 1000, -1))
            //{ }
            //var timer = new Timer(_ => _notifications.Remove(errorNotification), null, 1000, -1);
        }
        #endregion


        private void BillingLink_Button_Click(object sender, RoutedEventArgs e)
        {
            ShowError("This is error message!");
        }

        private void ContactsLink_Button_Click(object sender, RoutedEventArgs e)
        {
            using (var wc = new ThisWebClient())
            {
                MessageBox.Show(wc.JobQueueInfo());
                MessageBox.Show(wc.ServerName());
                MessageBox.Show(wc.CustomerACLDestination(new CutomerACLDestinationParameters { ID = 0 }));
            }
        }
    }
}

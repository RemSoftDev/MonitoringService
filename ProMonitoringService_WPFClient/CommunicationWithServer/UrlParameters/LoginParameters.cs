using ProMonitoringService_WPFClient.Contracts;

namespace ProMonitoringService_WPFClient.CommunicationWithServer.UrlParameters
{
    public sealed class LoginParameters : iUrlParameters
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string GetUrlEncodedData() => $"email={Email.UrlEncode()}&password={Password.UrlEncode()}";
    }
}

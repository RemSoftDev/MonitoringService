using ProMonitoringService_WPFClient.Contracts;

namespace ProMonitoringService_WPFClient.CommunicationWithServer.UrlParameters
{
    public sealed class CutomerACLDestinationParameters : iUrlParameters
    {
        public int ID { get; set; }
        public string GetUrlEncodedData() => $"customer_id={ID}";
    }
}

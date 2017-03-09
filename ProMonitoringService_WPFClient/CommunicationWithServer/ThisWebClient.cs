using ProMonitoringService_WPFClient.CommunicationWithServer.UrlParameters;
using ProMonitoringService_WPFClient.Contracts;
using System;
using System.Net;
namespace ProMonitoringService_WPFClient.CommunicationWithServer
{
    public sealed class ThisWebClient : WebClient
    {
        public static string RequestAddress => "http://198.211.127.72/vpn/request.php?request=";
        public ThisWebClient()
        {
            Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
        }
        public string Post(string requestType, iUrlParameters postableObj) => 
            UploadString(new Uri($"{RequestAddress}{requestType}"), postableObj.GetUrlEncodedData());

        #region Get(...) overloads
        public string Get(string requestType, iUrlParameters parametes) =>
            DownloadString(new Uri($"{RequestAddress}{requestType}&{parametes.GetUrlEncodedData()}"));
        public string Get(string requestType) => DownloadString(new Uri($"{RequestAddress}{requestType}"));
        #endregion

        public string Login(LoginParameters loginParameters) => Post($"dologin", loginParameters);
        public string JobQueueInfo() => Get("job_queue_info");
        public string ServerName() => Get("get_server_name");
        public string CustomerACLDestination(CutomerACLDestinationParameters customerACLDestinationParameters) => 
            Post("get_customer_acl_destination", customerACLDestinationParameters);
    }
}
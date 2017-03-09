using ProMonitoringService_WPFClient.Contracts;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace ProMonitoringService_WPFClient.CommunicationWithServer
{
    public sealed class DefaultServerResponseSerializer : iServerResponseDeserializer
    {
        public Dictionary<string, dynamic> DeserializeFromJson(string json) =>
            new JavaScriptSerializer().Deserialize<Dictionary<string, dynamic>>(json);
    }
}

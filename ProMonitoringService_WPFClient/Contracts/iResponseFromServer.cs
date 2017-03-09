using System.Collections.Generic;

namespace ProMonitoringService_WPFClient.Contracts
{
    public interface iServerResponseDeserializer
    {
        Dictionary<string, dynamic> DeserializeFromJson(string json);
    }
}

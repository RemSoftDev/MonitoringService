using ProMonitoringService_WPFClient.CommunicationWithServer;
using System.Collections.Generic;

namespace ProMonitoringService_WPFClient.Contracts
{
    public abstract class ServerResponseObject<T> where T : ServerResponseObject<T>
    {
        private readonly iServerResponseDeserializer _responseDeserializer = new DefaultServerResponseSerializer();

        public bool Success { get; private set; }

        public T FromJson(string json)
        {
            var deserializedJson = _responseDeserializer.DeserializeFromJson(json);

            Success = (int)deserializedJson["status"] == 1;

            return Success ? ExtractData(deserializedJson["value"]) : this as T;
        }

        protected abstract T ExtractData(Dictionary<string, object> deserializedJson);
    }
}

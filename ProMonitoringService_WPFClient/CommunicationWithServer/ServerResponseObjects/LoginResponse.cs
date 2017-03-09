using System.Collections.Generic;

namespace ProMonitoringService_WPFClient.Contracts.ServerResponseObjects
{
    public sealed class LoginResponse : ServerResponseObject<LoginResponse>
    {
        public string Token { get; private set; }
        public string Email { get; private set; }
        public string UserID { get; private set; }

        protected override LoginResponse ExtractData(Dictionary<string, object> deserializedJson)
        {
            Token = deserializedJson["token"] as string;
            Email = deserializedJson["email"] as string;
            UserID = deserializedJson["user_id"] as string;

            return this;
        }
    }
}

using ProMonitoringService_WPFClient.CommunicationWithServer.UrlParameters;
using ProMonitoringService_WPFClient.Contracts;
using ProMonitoringService_WPFClient.Contracts.ServerResponseObjects;
using ProMonitoringService_WPFClient.ViewModels;
using System;
using System.Threading.Tasks;

namespace ProMonitoringService_WPFClient.CommunicationWithServer
{
    public sealed class DefaultLoginLogoutService : iLoginLogoutService
    {
        public async Task<LoginResponse> TryLogin(LoginParameters loginParameters)
        {
            using (ThisWebClient wc = new ThisWebClient())
            {
                return await Task.Run(
                    () =>
                    {
                        return new LoginResponse().FromJson(
                            wc.Login(loginParameters));
                    });
            }
        }
        public Task Logout(UserData_VM userData)
        {
            throw new NotImplementedException();
        }
    }

}

using ProMonitoringService_WPFClient.Contracts.ServerResponseObjects;
using ProMonitoringService_WPFClient.ViewModels;
using System.Threading.Tasks;
using ProMonitoringService_WPFClient.CommunicationWithServer.UrlParameters;

namespace ProMonitoringService_WPFClient.Contracts
{
    public interface iLoginLogoutService
    {
        Task<LoginResponse> TryLogin(LoginParameters loginParameters);
        Task Logout(UserData_VM userData);
    }
}


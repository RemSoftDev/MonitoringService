using System.Collections.ObjectModel;
using System.Net;

namespace ProMonitoringService_WPFClient.ViewModels
{
    public sealed class Tunnel_VM : ViewModel
    {
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string VPN_IP { get; set; }
        public ObservableCollection<IPAddress> Real_IPs { get; set; }
        public int Points { get; set; }
        public bool Gateway { get; set; }
        public ACL_VM SourceACL { get; set; }
        public ObservableCollection<ACL_VM> DestinationACLs { get; set; }
    }
}

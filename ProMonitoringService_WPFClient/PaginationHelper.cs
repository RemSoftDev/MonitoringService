using ProMonitoringService_WPFClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProMonitoringService_WPFClient
{
    public static class PaginationHelper
    {
        public static ObservableCollection<Tunnel_VM> Page1 = new ObservableCollection<Tunnel_VM>
        {
            new Tunnel_VM {
                            Name = "Tunnel 156",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM { Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
                        new Tunnel_VM {
                            Name = "Tunnel 157",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM { Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
                        new Tunnel_VM {
                            Name = "Tunnel 158",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
                        new Tunnel_VM {
                            Name = "Tunnel 156",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
                        new Tunnel_VM {
                            Name = "Tunnel 158",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        }
        };

        public static ObservableCollection<Tunnel_VM> Page2 = new ObservableCollection<Tunnel_VM>
        {
            
                        new Tunnel_VM {
                            Name = "Tunnel 159",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
                        new Tunnel_VM {
                            Name = "Tunnel 160",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
                        new Tunnel_VM {
                            Name = "Tunnel 161",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
                        new Tunnel_VM {
                            Name = "Tunnel 162",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
                        new Tunnel_VM {
                            Name = "Tunnel 159",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        },
        };

        public static ObservableCollection<Tunnel_VM> Page3 = new ObservableCollection<Tunnel_VM>
        {

                        
                        new Tunnel_VM {
                            Name = "Tunnel 163",
                            Gateway = true,
                            VPN_IP = "1.1.1.38",
                            Real_IPs = new ObservableCollection<IPAddress> { IPAddress.Parse("1.4.127.255"), IPAddress.Parse("1.8.127.255") },
                            Points = 80,
                            SourceACL = new ACL_VM { Name = "ACL_name 1", Description = "Some description" },
                            DestinationACLs = new ObservableCollection<ACL_VM>
                            {
                                new ACL_VM {Name = "Destination ACL", Description = "Description of destination ACL" }
                            }
                        }
        };
    }
}

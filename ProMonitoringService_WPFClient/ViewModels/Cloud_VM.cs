using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMonitoringService_WPFClient.ViewModels
{
    public sealed class Cloud_VM : ViewModel
    {
        public string Name { get; set; }
        public double TotalCost { get; set; }
        public ObservableCollection<Tunnel_VM> Tunnels { get; set; }
    }
}

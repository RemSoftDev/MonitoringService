using System.Web;

namespace ProMonitoringService_WPFClient
{
    public static class Extensions
    {
        public static string UrlEncode(this string @this) => HttpUtility.UrlEncode(@this);
    }
}

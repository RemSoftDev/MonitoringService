using System;
using System.Globalization;
using System.Windows.Data;

namespace ProMonitoringService_WPFClient.Resources
{
    public sealed class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            (bool)value ? "#1D9E74" : "#DA3738";

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

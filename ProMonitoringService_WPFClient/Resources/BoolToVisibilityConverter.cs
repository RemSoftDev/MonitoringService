using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ProMonitoringService_WPFClient.Resources
{
    public sealed class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (parameter as string)
            {
                case ("visibleWhenTrue"): return (bool)value ? Visibility.Visible : Visibility.Collapsed;
                case ("visibleWhenFalse"): return (bool)value ? Visibility.Collapsed : Visibility.Visible;
                default: throw new ArgumentException(parameter as string + " - unknow parameter! Can not convert to Visibility!");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

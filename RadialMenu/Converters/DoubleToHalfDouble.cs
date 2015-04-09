using System;
using System.Globalization;
using System.Windows.Data;

namespace RadialMenu.Converters
{
    internal class DoubleToHalfDouble : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value / 2.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("DoubleToHalfDouble is a One-Way converter only !");
        }
    }
}

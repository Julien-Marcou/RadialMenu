using RadialMenu.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;


namespace RadialMenuDemo.Utils
{
    internal class Test : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            System.Diagnostics.Debug.WriteLine(value);
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

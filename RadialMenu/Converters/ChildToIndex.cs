using RadialMenu.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace RadialMenu.Converters
{
    internal class ChildToIndex : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
            {
                throw new ArgumentException("ChildToIndex converter needs 2 values (RadialMenuItem item, List<RadialMenuItem> items) !", "values");
            }

            RadialMenuItem item = (RadialMenuItem)values[0];
            List<RadialMenuItem> items = (List<RadialMenuItem>)values[1];

            return items.IndexOf(item);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("ChildToIndex is a One-Way converter only !");
        }
    }
}

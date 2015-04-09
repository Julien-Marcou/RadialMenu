using System;
using System.Globalization;
using System.Windows.Data;

namespace RadialMenu.Converters
{
    internal class RadialMenuItemToAngleDelta : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
            {
                throw new ArgumentException("RadialMenuItemToAngleDelta converter needs 2 values (int index, int count) !", "values");
            }

            int sliceIndex = (int)values[0];
            int sliceCount = (int)values[1];

            return 360.0 / sliceCount;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("RadialMenuItemToAngleDelta is a One-Way converter only !");
        }
    }
}

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace RadialMenu.Converters
{
    internal class IndexCountAndSizeToPosition : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 3)
            {
                throw new ArgumentException("IndexCountAndSizeToPosition converter needs 3 values (int index, int count, double size) !", "values");
            }
            if (parameter == null)
            {
                throw new ArgumentNullException("parameter", "IndexCountAndSizeToPosition converter needs the parameter (string axis) !");
            }

            int sliceIndex = (int)values[0];
            int sliceCount = (int)values[1];
            double contentSize = (double)values[2];
            string axis = (string)parameter;

            if (axis != "X" && axis != "Y")
            {
                throw new ArgumentException("IndexCountAndSizeToPosition parameter needs to be 'X' or 'Y' !", "parameter");
            }

            double angleDelta = 360.0 / sliceCount;
            double startAngle = 360.0 / sliceCount * sliceIndex;
            Point center = ComputeCartesianCoordinate(new Point(155, 155), startAngle + (angleDelta / 2), ((150 + 30 - 15) / 2) + 5);

            if (axis == "X")
            {
                return center.X - contentSize / 2;
            }

            // Else axis == "Y"
            return center.Y - contentSize / 2;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("IndexCountAndSizeToPosition is a One-Way converter only !");
        }

        private static Point ComputeCartesianCoordinate(Point center, double angle, double radius)
        {
            // Converts to radians
            double radiansAngle = (Math.PI / 180.0) * (angle - 90);
            double x = radius * Math.Cos(radiansAngle);
            double y = radius * Math.Sin(radiansAngle);
            return new Point(x + center.X, y + center.Y);
        }
    }
}

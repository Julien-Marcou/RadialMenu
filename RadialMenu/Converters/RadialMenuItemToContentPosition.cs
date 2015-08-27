using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace RadialMenu.Converters
{
    internal class RadialMenuItemToContentPosition : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 6)
            {
                throw new ArgumentException("RadialMenuItemToContentPosition converter needs 6 values (double angle, double centerX, double centerY, double contentWidth, double contentHeight, double contentRadius) !", "values");
            }
            if (parameter == null)
            {
                throw new ArgumentNullException("parameter", "RadialMenuItemToContentPosition converter needs the parameter (string axis) !");
            }

            string axis = (string)parameter;

            if (axis != "X" && axis != "Y")
            {
                throw new ArgumentException("RadialMenuItemToContentPosition parameter needs to be 'X' or 'Y' !", "parameter");
            }

            double angle = (double)values[0];
            double centerX = (double)values[1];
            double centerY = (double)values[2];
            double contentWidth = (double)values[3];
            double contentHeight = (double)values[4];
            double contentRadius = (double)values[5];

            Point contentPosition = ComputeCartesianCoordinate(new Point(centerX, centerY), angle, contentRadius);

            if (axis == "X")
            {
                return contentPosition.X - (contentWidth / 2);
            }

            return contentPosition.Y - (contentHeight / 2);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException("RadialMenuItemToContentPosition is a One-Way converter only !");
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

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RadialMenu.Controls
{
    /// <summary>
    /// Interaction logic for RadialMenuCentralItem.xaml
    /// </summary>
    public class RadialMenuCentralItem : Button
    {
        static RadialMenuCentralItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadialMenuCentralItem), new FrameworkPropertyMetadata(typeof(RadialMenuCentralItem)));
        }
    }
}

using System.Windows;
using System.Windows.Controls;

namespace RadialMenu.Controls
{
    /// <summary>
    /// Interaction logic for RadialMenuItemsControl.xaml
    /// </summary>
    internal class RadialMenuItemsControl : ItemsControl
    {
        static RadialMenuItemsControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadialMenuItemsControl), new FrameworkPropertyMetadata(typeof(RadialMenuItemsControl)));
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            var radialMenuItem = item as RadialMenuItem;
            var count = Items.Count;
            var index = Items.IndexOf(radialMenuItem);

            radialMenuItem.Index = index;
            radialMenuItem.Count = count;

            return true;
        }
    }
}

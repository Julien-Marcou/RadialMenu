using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

            return false;
        }

    }
}

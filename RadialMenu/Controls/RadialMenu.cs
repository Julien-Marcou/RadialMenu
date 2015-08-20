using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RadialMenu.Controls
{
    /// <summary>
    /// Interaction logic for RadialMenu.xaml
    /// </summary>
    public class RadialMenu : ContentControl
    {
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(RadialMenu),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty HalfShiftedItemsProperty =
            DependencyProperty.Register("HalfShiftedItems", typeof(bool), typeof(RadialMenu),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public bool HalfShiftedItems
        {
            get { return (bool)GetValue(HalfShiftedItemsProperty); }
            set { SetValue(HalfShiftedItemsProperty, value); }
        }

        public static readonly DependencyProperty CentralItemProperty =
            DependencyProperty.Register("CentralItem", typeof(RadialMenuCentralItem), typeof(RadialMenu),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public RadialMenuCentralItem CentralItem
        {
            get { return (RadialMenuCentralItem)GetValue(CentralItemProperty); }
            set { SetValue(CentralItemProperty, value); }
        }

        public new static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(List<RadialMenuItem>), typeof(RadialMenu),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public new List<RadialMenuItem> Content
        {
            get { return (List<RadialMenuItem>)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public List<RadialMenuItem> Items
        {
            get { return Content; }
            set { Content = value; }
        }

        static RadialMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadialMenu), new FrameworkPropertyMetadata(typeof(RadialMenu)));
        }

        public override void BeginInit()
        {
            Content = new List<RadialMenuItem>();
            base.BeginInit();
        }

        protected override Size ArrangeOverride(Size arrangeSize)
        {
            for (int i = 0, count = Items.Count; i < count; i++)
            {
                Items[i].Index = i;
                Items[i].Count = count;
                Items[i].HalfShifted = HalfShiftedItems;
            }
            return base.ArrangeOverride(arrangeSize);
        }
    }
}

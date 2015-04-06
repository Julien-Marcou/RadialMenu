using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RadialMenu.Controls
{
    /// <summary>
    /// Interaction logic for RadialMenuItem.xaml
    /// </summary>
    public class RadialMenuItem : ContentControl
    {
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public new static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(Panel), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public new Panel Content
        {
            get { return (Panel)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly DependencyProperty IndexProperty =
            DependencyProperty.Register("Index", typeof(int), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public int Index
        {
            get { return (int)GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }

        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(int), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        static RadialMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadialMenuItem), new FrameworkPropertyMetadata(typeof(RadialMenuItem)));
        }
    }
}

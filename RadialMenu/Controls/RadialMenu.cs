using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        public static readonly DependencyProperty CentralMenuItemProperty =
            DependencyProperty.Register("CentralMenuItem", typeof(Panel), typeof(RadialMenu),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public Panel CentralMenuItem
        {
            get { return (Panel)GetValue(CentralMenuItemProperty); }
            set { SetValue(CentralMenuItemProperty, value); }
        }

        public static readonly DependencyProperty CentralMenuCommandProperty =
            DependencyProperty.Register("CentralMenuCommand", typeof(ICommand), typeof(RadialMenu),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public ICommand CentralMenuCommand
        {
            get { return (ICommand)GetValue(CentralMenuCommandProperty); }
            set { SetValue(CentralMenuCommandProperty, value); }
        }

        public new static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(List<RadialMenuItem>), typeof(RadialMenu),
            new FrameworkPropertyMetadata(new List<RadialMenuItem>(), FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public new List<RadialMenuItem> Content
        {
            get { return (List<RadialMenuItem>)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        static RadialMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadialMenu), new FrameworkPropertyMetadata(typeof(RadialMenu)));
        }
    }
}

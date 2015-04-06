using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Runtime.CompilerServices;
using RadialMenuDemo.Utils;
using System.Threading;

namespace RadialMenuDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private bool _isOpen = false;
        public bool IsOpen
        {
            get
            {
                return _isOpen;
            }
            set
            {
                _isOpen = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CloseRadialMenu
        {
            get
            {
                return new RelayCommand(() => IsOpen = false);
            }
        }
        public ICommand OpenRadialMenu
        {
            get
            {
                return new RelayCommand(() => IsOpen = true);
            }
        }

        public ICommand Test1
        {
            get
            {
                return new RelayCommand(() => System.Diagnostics.Debug.WriteLine("1"));
            }
        }

        public ICommand Test2
        {
            get
            {
                return new RelayCommand(() => System.Diagnostics.Debug.WriteLine("2"));
            }
        }

        public ICommand Test3
        {
            get
            {
                return new RelayCommand(() => System.Diagnostics.Debug.WriteLine("3"));
            }
        }

        public ICommand Test4
        {
            get
            {
                return new RelayCommand(() => System.Diagnostics.Debug.WriteLine("4"));
            }
        }

        public ICommand Test5
        {
            get
            {
                return new RelayCommand(() => System.Diagnostics.Debug.WriteLine("5"));
            }
        }

        public ICommand Test6
        {
            get
            {
                return new RelayCommand(
                    () =>
                    {
                        System.Diagnostics.Debug.WriteLine("6");
                    },
                    () =>
                    {
                        return false;
                    }
                );
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenRadialMenu.Execute(null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Konwertery.Annotations;

namespace Konwertery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Visibility _widocznoscV1;
        public Visibility WidocznoscV1
        {
            get
            {
                return _widocznoscV1;
            }
            set
            {
                _widocznoscV1 = value;
                OnPropertyChanged(nameof(WidocznoscV1));
            }
        }

        private bool _widocznoscV2;
        public bool WidocznoscV2
        {
            get
            {
                return _widocznoscV2;
            }
            set
            {
                _widocznoscV2 = value;
                OnPropertyChanged(nameof(WidocznoscV2));
            }
        }

        private bool _czyZazanczony;
        public bool CzyZazanczony
        {
            get
            {
                return _czyZazanczony;
            }
            set
            {
                _czyZazanczony = value;
                OnPropertyChanged(nameof(CzyZazanczony));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ButtonUkryjV1_OnClick(object sender, RoutedEventArgs e)
        {
            if (WidocznoscV1 == Visibility.Visible)
            {
                WidocznoscV1 = Visibility.Hidden;
            }
            else
            {
                WidocznoscV1 = Visibility.Visible;
            }
        }

        private void ButtonUkryjV2_OnClick(object sender, RoutedEventArgs e)
        {
            WidocznoscV2 = !WidocznoscV2;
        }
    }
}

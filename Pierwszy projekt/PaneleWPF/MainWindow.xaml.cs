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

namespace PaneleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonWrapPanel_OnClick(object sender, RoutedEventArgs e)
        {
            OknoWrapPanel oknoWrapPanel = new OknoWrapPanel();
            oknoWrapPanel.ShowDialog();
        }

        private void ButtonStackPanel_OnClick(object sender, RoutedEventArgs e)
        {
            OknoStackPanel oknoStackPanel = new OknoStackPanel();
            oknoStackPanel.ShowDialog();
        }

        private void ButtonDockPanel_OnClick(object sender, RoutedEventArgs e)
        {
            OknoDockPanel oknoDockPanel = new OknoDockPanel();
            oknoDockPanel.ShowDialog();
        }

        private void ButtonGrid_OnClick(object sender, RoutedEventArgs e)
        {
            OknoGrid oknoGrid = new OknoGrid();
            oknoGrid.ShowDialog();
        }

        private void ButtonGridSpliter_OnClick(object sender, RoutedEventArgs e)
        {
            OknoGridSpliter gridSpliter = new OknoGridSpliter();
            gridSpliter.ShowDialog();
        }
    }
}

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
using Bindowanie.Annotations;

namespace Bindowanie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string DanaTextBox { get; set; }

        public string Dana_z_widoku_do_kodu { get; set; }
        public string Dana_z_kodu_do_widoku { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBlockWynik.Text = TextBoxWartosc.Text;
            ButtonPrzycisk.Content = TextBoxWartosc.Text;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DanaTextBox);
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Dana_z_widoku_do_kodu, out int liczba))
            {
                liczba = liczba * 2;
                Dana_z_kodu_do_widoku = liczba.ToString();
                //Dana_z_kodu_do_widoku
                OnPropertyChanged("Dana_z_kodu_do_widoku");
            }
            else
            {
                Dana_z_kodu_do_widoku = "Podano wartość nie będącą liczbą!!!!";
                OnPropertyChanged(nameof(Dana_z_kodu_do_widoku));
            }

        }




    }
}

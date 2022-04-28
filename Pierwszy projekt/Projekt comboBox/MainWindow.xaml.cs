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
using Projekt_comboBox.Annotations;

namespace Projekt_comboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<string> ListaPozycji { get; set; }

        public List<KolorNaLiscie> ListaKolorow { get; set; }

        public KolorNaLiscie WybranyKolor { get; set; }

        public bool AktywujPrzycisk
        {
            get
            {
                return WybranyKolor != null;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            ListaPozycji = new List<string>();
            ListaPozycji.Add("Pozycja bindowania 0");
            ListaPozycji.Add("Pozycja bindowania 1");
            ListaPozycji.Add("Pozycja bindowania 2");
            OnPropertyChanged(nameof(ListaPozycji));

            ListaKolorow = new List<KolorNaLiscie>();
            ListaKolorow.Add(new KolorNaLiscie()
            {
                NazwaKoloru = "Green",
                OpisKoloru = "Zielony"
            });
            ListaKolorow.Add(new KolorNaLiscie()
            {
                NazwaKoloru = "Red",
                OpisKoloru = "Czerwony"
            });
            OnPropertyChanged(nameof(ListaKolorow));
            OnPropertyChanged(nameof(AktywujPrzycisk));

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            string tekst = "wybrano kolor: ";
            if (WybranyKolor != null)
                tekst = tekst + WybranyKolor.OpisKoloru;
            else
                tekst = tekst + "Brak koloru";
            MessageBox.Show(tekst);
        }
    }
}

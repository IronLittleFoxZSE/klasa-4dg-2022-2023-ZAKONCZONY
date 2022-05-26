using PrzelicznikMVVM.Baza_danych.Model;
using PrzelicznikMVVM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitisWpf;

namespace PrzelicznikMVVM.ViewModel
{
    class PrzelicznikVM : ObserverVM
    {
        private IPrzelicznikRepository przelicznikRepository;

        private List<Rodzaj> _listaRodzaj;

        public List<Rodzaj> ListaRodzaj
        {
            get { return _listaRodzaj; }
            set
            {
                _listaRodzaj = value;
                OnPropertyChanged();
            }
        }

        private Rodzaj _wybranyRodzaj;

        public Rodzaj WybranyRodzaj
        {
            get { return _wybranyRodzaj; }
            set
            {
                _wybranyRodzaj = value;
                OnPropertyChanged();
                ZaladujJednostkiZrodlowe();
                ZaladujJednostkiDocelowe();
            }
        }

        private List<Jednostka> _jednostkiZrodlowe;

        public List<Jednostka> JednostkiZrodlowe
        {
            get { return _jednostkiZrodlowe; }
            set
            {
                _jednostkiZrodlowe = value;
                OnPropertyChanged();
            }
        }

        private Jednostka _wybranaJednostkaZrodlowa;

        public Jednostka WybranaJednostkaZrodlowa
        {
            get { return _wybranaJednostkaZrodlowa; }
            set
            {
                _wybranaJednostkaZrodlowa = value;
                OnPropertyChanged();
            }
        }

        private List<Jednostka> _jednostkiDocelowe;

        public List<Jednostka> JednostkiDocelowe
        {
            get { return _jednostkiDocelowe; }
            set
            {
                _jednostkiDocelowe = value;
                OnPropertyChanged();
            }
        }

        private Jednostka _wybranaJednostkaDocelowa;

        public Jednostka WybranaJednostkaDocelowa
        {
            get { return _wybranaJednostkaDocelowa; }
            set
            {
                _wybranaJednostkaDocelowa = value;
                OnPropertyChanged();
            }
        }

        private string _wpisanaWartosc;

        public string WpisanaWartosc
        {
            get { return _wpisanaWartosc; }
            set 
            { 
                _wpisanaWartosc = value;
                OnPropertyChanged();
            }
        }

        private string _wynikPrzeliczenia;

        public string WynikPrzeliczenia
        {
            get { return _wynikPrzeliczenia; }
            set 
            { 
                _wynikPrzeliczenia = value;
                OnPropertyChanged();
            }
        }

        private ICommand _przeliczCommand;

        public ICommand PrzeliczCommand
        {
            get
            {
                if (_przeliczCommand == null)
                    _przeliczCommand = new RelayCommand<object>(Przelicz, (o)=> int.TryParse(WpisanaWartosc, out int w));
                return _przeliczCommand;
            }
        }


        public PrzelicznikVM()
        {
            przelicznikRepository = new PrzelicznikRepository();

            ListaRodzaj = przelicznikRepository.ReadRodzaje();
            WybranyRodzaj = ListaRodzaj.First();
        }

        private void ZaladujJednostkiZrodlowe()
        {
            JednostkiZrodlowe = przelicznikRepository.ReadJednostki(WybranyRodzaj.Id);
            WybranaJednostkaZrodlowa = JednostkiZrodlowe.First();
        }

        private void ZaladujJednostkiDocelowe()
        {
            JednostkiDocelowe = przelicznikRepository.ReadJednostki(WybranyRodzaj.Id);
            WybranaJednostkaDocelowa = JednostkiDocelowe.First();
        }

        private void Przelicz(object o)
        {
            PrzelicznikJednostek przelicznikJednostek = przelicznikRepository
                .ReadPrzelicznikJednostek(WybranaJednostkaZrodlowa.Id, WybranaJednostkaDocelowa.Id);
            
            if (!double.TryParse(WpisanaWartosc, out double wartosc))
            {
                WynikPrzeliczenia = "Zła wartość w polu danych";
                return;
            }

            double wynik = wartosc * przelicznikJednostek.WartoscPrzelicznika;
            WynikPrzeliczenia = wartosc + WybranaJednostkaZrodlowa.Symbol + " = " + wynik + WybranaJednostkaDocelowa.Symbol;
        }
    }
}

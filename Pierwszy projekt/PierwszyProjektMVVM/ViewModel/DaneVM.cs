using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PierwszyProjektMVVM.Annotations;
using PierwszyProjektMVVM.Model;
using UtilitisWpf;


namespace PierwszyProjektMVVM.ViewModel
{
    class DaneVM : ObserverVM
    {
        private Dane dane;

        public string DanaWejsciowa
        {
            set
            {
                dane.DanaWejsciowa = value;
            }
        }

        public string DanaWyliczana
        {
            get
            {
                return dane.DanaWyliczana;
            }
            set
            {
                dane.DanaWyliczana = value;
                OnPropertyChanged();
            }
        }

        private bool _czyAktywna;
        public bool CzyAktywna
        {
            get
            {
                return dane.CzyAktywny;
            }
            set
            {
                dane.CzyAktywny = value;
                OnPropertyChanged();
            }
        }

        private ICommand _wykonajObliczenia;
        public ICommand WykonajObliczenia
        {
            get
            {
                if (_wykonajObliczenia == null)
                {
                    _wykonajObliczenia = new RelayCommand<object>(WywolajMetode);
                }

                return _wykonajObliczenia;
            }
        }

        public DaneVM()
        {
            dane = new Dane();
        }

        private void WywolajMetode(object parametr)
        {
            if (int.TryParse(dane.DanaWejsciowa, out int liczba))
            {
                liczba = liczba * liczba;
                DanaWyliczana = "Wynik operacji: " + liczba;
            }
            else
            {
                DanaWyliczana = "Podano nie liczbę.";
            }
        }
    }
}

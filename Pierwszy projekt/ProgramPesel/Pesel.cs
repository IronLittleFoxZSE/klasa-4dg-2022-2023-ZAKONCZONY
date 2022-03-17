using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPesel
{
    class Pesel
    {
        private string numerPesel;


        private int rok;

        public string Plec
        {
            get
            {
                return numerPesel[9].ToString();
            }
        }

        public string PlecOpis
        {
            get
            {
                int plec = int.Parse(numerPesel[9].ToString());
                if (plec % 2 == 0)
                    return "Kobieta";
                else
                    return "Mężczyzna";
            }
        }


        public Pesel(string numerPesel)
        {
            this.numerPesel = numerPesel;
            Walidacja();
        }

        private void Walidacja()
        {
            WalidacjaPoprawnoscDlugosci();
            /*WalidacjaPoprawnosciZnakow();
            WalidacjaPoprawnosciMiesiaca();
            WalidacjaPoprawnosciDnia();
            WalidacjaPoprawnosciCyfryKontrolnej();*/
        }

        private void WalidacjaPoprawnoscDlugosci()
        {
            if (numerPesel.Length != 11)
                throw new Exception("Zła długość numeru pesel");
        }

        private int Parse(string liczbaStr)
        {
            int wynik = 0;
            int pozycja = 1;
            for (int i = liczbaStr.Length-1 ; i <= 0 ; i--)
            {
                wynik = ((int) liczbaStr[i] - 48) * pozycja + wynik;
                pozycja *= 10;
            }
            return wynik;
        }
    }
}

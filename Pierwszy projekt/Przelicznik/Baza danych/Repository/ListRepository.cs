using Przelicznik.Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Przelicznik.Baza_danych.Repository
{
    class ListRepository
    {
        private List<Rodzaj> Rodzaje = new List<Rodzaj>();
        private List<Jednostka> Jednostki = new List<Jednostka>();
        private List<PrzelicznikJednostek> PrzelicznikiJednostek = new List<PrzelicznikJednostek>();

        public ListRepository()
        {
            CreateRodzaj(1, "Waluta");
            CreateRodzaj(2, "Masa");

            CreateJednostka(1, "Złoty", "zł", 1);
            CreateJednostka(2, "Dolar", "$", 1);
            CreateJednostka(3, "Funt", "£", 1);
            CreateJednostka(4, "gram", "g", 2);
            CreateJednostka(5, "dekagram", "dag", 2);
            CreateJednostka(6, "kilogram", "kg", 2);
            CreateJednostka(7, "tona", "t", 2);

            //Złoty na ...
            CreatePrzelicznikJednostek(1, 1, 1, 1);
            CreatePrzelicznikJednostek(2, 1, 2, 0.5);
            CreatePrzelicznikJednostek(3, 1, 3, 5);

            //Dolar na ...
            CreatePrzelicznikJednostek(4, 2, 1, 2);
            CreatePrzelicznikJednostek(5, 2, 2, 1);
            CreatePrzelicznikJednostek(6, 2, 3, 4);

            //Funt na ...
            CreatePrzelicznikJednostek(7, 3, 1, 0.2);
            CreatePrzelicznikJednostek(8, 3, 2, 0.25);
            CreatePrzelicznikJednostek(9, 3, 3, 1);

            //gram na ...
            CreatePrzelicznikJednostek(10, 4, 4, 1);
            CreatePrzelicznikJednostek(11, 4, 5, 0.1);
            CreatePrzelicznikJednostek(12, 4, 6, 0.001);
            CreatePrzelicznikJednostek(14, 4, 7, 0.000001);

            //dekagram na ...
            CreatePrzelicznikJednostek(15, 5, 4, 10);
            CreatePrzelicznikJednostek(16, 5, 5, 1);
            CreatePrzelicznikJednostek(17, 5, 6, 0.01);
            CreatePrzelicznikJednostek(18, 5, 7, 0.00001);

            //kilogram na ...
            CreatePrzelicznikJednostek(19, 6, 4, 1000);
            CreatePrzelicznikJednostek(20, 6, 5, 100);
            CreatePrzelicznikJednostek(21, 6, 6, 1);
            CreatePrzelicznikJednostek(22, 6, 7, 0.001);

            //tona na ...
            CreatePrzelicznikJednostek(23, 7, 4, 1000000);
            CreatePrzelicznikJednostek(24, 7, 5, 100000);
            CreatePrzelicznikJednostek(25, 7, 6, 1000);
            CreatePrzelicznikJednostek(26, 7, 7, 1);
        }

        public void CreateRodzaj(int id, string nazwa)
        {
            Rodzaj rodzaj = new Rodzaj
            {
                Id = id,
                Nazwa = nazwa
            };
            Rodzaje.Add(rodzaj);
        }

        public void CreateJednostka(int id, string nazwa, string symbol, int rodzajId)
        {
            Jednostka jednostka = new Jednostka()
            {
                Id = id,
                Nazwa = nazwa,
                Symbol = symbol,
                RodzajId = rodzajId
            };
            Jednostki.Add(jednostka);
        }

        public void CreatePrzelicznikJednostek(int id, int zrodloJednostkaID, int docelowaJednostkaId, double wartoscPrzelicznika)
        {
            PrzelicznikJednostek przelicznikJednostek = new PrzelicznikJednostek()
            {
                Id = id,
                ZrodloJednostkaID = zrodloJednostkaID,
                DocelowaJednostkaId = docelowaJednostkaId,
                WartoscPrzelicznika = wartoscPrzelicznika
            };
            PrzelicznikiJednostek.Add(przelicznikJednostek);
        }

        public List<Rodzaj> ReadRodzaje()
        {
            return Rodzaje;
        }

        public List<Jednostka> ReadJednostki(int rodzajId)
        {
            return Jednostki.Where(j => j.RodzajId == rodzajId).ToList();
        }

        public PrzelicznikJednostek ReadPrzelicznikJednostek(int jednostaZrodlowaId, int jednostkaDocelowaId)
        {
            return PrzelicznikiJednostek.FirstOrDefault(pj => pj.ZrodloJednostkaID == jednostaZrodlowaId
            && pj.DocelowaJednostkaId == jednostkaDocelowaId);
        }
    }
}

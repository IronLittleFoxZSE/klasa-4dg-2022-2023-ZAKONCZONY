using PrzelicznikMVVM.Baza_danych.Context;
using PrzelicznikMVVM.Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzelicznikMVVM.Repository
{
    class PrzelicznikRepository : IPrzelicznikRepository
    {
        private PrzelicznikDbContext przelicznikDbContext;

        public PrzelicznikRepository()
        {
            przelicznikDbContext = new PrzelicznikDbContext();
            //UzupelnienieBazy();
        }

        #region Uzupełnienie bazy

        private void UzupelnienieBazy()
        {
            CreateRodzaj("Waluta");
            CreateRodzaj("Masa");

            CreateJednostka("Złoty", "zł", 1);
            CreateJednostka("Dolar", "$", 1);
            CreateJednostka("Funt", "£", 1);
            CreateJednostka("gram", "g", 2);
            CreateJednostka("dekagram", "dag", 2);
            CreateJednostka("kilogram", "kg", 2);
            CreateJednostka("tona", "t", 2);

            //Złoty na ...
            CreatePrzelicznikJednostek(1, 1, 1);
            CreatePrzelicznikJednostek(1, 2, 0.5);
            CreatePrzelicznikJednostek(1, 3, 5);

            //Dolar na ...
            CreatePrzelicznikJednostek(2, 1, 2);
            CreatePrzelicznikJednostek(2, 2, 1);
            CreatePrzelicznikJednostek(2, 3, 4);

            //Funt na ...
            CreatePrzelicznikJednostek(3, 1, 0.2);
            CreatePrzelicznikJednostek(3, 2, 0.25);
            CreatePrzelicznikJednostek(3, 3, 1);

            //gram na ...
            CreatePrzelicznikJednostek(4, 4, 1);
            CreatePrzelicznikJednostek(4, 5, 0.1);
            CreatePrzelicznikJednostek(4, 6, 0.001);
            CreatePrzelicznikJednostek(4, 7, 0.000001);

            //dekagram na ...
            CreatePrzelicznikJednostek(5, 4, 10);
            CreatePrzelicznikJednostek(5, 5, 1);
            CreatePrzelicznikJednostek(5, 6, 0.01);
            CreatePrzelicznikJednostek(5, 7, 0.00001);

            //kilogram na ...
            CreatePrzelicznikJednostek(6, 4, 1000);
            CreatePrzelicznikJednostek(6, 5, 100);
            CreatePrzelicznikJednostek(6, 6, 1);
            CreatePrzelicznikJednostek(6, 7, 0.001);

            //tona na ...
            CreatePrzelicznikJednostek(7, 4, 1000000);
            CreatePrzelicznikJednostek(7, 5, 100000);
            CreatePrzelicznikJednostek(7, 6, 1000);
            CreatePrzelicznikJednostek(7, 7, 1);
        }

        #endregion

        #region Create

        public void CreateRodzaj(string nazwa)
        {
            Rodzaj rodzaj = new Rodzaj
            {
                Nazwa = nazwa
            };
            przelicznikDbContext.Rodzaje.Add(rodzaj);
            przelicznikDbContext.SaveChanges();
        }

        public void CreateJednostka(string nazwa, string symbol, int rodzajId)
        {
            Jednostka jednostka = new Jednostka()
            {
                Nazwa = nazwa,
                Symbol = symbol,
                RodzajId = rodzajId
            };
            przelicznikDbContext.Jednostki.Add(jednostka);
            przelicznikDbContext.SaveChanges();
        }

        public void CreatePrzelicznikJednostek(int zrodloJednostkaID, int docelowaJednostkaId, double wartoscPrzelicznika)
        {
            PrzelicznikJednostek przelicznikJednostek = new PrzelicznikJednostek()
            {
                ZrodloJednostkaID = zrodloJednostkaID,
                DocelowaJednostkaId = docelowaJednostkaId,
                WartoscPrzelicznika = wartoscPrzelicznika
            };
            przelicznikDbContext.PrzelicznikJednostek.Add(przelicznikJednostek);
            przelicznikDbContext.SaveChanges();
        }

        #endregion

        #region Read
        public List<Rodzaj> ReadRodzaje()
        {
            List<Rodzaj> listaWynikowa = przelicznikDbContext.Rodzaje.ToList();
            return listaWynikowa;
        }

        public List<Jednostka> ReadJednostki(int rodzajId)
        {
            return przelicznikDbContext.Jednostki.Where(j => j.RodzajId == rodzajId).ToList();
        }

        public PrzelicznikJednostek ReadPrzelicznikJednostek(int jednostaZrodlowaId, int jednostkaDocelowaId)
        {
            return przelicznikDbContext.PrzelicznikJednostek.FirstOrDefault(pj => pj.ZrodloJednostkaID == jednostaZrodlowaId
            && pj.DocelowaJednostkaId == jednostkaDocelowaId);
        }

        #endregion



    }
}

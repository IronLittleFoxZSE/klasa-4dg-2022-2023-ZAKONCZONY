using PrzelicznikMVVM.Baza_danych.Model;
using System.Collections.Generic;

namespace PrzelicznikMVVM.Repository
{
    interface IPrzelicznikRepository
    {
        void CreateJednostka(string nazwa, string symbol, int rodzajId);
        void CreatePrzelicznikJednostek(int zrodloJednostkaID, int docelowaJednostkaId, double wartoscPrzelicznika);
        void CreateRodzaj(string nazwa);
        List<Rodzaj> ReadRodzaje();
        List<Jednostka> ReadJednostki(int rodzajId);
        PrzelicznikJednostek ReadPrzelicznikJednostek(int jednostaZrodlowaId, int jednostkaDocelowaId);
    }
}
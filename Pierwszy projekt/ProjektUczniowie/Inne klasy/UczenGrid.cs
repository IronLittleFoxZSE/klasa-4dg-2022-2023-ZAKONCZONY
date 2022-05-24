using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektUczniowie.Baza_danych.Model;

namespace ProjektUczniowie.Inne_klasy
{
    public class UczenGrid
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NazwaKlasy { get; set; }
        public int RokUrodzenia { get; set; }
        public Klasa Klasa { get; set; }
    }
}

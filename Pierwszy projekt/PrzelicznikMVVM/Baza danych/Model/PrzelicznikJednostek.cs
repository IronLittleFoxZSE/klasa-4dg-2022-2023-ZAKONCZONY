using System;
using System.Collections.Generic;
using System.Text;

namespace PrzelicznikMVVM.Baza_danych.Model
{
    class PrzelicznikJednostek
    {
        public int Id { get; set; }
        
        public int ZrodloJednostkaID { get; set; }
        public Jednostka Zrodlo { get; set; }

        public int DocelowaJednostkaId { get; set; }
        public Jednostka Docelowa { get; set; }

        public double WartoscPrzelicznika { get; set; }
    }
}

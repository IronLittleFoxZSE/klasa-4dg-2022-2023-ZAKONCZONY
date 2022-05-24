using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjektUczniowie.Baza_danych.Model;

namespace ProjektUczniowie.Baza_danych.Context
{
    public class UczniowieDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=uczniowieDb.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Klasa> Klasy { get; set; }
        public DbSet<Uczen> Uczniowie { get; set; }
    }
}

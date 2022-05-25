using Microsoft.EntityFrameworkCore;
using PrzelicznikMVVM.Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzelicznikMVVM.Baza_danych.Context
{
    class PrzelicznikDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=przelicznikDbMVVM.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Rodzaj> Rodzaje { get; set; }
        public DbSet<Jednostka> Jednostki { get; set; }
        public DbSet<PrzelicznikJednostek> PrzelicznikJednostek { get; set; }
    }
}

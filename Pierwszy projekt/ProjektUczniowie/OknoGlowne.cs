using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ProjektUczniowie.Baza_danych.Context;
using ProjektUczniowie.Baza_danych.Model;
using ProjektUczniowie.Inne_klasy;
using ProjektUczniowie.Okna;

namespace ProjektUczniowie
{
    public partial class OknoGlowne : Form
    {
        private UczniowieDbcontext uczniowieDbcontext;
        public OknoGlowne()
        {
            InitializeComponent();

            uczniowieDbcontext = new UczniowieDbcontext();

            ZaladujListeKlas();
            dataGridViewListaUczniow.AutoGenerateColumns = false;
        }

        private void ZaladujListeKlas()
        {
            List<Klasa> listaKlas = uczniowieDbcontext.Klasy.ToList();
            listaKlas.Insert(0, new Klasa()
            {
                Id = -1,
                NazwaKlasy = "<wszystkie>"
            });
            comboBoxWyszukajKlasa.DataSource = listaKlas;
            comboBoxWyszukajKlasa.DisplayMember = "NazwaKlasy";
        }

        private void buttonDodajKlase_Click(object sender, EventArgs e)
        {
            OknoDodajKlase oknoDodajKlase = new OknoDodajKlase();
            oknoDodajKlase.UczniowieDbcontext = uczniowieDbcontext;
            if (oknoDodajKlase.ShowDialog() == DialogResult.OK)
            {
                Klasa klasa = new Klasa()
                {
                    NazwaKlasy = oknoDodajKlase.NazwaKlasy
                };
                uczniowieDbcontext.Klasy.Add(klasa);
                uczniowieDbcontext.SaveChanges();
                ZaladujListeKlas();
            }

        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz usunąć aktualny rekord?", "Usuwanie", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                UczenGrid aktualnyUczenGrid = dataGridViewListaUczniow.CurrentRow?.DataBoundItem as UczenGrid;
                if (aktualnyUczenGrid != null)
                {
                    Uczen szukanyUczen = uczniowieDbcontext.Uczniowie.Find(aktualnyUczenGrid.Id);
                    if (szukanyUczen != null)
                    {
                        uczniowieDbcontext.Uczniowie.Remove(szukanyUczen);
                        uczniowieDbcontext.SaveChanges();

                        //(dataGridViewListaUczniow.DataSource as List<UczenGrid>).Remove(aktualnyUczenGrid);
                        //dataGridViewListaUczniow.Refresh();
                        //dataGridViewListaUczniow.Rows.Remove(dataGridViewListaUczniow.CurrentRow);
                        //dataGridViewListaUczniow.Rows.RemoveAt(dataGridViewListaUczniow.CurrentRow.Index);
                        MessageBox.Show("Skasowanie zakończone powodzeniem");
                        buttonSzukaj.PerformClick();
                    }
                }
            }
        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            var listaUczniow = uczniowieDbcontext.Uczniowie.AsQueryable();
            if (!string.IsNullOrEmpty(textBoxWyszukajImie.Text))
                listaUczniow = listaUczniow.Where(u => u.Imie == textBoxWyszukajImie.Text);
            if (!string.IsNullOrEmpty(textBoxWyszukajNazwisko.Text))
                listaUczniow = listaUczniow.Where(u => u.Nazwisko == textBoxWyszukajNazwisko.Text);
            if ((comboBoxWyszukajKlasa.SelectedItem as Klasa)?.Id != -1)
                listaUczniow = listaUczniow.Where(u => u.KlasaId == (comboBoxWyszukajKlasa.SelectedItem as Klasa).Id);
            if (!string.IsNullOrEmpty(numericUpDownWyszukajRok.Text))
                listaUczniow = listaUczniow.Where(u => u.RokUrodzenia == (int)numericUpDownWyszukajRok.Value);

            var docelowaLista = listaUczniow
                .Include(u=>u.Klasa)
                .Select(u => new UczenGrid()
            {
                Id = u.Id,
                Imie = u.Imie,
                Nazwisko = u.Nazwisko,
                RokUrodzenia = u.RokUrodzenia,
                NazwaKlasy = u.Klasa.NazwaKlasy,
                Klasa = u.Klasa
            }).ToList();

            dataGridViewListaUczniow.DataSource = docelowaLista;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            OknoSzczegolyUczen oknoSzczegolyUczen = new OknoSzczegolyUczen(uczniowieDbcontext);
            oknoSzczegolyUczen.OpisPrzysiskuOk = "Dodaj";
            if (oknoSzczegolyUczen.ShowDialog() == DialogResult.OK)
            {
                Uczen uczen = new Uczen()
                {
                    Imie = oknoSzczegolyUczen.Imie,
                    Nazwisko = oknoSzczegolyUczen.Nazwisko,
                    RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia,
                    KlasaId = oknoSzczegolyUczen.Klasa.Id
                };
                uczniowieDbcontext.Uczniowie.Add(uczen);
                uczniowieDbcontext.SaveChanges();
            }
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            OknoSzczegolyUczen oknoSzczegolyUczen = new OknoSzczegolyUczen(uczniowieDbcontext);
            oknoSzczegolyUczen.OpisPrzysiskuOk = "Edytuj";
            UczenGrid aktualnyUczen = dataGridViewListaUczniow.CurrentRow?.DataBoundItem as UczenGrid;

            if (aktualnyUczen == null)
            {
                return;
            }

            oknoSzczegolyUczen.Imie = aktualnyUczen.Imie;
            oknoSzczegolyUczen.Nazwisko = aktualnyUczen.Nazwisko;
            oknoSzczegolyUczen.RokUrodzenia = aktualnyUczen.RokUrodzenia;
            oknoSzczegolyUczen.Klasa = aktualnyUczen.Klasa;

            if (oknoSzczegolyUczen.ShowDialog() == DialogResult.OK)
            {
                aktualnyUczen.Imie = oknoSzczegolyUczen.Imie;
                aktualnyUczen.Nazwisko = oknoSzczegolyUczen.Nazwisko;
                aktualnyUczen.RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia;
                aktualnyUczen.Klasa = oknoSzczegolyUczen.Klasa;
                aktualnyUczen.NazwaKlasy = oknoSzczegolyUczen.Klasa.NazwaKlasy;
                dataGridViewListaUczniow.Refresh();

                Uczen uczen = uczniowieDbcontext.Uczniowie.FirstOrDefault(u => u.Id == aktualnyUczen.Id);

                uczen.Imie = oknoSzczegolyUczen.Imie;
                uczen.Nazwisko = oknoSzczegolyUczen.Nazwisko;
                uczen.RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia;
                uczen.KlasaId = oknoSzczegolyUczen.Klasa.Id;
                uczniowieDbcontext.SaveChanges();
            }
        }
    }

    
}

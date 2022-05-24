using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektUczniowie.Baza_danych.Context;
using ProjektUczniowie.Baza_danych.Model;

namespace ProjektUczniowie.Okna
{
    public partial class OknoSzczegolyUczen : Form
    {
        public UczniowieDbcontext uczniowieDbcontext;

        public string Imie
        {
            get
            {
                return textBoxWyszukajImie.Text;
            }
            set
            {
                textBoxWyszukajImie.Text = value;
            }
        }
        public string Nazwisko
        {
            get
            {
                return textBoxWyszukajNazwisko.Text;
            }
            set
            {
                textBoxWyszukajNazwisko.Text = value;
            }
        }

        public int RokUrodzenia
        {
            get
            {
                return (int)numericUpDownWyszukajRok.Value;
            }
            set
            {
                numericUpDownWyszukajRok.Value = value;
            }
        }

        public Klasa Klasa
        {
            get
            {
                return comboBoxWyszukajKlasa.SelectedItem as Klasa;
            }
            set
            {
                foreach (Klasa element in comboBoxWyszukajKlasa.DataSource as IEnumerable<Klasa>)
                {
                    if (element.Id == value.Id)
                    {
                        comboBoxWyszukajKlasa.SelectedItem = element;
                        break;
                    }
                }
            }
        }

        public bool PokazPrzyciskAnuluj
        {
            set
            {
                buttonAnuluj.Visible = value;
            }
        }

        public string OpisPrzysiskuOk
        {
            set
            {
                buttonOk.Text = value;
            }
        }



        public OknoSzczegolyUczen(UczniowieDbcontext uczniowieDbcontext)
        {
            InitializeComponent();
            this.uczniowieDbcontext = uczniowieDbcontext;
            ZaladujListeKlas();
        }

        private void ZaladujListeKlas()
        {
            List<Klasa> listaKlas = uczniowieDbcontext.Klasy.ToList();
            comboBoxWyszukajKlasa.DataSource = listaKlas;
            comboBoxWyszukajKlasa.DisplayMember = "NazwaKlasy";
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

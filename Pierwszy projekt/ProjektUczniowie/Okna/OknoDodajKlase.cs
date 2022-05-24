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

namespace ProjektUczniowie.Okna
{
    public partial class OknoDodajKlase : Form
    {
        public UczniowieDbcontext UczniowieDbcontext { get; set; }

        public string NazwaKlasy
        {
            get
            {
                return textBoxNazwaKlasy.Text;
            }
        }

        public OknoDodajKlase()
        {
            InitializeComponent();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (UczniowieDbcontext == null)
            {
                MessageBox.Show("Nieprawidłowo otwarte okono");
                return;
            }

            string nazwaKlasy = textBoxNazwaKlasy.Text;
            if (string.IsNullOrEmpty(nazwaKlasy))
            {
                MessageBox.Show("Podaj nazwę klasy");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();

        }
    }
}

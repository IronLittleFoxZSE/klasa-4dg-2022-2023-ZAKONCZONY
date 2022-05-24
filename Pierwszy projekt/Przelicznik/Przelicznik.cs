using Przelicznik.Baza_danych.Model;
using Przelicznik.Baza_danych.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przelicznik
{
    public partial class Przelicznik : Form
    {
        private ListRepository listRepository = new ListRepository();

        public Przelicznik()
        {
            InitializeComponent();

            comboBoxRodzaj.SelectedIndexChanged -= comboBoxRodzaj_SelectedIndexChanged;

            List<Rodzaj> rodzaje = listRepository.ReadRodzaje();

            comboBoxRodzaj.DataSource = rodzaje;
            comboBoxRodzaj.DisplayMember = "Nazwa";

            comboBoxRodzaj.SelectedIndex = 0;
            comboBoxRodzaj.SelectedIndexChanged += comboBoxRodzaj_SelectedIndexChanged;
            comboBoxRodzaj_SelectedIndexChanged(null, null);
        }

        private void comboBoxRodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRodzaj.SelectedItem is Rodzaj)
            {
                Rodzaj wybranyRodzaj = comboBoxRodzaj.SelectedItem as Rodzaj;
                List<Jednostka> jednostkiZrodlowe = listRepository.ReadJednostki(wybranyRodzaj.Id);
                List<Jednostka> jednostkiDocelowe = listRepository.ReadJednostki(wybranyRodzaj.Id);

                comboBoxJednostkaZrodlowa.DataSource = jednostkiZrodlowe;
                comboBoxJednostkaZrodlowa.DisplayMember = "Nazwa";
                comboBoxJednostkaZrodlowa.SelectedIndex = 0;

                comboBoxJednostkaDocelowa.DataSource = jednostkiDocelowe;
                comboBoxJednostkaDocelowa.DisplayMember = "Nazwa";
                comboBoxJednostkaDocelowa.SelectedIndex = 0;

                comboBoxJednostkaDocelowa_SelectedIndexChanged(null, null);
            }
        }

        private void comboBoxJednostkaZrodlowa_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelWynik.Text = "";
        }

        private void comboBoxJednostkaDocelowa_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelWynik.Text = "";
        }

        private void buttonPrzelicz_Click(object sender, EventArgs e)
        {
            if (comboBoxJednostkaZrodlowa.SelectedItem is Jednostka
                && comboBoxJednostkaDocelowa.SelectedItem is Jednostka 
                && double.TryParse(textBoxWartosc.Text, out double wartosc))
            {
                Jednostka jednostkaZrodlowa = comboBoxJednostkaZrodlowa.SelectedItem as Jednostka;
                Jednostka jednostkaDocelowa = comboBoxJednostkaDocelowa.SelectedItem as Jednostka;

                PrzelicznikJednostek przelicznikJednostek = listRepository.ReadPrzelicznikJednostek(jednostkaZrodlowa.Id, jednostkaDocelowa.Id);

                double wynik = wartosc * przelicznikJednostek.WartoscPrzelicznika;

                labelWynik.Text = wartosc + jednostkaZrodlowa.Symbol + " = " + wynik.ToString() + jednostkaDocelowa.Symbol;
            }
        }
    }
}


namespace ProjektUczniowie
{
    partial class OknoGlowne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFiltry = new System.Windows.Forms.GroupBox();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.labelWyszukajRok = new System.Windows.Forms.Label();
            this.labelWyszukajKlasa = new System.Windows.Forms.Label();
            this.labelWyszukajNazwisko = new System.Windows.Forms.Label();
            this.labelWyszukajImie = new System.Windows.Forms.Label();
            this.numericUpDownWyszukajRok = new System.Windows.Forms.NumericUpDown();
            this.comboBoxWyszukajKlasa = new System.Windows.Forms.ComboBox();
            this.textBoxWyszukajNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxWyszukajImie = new System.Windows.Forms.TextBox();
            this.groupBoxOperacje = new System.Windows.Forms.GroupBox();
            this.buttonDodajKlase = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.groupBoxListaUczniow = new System.Windows.Forms.GroupBox();
            this.dataGridViewListaUczniow = new System.Windows.Forms.DataGridView();
            this.ColumnImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKlasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRokUrodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFiltry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWyszukajRok)).BeginInit();
            this.groupBoxOperacje.SuspendLayout();
            this.groupBoxListaUczniow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUczniow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltry
            // 
            this.groupBoxFiltry.Controls.Add(this.buttonSzukaj);
            this.groupBoxFiltry.Controls.Add(this.labelWyszukajRok);
            this.groupBoxFiltry.Controls.Add(this.labelWyszukajKlasa);
            this.groupBoxFiltry.Controls.Add(this.labelWyszukajNazwisko);
            this.groupBoxFiltry.Controls.Add(this.labelWyszukajImie);
            this.groupBoxFiltry.Controls.Add(this.numericUpDownWyszukajRok);
            this.groupBoxFiltry.Controls.Add(this.comboBoxWyszukajKlasa);
            this.groupBoxFiltry.Controls.Add(this.textBoxWyszukajNazwisko);
            this.groupBoxFiltry.Controls.Add(this.textBoxWyszukajImie);
            this.groupBoxFiltry.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFiltry.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFiltry.Name = "groupBoxFiltry";
            this.groupBoxFiltry.Size = new System.Drawing.Size(834, 97);
            this.groupBoxFiltry.TabIndex = 0;
            this.groupBoxFiltry.TabStop = false;
            this.groupBoxFiltry.Text = "Filtry";
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(623, 22);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(170, 64);
            this.buttonSzukaj.TabIndex = 8;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // labelWyszukajRok
            // 
            this.labelWyszukajRok.AutoSize = true;
            this.labelWyszukajRok.Location = new System.Drawing.Point(437, 19);
            this.labelWyszukajRok.Name = "labelWyszukajRok";
            this.labelWyszukajRok.Size = new System.Drawing.Size(30, 15);
            this.labelWyszukajRok.TabIndex = 7;
            this.labelWyszukajRok.Text = "Rok:";
            // 
            // labelWyszukajKlasa
            // 
            this.labelWyszukajKlasa.AutoSize = true;
            this.labelWyszukajKlasa.Location = new System.Drawing.Point(310, 19);
            this.labelWyszukajKlasa.Name = "labelWyszukajKlasa";
            this.labelWyszukajKlasa.Size = new System.Drawing.Size(37, 15);
            this.labelWyszukajKlasa.TabIndex = 6;
            this.labelWyszukajKlasa.Text = "Klasa:";
            // 
            // labelWyszukajNazwisko
            // 
            this.labelWyszukajNazwisko.AutoSize = true;
            this.labelWyszukajNazwisko.Location = new System.Drawing.Point(163, 19);
            this.labelWyszukajNazwisko.Name = "labelWyszukajNazwisko";
            this.labelWyszukajNazwisko.Size = new System.Drawing.Size(60, 15);
            this.labelWyszukajNazwisko.TabIndex = 5;
            this.labelWyszukajNazwisko.Text = "Nazwisko:";
            // 
            // labelWyszukajImie
            // 
            this.labelWyszukajImie.AutoSize = true;
            this.labelWyszukajImie.Location = new System.Drawing.Point(12, 19);
            this.labelWyszukajImie.Name = "labelWyszukajImie";
            this.labelWyszukajImie.Size = new System.Drawing.Size(33, 15);
            this.labelWyszukajImie.TabIndex = 4;
            this.labelWyszukajImie.Text = "Imię:";
            // 
            // numericUpDownWyszukajRok
            // 
            this.numericUpDownWyszukajRok.Location = new System.Drawing.Point(437, 39);
            this.numericUpDownWyszukajRok.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownWyszukajRok.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownWyszukajRok.Name = "numericUpDownWyszukajRok";
            this.numericUpDownWyszukajRok.Size = new System.Drawing.Size(107, 23);
            this.numericUpDownWyszukajRok.TabIndex = 3;
            this.numericUpDownWyszukajRok.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // comboBoxWyszukajKlasa
            // 
            this.comboBoxWyszukajKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWyszukajKlasa.FormattingEnabled = true;
            this.comboBoxWyszukajKlasa.Location = new System.Drawing.Point(310, 38);
            this.comboBoxWyszukajKlasa.Name = "comboBoxWyszukajKlasa";
            this.comboBoxWyszukajKlasa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWyszukajKlasa.TabIndex = 2;
            // 
            // textBoxWyszukajNazwisko
            // 
            this.textBoxWyszukajNazwisko.Location = new System.Drawing.Point(163, 38);
            this.textBoxWyszukajNazwisko.Name = "textBoxWyszukajNazwisko";
            this.textBoxWyszukajNazwisko.Size = new System.Drawing.Size(141, 23);
            this.textBoxWyszukajNazwisko.TabIndex = 1;
            // 
            // textBoxWyszukajImie
            // 
            this.textBoxWyszukajImie.Location = new System.Drawing.Point(12, 37);
            this.textBoxWyszukajImie.Name = "textBoxWyszukajImie";
            this.textBoxWyszukajImie.Size = new System.Drawing.Size(145, 23);
            this.textBoxWyszukajImie.TabIndex = 0;
            // 
            // groupBoxOperacje
            // 
            this.groupBoxOperacje.Controls.Add(this.buttonDodajKlase);
            this.groupBoxOperacje.Controls.Add(this.buttonUsun);
            this.groupBoxOperacje.Controls.Add(this.buttonEdytuj);
            this.groupBoxOperacje.Controls.Add(this.buttonDodaj);
            this.groupBoxOperacje.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOperacje.Location = new System.Drawing.Point(710, 97);
            this.groupBoxOperacje.Name = "groupBoxOperacje";
            this.groupBoxOperacje.Size = new System.Drawing.Size(124, 453);
            this.groupBoxOperacje.TabIndex = 1;
            this.groupBoxOperacje.TabStop = false;
            this.groupBoxOperacje.Text = "Operacje";
            // 
            // buttonDodajKlase
            // 
            this.buttonDodajKlase.Location = new System.Drawing.Point(8, 230);
            this.buttonDodajKlase.Name = "buttonDodajKlase";
            this.buttonDodajKlase.Size = new System.Drawing.Size(104, 59);
            this.buttonDodajKlase.TabIndex = 3;
            this.buttonDodajKlase.Text = "Dodaj klasę";
            this.buttonDodajKlase.UseVisualStyleBackColor = true;
            this.buttonDodajKlase.Click += new System.EventHandler(this.buttonDodajKlase_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(6, 126);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(106, 46);
            this.buttonUsun.TabIndex = 2;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(6, 74);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(106, 46);
            this.buttonEdytuj.TabIndex = 1;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(6, 22);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(106, 46);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // groupBoxListaUczniow
            // 
            this.groupBoxListaUczniow.Controls.Add(this.dataGridViewListaUczniow);
            this.groupBoxListaUczniow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListaUczniow.Location = new System.Drawing.Point(0, 97);
            this.groupBoxListaUczniow.Name = "groupBoxListaUczniow";
            this.groupBoxListaUczniow.Size = new System.Drawing.Size(710, 453);
            this.groupBoxListaUczniow.TabIndex = 2;
            this.groupBoxListaUczniow.TabStop = false;
            this.groupBoxListaUczniow.Text = "Lista uczniów";
            // 
            // dataGridViewListaUczniow
            // 
            this.dataGridViewListaUczniow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaUczniow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImie,
            this.ColumnNazwisko,
            this.ColumnKlasa,
            this.ColumnRokUrodzenia});
            this.dataGridViewListaUczniow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListaUczniow.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewListaUczniow.Name = "dataGridViewListaUczniow";
            this.dataGridViewListaUczniow.RowTemplate.Height = 25;
            this.dataGridViewListaUczniow.Size = new System.Drawing.Size(704, 431);
            this.dataGridViewListaUczniow.TabIndex = 0;
            // 
            // ColumnImie
            // 
            this.ColumnImie.DataPropertyName = "Imie";
            this.ColumnImie.HeaderText = "Imię";
            this.ColumnImie.Name = "ColumnImie";
            // 
            // ColumnNazwisko
            // 
            this.ColumnNazwisko.DataPropertyName = "Nazwisko";
            this.ColumnNazwisko.HeaderText = "Nazwisko";
            this.ColumnNazwisko.Name = "ColumnNazwisko";
            // 
            // ColumnKlasa
            // 
            this.ColumnKlasa.DataPropertyName = "NazwaKlasy";
            this.ColumnKlasa.HeaderText = "Klasa";
            this.ColumnKlasa.Name = "ColumnKlasa";
            // 
            // ColumnRokUrodzenia
            // 
            this.ColumnRokUrodzenia.DataPropertyName = "RokUrodzenia";
            this.ColumnRokUrodzenia.HeaderText = "Rok urodzenia";
            this.ColumnRokUrodzenia.Name = "ColumnRokUrodzenia";
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 550);
            this.Controls.Add(this.groupBoxListaUczniow);
            this.Controls.Add(this.groupBoxOperacje);
            this.Controls.Add(this.groupBoxFiltry);
            this.Name = "OknoGlowne";
            this.Text = "Form1";
            this.groupBoxFiltry.ResumeLayout(false);
            this.groupBoxFiltry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWyszukajRok)).EndInit();
            this.groupBoxOperacje.ResumeLayout(false);
            this.groupBoxListaUczniow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUczniow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltry;
        private System.Windows.Forms.GroupBox groupBoxOperacje;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.GroupBox groupBoxListaUczniow;
        private System.Windows.Forms.DataGridView dataGridViewListaUczniow;
        private System.Windows.Forms.Label labelWyszukajRok;
        private System.Windows.Forms.Label labelWyszukajKlasa;
        private System.Windows.Forms.Label labelWyszukajNazwisko;
        private System.Windows.Forms.Label labelWyszukajImie;
        private System.Windows.Forms.NumericUpDown numericUpDownWyszukajRok;
        private System.Windows.Forms.ComboBox comboBoxWyszukajKlasa;
        private System.Windows.Forms.TextBox textBoxWyszukajNazwisko;
        private System.Windows.Forms.TextBox textBoxWyszukajImie;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.Button buttonDodajKlase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKlasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRokUrodzenia;
    }
}



namespace ProjektUczniowie.Okna
{
    partial class OknoSzczegolyUczen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWyszukajRok = new System.Windows.Forms.Label();
            this.labelWyszukajKlasa = new System.Windows.Forms.Label();
            this.labelWyszukajNazwisko = new System.Windows.Forms.Label();
            this.labelWyszukajImie = new System.Windows.Forms.Label();
            this.numericUpDownWyszukajRok = new System.Windows.Forms.NumericUpDown();
            this.comboBoxWyszukajKlasa = new System.Windows.Forms.ComboBox();
            this.textBoxWyszukajNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxWyszukajImie = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWyszukajRok)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWyszukajRok
            // 
            this.labelWyszukajRok.AutoSize = true;
            this.labelWyszukajRok.Location = new System.Drawing.Point(437, 9);
            this.labelWyszukajRok.Name = "labelWyszukajRok";
            this.labelWyszukajRok.Size = new System.Drawing.Size(30, 15);
            this.labelWyszukajRok.TabIndex = 15;
            this.labelWyszukajRok.Text = "Rok:";
            // 
            // labelWyszukajKlasa
            // 
            this.labelWyszukajKlasa.AutoSize = true;
            this.labelWyszukajKlasa.Location = new System.Drawing.Point(310, 9);
            this.labelWyszukajKlasa.Name = "labelWyszukajKlasa";
            this.labelWyszukajKlasa.Size = new System.Drawing.Size(37, 15);
            this.labelWyszukajKlasa.TabIndex = 14;
            this.labelWyszukajKlasa.Text = "Klasa:";
            // 
            // labelWyszukajNazwisko
            // 
            this.labelWyszukajNazwisko.AutoSize = true;
            this.labelWyszukajNazwisko.Location = new System.Drawing.Point(163, 9);
            this.labelWyszukajNazwisko.Name = "labelWyszukajNazwisko";
            this.labelWyszukajNazwisko.Size = new System.Drawing.Size(60, 15);
            this.labelWyszukajNazwisko.TabIndex = 13;
            this.labelWyszukajNazwisko.Text = "Nazwisko:";
            // 
            // labelWyszukajImie
            // 
            this.labelWyszukajImie.AutoSize = true;
            this.labelWyszukajImie.Location = new System.Drawing.Point(12, 9);
            this.labelWyszukajImie.Name = "labelWyszukajImie";
            this.labelWyszukajImie.Size = new System.Drawing.Size(33, 15);
            this.labelWyszukajImie.TabIndex = 12;
            this.labelWyszukajImie.Text = "Imię:";
            // 
            // numericUpDownWyszukajRok
            // 
            this.numericUpDownWyszukajRok.Location = new System.Drawing.Point(437, 29);
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
            this.numericUpDownWyszukajRok.ReadOnly = true;
            this.numericUpDownWyszukajRok.Size = new System.Drawing.Size(107, 23);
            this.numericUpDownWyszukajRok.TabIndex = 11;
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
            this.comboBoxWyszukajKlasa.Location = new System.Drawing.Point(310, 28);
            this.comboBoxWyszukajKlasa.Name = "comboBoxWyszukajKlasa";
            this.comboBoxWyszukajKlasa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWyszukajKlasa.TabIndex = 10;
            // 
            // textBoxWyszukajNazwisko
            // 
            this.textBoxWyszukajNazwisko.Location = new System.Drawing.Point(163, 28);
            this.textBoxWyszukajNazwisko.Name = "textBoxWyszukajNazwisko";
            this.textBoxWyszukajNazwisko.Size = new System.Drawing.Size(141, 23);
            this.textBoxWyszukajNazwisko.TabIndex = 9;
            // 
            // textBoxWyszukajImie
            // 
            this.textBoxWyszukajImie.Location = new System.Drawing.Point(12, 27);
            this.textBoxWyszukajImie.Name = "textBoxWyszukajImie";
            this.textBoxWyszukajImie.Size = new System.Drawing.Size(145, 23);
            this.textBoxWyszukajImie.TabIndex = 8;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(87, 96);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(334, 96);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 17;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // OknoSzczegolyUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 163);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelWyszukajRok);
            this.Controls.Add(this.labelWyszukajKlasa);
            this.Controls.Add(this.labelWyszukajNazwisko);
            this.Controls.Add(this.labelWyszukajImie);
            this.Controls.Add(this.numericUpDownWyszukajRok);
            this.Controls.Add(this.comboBoxWyszukajKlasa);
            this.Controls.Add(this.textBoxWyszukajNazwisko);
            this.Controls.Add(this.textBoxWyszukajImie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OknoSzczegolyUczen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Szczegóły ucznia";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWyszukajRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWyszukajRok;
        private System.Windows.Forms.Label labelWyszukajKlasa;
        private System.Windows.Forms.Label labelWyszukajNazwisko;
        private System.Windows.Forms.Label labelWyszukajImie;
        private System.Windows.Forms.NumericUpDown numericUpDownWyszukajRok;
        private System.Windows.Forms.ComboBox comboBoxWyszukajKlasa;
        private System.Windows.Forms.TextBox textBoxWyszukajNazwisko;
        private System.Windows.Forms.TextBox textBoxWyszukajImie;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnuluj;
    }
}
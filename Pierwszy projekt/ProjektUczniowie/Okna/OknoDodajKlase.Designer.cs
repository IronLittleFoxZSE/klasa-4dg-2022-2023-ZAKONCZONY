﻿
namespace ProjektUczniowie.Okna
{
    partial class OknoDodajKlase
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.labelNazwaKlasy = new System.Windows.Forms.Label();
            this.textBoxNazwaKlasy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(61, 93);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(240, 93);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 1;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // labelNazwaKlasy
            // 
            this.labelNazwaKlasy.AutoSize = true;
            this.labelNazwaKlasy.Location = new System.Drawing.Point(21, 9);
            this.labelNazwaKlasy.Name = "labelNazwaKlasy";
            this.labelNazwaKlasy.Size = new System.Drawing.Size(74, 15);
            this.labelNazwaKlasy.TabIndex = 2;
            this.labelNazwaKlasy.Text = "Nazwa klasy:";
            // 
            // textBoxNazwaKlasy
            // 
            this.textBoxNazwaKlasy.Location = new System.Drawing.Point(21, 41);
            this.textBoxNazwaKlasy.Name = "textBoxNazwaKlasy";
            this.textBoxNazwaKlasy.Size = new System.Drawing.Size(330, 23);
            this.textBoxNazwaKlasy.TabIndex = 3;
            // 
            // OknoDodajKlase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 144);
            this.Controls.Add(this.textBoxNazwaKlasy);
            this.Controls.Add(this.labelNazwaKlasy);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OknoDodajKlase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj klasę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Label labelNazwaKlasy;
        private System.Windows.Forms.TextBox textBoxNazwaKlasy;
    }
}
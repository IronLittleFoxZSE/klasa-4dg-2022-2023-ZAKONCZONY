
namespace Przelicznik
{
    partial class Przelicznik
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
            this.groupBoxRodzaj = new System.Windows.Forms.GroupBox();
            this.comboBoxRodzaj = new System.Windows.Forms.ComboBox();
            this.groupBoxJednostkaZrodlowa = new System.Windows.Forms.GroupBox();
            this.comboBoxJednostkaZrodlowa = new System.Windows.Forms.ComboBox();
            this.groupBoxJednostkaDocelowa = new System.Windows.Forms.GroupBox();
            this.comboBoxJednostkaDocelowa = new System.Windows.Forms.ComboBox();
            this.groupBoxWartosc = new System.Windows.Forms.GroupBox();
            this.buttonPrzelicz = new System.Windows.Forms.Button();
            this.textBoxWartosc = new System.Windows.Forms.TextBox();
            this.groupBoxWynik = new System.Windows.Forms.GroupBox();
            this.labelWynik = new System.Windows.Forms.Label();
            this.groupBoxRodzaj.SuspendLayout();
            this.groupBoxJednostkaZrodlowa.SuspendLayout();
            this.groupBoxJednostkaDocelowa.SuspendLayout();
            this.groupBoxWartosc.SuspendLayout();
            this.groupBoxWynik.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRodzaj
            // 
            this.groupBoxRodzaj.Controls.Add(this.comboBoxRodzaj);
            this.groupBoxRodzaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRodzaj.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRodzaj.Name = "groupBoxRodzaj";
            this.groupBoxRodzaj.Size = new System.Drawing.Size(800, 66);
            this.groupBoxRodzaj.TabIndex = 0;
            this.groupBoxRodzaj.TabStop = false;
            this.groupBoxRodzaj.Text = "Rodzaj:";
            // 
            // comboBoxRodzaj
            // 
            this.comboBoxRodzaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRodzaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRodzaj.FormattingEnabled = true;
            this.comboBoxRodzaj.Location = new System.Drawing.Point(6, 22);
            this.comboBoxRodzaj.Name = "comboBoxRodzaj";
            this.comboBoxRodzaj.Size = new System.Drawing.Size(782, 23);
            this.comboBoxRodzaj.TabIndex = 0;
            this.comboBoxRodzaj.SelectedIndexChanged += new System.EventHandler(this.comboBoxRodzaj_SelectedIndexChanged);
            // 
            // groupBoxJednostkaZrodlowa
            // 
            this.groupBoxJednostkaZrodlowa.Controls.Add(this.comboBoxJednostkaZrodlowa);
            this.groupBoxJednostkaZrodlowa.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJednostkaZrodlowa.Location = new System.Drawing.Point(0, 66);
            this.groupBoxJednostkaZrodlowa.Name = "groupBoxJednostkaZrodlowa";
            this.groupBoxJednostkaZrodlowa.Size = new System.Drawing.Size(800, 62);
            this.groupBoxJednostkaZrodlowa.TabIndex = 1;
            this.groupBoxJednostkaZrodlowa.TabStop = false;
            this.groupBoxJednostkaZrodlowa.Text = "Jednostka źródłowa:";
            // 
            // comboBoxJednostkaZrodlowa
            // 
            this.comboBoxJednostkaZrodlowa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxJednostkaZrodlowa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJednostkaZrodlowa.FormattingEnabled = true;
            this.comboBoxJednostkaZrodlowa.Location = new System.Drawing.Point(9, 22);
            this.comboBoxJednostkaZrodlowa.Name = "comboBoxJednostkaZrodlowa";
            this.comboBoxJednostkaZrodlowa.Size = new System.Drawing.Size(782, 23);
            this.comboBoxJednostkaZrodlowa.TabIndex = 1;
            this.comboBoxJednostkaZrodlowa.SelectedIndexChanged += new System.EventHandler(this.comboBoxJednostkaZrodlowa_SelectedIndexChanged);
            // 
            // groupBoxJednostkaDocelowa
            // 
            this.groupBoxJednostkaDocelowa.Controls.Add(this.comboBoxJednostkaDocelowa);
            this.groupBoxJednostkaDocelowa.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxJednostkaDocelowa.Location = new System.Drawing.Point(0, 128);
            this.groupBoxJednostkaDocelowa.Name = "groupBoxJednostkaDocelowa";
            this.groupBoxJednostkaDocelowa.Size = new System.Drawing.Size(800, 62);
            this.groupBoxJednostkaDocelowa.TabIndex = 2;
            this.groupBoxJednostkaDocelowa.TabStop = false;
            this.groupBoxJednostkaDocelowa.Text = "Jednostka docelowa:";
            // 
            // comboBoxJednostkaDocelowa
            // 
            this.comboBoxJednostkaDocelowa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxJednostkaDocelowa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJednostkaDocelowa.FormattingEnabled = true;
            this.comboBoxJednostkaDocelowa.Location = new System.Drawing.Point(9, 22);
            this.comboBoxJednostkaDocelowa.Name = "comboBoxJednostkaDocelowa";
            this.comboBoxJednostkaDocelowa.Size = new System.Drawing.Size(782, 23);
            this.comboBoxJednostkaDocelowa.TabIndex = 1;
            this.comboBoxJednostkaDocelowa.SelectedIndexChanged += new System.EventHandler(this.comboBoxJednostkaDocelowa_SelectedIndexChanged);
            // 
            // groupBoxWartosc
            // 
            this.groupBoxWartosc.Controls.Add(this.buttonPrzelicz);
            this.groupBoxWartosc.Controls.Add(this.textBoxWartosc);
            this.groupBoxWartosc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxWartosc.Location = new System.Drawing.Point(0, 190);
            this.groupBoxWartosc.Name = "groupBoxWartosc";
            this.groupBoxWartosc.Size = new System.Drawing.Size(800, 86);
            this.groupBoxWartosc.TabIndex = 3;
            this.groupBoxWartosc.TabStop = false;
            this.groupBoxWartosc.Text = "Wartość:";
            // 
            // buttonPrzelicz
            // 
            this.buttonPrzelicz.Location = new System.Drawing.Point(405, 15);
            this.buttonPrzelicz.Name = "buttonPrzelicz";
            this.buttonPrzelicz.Size = new System.Drawing.Size(172, 58);
            this.buttonPrzelicz.TabIndex = 1;
            this.buttonPrzelicz.Text = "Przelicz";
            this.buttonPrzelicz.UseVisualStyleBackColor = true;
            this.buttonPrzelicz.Click += new System.EventHandler(this.buttonPrzelicz_Click);
            // 
            // textBoxWartosc
            // 
            this.textBoxWartosc.Location = new System.Drawing.Point(21, 34);
            this.textBoxWartosc.Name = "textBoxWartosc";
            this.textBoxWartosc.Size = new System.Drawing.Size(334, 23);
            this.textBoxWartosc.TabIndex = 0;
            // 
            // groupBoxWynik
            // 
            this.groupBoxWynik.Controls.Add(this.labelWynik);
            this.groupBoxWynik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWynik.Location = new System.Drawing.Point(0, 276);
            this.groupBoxWynik.Name = "groupBoxWynik";
            this.groupBoxWynik.Size = new System.Drawing.Size(800, 174);
            this.groupBoxWynik.TabIndex = 4;
            this.groupBoxWynik.TabStop = false;
            this.groupBoxWynik.Text = "Wynik:";
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWynik.Location = new System.Drawing.Point(177, 69);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(454, 50);
            this.labelWynik.TabIndex = 0;
            this.labelWynik.Text = "XXXXXXXXXXXXXXXXXX";
            this.labelWynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Przelicznik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxWynik);
            this.Controls.Add(this.groupBoxWartosc);
            this.Controls.Add(this.groupBoxJednostkaDocelowa);
            this.Controls.Add(this.groupBoxJednostkaZrodlowa);
            this.Controls.Add(this.groupBoxRodzaj);
            this.Name = "Przelicznik";
            this.Text = "Przelicznik";
            this.groupBoxRodzaj.ResumeLayout(false);
            this.groupBoxJednostkaZrodlowa.ResumeLayout(false);
            this.groupBoxJednostkaDocelowa.ResumeLayout(false);
            this.groupBoxWartosc.ResumeLayout(false);
            this.groupBoxWartosc.PerformLayout();
            this.groupBoxWynik.ResumeLayout(false);
            this.groupBoxWynik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRodzaj;
        private System.Windows.Forms.ComboBox comboBoxRodzaj;
        private System.Windows.Forms.GroupBox groupBoxJednostkaZrodlowa;
        private System.Windows.Forms.ComboBox comboBoxJednostkaZrodlowa;
        private System.Windows.Forms.GroupBox groupBoxJednostkaDocelowa;
        private System.Windows.Forms.ComboBox comboBoxJednostkaDocelowa;
        private System.Windows.Forms.GroupBox groupBoxWartosc;
        private System.Windows.Forms.Button buttonPrzelicz;
        private System.Windows.Forms.TextBox textBoxWartosc;
        private System.Windows.Forms.GroupBox groupBoxWynik;
        private System.Windows.Forms.Label labelWynik;
    }
}


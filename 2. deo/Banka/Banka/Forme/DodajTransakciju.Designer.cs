namespace Banka.Forme
{
    partial class DodajTransakciju
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
            this.lblTip = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPodaciPrimaoca = new System.Windows.Forms.Label();
            this.rtbPodaciPrimaoca = new System.Windows.Forms.RichTextBox();
            this.lblReferenca = new System.Windows.Forms.Label();
            this.tbReferenca = new System.Windows.Forms.TextBox();
            this.lblValuta = new System.Windows.Forms.Label();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.rtbKomentar = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblBrRacuna = new System.Windows.Forms.Label();
            this.tbBrRacuna = new System.Windows.Forms.TextBox();
            this.nudIznos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(41, 61);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(186, 23);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Tip transakcije:";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(233, 58);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(204, 31);
            this.cbTip.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(140, 98);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(87, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // lblPodaciPrimaoca
            // 
            this.lblPodaciPrimaoca.AutoSize = true;
            this.lblPodaciPrimaoca.Location = new System.Drawing.Point(41, 135);
            this.lblPodaciPrimaoca.Name = "lblPodaciPrimaoca";
            this.lblPodaciPrimaoca.Size = new System.Drawing.Size(186, 23);
            this.lblPodaciPrimaoca.TabIndex = 3;
            this.lblPodaciPrimaoca.Text = "Podaci primaoca:";
            // 
            // rtbPodaciPrimaoca
            // 
            this.rtbPodaciPrimaoca.Location = new System.Drawing.Point(233, 132);
            this.rtbPodaciPrimaoca.Name = "rtbPodaciPrimaoca";
            this.rtbPodaciPrimaoca.Size = new System.Drawing.Size(204, 96);
            this.rtbPodaciPrimaoca.TabIndex = 4;
            this.rtbPodaciPrimaoca.Text = "";
            // 
            // lblReferenca
            // 
            this.lblReferenca.AutoSize = true;
            this.lblReferenca.Location = new System.Drawing.Point(107, 237);
            this.lblReferenca.Name = "lblReferenca";
            this.lblReferenca.Size = new System.Drawing.Size(120, 23);
            this.lblReferenca.TabIndex = 5;
            this.lblReferenca.Text = "Referenca:";
            // 
            // tbReferenca
            // 
            this.tbReferenca.Location = new System.Drawing.Point(233, 234);
            this.tbReferenca.Name = "tbReferenca";
            this.tbReferenca.Size = new System.Drawing.Size(204, 31);
            this.tbReferenca.TabIndex = 6;
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(140, 274);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(87, 23);
            this.lblValuta.TabIndex = 7;
            this.lblValuta.Text = "Valuta:";
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(233, 271);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(204, 31);
            this.cbValuta.TabIndex = 8;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(151, 311);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(76, 23);
            this.lblIznos.TabIndex = 9;
            this.lblIznos.Text = "Iznos:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(162, 348);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(65, 23);
            this.lblOpis.TabIndex = 10;
            this.lblOpis.Text = "Opis:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(118, 385);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(109, 23);
            this.lblKomentar.TabIndex = 11;
            this.lblKomentar.Text = "Komentar:";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(233, 345);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(204, 31);
            this.tbOpis.TabIndex = 13;
            // 
            // rtbKomentar
            // 
            this.rtbKomentar.Location = new System.Drawing.Point(233, 382);
            this.rtbKomentar.Name = "rtbKomentar";
            this.rtbKomentar.Size = new System.Drawing.Size(204, 96);
            this.rtbKomentar.TabIndex = 14;
            this.rtbKomentar.Text = "";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(233, 484);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(204, 37);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(233, 95);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(204, 31);
            this.cbStatus.TabIndex = 16;
            // 
            // lblBrRacuna
            // 
            this.lblBrRacuna.AutoSize = true;
            this.lblBrRacuna.Location = new System.Drawing.Point(85, 24);
            this.lblBrRacuna.Name = "lblBrRacuna";
            this.lblBrRacuna.Size = new System.Drawing.Size(142, 23);
            this.lblBrRacuna.TabIndex = 17;
            this.lblBrRacuna.Text = "Broj računa:";
            // 
            // tbBrRacuna
            // 
            this.tbBrRacuna.Location = new System.Drawing.Point(233, 21);
            this.tbBrRacuna.Name = "tbBrRacuna";
            this.tbBrRacuna.Size = new System.Drawing.Size(204, 31);
            this.tbBrRacuna.TabIndex = 18;
            // 
            // nudIznos
            // 
            this.nudIznos.Location = new System.Drawing.Point(233, 308);
            this.nudIznos.Name = "nudIznos";
            this.nudIznos.Size = new System.Drawing.Size(204, 31);
            this.nudIznos.TabIndex = 19;
            // 
            // DodajTransakciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 563);
            this.Controls.Add(this.nudIznos);
            this.Controls.Add(this.tbBrRacuna);
            this.Controls.Add(this.lblBrRacuna);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.rtbKomentar);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.cbValuta);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.tbReferenca);
            this.Controls.Add(this.lblReferenca);
            this.Controls.Add(this.rtbPodaciPrimaoca);
            this.Controls.Add(this.lblPodaciPrimaoca);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.lblTip);
            this.Name = "DodajTransakciju";
            this.Text = "Dodaj Transakciju";
            this.Load += new System.EventHandler(this.DodajTransakciju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPodaciPrimaoca;
        private System.Windows.Forms.RichTextBox rtbPodaciPrimaoca;
        private System.Windows.Forms.Label lblReferenca;
        private System.Windows.Forms.TextBox tbReferenca;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.RichTextBox rtbKomentar;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblBrRacuna;
        private System.Windows.Forms.TextBox tbBrRacuna;
        private System.Windows.Forms.NumericUpDown nudIznos;
    }
}
namespace Banka.Forme
{
    partial class DodajKamatu
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
            this.rbKamataNaRacun = new System.Windows.Forms.RadioButton();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.tbBrojRacuna = new System.Windows.Forms.TextBox();
            this.rbKamataNaKredit = new System.Windows.Forms.RadioButton();
            this.lblIdKredita = new System.Windows.Forms.Label();
            this.tbKamataNaKredit = new System.Windows.Forms.TextBox();
            this.rbKamataNaDepozit = new System.Windows.Forms.RadioButton();
            this.lblIdDepozita = new System.Windows.Forms.Label();
            this.tbKamataNaDepozit = new System.Windows.Forms.TextBox();
            this.lblDatumObracuna = new System.Windows.Forms.Label();
            this.dtpDatumObracuna = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodObracuna = new System.Windows.Forms.Label();
            this.cbPeriodObracuna = new System.Windows.Forms.ComboBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nudIznos = new System.Windows.Forms.NumericUpDown();
            this.lblIznos = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbKamataNaRacun
            // 
            this.rbKamataNaRacun.AutoSize = true;
            this.rbKamataNaRacun.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbKamataNaRacun.Location = new System.Drawing.Point(56, 25);
            this.rbKamataNaRacun.Name = "rbKamataNaRacun";
            this.rbKamataNaRacun.Size = new System.Drawing.Size(168, 29);
            this.rbKamataNaRacun.TabIndex = 0;
            this.rbKamataNaRacun.TabStop = true;
            this.rbKamataNaRacun.Text = "Kamata na račun";
            this.rbKamataNaRacun.UseVisualStyleBackColor = true;
            this.rbKamataNaRacun.CheckedChanged += new System.EventHandler(this.rbKamataNaRacun_CheckedChanged);
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Location = new System.Drawing.Point(283, 27);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(104, 25);
            this.lblBrojRacuna.TabIndex = 1;
            this.lblBrojRacuna.Text = "Broj računa:";
            // 
            // tbBrojRacuna
            // 
            this.tbBrojRacuna.Location = new System.Drawing.Point(409, 24);
            this.tbBrojRacuna.Name = "tbBrojRacuna";
            this.tbBrojRacuna.Size = new System.Drawing.Size(200, 31);
            this.tbBrojRacuna.TabIndex = 2;
            // 
            // rbKamataNaKredit
            // 
            this.rbKamataNaKredit.AutoSize = true;
            this.rbKamataNaKredit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbKamataNaKredit.Location = new System.Drawing.Point(54, 65);
            this.rbKamataNaKredit.Name = "rbKamataNaKredit";
            this.rbKamataNaKredit.Size = new System.Drawing.Size(170, 29);
            this.rbKamataNaKredit.TabIndex = 3;
            this.rbKamataNaKredit.TabStop = true;
            this.rbKamataNaKredit.Text = "Kamata na kredit";
            this.rbKamataNaKredit.UseVisualStyleBackColor = true;
            this.rbKamataNaKredit.CheckedChanged += new System.EventHandler(this.rbKamataNaKredit_CheckedChanged);
            // 
            // lblIdKredita
            // 
            this.lblIdKredita.AutoSize = true;
            this.lblIdKredita.Location = new System.Drawing.Point(294, 67);
            this.lblIdKredita.Name = "lblIdKredita";
            this.lblIdKredita.Size = new System.Drawing.Size(93, 25);
            this.lblIdKredita.TabIndex = 4;
            this.lblIdKredita.Text = "ID kredita:";
            // 
            // tbKamataNaKredit
            // 
            this.tbKamataNaKredit.Location = new System.Drawing.Point(409, 64);
            this.tbKamataNaKredit.Name = "tbKamataNaKredit";
            this.tbKamataNaKredit.Size = new System.Drawing.Size(200, 31);
            this.tbKamataNaKredit.TabIndex = 5;
            // 
            // rbKamataNaDepozit
            // 
            this.rbKamataNaDepozit.AutoSize = true;
            this.rbKamataNaDepozit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbKamataNaDepozit.Location = new System.Drawing.Point(39, 105);
            this.rbKamataNaDepozit.Name = "rbKamataNaDepozit";
            this.rbKamataNaDepozit.Size = new System.Drawing.Size(185, 29);
            this.rbKamataNaDepozit.TabIndex = 6;
            this.rbKamataNaDepozit.TabStop = true;
            this.rbKamataNaDepozit.Text = "Kamata na depozit";
            this.rbKamataNaDepozit.UseVisualStyleBackColor = true;
            this.rbKamataNaDepozit.CheckedChanged += new System.EventHandler(this.rbKamataNaDepozit_CheckedChanged);
            // 
            // lblIdDepozita
            // 
            this.lblIdDepozita.AutoSize = true;
            this.lblIdDepozita.Location = new System.Drawing.Point(279, 107);
            this.lblIdDepozita.Name = "lblIdDepozita";
            this.lblIdDepozita.Size = new System.Drawing.Size(108, 25);
            this.lblIdDepozita.TabIndex = 7;
            this.lblIdDepozita.Text = "ID depozita:";
            // 
            // tbKamataNaDepozit
            // 
            this.tbKamataNaDepozit.Location = new System.Drawing.Point(409, 104);
            this.tbKamataNaDepozit.Name = "tbKamataNaDepozit";
            this.tbKamataNaDepozit.Size = new System.Drawing.Size(200, 31);
            this.tbKamataNaDepozit.TabIndex = 8;
            // 
            // lblDatumObracuna
            // 
            this.lblDatumObracuna.AutoSize = true;
            this.lblDatumObracuna.Location = new System.Drawing.Point(51, 150);
            this.lblDatumObracuna.Name = "lblDatumObracuna";
            this.lblDatumObracuna.Size = new System.Drawing.Size(149, 25);
            this.lblDatumObracuna.TabIndex = 9;
            this.lblDatumObracuna.Text = "Datum obračuna:";
            // 
            // dtpDatumObracuna
            // 
            this.dtpDatumObracuna.Location = new System.Drawing.Point(254, 144);
            this.dtpDatumObracuna.Name = "dtpDatumObracuna";
            this.dtpDatumObracuna.Size = new System.Drawing.Size(200, 31);
            this.dtpDatumObracuna.TabIndex = 10;
            // 
            // lblPeriodObracuna
            // 
            this.lblPeriodObracuna.AutoSize = true;
            this.lblPeriodObracuna.Location = new System.Drawing.Point(55, 188);
            this.lblPeriodObracuna.Name = "lblPeriodObracuna";
            this.lblPeriodObracuna.Size = new System.Drawing.Size(145, 25);
            this.lblPeriodObracuna.TabIndex = 11;
            this.lblPeriodObracuna.Text = "Period obračuna:";
            // 
            // cbPeriodObracuna
            // 
            this.cbPeriodObracuna.FormattingEnabled = true;
            this.cbPeriodObracuna.Location = new System.Drawing.Point(254, 184);
            this.cbPeriodObracuna.Name = "cbPeriodObracuna";
            this.cbPeriodObracuna.Size = new System.Drawing.Size(200, 33);
            this.cbPeriodObracuna.TabIndex = 12;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(160, 228);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(40, 25);
            this.lblTip.TabIndex = 13;
            this.lblTip.Text = "Tip:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(136, 268);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 25);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(254, 224);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(200, 33);
            this.cbTip.TabIndex = 15;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(254, 264);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 33);
            this.cbStatus.TabIndex = 16;
            // 
            // nudIznos
            // 
            this.nudIznos.Location = new System.Drawing.Point(254, 304);
            this.nudIznos.Name = "nudIznos";
            this.nudIznos.Size = new System.Drawing.Size(200, 31);
            this.nudIznos.TabIndex = 17;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(142, 307);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(58, 25);
            this.lblIznos.TabIndex = 18;
            this.lblIznos.Text = "Iznos:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(254, 344);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(200, 31);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // DodajKamatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 410);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.nudIznos);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.cbPeriodObracuna);
            this.Controls.Add(this.lblPeriodObracuna);
            this.Controls.Add(this.dtpDatumObracuna);
            this.Controls.Add(this.lblDatumObracuna);
            this.Controls.Add(this.tbKamataNaDepozit);
            this.Controls.Add(this.lblIdDepozita);
            this.Controls.Add(this.rbKamataNaDepozit);
            this.Controls.Add(this.tbKamataNaKredit);
            this.Controls.Add(this.lblIdKredita);
            this.Controls.Add(this.rbKamataNaKredit);
            this.Controls.Add(this.tbBrojRacuna);
            this.Controls.Add(this.lblBrojRacuna);
            this.Controls.Add(this.rbKamataNaRacun);
            this.Name = "DodajKamatu";
            this.Text = "DodajKamatu";
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKamataNaRacun;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.TextBox tbBrojRacuna;
        private System.Windows.Forms.RadioButton rbKamataNaKredit;
        private System.Windows.Forms.Label lblIdKredita;
        private System.Windows.Forms.TextBox tbKamataNaKredit;
        private System.Windows.Forms.RadioButton rbKamataNaDepozit;
        private System.Windows.Forms.Label lblIdDepozita;
        private System.Windows.Forms.TextBox tbKamataNaDepozit;
        private System.Windows.Forms.Label lblDatumObracuna;
        private System.Windows.Forms.DateTimePicker dtpDatumObracuna;
        private System.Windows.Forms.Label lblPeriodObracuna;
        private System.Windows.Forms.ComboBox cbPeriodObracuna;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown nudIznos;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
namespace Banka.Forme
{
    partial class DodajDepozit
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.rtbKomentar = new System.Windows.Forms.RichTextBox();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblKamatnaStopa = new System.Windows.Forms.Label();
            this.nudKamatnaStopa = new System.Windows.Forms.NumericUpDown();
            this.nudIznos = new System.Windows.Forms.NumericUpDown();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.cbStatusDepozita = new System.Windows.Forms.ComboBox();
            this.lblStatusDepozita = new System.Windows.Forms.Label();
            this.lblPeriodOrocenja = new System.Windows.Forms.Label();
            this.lblDatumIsteka = new System.Windows.Forms.Label();
            this.lblDatumPocetka = new System.Windows.Forms.Label();
            this.nudPeriodOrocenja = new System.Windows.Forms.NumericUpDown();
            this.dtpDatumIsteka = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.lblBrRacuna = new System.Windows.Forms.Label();
            this.tbBrRacuna = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKamatnaStopa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodOrocenja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(230, 445);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(200, 37);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // rtbKomentar
            // 
            this.rtbKomentar.Location = new System.Drawing.Point(230, 333);
            this.rtbKomentar.Name = "rtbKomentar";
            this.rtbKomentar.Size = new System.Drawing.Size(200, 96);
            this.rtbKomentar.TabIndex = 15;
            this.rtbKomentar.Text = "";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(115, 336);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(109, 23);
            this.lblKomentar.TabIndex = 14;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblKamatnaStopa
            // 
            this.lblKamatnaStopa.AutoSize = true;
            this.lblKamatnaStopa.Location = new System.Drawing.Point(60, 298);
            this.lblKamatnaStopa.Name = "lblKamatnaStopa";
            this.lblKamatnaStopa.Size = new System.Drawing.Size(164, 23);
            this.lblKamatnaStopa.TabIndex = 13;
            this.lblKamatnaStopa.Text = "Kamatna stopa:";
            // 
            // nudKamatnaStopa
            // 
            this.nudKamatnaStopa.DecimalPlaces = 2;
            this.nudKamatnaStopa.Location = new System.Drawing.Point(230, 296);
            this.nudKamatnaStopa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKamatnaStopa.Name = "nudKamatnaStopa";
            this.nudKamatnaStopa.Size = new System.Drawing.Size(200, 31);
            this.nudKamatnaStopa.TabIndex = 12;
            // 
            // nudIznos
            // 
            this.nudIznos.Location = new System.Drawing.Point(230, 259);
            this.nudIznos.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudIznos.Name = "nudIznos";
            this.nudIznos.Size = new System.Drawing.Size(200, 31);
            this.nudIznos.TabIndex = 11;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(148, 261);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(76, 23);
            this.lblIznos.TabIndex = 10;
            this.lblIznos.Text = "Iznos:";
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(137, 225);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(87, 23);
            this.lblValuta.TabIndex = 9;
            this.lblValuta.Text = "Valuta:";
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(230, 222);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(200, 31);
            this.cbValuta.TabIndex = 8;
            // 
            // cbStatusDepozita
            // 
            this.cbStatusDepozita.FormattingEnabled = true;
            this.cbStatusDepozita.Location = new System.Drawing.Point(230, 185);
            this.cbStatusDepozita.Name = "cbStatusDepozita";
            this.cbStatusDepozita.Size = new System.Drawing.Size(200, 31);
            this.cbStatusDepozita.TabIndex = 7;
            // 
            // lblStatusDepozita
            // 
            this.lblStatusDepozita.AutoSize = true;
            this.lblStatusDepozita.Location = new System.Drawing.Point(38, 188);
            this.lblStatusDepozita.Name = "lblStatusDepozita";
            this.lblStatusDepozita.Size = new System.Drawing.Size(186, 23);
            this.lblStatusDepozita.TabIndex = 6;
            this.lblStatusDepozita.Text = "Status depozita:";
            // 
            // lblPeriodOrocenja
            // 
            this.lblPeriodOrocenja.AutoSize = true;
            this.lblPeriodOrocenja.Location = new System.Drawing.Point(38, 150);
            this.lblPeriodOrocenja.Name = "lblPeriodOrocenja";
            this.lblPeriodOrocenja.Size = new System.Drawing.Size(186, 23);
            this.lblPeriodOrocenja.TabIndex = 5;
            this.lblPeriodOrocenja.Text = "Period oročenja:";
            // 
            // lblDatumIsteka
            // 
            this.lblDatumIsteka.AutoSize = true;
            this.lblDatumIsteka.Location = new System.Drawing.Point(71, 117);
            this.lblDatumIsteka.Name = "lblDatumIsteka";
            this.lblDatumIsteka.Size = new System.Drawing.Size(153, 23);
            this.lblDatumIsteka.TabIndex = 4;
            this.lblDatumIsteka.Text = "Datum isteka:";
            // 
            // lblDatumPocetka
            // 
            this.lblDatumPocetka.AutoSize = true;
            this.lblDatumPocetka.Location = new System.Drawing.Point(60, 80);
            this.lblDatumPocetka.Name = "lblDatumPocetka";
            this.lblDatumPocetka.Size = new System.Drawing.Size(164, 23);
            this.lblDatumPocetka.TabIndex = 3;
            this.lblDatumPocetka.Text = "Datum početka:";
            // 
            // nudPeriodOrocenja
            // 
            this.nudPeriodOrocenja.Location = new System.Drawing.Point(230, 148);
            this.nudPeriodOrocenja.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPeriodOrocenja.Name = "nudPeriodOrocenja";
            this.nudPeriodOrocenja.Size = new System.Drawing.Size(200, 31);
            this.nudPeriodOrocenja.TabIndex = 2;
            // 
            // dtpDatumIsteka
            // 
            this.dtpDatumIsteka.Location = new System.Drawing.Point(230, 111);
            this.dtpDatumIsteka.Name = "dtpDatumIsteka";
            this.dtpDatumIsteka.Size = new System.Drawing.Size(200, 31);
            this.dtpDatumIsteka.TabIndex = 1;
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Location = new System.Drawing.Point(230, 74);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(200, 31);
            this.dtpDatumPocetka.TabIndex = 0;
            // 
            // lblBrRacuna
            // 
            this.lblBrRacuna.AutoSize = true;
            this.lblBrRacuna.Location = new System.Drawing.Point(82, 37);
            this.lblBrRacuna.Name = "lblBrRacuna";
            this.lblBrRacuna.Size = new System.Drawing.Size(142, 23);
            this.lblBrRacuna.TabIndex = 17;
            this.lblBrRacuna.Text = "Broj računa:";
            // 
            // tbBrRacuna
            // 
            this.tbBrRacuna.Location = new System.Drawing.Point(230, 34);
            this.tbBrRacuna.Name = "tbBrRacuna";
            this.tbBrRacuna.Size = new System.Drawing.Size(200, 31);
            this.tbBrRacuna.TabIndex = 18;
            // 
            // DodajDepozit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 504);
            this.Controls.Add(this.tbBrRacuna);
            this.Controls.Add(this.lblBrRacuna);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.rtbKomentar);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblKamatnaStopa);
            this.Controls.Add(this.nudKamatnaStopa);
            this.Controls.Add(this.nudIznos);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.cbValuta);
            this.Controls.Add(this.cbStatusDepozita);
            this.Controls.Add(this.lblStatusDepozita);
            this.Controls.Add(this.lblPeriodOrocenja);
            this.Controls.Add(this.lblDatumIsteka);
            this.Controls.Add(this.lblDatumPocetka);
            this.Controls.Add(this.nudPeriodOrocenja);
            this.Controls.Add(this.dtpDatumIsteka);
            this.Controls.Add(this.dtpDatumPocetka);
            this.Name = "DodajDepozit";
            this.Text = "Dodaj Depozit";
            this.Load += new System.EventHandler(this.DodajDepozit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKamatnaStopa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodOrocenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.DateTimePicker dtpDatumIsteka;
        private System.Windows.Forms.NumericUpDown nudPeriodOrocenja;
        private System.Windows.Forms.Label lblDatumPocetka;
        private System.Windows.Forms.Label lblDatumIsteka;
        private System.Windows.Forms.Label lblPeriodOrocenja;
        private System.Windows.Forms.Label lblStatusDepozita;
        private System.Windows.Forms.ComboBox cbStatusDepozita;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.NumericUpDown nudIznos;
        private System.Windows.Forms.NumericUpDown nudKamatnaStopa;
        private System.Windows.Forms.Label lblKamatnaStopa;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.RichTextBox rtbKomentar;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblBrRacuna;
        private System.Windows.Forms.TextBox tbBrRacuna;
    }
}
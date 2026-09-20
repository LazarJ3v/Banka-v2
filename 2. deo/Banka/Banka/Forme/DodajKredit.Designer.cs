namespace Banka.Forme
{
    partial class DodajKredit
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
            this.lblDatumDospeca = new System.Windows.Forms.Label();
            this.lblDatumOdobrenja = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMesecnaRata = new System.Windows.Forms.Label();
            this.lblRokOtplate = new System.Windows.Forms.Label();
            this.lblNamena = new System.Windows.Forms.Label();
            this.lblKamatnaStopa = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.dtpDatumDospeca = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumOdobrenja = new System.Windows.Forms.DateTimePicker();
            this.nudIznos = new System.Windows.Forms.NumericUpDown();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nudMesecnaRata = new System.Windows.Forms.NumericUpDown();
            this.nudRokOtplate = new System.Windows.Forms.NumericUpDown();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.nudKamatnaStopa = new System.Windows.Forms.NumericUpDown();
            this.rtbKomentar = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMesecnaRata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRokOtplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKamatnaStopa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatumDospeca
            // 
            this.lblDatumDospeca.AutoSize = true;
            this.lblDatumDospeca.Location = new System.Drawing.Point(71, 31);
            this.lblDatumDospeca.Name = "lblDatumDospeca";
            this.lblDatumDospeca.Size = new System.Drawing.Size(164, 23);
            this.lblDatumDospeca.TabIndex = 0;
            this.lblDatumDospeca.Text = "Datum dospeća:";
            // 
            // lblDatumOdobrenja
            // 
            this.lblDatumOdobrenja.AutoSize = true;
            this.lblDatumOdobrenja.Location = new System.Drawing.Point(49, 71);
            this.lblDatumOdobrenja.Name = "lblDatumOdobrenja";
            this.lblDatumOdobrenja.Size = new System.Drawing.Size(186, 23);
            this.lblDatumOdobrenja.TabIndex = 1;
            this.lblDatumOdobrenja.Text = "Datum odobrenja:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(159, 107);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(76, 23);
            this.lblIznos.TabIndex = 2;
            this.lblIznos.Text = "Iznos:";
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(148, 148);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(87, 23);
            this.lblValuta.TabIndex = 3;
            this.lblValuta.Text = "Valuta:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(60, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(175, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status kredita:";
            // 
            // lblMesecnaRata
            // 
            this.lblMesecnaRata.AutoSize = true;
            this.lblMesecnaRata.Location = new System.Drawing.Point(82, 227);
            this.lblMesecnaRata.Name = "lblMesecnaRata";
            this.lblMesecnaRata.Size = new System.Drawing.Size(153, 23);
            this.lblMesecnaRata.TabIndex = 5;
            this.lblMesecnaRata.Text = "Mesečna rata:";
            // 
            // lblRokOtplate
            // 
            this.lblRokOtplate.AutoSize = true;
            this.lblRokOtplate.Location = new System.Drawing.Point(93, 267);
            this.lblRokOtplate.Name = "lblRokOtplate";
            this.lblRokOtplate.Size = new System.Drawing.Size(142, 23);
            this.lblRokOtplate.TabIndex = 6;
            this.lblRokOtplate.Text = "Rok otplate:";
            // 
            // lblNamena
            // 
            this.lblNamena.AutoSize = true;
            this.lblNamena.Location = new System.Drawing.Point(148, 308);
            this.lblNamena.Name = "lblNamena";
            this.lblNamena.Size = new System.Drawing.Size(87, 23);
            this.lblNamena.TabIndex = 7;
            this.lblNamena.Text = "Namena:";
            // 
            // lblKamatnaStopa
            // 
            this.lblKamatnaStopa.AutoSize = true;
            this.lblKamatnaStopa.Location = new System.Drawing.Point(71, 347);
            this.lblKamatnaStopa.Name = "lblKamatnaStopa";
            this.lblKamatnaStopa.Size = new System.Drawing.Size(164, 23);
            this.lblKamatnaStopa.TabIndex = 8;
            this.lblKamatnaStopa.Text = "Kamatna stopa:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(126, 388);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(109, 23);
            this.lblKomentar.TabIndex = 9;
            this.lblKomentar.Text = "Komentar:";
            // 
            // dtpDatumDospeca
            // 
            this.dtpDatumDospeca.Location = new System.Drawing.Point(241, 25);
            this.dtpDatumDospeca.Name = "dtpDatumDospeca";
            this.dtpDatumDospeca.Size = new System.Drawing.Size(200, 31);
            this.dtpDatumDospeca.TabIndex = 10;
            // 
            // dtpDatumOdobrenja
            // 
            this.dtpDatumOdobrenja.Location = new System.Drawing.Point(241, 65);
            this.dtpDatumOdobrenja.Name = "dtpDatumOdobrenja";
            this.dtpDatumOdobrenja.Size = new System.Drawing.Size(200, 31);
            this.dtpDatumOdobrenja.TabIndex = 11;
            // 
            // nudIznos
            // 
            this.nudIznos.Location = new System.Drawing.Point(241, 105);
            this.nudIznos.Name = "nudIznos";
            this.nudIznos.Size = new System.Drawing.Size(200, 31);
            this.nudIznos.TabIndex = 12;
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(241, 145);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(200, 31);
            this.cbValuta.TabIndex = 13;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(241, 185);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 31);
            this.cbStatus.TabIndex = 14;
            // 
            // nudMesecnaRata
            // 
            this.nudMesecnaRata.Location = new System.Drawing.Point(241, 225);
            this.nudMesecnaRata.Name = "nudMesecnaRata";
            this.nudMesecnaRata.Size = new System.Drawing.Size(200, 31);
            this.nudMesecnaRata.TabIndex = 15;
            // 
            // nudRokOtplate
            // 
            this.nudRokOtplate.Location = new System.Drawing.Point(241, 265);
            this.nudRokOtplate.Name = "nudRokOtplate";
            this.nudRokOtplate.Size = new System.Drawing.Size(200, 31);
            this.nudRokOtplate.TabIndex = 16;
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(241, 305);
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(200, 31);
            this.tbNapomena.TabIndex = 17;
            // 
            // nudKamatnaStopa
            // 
            this.nudKamatnaStopa.Location = new System.Drawing.Point(241, 345);
            this.nudKamatnaStopa.Name = "nudKamatnaStopa";
            this.nudKamatnaStopa.Size = new System.Drawing.Size(200, 31);
            this.nudKamatnaStopa.TabIndex = 18;
            // 
            // rtbKomentar
            // 
            this.rtbKomentar.Location = new System.Drawing.Point(241, 385);
            this.rtbKomentar.Name = "rtbKomentar";
            this.rtbKomentar.Size = new System.Drawing.Size(200, 96);
            this.rtbKomentar.TabIndex = 19;
            this.rtbKomentar.Text = "";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(241, 500);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(200, 35);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // DodajKredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 562);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.rtbKomentar);
            this.Controls.Add(this.nudKamatnaStopa);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.nudRokOtplate);
            this.Controls.Add(this.nudMesecnaRata);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbValuta);
            this.Controls.Add(this.nudIznos);
            this.Controls.Add(this.dtpDatumOdobrenja);
            this.Controls.Add(this.dtpDatumDospeca);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblKamatnaStopa);
            this.Controls.Add(this.lblNamena);
            this.Controls.Add(this.lblRokOtplate);
            this.Controls.Add(this.lblMesecnaRata);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblDatumOdobrenja);
            this.Controls.Add(this.lblDatumDospeca);
            this.Name = "DodajKredit";
            this.Text = "DodajKredit";
            this.Load += new System.EventHandler(this.DodajKredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMesecnaRata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRokOtplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKamatnaStopa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumDospeca;
        private System.Windows.Forms.Label lblDatumOdobrenja;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMesecnaRata;
        private System.Windows.Forms.Label lblRokOtplate;
        private System.Windows.Forms.Label lblNamena;
        private System.Windows.Forms.Label lblKamatnaStopa;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.DateTimePicker dtpDatumDospeca;
        private System.Windows.Forms.DateTimePicker dtpDatumOdobrenja;
        private System.Windows.Forms.NumericUpDown nudIznos;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown nudMesecnaRata;
        private System.Windows.Forms.NumericUpDown nudRokOtplate;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.NumericUpDown nudKamatnaStopa;
        private System.Windows.Forms.RichTextBox rtbKomentar;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
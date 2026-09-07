namespace Banka.Forme
{
    partial class DodajKlijenta
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
            this.gbFizickoLicePodaci = new System.Windows.Forms.GroupBox();
            this.lblKomentarFL = new System.Windows.Forms.Label();
            this.lblEmailFL = new System.Windows.Forms.Label();
            this.lblTelefonFL = new System.Windows.Forms.Label();
            this.lblGradFL = new System.Windows.Forms.Label();
            this.lblAdresaFL = new System.Windows.Forms.Label();
            this.lblDatumRodjenjaFL = new System.Windows.Forms.Label();
            this.lblBrojLicneKarteFL = new System.Windows.Forms.Label();
            this.lblJmbgFL = new System.Windows.Forms.Label();
            this.lblPrezimeFL = new System.Windows.Forms.Label();
            this.lblImeFL = new System.Windows.Forms.Label();
            this.rtbKomentarFL = new System.Windows.Forms.RichTextBox();
            this.tbEmailFL = new System.Windows.Forms.TextBox();
            this.tbTelefonFL = new System.Windows.Forms.TextBox();
            this.tbGradFL = new System.Windows.Forms.TextBox();
            this.tbAdresaFL = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenjaFL = new System.Windows.Forms.DateTimePicker();
            this.tbBrojLicneKarteFL = new System.Windows.Forms.TextBox();
            this.tbJmbgFL = new System.Windows.Forms.TextBox();
            this.tbPrezimeFL = new System.Windows.Forms.TextBox();
            this.tbImeFL = new System.Windows.Forms.TextBox();
            this.gbTipKlijenta = new System.Windows.Forms.GroupBox();
            this.rbPravnoLice = new System.Windows.Forms.RadioButton();
            this.rbFizickoLice = new System.Windows.Forms.RadioButton();
            this.gbPravnoLicePodaci = new System.Windows.Forms.GroupBox();
            this.tbNazivFirmePL = new System.Windows.Forms.TextBox();
            this.tbPibPL = new System.Windows.Forms.TextBox();
            this.tbAdresaPL = new System.Windows.Forms.TextBox();
            this.tbGradPL = new System.Windows.Forms.TextBox();
            this.tbTelefonPL = new System.Windows.Forms.TextBox();
            this.tbEmailPL = new System.Windows.Forms.TextBox();
            this.rtbKomentarPL = new System.Windows.Forms.RichTextBox();
            this.lblNazivFirmePL = new System.Windows.Forms.Label();
            this.lblPibPL = new System.Windows.Forms.Label();
            this.lblAdresaPL = new System.Windows.Forms.Label();
            this.lblGradPL = new System.Windows.Forms.Label();
            this.lblTelefonPL = new System.Windows.Forms.Label();
            this.lblEmailPL = new System.Windows.Forms.Label();
            this.lblKomentarPL = new System.Windows.Forms.Label();
            this.gbFizickoLicePodaci.SuspendLayout();
            this.gbTipKlijenta.SuspendLayout();
            this.gbPravnoLicePodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(544, 508);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(180, 31);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // gbFizickoLicePodaci
            // 
            //this.gbFizickoLicePodaci.Controls.Add(this.gbPravnoLicePodaci);
            this.gbFizickoLicePodaci.Controls.Add(this.lblKomentarFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblEmailFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblTelefonFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblGradFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblAdresaFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblDatumRodjenjaFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblBrojLicneKarteFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblJmbgFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblPrezimeFL);
            this.gbFizickoLicePodaci.Controls.Add(this.lblImeFL);
            this.gbFizickoLicePodaci.Controls.Add(this.rtbKomentarFL);
            this.gbFizickoLicePodaci.Controls.Add(this.tbEmailFL);
            this.gbFizickoLicePodaci.Controls.Add(this.tbTelefonFL);
            this.gbFizickoLicePodaci.Controls.Add(this.tbGradFL);
            this.gbFizickoLicePodaci.Controls.Add(this.tbAdresaFL);
            this.gbFizickoLicePodaci.Controls.Add(this.dtpDatumRodjenjaFL);
            this.gbFizickoLicePodaci.Controls.Add(this.tbBrojLicneKarteFL);
            this.gbFizickoLicePodaci.Controls.Add(this.tbJmbgFL);
            this.gbFizickoLicePodaci.Controls.Add(this.tbPrezimeFL);
            this.gbFizickoLicePodaci.Controls.Add(this.tbImeFL);
            this.gbFizickoLicePodaci.Location = new System.Drawing.Point(12, 129);
            this.gbFizickoLicePodaci.Name = "gbFizickoLicePodaci";
            this.gbFizickoLicePodaci.Padding = new System.Windows.Forms.Padding(10);
            this.gbFizickoLicePodaci.Size = new System.Drawing.Size(712, 371);
            this.gbFizickoLicePodaci.TabIndex = 1;
            this.gbFizickoLicePodaci.TabStop = false;
            this.gbFizickoLicePodaci.Text = "Fizičko lice podaci";
            this.Controls.Add(this.gbFizickoLicePodaci);
            // 
            // lblKomentarFL
            // 
            this.lblKomentarFL.AutoSize = true;
            this.lblKomentarFL.Location = new System.Drawing.Point(359, 228);
            this.lblKomentarFL.Name = "lblKomentarFL";
            this.lblKomentarFL.Size = new System.Drawing.Size(93, 25);
            this.lblKomentarFL.TabIndex = 19;
            this.lblKomentarFL.Text = "Komentar:";
            // 
            // lblEmailFL
            // 
            this.lblEmailFL.AutoSize = true;
            this.lblEmailFL.Location = new System.Drawing.Point(455, 181);
            this.lblEmailFL.Name = "lblEmailFL";
            this.lblEmailFL.Size = new System.Drawing.Size(58, 25);
            this.lblEmailFL.TabIndex = 18;
            this.lblEmailFL.Text = "Email:";
            // 
            // lblTelefonFL
            // 
            this.lblTelefonFL.AutoSize = true;
            this.lblTelefonFL.Location = new System.Drawing.Point(441, 134);
            this.lblTelefonFL.Name = "lblTelefonFL";
            this.lblTelefonFL.Size = new System.Drawing.Size(72, 25);
            this.lblTelefonFL.TabIndex = 17;
            this.lblTelefonFL.Text = "Telefon:";
            // 
            // lblGradFL
            // 
            this.lblGradFL.AutoSize = true;
            this.lblGradFL.Location = new System.Drawing.Point(459, 87);
            this.lblGradFL.Name = "lblGradFL";
            this.lblGradFL.Size = new System.Drawing.Size(54, 25);
            this.lblGradFL.TabIndex = 16;
            this.lblGradFL.Text = "Grad:";
            // 
            // lblAdresaFL
            // 
            this.lblAdresaFL.AutoSize = true;
            this.lblAdresaFL.Location = new System.Drawing.Point(442, 40);
            this.lblAdresaFL.Name = "lblAdresaFL";
            this.lblAdresaFL.Size = new System.Drawing.Size(71, 25);
            this.lblAdresaFL.TabIndex = 15;
            this.lblAdresaFL.Text = "Adresa:";
            // 
            // lblDatumRodjenjaFL
            // 
            this.lblDatumRodjenjaFL.AutoSize = true;
            this.lblDatumRodjenjaFL.Location = new System.Drawing.Point(15, 230);
            this.lblDatumRodjenjaFL.Name = "lblDatumRodjenjaFL";
            this.lblDatumRodjenjaFL.Size = new System.Drawing.Size(135, 25);
            this.lblDatumRodjenjaFL.TabIndex = 14;
            this.lblDatumRodjenjaFL.Text = "Datum rođenja:";
            // 
            // lblBrojLicneKarteFL
            // 
            this.lblBrojLicneKarteFL.AutoSize = true;
            this.lblBrojLicneKarteFL.Location = new System.Drawing.Point(19, 181);
            this.lblBrojLicneKarteFL.Name = "lblBrojLicneKarteFL";
            this.lblBrojLicneKarteFL.Size = new System.Drawing.Size(131, 25);
            this.lblBrojLicneKarteFL.TabIndex = 13;
            this.lblBrojLicneKarteFL.Text = "Broj lične karte:";
            // 
            // lblJmbgFL
            // 
            this.lblJmbgFL.AutoSize = true;
            this.lblJmbgFL.Location = new System.Drawing.Point(90, 134);
            this.lblJmbgFL.Name = "lblJmbgFL";
            this.lblJmbgFL.Size = new System.Drawing.Size(60, 25);
            this.lblJmbgFL.TabIndex = 12;
            this.lblJmbgFL.Text = "Jmbg:";
            // 
            // lblPrezimeFL
            // 
            this.lblPrezimeFL.AutoSize = true;
            this.lblPrezimeFL.Location = new System.Drawing.Point(72, 87);
            this.lblPrezimeFL.Name = "lblPrezimeFL";
            this.lblPrezimeFL.Size = new System.Drawing.Size(78, 25);
            this.lblPrezimeFL.TabIndex = 11;
            this.lblPrezimeFL.Text = "Prezime:";
            // 
            // lblImeFL
            // 
            this.lblImeFL.AutoSize = true;
            this.lblImeFL.Location = new System.Drawing.Point(104, 40);
            this.lblImeFL.Name = "lblImeFL";
            this.lblImeFL.Size = new System.Drawing.Size(46, 25);
            this.lblImeFL.TabIndex = 10;
            this.lblImeFL.Text = "Ime:";
            // 
            // rtbKomentarFL
            // 
            this.rtbKomentarFL.Location = new System.Drawing.Point(458, 225);
            this.rtbKomentarFL.Name = "rtbKomentarFL";
            this.rtbKomentarFL.Size = new System.Drawing.Size(241, 133);
            this.rtbKomentarFL.TabIndex = 9;
            this.rtbKomentarFL.Text = "";
            // 
            // tbEmailFL
            // 
            this.tbEmailFL.Location = new System.Drawing.Point(519, 178);
            this.tbEmailFL.Name = "tbEmailFL";
            this.tbEmailFL.Size = new System.Drawing.Size(180, 31);
            this.tbEmailFL.TabIndex = 8;
            // 
            // tbTelefonFL
            // 
            this.tbTelefonFL.Location = new System.Drawing.Point(519, 131);
            this.tbTelefonFL.Name = "tbTelefonFL";
            this.tbTelefonFL.Size = new System.Drawing.Size(180, 31);
            this.tbTelefonFL.TabIndex = 7;
            // 
            // tbGradFL
            // 
            this.tbGradFL.Location = new System.Drawing.Point(519, 84);
            this.tbGradFL.Name = "tbGradFL";
            this.tbGradFL.Size = new System.Drawing.Size(180, 31);
            this.tbGradFL.TabIndex = 6;
            // 
            // tbAdresaFL
            // 
            this.tbAdresaFL.Location = new System.Drawing.Point(519, 37);
            this.tbAdresaFL.Name = "tbAdresaFL";
            this.tbAdresaFL.Size = new System.Drawing.Size(180, 31);
            this.tbAdresaFL.TabIndex = 5;
            // 
            // dtpDatumRodjenjaFL
            // 
            this.dtpDatumRodjenjaFL.Location = new System.Drawing.Point(156, 225);
            this.dtpDatumRodjenjaFL.Name = "dtpDatumRodjenjaFL";
            this.dtpDatumRodjenjaFL.Size = new System.Drawing.Size(180, 31);
            this.dtpDatumRodjenjaFL.TabIndex = 4;
            // 
            // tbBrojLicneKarteFL
            // 
            this.tbBrojLicneKarteFL.Location = new System.Drawing.Point(156, 178);
            this.tbBrojLicneKarteFL.Name = "tbBrojLicneKarteFL";
            this.tbBrojLicneKarteFL.Size = new System.Drawing.Size(180, 31);
            this.tbBrojLicneKarteFL.TabIndex = 3;
            // 
            // tbJmbgFL
            // 
            this.tbJmbgFL.Location = new System.Drawing.Point(156, 131);
            this.tbJmbgFL.Name = "tbJmbgFL";
            this.tbJmbgFL.Size = new System.Drawing.Size(180, 31);
            this.tbJmbgFL.TabIndex = 2;
            // 
            // tbPrezimeFL
            // 
            this.tbPrezimeFL.Location = new System.Drawing.Point(156, 84);
            this.tbPrezimeFL.Name = "tbPrezimeFL";
            this.tbPrezimeFL.Size = new System.Drawing.Size(180, 31);
            this.tbPrezimeFL.TabIndex = 1;
            // 
            // tbImeFL
            // 
            this.tbImeFL.Location = new System.Drawing.Point(156, 37);
            this.tbImeFL.Name = "tbImeFL";
            this.tbImeFL.Size = new System.Drawing.Size(180, 31);
            this.tbImeFL.TabIndex = 0;
            // 
            // gbTipKlijenta
            // 
            this.gbTipKlijenta.Controls.Add(this.rbPravnoLice);
            this.gbTipKlijenta.Controls.Add(this.rbFizickoLice);
            this.gbTipKlijenta.Location = new System.Drawing.Point(12, 12);
            this.gbTipKlijenta.Name = "gbTipKlijenta";
            this.gbTipKlijenta.Padding = new System.Windows.Forms.Padding(10);
            this.gbTipKlijenta.Size = new System.Drawing.Size(712, 111);
            this.gbTipKlijenta.TabIndex = 0;
            this.gbTipKlijenta.TabStop = false;
            this.gbTipKlijenta.Text = "Tip klijenta";
            // 
            // rbPravnoLice
            // 
            this.rbPravnoLice.AutoSize = true;
            this.rbPravnoLice.Location = new System.Drawing.Point(13, 69);
            this.rbPravnoLice.Name = "rbPravnoLice";
            this.rbPravnoLice.Size = new System.Drawing.Size(122, 29);
            this.rbPravnoLice.TabIndex = 1;
            this.rbPravnoLice.TabStop = true;
            this.rbPravnoLice.Text = "Pravno lice";
            this.rbPravnoLice.UseVisualStyleBackColor = true;
            // 
            // rbFizickoLice
            // 
            this.rbFizickoLice.AutoSize = true;
            this.rbFizickoLice.Location = new System.Drawing.Point(13, 34);
            this.rbFizickoLice.Name = "rbFizickoLice";
            this.rbFizickoLice.Size = new System.Drawing.Size(120, 29);
            this.rbFizickoLice.TabIndex = 0;
            this.rbFizickoLice.TabStop = true;
            this.rbFizickoLice.Text = "Fizičko lice";
            this.rbFizickoLice.UseVisualStyleBackColor = true;
            this.rbFizickoLice.CheckedChanged += new System.EventHandler(this.rbFizickoLice_CheckedChanged);
            // 
            // gbPravnoLicePodaci
            // 
            this.gbPravnoLicePodaci.Controls.Add(this.lblKomentarPL);
            this.gbPravnoLicePodaci.Controls.Add(this.lblEmailPL);
            this.gbPravnoLicePodaci.Controls.Add(this.lblTelefonPL);
            this.gbPravnoLicePodaci.Controls.Add(this.lblGradPL);
            this.gbPravnoLicePodaci.Controls.Add(this.lblAdresaPL);
            this.gbPravnoLicePodaci.Controls.Add(this.lblPibPL);
            this.gbPravnoLicePodaci.Controls.Add(this.lblNazivFirmePL);
            this.gbPravnoLicePodaci.Controls.Add(this.rtbKomentarPL);
            this.gbPravnoLicePodaci.Controls.Add(this.tbEmailPL);
            this.gbPravnoLicePodaci.Controls.Add(this.tbTelefonPL);
            this.gbPravnoLicePodaci.Controls.Add(this.tbGradPL);
            this.gbPravnoLicePodaci.Controls.Add(this.tbAdresaPL);
            this.gbPravnoLicePodaci.Controls.Add(this.tbPibPL);
            this.gbPravnoLicePodaci.Controls.Add(this.tbNazivFirmePL);
            this.gbPravnoLicePodaci.Location = new System.Drawing.Point(12, 129);
            this.gbPravnoLicePodaci.Name = "gbPravnoLicePodaci";
            this.gbPravnoLicePodaci.Size = new System.Drawing.Size(712, 371);
            this.gbPravnoLicePodaci.TabIndex = 3;
            this.gbPravnoLicePodaci.TabStop = false;
            this.gbPravnoLicePodaci.Text = "Pravno lice podaci";
            this.Controls.Add(this.gbPravnoLicePodaci);
            // 
            // tbNazivFirmePL
            // 
            this.tbNazivFirmePL.Location = new System.Drawing.Point(156, 37);
            this.tbNazivFirmePL.Name = "tbNazivFirmePL";
            this.tbNazivFirmePL.Size = new System.Drawing.Size(180, 31);
            this.tbNazivFirmePL.TabIndex = 0;
            // 
            // tbPibPL
            // 
            this.tbPibPL.Location = new System.Drawing.Point(156, 84);
            this.tbPibPL.Name = "tbPibPL";
            this.tbPibPL.Size = new System.Drawing.Size(180, 31);
            this.tbPibPL.TabIndex = 1;
            // 
            // tbAdresaPL
            // 
            this.tbAdresaPL.Location = new System.Drawing.Point(156, 131);
            this.tbAdresaPL.Name = "tbAdresaPL";
            this.tbAdresaPL.Size = new System.Drawing.Size(180, 31);
            this.tbAdresaPL.TabIndex = 2;
            // 
            // tbGradPL
            // 
            this.tbGradPL.Location = new System.Drawing.Point(156, 179);
            this.tbGradPL.Name = "tbGradPL";
            this.tbGradPL.Size = new System.Drawing.Size(180, 31);
            this.tbGradPL.TabIndex = 3;
            // 
            // tbTelefonPL
            // 
            this.tbTelefonPL.Location = new System.Drawing.Point(519, 37);
            this.tbTelefonPL.Name = "tbTelefonPL";
            this.tbTelefonPL.Size = new System.Drawing.Size(180, 31);
            this.tbTelefonPL.TabIndex = 4;
            // 
            // tbEmailPL
            // 
            this.tbEmailPL.Location = new System.Drawing.Point(520, 85);
            this.tbEmailPL.Name = "tbEmailPL";
            this.tbEmailPL.Size = new System.Drawing.Size(179, 31);
            this.tbEmailPL.TabIndex = 5;
            // 
            // rtbKomentarPL
            // 
            this.rtbKomentarPL.Location = new System.Drawing.Point(458, 132);
            this.rtbKomentarPL.Name = "rtbKomentarPL";
            this.rtbKomentarPL.Size = new System.Drawing.Size(241, 133);
            this.rtbKomentarPL.TabIndex = 6;
            this.rtbKomentarPL.Text = "";
            // 
            // lblNazivFirmePL
            // 
            this.lblNazivFirmePL.AutoSize = true;
            this.lblNazivFirmePL.Location = new System.Drawing.Point(45, 40);
            this.lblNazivFirmePL.Name = "lblNazivFirmePL";
            this.lblNazivFirmePL.Size = new System.Drawing.Size(105, 25);
            this.lblNazivFirmePL.TabIndex = 7;
            this.lblNazivFirmePL.Text = "Naziv firme:";
            // 
            // lblPibPL
            // 
            this.lblPibPL.AutoSize = true;
            this.lblPibPL.Location = new System.Drawing.Point(109, 87);
            this.lblPibPL.Name = "lblPibPL";
            this.lblPibPL.Size = new System.Drawing.Size(41, 25);
            this.lblPibPL.TabIndex = 8;
            this.lblPibPL.Text = "Pib:";
            // 
            // lblAdresaPL
            // 
            this.lblAdresaPL.AutoSize = true;
            this.lblAdresaPL.Location = new System.Drawing.Point(79, 134);
            this.lblAdresaPL.Name = "lblAdresaPL";
            this.lblAdresaPL.Size = new System.Drawing.Size(71, 25);
            this.lblAdresaPL.TabIndex = 9;
            this.lblAdresaPL.Text = "Adresa:";
            // 
            // lblGradPL
            // 
            this.lblGradPL.AutoSize = true;
            this.lblGradPL.Location = new System.Drawing.Point(96, 182);
            this.lblGradPL.Name = "lblGradPL";
            this.lblGradPL.Size = new System.Drawing.Size(54, 25);
            this.lblGradPL.TabIndex = 10;
            this.lblGradPL.Text = "Grad:";
            // 
            // lblTelefonPL
            // 
            this.lblTelefonPL.AutoSize = true;
            this.lblTelefonPL.Location = new System.Drawing.Point(441, 40);
            this.lblTelefonPL.Name = "lblTelefonPL";
            this.lblTelefonPL.Size = new System.Drawing.Size(72, 25);
            this.lblTelefonPL.TabIndex = 11;
            this.lblTelefonPL.Text = "Telefon:";
            // 
            // lblEmailPL
            // 
            this.lblEmailPL.AutoSize = true;
            this.lblEmailPL.Location = new System.Drawing.Point(459, 88);
            this.lblEmailPL.Name = "lblEmailPL";
            this.lblEmailPL.Size = new System.Drawing.Size(58, 25);
            this.lblEmailPL.TabIndex = 12;
            this.lblEmailPL.Text = "Email:";
            // 
            // lblKomentarPL
            // 
            this.lblKomentarPL.AutoSize = true;
            this.lblKomentarPL.Location = new System.Drawing.Point(359, 135);
            this.lblKomentarPL.Name = "lblKomentarPL";
            this.lblKomentarPL.Size = new System.Drawing.Size(93, 25);
            this.lblKomentarPL.TabIndex = 13;
            this.lblKomentarPL.Text = "Komentar:";
            // 
            // DodajKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 571);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.gbFizickoLicePodaci);
            this.Controls.Add(this.gbTipKlijenta);
            this.Name = "DodajKlijenta";
            this.Text = "DodajKlijenta";
            this.gbFizickoLicePodaci.ResumeLayout(false);
            this.gbFizickoLicePodaci.PerformLayout();
            this.gbTipKlijenta.ResumeLayout(false);
            this.gbTipKlijenta.PerformLayout();
            this.gbPravnoLicePodaci.ResumeLayout(false);
            this.gbPravnoLicePodaci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipKlijenta;
        private System.Windows.Forms.RadioButton rbPravnoLice;
        private System.Windows.Forms.RadioButton rbFizickoLice;
        private System.Windows.Forms.GroupBox gbFizickoLicePodaci;
        private System.Windows.Forms.TextBox tbPrezimeFL;
        private System.Windows.Forms.TextBox tbImeFL;
        private System.Windows.Forms.TextBox tbJmbgFL;
        private System.Windows.Forms.TextBox tbBrojLicneKarteFL;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenjaFL;
        private System.Windows.Forms.TextBox tbTelefonFL;
        private System.Windows.Forms.TextBox tbGradFL;
        private System.Windows.Forms.TextBox tbAdresaFL;
        private System.Windows.Forms.Label lblAdresaFL;
        private System.Windows.Forms.Label lblDatumRodjenjaFL;
        private System.Windows.Forms.Label lblBrojLicneKarteFL;
        private System.Windows.Forms.Label lblJmbgFL;
        private System.Windows.Forms.Label lblPrezimeFL;
        private System.Windows.Forms.Label lblImeFL;
        private System.Windows.Forms.RichTextBox rtbKomentarFL;
        private System.Windows.Forms.TextBox tbEmailFL;
        private System.Windows.Forms.Label lblKomentarFL;
        private System.Windows.Forms.Label lblEmailFL;
        private System.Windows.Forms.Label lblTelefonFL;
        private System.Windows.Forms.Label lblGradFL;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox gbPravnoLicePodaci;
        private System.Windows.Forms.TextBox tbPibPL;
        private System.Windows.Forms.TextBox tbNazivFirmePL;
        private System.Windows.Forms.TextBox tbGradPL;
        private System.Windows.Forms.TextBox tbAdresaPL;
        private System.Windows.Forms.TextBox tbTelefonPL;
        private System.Windows.Forms.RichTextBox rtbKomentarPL;
        private System.Windows.Forms.TextBox tbEmailPL;
        private System.Windows.Forms.Label lblKomentarPL;
        private System.Windows.Forms.Label lblEmailPL;
        private System.Windows.Forms.Label lblTelefonPL;
        private System.Windows.Forms.Label lblGradPL;
        private System.Windows.Forms.Label lblAdresaPL;
        private System.Windows.Forms.Label lblPibPL;
        private System.Windows.Forms.Label lblNazivFirmePL;
    }
}
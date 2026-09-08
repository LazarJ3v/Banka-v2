namespace Banka.Forme
{
    partial class KlijentiPregled
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
            this.gbFizickaLica = new System.Windows.Forms.GroupBox();
            this.dgvFizickaLica = new System.Windows.Forms.DataGridView();
            this.gbPravnaLica = new System.Windows.Forms.GroupBox();
            this.dgvPravnaLica = new System.Windows.Forms.DataGridView();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.cbTipKlijenta = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblStatusKlijenta = new System.Windows.Forms.Label();
            this.lblTipKlijenta = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbStatusKlijenta = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblBrojKlijenata = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.gbFizickaLica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFizickaLica)).BeginInit();
            this.gbPravnaLica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPravnaLica)).BeginInit();
            this.gbPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFizickaLica
            // 
            this.gbFizickaLica.Controls.Add(this.dgvFizickaLica);
            this.gbFizickaLica.Location = new System.Drawing.Point(13, 11);
            this.gbFizickaLica.Name = "gbFizickaLica";
            this.gbFizickaLica.Size = new System.Drawing.Size(813, 230);
            this.gbFizickaLica.TabIndex = 0;
            this.gbFizickaLica.TabStop = false;
            this.gbFizickaLica.Text = "Fizička lica";
            // 
            // dgvFizickaLica
            // 
            this.dgvFizickaLica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFizickaLica.Location = new System.Drawing.Point(7, 28);
            this.dgvFizickaLica.Name = "dgvFizickaLica";
            this.dgvFizickaLica.RowHeadersWidth = 62;
            this.dgvFizickaLica.RowTemplate.Height = 28;
            this.dgvFizickaLica.Size = new System.Drawing.Size(800, 197);
            this.dgvFizickaLica.TabIndex = 0;
            // 
            // gbPravnaLica
            // 
            this.gbPravnaLica.Controls.Add(this.dgvPravnaLica);
            this.gbPravnaLica.Location = new System.Drawing.Point(13, 247);
            this.gbPravnaLica.Name = "gbPravnaLica";
            this.gbPravnaLica.Size = new System.Drawing.Size(813, 230);
            this.gbPravnaLica.TabIndex = 1;
            this.gbPravnaLica.TabStop = false;
            this.gbPravnaLica.Text = "Pravna lica";
            // 
            // dgvPravnaLica
            // 
            this.dgvPravnaLica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPravnaLica.Location = new System.Drawing.Point(7, 28);
            this.dgvPravnaLica.Name = "dgvPravnaLica";
            this.dgvPravnaLica.RowHeadersWidth = 62;
            this.dgvPravnaLica.RowTemplate.Height = 28;
            this.dgvPravnaLica.Size = new System.Drawing.Size(800, 197);
            this.dgvPravnaLica.TabIndex = 0;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.cbTipKlijenta);
            this.gbPretraga.Controls.Add(this.btnPretrazi);
            this.gbPretraga.Controls.Add(this.lblStatusKlijenta);
            this.gbPretraga.Controls.Add(this.lblTipKlijenta);
            this.gbPretraga.Controls.Add(this.lblEmail);
            this.gbPretraga.Controls.Add(this.cbStatusKlijenta);
            this.gbPretraga.Controls.Add(this.tbEmail);
            this.gbPretraga.Location = new System.Drawing.Point(833, 11);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.gbPretraga.Size = new System.Drawing.Size(304, 230);
            this.gbPretraga.TabIndex = 2;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraga";
            // 
            // cbTipKlijenta
            // 
            this.cbTipKlijenta.FormattingEnabled = true;
            this.cbTipKlijenta.Location = new System.Drawing.Point(91, 77);
            this.cbTipKlijenta.Name = "cbTipKlijenta";
            this.cbTipKlijenta.Size = new System.Drawing.Size(198, 31);
            this.cbTipKlijenta.TabIndex = 7;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(14, 172);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(275, 37);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // lblStatusKlijenta
            // 
            this.lblStatusKlijenta.AutoSize = true;
            this.lblStatusKlijenta.Location = new System.Drawing.Point(14, 125);
            this.lblStatusKlijenta.Name = "lblStatusKlijenta";
            this.lblStatusKlijenta.Size = new System.Drawing.Size(87, 23);
            this.lblStatusKlijenta.TabIndex = 5;
            this.lblStatusKlijenta.Text = "Status:";
            // 
            // lblTipKlijenta
            // 
            this.lblTipKlijenta.AutoSize = true;
            this.lblTipKlijenta.Location = new System.Drawing.Point(41, 80);
            this.lblTipKlijenta.Name = "lblTipKlijenta";
            this.lblTipKlijenta.Size = new System.Drawing.Size(54, 23);
            this.lblTipKlijenta.TabIndex = 4;
            this.lblTipKlijenta.Text = "Tip:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 37);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // cbStatusKlijenta
            // 
            this.cbStatusKlijenta.FormattingEnabled = true;
            this.cbStatusKlijenta.Location = new System.Drawing.Point(91, 122);
            this.cbStatusKlijenta.Name = "cbStatusKlijenta";
            this.cbStatusKlijenta.Size = new System.Drawing.Size(198, 31);
            this.cbStatusKlijenta.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(91, 34);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(198, 31);
            this.tbEmail.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(839, 274);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(290, 37);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(839, 328);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(290, 37);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(839, 382);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(290, 37);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // lblBrojKlijenata
            // 
            this.lblBrojKlijenata.AutoSize = true;
            this.lblBrojKlijenata.Location = new System.Drawing.Point(13, 486);
            this.lblBrojKlijenata.Name = "lblBrojKlijenata";
            this.lblBrojKlijenata.Size = new System.Drawing.Size(175, 23);
            this.lblBrojKlijenata.TabIndex = 6;
            this.lblBrojKlijenata.Text = "Broj klijenata:";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(147, 486);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(54, 23);
            this.lblBroj.TabIndex = 7;
            this.lblBroj.Text = "Broj";
            // 
            // KlijentiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 517);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.lblBrojKlijenata);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbPravnaLica);
            this.Controls.Add(this.gbFizickaLica);
            this.Name = "KlijentiPregled";
            this.Text = "KlijentiPregled";
            this.Load += new System.EventHandler(this.KlijentiPregled_Load);
            this.gbFizickaLica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFizickaLica)).EndInit();
            this.gbPravnaLica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPravnaLica)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFizickaLica;
        private System.Windows.Forms.DataGridView dgvFizickaLica;
        private System.Windows.Forms.GroupBox gbPravnaLica;
        private System.Windows.Forms.DataGridView dgvPravnaLica;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.ComboBox cbStatusKlijenta;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTipKlijenta;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lblStatusKlijenta;
        private System.Windows.Forms.ComboBox cbTipKlijenta;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblBrojKlijenata;
        private System.Windows.Forms.Label lblBroj;
    }
}
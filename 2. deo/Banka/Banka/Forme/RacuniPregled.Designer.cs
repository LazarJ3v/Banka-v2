namespace Banka.Forme
{
    partial class RacuniPregled
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
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.gbRacuni = new System.Windows.Forms.GroupBox();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.tbBrojRacuna = new System.Windows.Forms.TextBox();
            this.lblTipRacuna = new System.Windows.Forms.Label();
            this.cbTipRacuna = new System.Windows.Forms.ComboBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.gbRacuni.SuspendLayout();
            this.gbPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(7, 28);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowHeadersWidth = 62;
            this.dgvRacuni.RowTemplate.Height = 28;
            this.dgvRacuni.Size = new System.Drawing.Size(1114, 540);
            this.dgvRacuni.TabIndex = 0;
            // 
            // gbRacuni
            // 
            this.gbRacuni.Controls.Add(this.dgvRacuni);
            this.gbRacuni.Location = new System.Drawing.Point(25, 21);
            this.gbRacuni.Name = "gbRacuni";
            this.gbRacuni.Size = new System.Drawing.Size(1127, 574);
            this.gbRacuni.TabIndex = 1;
            this.gbRacuni.TabStop = false;
            this.gbRacuni.Text = "Računi";
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.btnPretrazi);
            this.gbPretraga.Controls.Add(this.lblBrojRacuna);
            this.gbPretraga.Controls.Add(this.tbBrojRacuna);
            this.gbPretraga.Controls.Add(this.lblTipRacuna);
            this.gbPretraga.Controls.Add(this.cbTipRacuna);
            this.gbPretraga.Location = new System.Drawing.Point(1159, 21);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(364, 231);
            this.gbPretraga.TabIndex = 2;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraga";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(6, 181);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(352, 29);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Location = new System.Drawing.Point(7, 66);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(142, 23);
            this.lblBrojRacuna.TabIndex = 3;
            this.lblBrojRacuna.Text = "Broj računa:";
            // 
            // tbBrojRacuna
            // 
            this.tbBrojRacuna.Location = new System.Drawing.Point(151, 63);
            this.tbBrojRacuna.Name = "tbBrojRacuna";
            this.tbBrojRacuna.Size = new System.Drawing.Size(198, 31);
            this.tbBrojRacuna.TabIndex = 2;
            // 
            // lblTipRacuna
            // 
            this.lblTipRacuna.AutoSize = true;
            this.lblTipRacuna.Location = new System.Drawing.Point(14, 30);
            this.lblTipRacuna.Name = "lblTipRacuna";
            this.lblTipRacuna.Size = new System.Drawing.Size(131, 23);
            this.lblTipRacuna.TabIndex = 1;
            this.lblTipRacuna.Text = "Tip računa:";
            // 
            // cbTipRacuna
            // 
            this.cbTipRacuna.FormattingEnabled = true;
            this.cbTipRacuna.Location = new System.Drawing.Point(151, 26);
            this.cbTipRacuna.Name = "cbTipRacuna";
            this.cbTipRacuna.Size = new System.Drawing.Size(198, 31);
            this.cbTipRacuna.TabIndex = 0;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(1164, 265);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(352, 29);
            this.btnDetalji.TabIndex = 3;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1164, 325);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(352, 29);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(1164, 385);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(352, 29);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(1164, 445);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(352, 29);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // RacuniPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1548, 664);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbRacuni);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "RacuniPregled";
            this.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RacuniPregled";
            this.Load += new System.EventHandler(this.RacuniPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.gbRacuni.ResumeLayout(false);
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.GroupBox gbRacuni;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.TextBox tbBrojRacuna;
        private System.Windows.Forms.Label lblTipRacuna;
        private System.Windows.Forms.ComboBox cbTipRacuna;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}
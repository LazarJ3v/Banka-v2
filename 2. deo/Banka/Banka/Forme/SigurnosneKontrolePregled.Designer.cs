namespace Banka.Forme
{
    partial class SigurnosneKontrolePregled
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.gbSigurnosneKontrole = new System.Windows.Forms.GroupBox();
            this.dgvSigurnosneKontrole = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.gbSigurnosneKontrole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSigurnosneKontrole)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(774, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(233, 37);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // gbSigurnosneKontrole
            // 
            this.gbSigurnosneKontrole.Controls.Add(this.dgvSigurnosneKontrole);
            this.gbSigurnosneKontrole.Location = new System.Drawing.Point(12, 12);
            this.gbSigurnosneKontrole.Name = "gbSigurnosneKontrole";
            this.gbSigurnosneKontrole.Size = new System.Drawing.Size(756, 451);
            this.gbSigurnosneKontrole.TabIndex = 1;
            this.gbSigurnosneKontrole.TabStop = false;
            this.gbSigurnosneKontrole.Text = "Sigurnosne kontrole";
            // 
            // dgvSigurnosneKontrole
            // 
            this.dgvSigurnosneKontrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSigurnosneKontrole.Location = new System.Drawing.Point(6, 30);
            this.dgvSigurnosneKontrole.Name = "dgvSigurnosneKontrole";
            this.dgvSigurnosneKontrole.RowHeadersWidth = 62;
            this.dgvSigurnosneKontrole.RowTemplate.Height = 28;
            this.dgvSigurnosneKontrole.Size = new System.Drawing.Size(744, 415);
            this.dgvSigurnosneKontrole.TabIndex = 0;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(774, 72);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(233, 37);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(774, 132);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(233, 37);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // SigurnosneKontrolePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 475);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.gbSigurnosneKontrole);
            this.Controls.Add(this.btnDodaj);
            this.Name = "SigurnosneKontrolePregled";
            this.Text = "SigurnosneKontrolePregled";
            this.Load += new System.EventHandler(this.SigurnosneKontrolePregled_Load);
            this.gbSigurnosneKontrole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSigurnosneKontrole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox gbSigurnosneKontrole;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvSigurnosneKontrole;
    }
}
namespace Banka.Forme
{
    partial class KreditiPregled
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
            this.gbKredit = new System.Windows.Forms.GroupBox();
            this.dgvKrediti = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.gbKredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKrediti)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKredit
            // 
            this.gbKredit.Controls.Add(this.dgvKrediti);
            this.gbKredit.Location = new System.Drawing.Point(12, 12);
            this.gbKredit.Name = "gbKredit";
            this.gbKredit.Size = new System.Drawing.Size(756, 451);
            this.gbKredit.TabIndex = 1;
            this.gbKredit.TabStop = false;
            this.gbKredit.Text = "Krediti";
            // 
            // dgvKrediti
            // 
            this.dgvKrediti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKrediti.Location = new System.Drawing.Point(6, 25);
            this.dgvKrediti.Name = "dgvKrediti";
            this.dgvKrediti.RowHeadersWidth = 62;
            this.dgvKrediti.RowTemplate.Height = 28;
            this.dgvKrediti.Size = new System.Drawing.Size(744, 420);
            this.dgvKrediti.TabIndex = 0;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(774, 132);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(233, 37);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(774, 72);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(233, 37);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(774, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(233, 37);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // KreditiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 475);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.gbKredit);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Name = "KreditiPregled";
            this.Text = "Krediti Pregled";
            this.Load += new System.EventHandler(this.KreditiPregled_Load);
            this.gbKredit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKrediti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKredit;
        private System.Windows.Forms.DataGridView dgvKrediti;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
    }
}
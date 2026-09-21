namespace Banka.Forme
{
    partial class DepozitiPregled
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
            this.gbDepozit = new System.Windows.Forms.GroupBox();
            this.dgvDepoziti = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.gbDepozit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoziti)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDepozit
            // 
            this.gbDepozit.Controls.Add(this.dgvDepoziti);
            this.gbDepozit.Location = new System.Drawing.Point(12, 12);
            this.gbDepozit.Name = "gbDepozit";
            this.gbDepozit.Size = new System.Drawing.Size(756, 451);
            this.gbDepozit.TabIndex = 0;
            this.gbDepozit.TabStop = false;
            this.gbDepozit.Text = "Depoziti";
            // 
            // dgvDepoziti
            // 
            this.dgvDepoziti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepoziti.Location = new System.Drawing.Point(6, 25);
            this.dgvDepoziti.Name = "dgvDepoziti";
            this.dgvDepoziti.RowHeadersWidth = 62;
            this.dgvDepoziti.RowTemplate.Height = 28;
            this.dgvDepoziti.Size = new System.Drawing.Size(744, 420);
            this.dgvDepoziti.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(774, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(233, 37);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(774, 72);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(233, 37);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(774, 132);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(233, 37);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // DepozitiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 475);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.gbDepozit);
            this.Name = "DepozitiPregled";
            this.Text = "Depoziti Pregled";
            this.Load += new System.EventHandler(this.DepozitiPregled_Load);
            this.gbDepozit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoziti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepozit;
        private System.Windows.Forms.DataGridView dgvDepoziti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}
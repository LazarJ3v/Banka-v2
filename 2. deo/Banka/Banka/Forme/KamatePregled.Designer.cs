namespace Banka.Forme
{
    partial class KamatePregled
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
            this.gbKamate = new System.Windows.Forms.GroupBox();
            this.dgvKamate = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.gbKamate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKamate
            // 
            this.gbKamate.Controls.Add(this.dgvKamate);
            this.gbKamate.Location = new System.Drawing.Point(12, 12);
            this.gbKamate.Name = "gbKamate";
            this.gbKamate.Size = new System.Drawing.Size(756, 451);
            this.gbKamate.TabIndex = 0;
            this.gbKamate.TabStop = false;
            this.gbKamate.Text = "Kamate";
            // 
            // dgvKamate
            // 
            this.dgvKamate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKamate.Location = new System.Drawing.Point(6, 30);
            this.dgvKamate.Name = "dgvKamate";
            this.dgvKamate.RowHeadersWidth = 62;
            this.dgvKamate.RowTemplate.Height = 28;
            this.dgvKamate.Size = new System.Drawing.Size(744, 415);
            this.dgvKamate.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(774, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(233, 37);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
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
            // KamatePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 475);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.gbKamate);
            this.Name = "KamatePregled";
            this.Text = "KamatePregled";
            this.gbKamate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKamate;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvKamate;
    }
}
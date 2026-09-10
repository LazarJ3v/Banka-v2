namespace Banka
{
    partial class Form1
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
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnTekuci = new System.Windows.Forms.Button();
            this.btnZiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(13, 13);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 30);
            this.btnUcitaj.TabIndex = 0;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(94, 13);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 30);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(175, 13);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 30);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(256, 13);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 30);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnTekuci
            // 
            this.btnTekuci.Location = new System.Drawing.Point(337, 13);
            this.btnTekuci.Name = "btnTekuci";
            this.btnTekuci.Size = new System.Drawing.Size(75, 30);
            this.btnTekuci.TabIndex = 4;
            this.btnTekuci.Text = "Tekuci";
            this.btnTekuci.UseVisualStyleBackColor = true;
            this.btnTekuci.Click += new System.EventHandler(this.btnTekuci_Click);
            // 
            // btnZiro
            // 
            this.btnZiro.Location = new System.Drawing.Point(418, 13);
            this.btnZiro.Name = "btnZiro";
            this.btnZiro.Size = new System.Drawing.Size(75, 30);
            this.btnZiro.TabIndex = 5;
            this.btnZiro.Text = "Ziro";
            this.btnZiro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZiro);
            this.Controls.Add(this.btnTekuci);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnUcitaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnTekuci;
        private System.Windows.Forms.Button btnZiro;
    }
}


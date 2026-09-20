namespace Banka
{
    partial class PocetnaStrana
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
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnRacuni = new System.Windows.Forms.Button();
            this.btnTransakcije = new System.Windows.Forms.Button();
            this.btnDepoziti = new System.Windows.Forms.Button();
            this.btnKrediti = new System.Windows.Forms.Button();
            this.btnKamate = new System.Windows.Forms.Button();
            this.btnSigurnosneKontrole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.Location = new System.Drawing.Point(13, 348);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(220, 37);
            this.btnKlijenti.TabIndex = 0;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = true;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnRacuni
            // 
            this.btnRacuni.Location = new System.Drawing.Point(239, 348);
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Size = new System.Drawing.Size(221, 37);
            this.btnRacuni.TabIndex = 1;
            this.btnRacuni.Text = "Računi";
            this.btnRacuni.UseVisualStyleBackColor = true;
            this.btnRacuni.Click += new System.EventHandler(this.btnRacuni_Click);
            // 
            // btnTransakcije
            // 
            this.btnTransakcije.Location = new System.Drawing.Point(466, 348);
            this.btnTransakcije.Name = "btnTransakcije";
            this.btnTransakcije.Size = new System.Drawing.Size(221, 37);
            this.btnTransakcije.TabIndex = 2;
            this.btnTransakcije.Text = "Transakcije";
            this.btnTransakcije.UseVisualStyleBackColor = true;
            this.btnTransakcije.Click += new System.EventHandler(this.btnTransakcije_Click);
            // 
            // btnDepoziti
            // 
            this.btnDepoziti.Location = new System.Drawing.Point(13, 305);
            this.btnDepoziti.Name = "btnDepoziti";
            this.btnDepoziti.Size = new System.Drawing.Size(220, 37);
            this.btnDepoziti.TabIndex = 3;
            this.btnDepoziti.Text = "Depoziti";
            this.btnDepoziti.UseVisualStyleBackColor = true;
            this.btnDepoziti.Click += new System.EventHandler(this.btnDepoziti_Click);
            // 
            // btnKrediti
            // 
            this.btnKrediti.Location = new System.Drawing.Point(239, 305);
            this.btnKrediti.Name = "btnKrediti";
            this.btnKrediti.Size = new System.Drawing.Size(221, 37);
            this.btnKrediti.TabIndex = 4;
            this.btnKrediti.Text = "Krediti";
            this.btnKrediti.UseVisualStyleBackColor = true;
            this.btnKrediti.Click += new System.EventHandler(this.btnKrediti_Click);
            // 
            // btnKamate
            // 
            this.btnKamate.Location = new System.Drawing.Point(466, 305);
            this.btnKamate.Name = "btnKamate";
            this.btnKamate.Size = new System.Drawing.Size(221, 37);
            this.btnKamate.TabIndex = 5;
            this.btnKamate.Text = "Kamate";
            this.btnKamate.UseVisualStyleBackColor = true;
            this.btnKamate.Click += new System.EventHandler(this.btnKamate_Click);
            // 
            // btnSigurnosneKontrole
            // 
            this.btnSigurnosneKontrole.Location = new System.Drawing.Point(693, 305);
            this.btnSigurnosneKontrole.Name = "btnSigurnosneKontrole";
            this.btnSigurnosneKontrole.Size = new System.Drawing.Size(175, 80);
            this.btnSigurnosneKontrole.TabIndex = 6;
            this.btnSigurnosneKontrole.Text = "Sigurnosne kontrole";
            this.btnSigurnosneKontrole.UseVisualStyleBackColor = true;
            this.btnSigurnosneKontrole.Click += new System.EventHandler(this.btnSigurnosneKontrole_Click);
            // 
            // PocetnaStrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 414);
            this.Controls.Add(this.btnSigurnosneKontrole);
            this.Controls.Add(this.btnKamate);
            this.Controls.Add(this.btnKrediti);
            this.Controls.Add(this.btnDepoziti);
            this.Controls.Add(this.btnTransakcije);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.btnKlijenti);
            this.Name = "PocetnaStrana";
            this.Text = "PocetnaStrana";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnRacuni;
        private System.Windows.Forms.Button btnTransakcije;
        private System.Windows.Forms.Button btnDepoziti;
        private System.Windows.Forms.Button btnKrediti;
        private System.Windows.Forms.Button btnKamate;
        private System.Windows.Forms.Button btnSigurnosneKontrole;
    }
}
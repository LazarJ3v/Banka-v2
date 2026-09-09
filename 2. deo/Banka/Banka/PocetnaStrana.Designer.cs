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
            // PocetnaStrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 414);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.btnKlijenti);
            this.Name = "PocetnaStrana";
            this.Text = "PocetnaStrana";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnRacuni;
    }
}
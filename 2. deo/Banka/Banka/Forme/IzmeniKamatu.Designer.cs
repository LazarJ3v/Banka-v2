namespace Banka.Forme
{
    partial class IzmeniKamatu
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
            this.lblDatumObracuna = new System.Windows.Forms.Label();
            this.dtpDatumObracuna = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodObracuna = new System.Windows.Forms.Label();
            this.lblTipKamate = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nudIznos = new System.Windows.Forms.NumericUpDown();
            this.lblIznos = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbPeriodObracuna = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatumObracuna
            // 
            this.lblDatumObracuna.AutoSize = true;
            this.lblDatumObracuna.Location = new System.Drawing.Point(66, 32);
            this.lblDatumObracuna.Name = "lblDatumObracuna";
            this.lblDatumObracuna.Size = new System.Drawing.Size(164, 23);
            this.lblDatumObracuna.TabIndex = 0;
            this.lblDatumObracuna.Text = "Datum obrčuna:";
            // 
            // dtpDatumObracuna
            // 
            this.dtpDatumObracuna.Location = new System.Drawing.Point(237, 26);
            this.dtpDatumObracuna.Name = "dtpDatumObracuna";
            this.dtpDatumObracuna.Size = new System.Drawing.Size(200, 31);
            this.dtpDatumObracuna.TabIndex = 1;
            // 
            // lblPeriodObracuna
            // 
            this.lblPeriodObracuna.AutoSize = true;
            this.lblPeriodObracuna.Location = new System.Drawing.Point(61, 69);
            this.lblPeriodObracuna.Name = "lblPeriodObracuna";
            this.lblPeriodObracuna.Size = new System.Drawing.Size(186, 23);
            this.lblPeriodObracuna.TabIndex = 2;
            this.lblPeriodObracuna.Text = "Period obračuna:";
            // 
            // lblTipKamate
            // 
            this.lblTipKamate.AutoSize = true;
            this.lblTipKamate.Location = new System.Drawing.Point(166, 109);
            this.lblTipKamate.Name = "lblTipKamate";
            this.lblTipKamate.Size = new System.Drawing.Size(54, 23);
            this.lblTipKamate.TabIndex = 4;
            this.lblTipKamate.Text = "Tip:";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(237, 106);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(200, 31);
            this.cbTip.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(142, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(87, 23);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(237, 146);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 31);
            this.cbStatus.TabIndex = 7;
            // 
            // nudIznos
            // 
            this.nudIznos.Location = new System.Drawing.Point(237, 186);
            this.nudIznos.Name = "nudIznos";
            this.nudIznos.Size = new System.Drawing.Size(200, 31);
            this.nudIznos.TabIndex = 8;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(148, 187);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(76, 23);
            this.lblIznos.TabIndex = 9;
            this.lblIznos.Text = "Iznos:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(237, 226);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(200, 31);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbPeriodObracuna
            // 
            this.cbPeriodObracuna.FormattingEnabled = true;
            this.cbPeriodObracuna.Location = new System.Drawing.Point(237, 66);
            this.cbPeriodObracuna.Name = "cbPeriodObracuna";
            this.cbPeriodObracuna.Size = new System.Drawing.Size(200, 31);
            this.cbPeriodObracuna.TabIndex = 11;
            // 
            // IzmeniKamatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 300);
            this.Controls.Add(this.cbPeriodObracuna);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.nudIznos);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.lblTipKamate);
            this.Controls.Add(this.lblPeriodObracuna);
            this.Controls.Add(this.dtpDatumObracuna);
            this.Controls.Add(this.lblDatumObracuna);
            this.Name = "IzmeniKamatu";
            this.Text = "IzmeniKamatu";
            this.Load += new System.EventHandler(this.IzmeniKamatu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumObracuna;
        private System.Windows.Forms.DateTimePicker dtpDatumObracuna;
        private System.Windows.Forms.Label lblPeriodObracuna;
        private System.Windows.Forms.Label lblTipKamate;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown nudIznos;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbPeriodObracuna;
    }
}
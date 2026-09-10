namespace Banka.Forme
{
    partial class DodajRacun
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
            this.gbKlijent = new System.Windows.Forms.GroupBox();
            this.lblPib = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.tbPib = new System.Windows.Forms.TextBox();
            this.tbJmbg = new System.Windows.Forms.TextBox();
            this.rbPravnoLice = new System.Windows.Forms.RadioButton();
            this.rbFizickoLice = new System.Windows.Forms.RadioButton();
            this.gbRacun = new System.Windows.Forms.GroupBox();
            this.gbTekuci = new System.Windows.Forms.GroupBox();
            this.btnObrisiPaket = new System.Windows.Forms.Button();
            this.dgvPaketi = new System.Windows.Forms.DataGridView();
            this.btnDodajPaket = new System.Windows.Forms.Button();
            this.lblPaket = new System.Windows.Forms.Label();
            this.tbPaket = new System.Windows.Forms.TextBox();
            this.lblMesecniLimit = new System.Windows.Forms.Label();
            this.tbMesecniLimit = new System.Windows.Forms.TextBox();
            this.cbPlatnaKartica = new System.Windows.Forms.CheckBox();
            this.gbZiro = new System.Windows.Forms.GroupBox();
            this.lblIntegracijaSaSistemima = new System.Windows.Forms.Label();
            this.rtbIntegracijaSaSistemima = new System.Windows.Forms.RichTextBox();
            this.lblLimitZaMasovnaPlacanja = new System.Windows.Forms.Label();
            this.tbLimitZaMasovnaPlacanja = new System.Windows.Forms.TextBox();
            this.cbElektronskoBankarstvo = new System.Windows.Forms.CheckBox();
            this.lblNamena = new System.Windows.Forms.Label();
            this.tbNamena = new System.Windows.Forms.TextBox();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.nudKamatnaStopa = new System.Windows.Forms.NumericUpDown();
            this.lblKamatnaStopa = new System.Windows.Forms.Label();
            this.lblDozvoljeniMinus = new System.Windows.Forms.Label();
            this.lblTrenutnoStanje = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.rtbKomentar = new System.Windows.Forms.RichTextBox();
            this.tbDozvoljeniMinus = new System.Windows.Forms.TextBox();
            this.tbTrenutnoStanje = new System.Windows.Forms.TextBox();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.tbBrojRacuna = new System.Windows.Forms.TextBox();
            this.rbDrugi = new System.Windows.Forms.RadioButton();
            this.rbZiro = new System.Windows.Forms.RadioButton();
            this.rbStedni = new System.Windows.Forms.RadioButton();
            this.rbDevizni = new System.Windows.Forms.RadioButton();
            this.rbTekuci = new System.Windows.Forms.RadioButton();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.gbKlijent.SuspendLayout();
            this.gbRacun.SuspendLayout();
            this.gbTekuci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).BeginInit();
            this.gbZiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKamatnaStopa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKlijent
            // 
            this.gbKlijent.Controls.Add(this.lblPib);
            this.gbKlijent.Controls.Add(this.lblJmbg);
            this.gbKlijent.Controls.Add(this.tbPib);
            this.gbKlijent.Controls.Add(this.tbJmbg);
            this.gbKlijent.Controls.Add(this.rbPravnoLice);
            this.gbKlijent.Controls.Add(this.rbFizickoLice);
            this.gbKlijent.Location = new System.Drawing.Point(23, 23);
            this.gbKlijent.Name = "gbKlijent";
            this.gbKlijent.Size = new System.Drawing.Size(754, 109);
            this.gbKlijent.TabIndex = 0;
            this.gbKlijent.TabStop = false;
            this.gbKlijent.Text = "Klijent";
            // 
            // lblPib
            // 
            this.lblPib.AutoSize = true;
            this.lblPib.Location = new System.Drawing.Point(501, 71);
            this.lblPib.Name = "lblPib";
            this.lblPib.Size = new System.Drawing.Size(41, 25);
            this.lblPib.TabIndex = 5;
            this.lblPib.Text = "Pib:";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(482, 32);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(60, 25);
            this.lblJmbg.TabIndex = 4;
            this.lblJmbg.Text = "Jmbg:";
            // 
            // tbPib
            // 
            this.tbPib.Location = new System.Drawing.Point(548, 68);
            this.tbPib.Name = "tbPib";
            this.tbPib.Size = new System.Drawing.Size(200, 31);
            this.tbPib.TabIndex = 3;
            // 
            // tbJmbg
            // 
            this.tbJmbg.Location = new System.Drawing.Point(548, 29);
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.Size = new System.Drawing.Size(200, 31);
            this.tbJmbg.TabIndex = 2;
            // 
            // rbPravnoLice
            // 
            this.rbPravnoLice.AutoSize = true;
            this.rbPravnoLice.Location = new System.Drawing.Point(7, 66);
            this.rbPravnoLice.Name = "rbPravnoLice";
            this.rbPravnoLice.Size = new System.Drawing.Size(122, 29);
            this.rbPravnoLice.TabIndex = 1;
            this.rbPravnoLice.TabStop = true;
            this.rbPravnoLice.Text = "Pravno lice";
            this.rbPravnoLice.UseVisualStyleBackColor = true;
            // 
            // rbFizickoLice
            // 
            this.rbFizickoLice.AutoSize = true;
            this.rbFizickoLice.Location = new System.Drawing.Point(6, 30);
            this.rbFizickoLice.Name = "rbFizickoLice";
            this.rbFizickoLice.Size = new System.Drawing.Size(120, 29);
            this.rbFizickoLice.TabIndex = 0;
            this.rbFizickoLice.TabStop = true;
            this.rbFizickoLice.Text = "Fizičko lice";
            this.rbFizickoLice.UseVisualStyleBackColor = true;
            this.rbFizickoLice.CheckedChanged += new System.EventHandler(this.rbFizickoLice_CheckedChanged);
            // 
            // gbRacun
            // 
            this.gbRacun.Controls.Add(this.gbTekuci);
            this.gbRacun.Controls.Add(this.gbZiro);
            this.gbRacun.Controls.Add(this.lblKomentar);
            this.gbRacun.Controls.Add(this.nudKamatnaStopa);
            this.gbRacun.Controls.Add(this.lblKamatnaStopa);
            this.gbRacun.Controls.Add(this.lblDozvoljeniMinus);
            this.gbRacun.Controls.Add(this.lblTrenutnoStanje);
            this.gbRacun.Controls.Add(this.lblValuta);
            this.gbRacun.Controls.Add(this.lblBrojRacuna);
            this.gbRacun.Controls.Add(this.rtbKomentar);
            this.gbRacun.Controls.Add(this.tbDozvoljeniMinus);
            this.gbRacun.Controls.Add(this.tbTrenutnoStanje);
            this.gbRacun.Controls.Add(this.cbValuta);
            this.gbRacun.Controls.Add(this.tbBrojRacuna);
            this.gbRacun.Controls.Add(this.rbDrugi);
            this.gbRacun.Controls.Add(this.rbZiro);
            this.gbRacun.Controls.Add(this.rbStedni);
            this.gbRacun.Controls.Add(this.rbDevizni);
            this.gbRacun.Controls.Add(this.rbTekuci);
            this.gbRacun.Location = new System.Drawing.Point(23, 138);
            this.gbRacun.Name = "gbRacun";
            this.gbRacun.Size = new System.Drawing.Size(754, 376);
            this.gbRacun.TabIndex = 1;
            this.gbRacun.TabStop = false;
            this.gbRacun.Text = "Račun";
            // 
            // gbTekuci
            // 
            this.gbTekuci.Controls.Add(this.btnObrisiPaket);
            this.gbTekuci.Controls.Add(this.dgvPaketi);
            this.gbTekuci.Controls.Add(this.btnDodajPaket);
            this.gbTekuci.Controls.Add(this.lblPaket);
            this.gbTekuci.Controls.Add(this.tbPaket);
            this.gbTekuci.Controls.Add(this.lblMesecniLimit);
            this.gbTekuci.Controls.Add(this.tbMesecniLimit);
            this.gbTekuci.Controls.Add(this.cbPlatnaKartica);
            this.gbTekuci.Location = new System.Drawing.Point(377, 65);
            this.gbTekuci.Name = "gbTekuci";
            this.gbTekuci.Size = new System.Drawing.Size(371, 305);
            this.gbTekuci.TabIndex = 7;
            this.gbTekuci.TabStop = false;
            this.gbTekuci.Text = "Tekući";
            // 
            // btnObrisiPaket
            // 
            this.btnObrisiPaket.Location = new System.Drawing.Point(6, 139);
            this.btnObrisiPaket.Name = "btnObrisiPaket";
            this.btnObrisiPaket.Size = new System.Drawing.Size(151, 31);
            this.btnObrisiPaket.TabIndex = 7;
            this.btnObrisiPaket.Text = "Obriši paket";
            this.btnObrisiPaket.UseVisualStyleBackColor = true;
            // 
            // dgvPaketi
            // 
            this.dgvPaketi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaketi.Location = new System.Drawing.Point(6, 192);
            this.dgvPaketi.Name = "dgvPaketi";
            this.dgvPaketi.RowHeadersWidth = 62;
            this.dgvPaketi.RowTemplate.Height = 28;
            this.dgvPaketi.Size = new System.Drawing.Size(359, 107);
            this.dgvPaketi.TabIndex = 6;
            // 
            // btnDodajPaket
            // 
            this.btnDodajPaket.Location = new System.Drawing.Point(165, 139);
            this.btnDodajPaket.Name = "btnDodajPaket";
            this.btnDodajPaket.Size = new System.Drawing.Size(200, 31);
            this.btnDodajPaket.TabIndex = 5;
            this.btnDodajPaket.Text = "Dodaj paket";
            this.btnDodajPaket.UseVisualStyleBackColor = true;
            // 
            // lblPaket
            // 
            this.lblPaket.AutoSize = true;
            this.lblPaket.Location = new System.Drawing.Point(101, 105);
            this.lblPaket.Name = "lblPaket";
            this.lblPaket.Size = new System.Drawing.Size(58, 25);
            this.lblPaket.TabIndex = 4;
            this.lblPaket.Text = "Paket:";
            // 
            // tbPaket
            // 
            this.tbPaket.Location = new System.Drawing.Point(165, 102);
            this.tbPaket.Name = "tbPaket";
            this.tbPaket.Size = new System.Drawing.Size(200, 31);
            this.tbPaket.TabIndex = 3;
            // 
            // lblMesecniLimit
            // 
            this.lblMesecniLimit.AutoSize = true;
            this.lblMesecniLimit.Location = new System.Drawing.Point(40, 68);
            this.lblMesecniLimit.Name = "lblMesecniLimit";
            this.lblMesecniLimit.Size = new System.Drawing.Size(119, 25);
            this.lblMesecniLimit.TabIndex = 2;
            this.lblMesecniLimit.Text = "Mesečni limit:";
            // 
            // tbMesecniLimit
            // 
            this.tbMesecniLimit.Location = new System.Drawing.Point(165, 65);
            this.tbMesecniLimit.Name = "tbMesecniLimit";
            this.tbMesecniLimit.Size = new System.Drawing.Size(200, 31);
            this.tbMesecniLimit.TabIndex = 1;
            // 
            // cbPlatnaKartica
            // 
            this.cbPlatnaKartica.AutoSize = true;
            this.cbPlatnaKartica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbPlatnaKartica.Location = new System.Drawing.Point(223, 30);
            this.cbPlatnaKartica.Name = "cbPlatnaKartica";
            this.cbPlatnaKartica.Size = new System.Drawing.Size(142, 29);
            this.cbPlatnaKartica.TabIndex = 0;
            this.cbPlatnaKartica.Text = "Platna kartica";
            this.cbPlatnaKartica.UseVisualStyleBackColor = true;
            // 
            // gbZiro
            // 
            this.gbZiro.Controls.Add(this.lblIntegracijaSaSistemima);
            this.gbZiro.Controls.Add(this.rtbIntegracijaSaSistemima);
            this.gbZiro.Controls.Add(this.lblLimitZaMasovnaPlacanja);
            this.gbZiro.Controls.Add(this.tbLimitZaMasovnaPlacanja);
            this.gbZiro.Controls.Add(this.cbElektronskoBankarstvo);
            this.gbZiro.Controls.Add(this.lblNamena);
            this.gbZiro.Controls.Add(this.tbNamena);
            this.gbZiro.Location = new System.Drawing.Point(377, 65);
            this.gbZiro.Name = "gbZiro";
            this.gbZiro.Size = new System.Drawing.Size(371, 305);
            this.gbZiro.TabIndex = 18;
            this.gbZiro.TabStop = false;
            this.gbZiro.Text = "Žiro";
            // 
            // lblIntegracijaSaSistemima
            // 
            this.lblIntegracijaSaSistemima.Location = new System.Drawing.Point(37, 142);
            this.lblIntegracijaSaSistemima.Name = "lblIntegracijaSaSistemima";
            this.lblIntegracijaSaSistemima.Size = new System.Drawing.Size(122, 59);
            this.lblIntegracijaSaSistemima.TabIndex = 6;
            this.lblIntegracijaSaSistemima.Text = "Integracija sa sistemima:";
            // 
            // rtbIntegracijaSaSistemima
            // 
            this.rtbIntegracijaSaSistemima.Location = new System.Drawing.Point(165, 139);
            this.rtbIntegracijaSaSistemima.Name = "rtbIntegracijaSaSistemima";
            this.rtbIntegracijaSaSistemima.Size = new System.Drawing.Size(200, 160);
            this.rtbIntegracijaSaSistemima.TabIndex = 5;
            this.rtbIntegracijaSaSistemima.Text = "";
            // 
            // lblLimitZaMasovnaPlacanja
            // 
            this.lblLimitZaMasovnaPlacanja.Location = new System.Drawing.Point(27, 89);
            this.lblLimitZaMasovnaPlacanja.Name = "lblLimitZaMasovnaPlacanja";
            this.lblLimitZaMasovnaPlacanja.Size = new System.Drawing.Size(132, 56);
            this.lblLimitZaMasovnaPlacanja.TabIndex = 4;
            this.lblLimitZaMasovnaPlacanja.Text = "Limit masovnih plaćanja:";
            // 
            // tbLimitZaMasovnaPlacanja
            // 
            this.tbLimitZaMasovnaPlacanja.Location = new System.Drawing.Point(165, 102);
            this.tbLimitZaMasovnaPlacanja.Name = "tbLimitZaMasovnaPlacanja";
            this.tbLimitZaMasovnaPlacanja.Size = new System.Drawing.Size(200, 31);
            this.tbLimitZaMasovnaPlacanja.TabIndex = 3;
            // 
            // cbElektronskoBankarstvo
            // 
            this.cbElektronskoBankarstvo.AutoSize = true;
            this.cbElektronskoBankarstvo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbElektronskoBankarstvo.Location = new System.Drawing.Point(138, 67);
            this.cbElektronskoBankarstvo.Name = "cbElektronskoBankarstvo";
            this.cbElektronskoBankarstvo.Size = new System.Drawing.Size(227, 29);
            this.cbElektronskoBankarstvo.TabIndex = 2;
            this.cbElektronskoBankarstvo.Text = "Elektronsko bankarstvo:";
            this.cbElektronskoBankarstvo.UseVisualStyleBackColor = true;
            // 
            // lblNamena
            // 
            this.lblNamena.AutoSize = true;
            this.lblNamena.Location = new System.Drawing.Point(77, 33);
            this.lblNamena.Name = "lblNamena";
            this.lblNamena.Size = new System.Drawing.Size(82, 25);
            this.lblNamena.TabIndex = 1;
            this.lblNamena.Text = "Namena:";
            // 
            // tbNamena
            // 
            this.tbNamena.Location = new System.Drawing.Point(165, 30);
            this.tbNamena.Name = "tbNamena";
            this.tbNamena.Size = new System.Drawing.Size(200, 31);
            this.tbNamena.TabIndex = 0;
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(72, 257);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(93, 25);
            this.lblKomentar.TabIndex = 17;
            this.lblKomentar.Text = "Komentar:";
            // 
            // nudKamatnaStopa
            // 
            this.nudKamatnaStopa.Location = new System.Drawing.Point(251, 216);
            this.nudKamatnaStopa.Name = "nudKamatnaStopa";
            this.nudKamatnaStopa.Size = new System.Drawing.Size(120, 31);
            this.nudKamatnaStopa.TabIndex = 16;
            // 
            // lblKamatnaStopa
            // 
            this.lblKamatnaStopa.AutoSize = true;
            this.lblKamatnaStopa.Location = new System.Drawing.Point(30, 218);
            this.lblKamatnaStopa.Name = "lblKamatnaStopa";
            this.lblKamatnaStopa.Size = new System.Drawing.Size(135, 25);
            this.lblKamatnaStopa.TabIndex = 15;
            this.lblKamatnaStopa.Text = "Kamatna stopa:";
            // 
            // lblDozvoljeniMinus
            // 
            this.lblDozvoljeniMinus.AutoSize = true;
            this.lblDozvoljeniMinus.Location = new System.Drawing.Point(13, 182);
            this.lblDozvoljeniMinus.Name = "lblDozvoljeniMinus";
            this.lblDozvoljeniMinus.Size = new System.Drawing.Size(152, 25);
            this.lblDozvoljeniMinus.TabIndex = 14;
            this.lblDozvoljeniMinus.Text = "Dozvoljeni minus:";
            // 
            // lblTrenutnoStanje
            // 
            this.lblTrenutnoStanje.AutoSize = true;
            this.lblTrenutnoStanje.Location = new System.Drawing.Point(29, 144);
            this.lblTrenutnoStanje.Name = "lblTrenutnoStanje";
            this.lblTrenutnoStanje.Size = new System.Drawing.Size(136, 25);
            this.lblTrenutnoStanje.TabIndex = 13;
            this.lblTrenutnoStanje.Text = "Trenutno stanje:";
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(101, 105);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(64, 25);
            this.lblValuta.TabIndex = 12;
            this.lblValuta.Text = "Valuta:";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Location = new System.Drawing.Point(61, 68);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(104, 25);
            this.lblBrojRacuna.TabIndex = 11;
            this.lblBrojRacuna.Text = "Broj računa:";
            // 
            // rtbKomentar
            // 
            this.rtbKomentar.Location = new System.Drawing.Point(171, 254);
            this.rtbKomentar.Name = "rtbKomentar";
            this.rtbKomentar.Size = new System.Drawing.Size(200, 116);
            this.rtbKomentar.TabIndex = 10;
            this.rtbKomentar.Text = "";
            // 
            // tbDozvoljeniMinus
            // 
            this.tbDozvoljeniMinus.Location = new System.Drawing.Point(171, 179);
            this.tbDozvoljeniMinus.Name = "tbDozvoljeniMinus";
            this.tbDozvoljeniMinus.Size = new System.Drawing.Size(200, 31);
            this.tbDozvoljeniMinus.TabIndex = 8;
            // 
            // tbTrenutnoStanje
            // 
            this.tbTrenutnoStanje.Location = new System.Drawing.Point(171, 141);
            this.tbTrenutnoStanje.Name = "tbTrenutnoStanje";
            this.tbTrenutnoStanje.Size = new System.Drawing.Size(200, 31);
            this.tbTrenutnoStanje.TabIndex = 7;
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(250, 102);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(121, 33);
            this.cbValuta.TabIndex = 6;
            // 
            // tbBrojRacuna
            // 
            this.tbBrojRacuna.Location = new System.Drawing.Point(171, 65);
            this.tbBrojRacuna.Name = "tbBrojRacuna";
            this.tbBrojRacuna.Size = new System.Drawing.Size(200, 31);
            this.tbBrojRacuna.TabIndex = 5;
            // 
            // rbDrugi
            // 
            this.rbDrugi.AutoSize = true;
            this.rbDrugi.Location = new System.Drawing.Point(363, 30);
            this.rbDrugi.Name = "rbDrugi";
            this.rbDrugi.Size = new System.Drawing.Size(81, 29);
            this.rbDrugi.TabIndex = 4;
            this.rbDrugi.TabStop = true;
            this.rbDrugi.Text = "Drugi";
            this.rbDrugi.UseVisualStyleBackColor = true;
            // 
            // rbZiro
            // 
            this.rbZiro.AutoSize = true;
            this.rbZiro.Location = new System.Drawing.Point(289, 30);
            this.rbZiro.Name = "rbZiro";
            this.rbZiro.Size = new System.Drawing.Size(68, 29);
            this.rbZiro.TabIndex = 3;
            this.rbZiro.TabStop = true;
            this.rbZiro.Text = "Žiro";
            this.rbZiro.UseVisualStyleBackColor = true;
            this.rbZiro.CheckedChanged += new System.EventHandler(this.rbZiro_CheckedChanged);
            // 
            // rbStedni
            // 
            this.rbStedni.AutoSize = true;
            this.rbStedni.Location = new System.Drawing.Point(197, 30);
            this.rbStedni.Name = "rbStedni";
            this.rbStedni.Size = new System.Drawing.Size(86, 29);
            this.rbStedni.TabIndex = 2;
            this.rbStedni.TabStop = true;
            this.rbStedni.Text = "Štedni";
            this.rbStedni.UseVisualStyleBackColor = true;
            // 
            // rbDevizni
            // 
            this.rbDevizni.AutoSize = true;
            this.rbDevizni.Location = new System.Drawing.Point(97, 30);
            this.rbDevizni.Name = "rbDevizni";
            this.rbDevizni.Size = new System.Drawing.Size(94, 29);
            this.rbDevizni.TabIndex = 1;
            this.rbDevizni.TabStop = true;
            this.rbDevizni.Text = "Devizni";
            this.rbDevizni.UseVisualStyleBackColor = true;
            // 
            // rbTekuci
            // 
            this.rbTekuci.AutoSize = true;
            this.rbTekuci.Location = new System.Drawing.Point(7, 30);
            this.rbTekuci.Name = "rbTekuci";
            this.rbTekuci.Size = new System.Drawing.Size(84, 29);
            this.rbTekuci.TabIndex = 0;
            this.rbTekuci.TabStop = true;
            this.rbTekuci.Text = "Tekući";
            this.rbTekuci.UseVisualStyleBackColor = true;
            this.rbTekuci.CheckedChanged += new System.EventHandler(this.rbTekuci_CheckedChanged);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(597, 521);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(180, 31);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // DodajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.gbRacun);
            this.Controls.Add(this.gbKlijent);
            this.Name = "DodajRacun";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "DodajRacun";
            this.gbKlijent.ResumeLayout(false);
            this.gbKlijent.PerformLayout();
            this.gbRacun.ResumeLayout(false);
            this.gbRacun.PerformLayout();
            this.gbTekuci.ResumeLayout(false);
            this.gbTekuci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).EndInit();
            this.gbZiro.ResumeLayout(false);
            this.gbZiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKamatnaStopa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKlijent;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox tbPib;
        private System.Windows.Forms.TextBox tbJmbg;
        private System.Windows.Forms.RadioButton rbPravnoLice;
        private System.Windows.Forms.RadioButton rbFizickoLice;
        private System.Windows.Forms.Label lblPib;
        private System.Windows.Forms.GroupBox gbRacun;
        private System.Windows.Forms.RadioButton rbDrugi;
        private System.Windows.Forms.RadioButton rbZiro;
        private System.Windows.Forms.RadioButton rbStedni;
        private System.Windows.Forms.RadioButton rbDevizni;
        private System.Windows.Forms.RadioButton rbTekuci;
        private System.Windows.Forms.TextBox tbBrojRacuna;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.TextBox tbDozvoljeniMinus;
        private System.Windows.Forms.TextBox tbTrenutnoStanje;
        private System.Windows.Forms.NumericUpDown nudKamatnaStopa;
        private System.Windows.Forms.Label lblKamatnaStopa;
        private System.Windows.Forms.Label lblDozvoljeniMinus;
        private System.Windows.Forms.Label lblTrenutnoStanje;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.RichTextBox rtbKomentar;
        private System.Windows.Forms.GroupBox gbZiro;
        private System.Windows.Forms.CheckBox cbElektronskoBankarstvo;
        private System.Windows.Forms.Label lblNamena;
        private System.Windows.Forms.TextBox tbNamena;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label lblLimitZaMasovnaPlacanja;
        private System.Windows.Forms.TextBox tbLimitZaMasovnaPlacanja;
        private System.Windows.Forms.GroupBox gbTekuci;
        private System.Windows.Forms.Label lblIntegracijaSaSistemima;
        private System.Windows.Forms.RichTextBox rtbIntegracijaSaSistemima;
        private System.Windows.Forms.Label lblPaket;
        private System.Windows.Forms.TextBox tbPaket;
        private System.Windows.Forms.Label lblMesecniLimit;
        private System.Windows.Forms.TextBox tbMesecniLimit;
        private System.Windows.Forms.CheckBox cbPlatnaKartica;
        private System.Windows.Forms.DataGridView dgvPaketi;
        private System.Windows.Forms.Button btnDodajPaket;
        private System.Windows.Forms.Button btnObrisiPaket;
    }
}
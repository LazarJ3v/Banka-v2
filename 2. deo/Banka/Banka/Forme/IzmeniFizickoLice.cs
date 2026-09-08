using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banka.Forme;

namespace Banka.Forme
{
    public partial class IzmeniFizickoLice : BaseForm
    {
        private FizickoLiceBasic fizickoLice;
        public IzmeniFizickoLice(FizickoLiceBasic _fizickoLice) : base()
        {
            InitializeComponent();
            fizickoLice = _fizickoLice;
            StilizujButton(
                btnIzmeni);
            StilizujLabel(
                lblAdresa,
                lblBrojLicneKarte,
                lblDatumRodjenja,
                lblEmail,
                lblGrad,
                lblIme,
                lblJmbg,
                lblKomentar,
                lblPrezime,
                lblStatus,
                lblTelefon);
            StilizujTextBox(
                tbAdresa,
                tbBrojLicneKarte,
                tbEmail,
                tbGrad,
                tbIme,
                tbJmbg,
                tbPrezime,
                tbTelefon
                );
            StilizujDateTimePicker(
                dtpDatumRodjenja);
            StilizujRichTextBox(
                rtbKomentar);
        }

        private void IzmeniFizickoLice_Load(object sender, EventArgs e)
        {
            tbIme.Text = fizickoLice.Ime;
            tbPrezime.Text = fizickoLice.Prezime;
            tbJmbg.Text = fizickoLice.Jmbg;
            tbBrojLicneKarte.Text = fizickoLice.BrojLicneKarte;

            if (fizickoLice.DatumRodjenja.HasValue)
                dtpDatumRodjenja.Value = fizickoLice.DatumRodjenja.Value;
            else
                dtpDatumRodjenja.Value = DateTime.Now;

            tbAdresa.Text = fizickoLice.Adresa;
            tbGrad.Text = fizickoLice.Grad;
            tbTelefon.Text = fizickoLice.Telefon;
            tbEmail.Text = fizickoLice.Email;
            rtbKomentar.Text = fizickoLice.Komentar;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            fizickoLice.Ime = tbIme.Text.Trim();
            fizickoLice.Prezime = tbPrezime.Text.Trim();
            fizickoLice.Jmbg = tbJmbg.Text.Trim();
            fizickoLice.BrojLicneKarte = tbBrojLicneKarte.Text.Trim();
            fizickoLice.DatumRodjenja = dtpDatumRodjenja.Value;
            fizickoLice.Adresa = tbAdresa.Text.Trim();
            fizickoLice.Grad = tbGrad.Text.Trim();
            fizickoLice.Telefon = tbTelefon.Text.Trim();
            fizickoLice.Email = tbEmail.Text.Trim();
            fizickoLice.Komentar = rtbKomentar.Text.Trim();

            // Čuvanje u bazu
            DTOManager.IzmeniFizickoLice(fizickoLice);

            MessageBox.Show("Podaci uspešno izmenjeni!", "Uspeh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

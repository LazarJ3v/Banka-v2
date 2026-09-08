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
    public partial class DodajKlijenta : BaseForm
    {
        public DodajKlijenta()
        {
            InitializeComponent();
            StilizujGroupBox(
                gbTipKlijenta,
                gbFizickoLicePodaci,
                gbPravnoLicePodaci);
            StilizujButton(
                btnSacuvaj);
            StilizujLabel(
                lblAdresaFL,
                lblAdresaPL,
                lblBrojLicneKarteFL,
                lblDatumRodjenjaFL,
                lblEmailFL,
                lblEmailPL,
                lblGradFL,
                lblGradPL,
                lblImeFL,
                lblJmbgFL,
                lblKomentarFL,
                lblKomentarPL,
                lblNazivFirmePL,
                lblPibPL,
                lblPrezimeFL,
                lblTelefonFL,
                lblTelefonPL
                );
            StilizujTextBox(
                tbAdresaFL,
                tbAdresaPL,
                tbBrojLicneKarteFL,
                tbEmailFL,
                tbEmailPL,
                tbGradFL,
                tbGradPL,
                tbImeFL,
                tbJmbgFL,
                tbNazivFirmePL,
                tbPibPL,
                tbPrezimeFL,
                tbTelefonFL,
                tbTelefonPL);
            StilizujDateTimePicker(
                dtpDatumRodjenjaFL);
            StilizujRichTextBox(
                rtbKomentarFL,
                rtbKomentarPL);
        }

        private void rbFizickoLice_CheckedChanged(object sender, EventArgs e)
        {
            gbFizickoLicePodaci.Visible = rbFizickoLice.Checked;
            gbPravnoLicePodaci.Visible = rbPravnoLice.Checked;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (rbFizickoLice.Checked)
            {
                FizickoLiceBasic fl = new FizickoLiceBasic
                {
                    Ime = tbImeFL.Text.Trim(),
                    Prezime = tbPrezimeFL.Text.Trim(),
                    Jmbg = tbJmbgFL.Text.Trim(),
                    BrojLicneKarte = tbBrojLicneKarteFL.Text.Trim(),
                    DatumRodjenja = dtpDatumRodjenjaFL.Value,
                    Adresa = tbAdresaFL.Text.Trim(),
                    Grad = tbGradFL.Text.Trim(),
                    Telefon = tbTelefonFL.Text.Trim(),
                    Email = tbEmailFL.Text.Trim(),
                    Status = "Aktivan",
                    Komentar = rtbKomentarFL.Text.Trim()
                };

                // Čuvanje u bazu
                DTOManager.DodajFizickoLice(fl);
            }
            else if(rbPravnoLice.Checked)
            {
                PravnoLiceBasic pl = new PravnoLiceBasic
                {
                    NazivFirme = tbNazivFirmePL.Text.Trim(),
                    Pib = tbPibPL.Text.Trim(),
                    Adresa = tbAdresaPL.Text.Trim(),
                    Grad = tbGradPL.Text.Trim(),
                    Telefon = tbTelefonPL.Text.Trim(),
                    Email = tbEmailPL.Text.Trim(),
                    Status = "Aktivan",
                    Komentar = rtbKomentarPL.Text.Trim()
                };

                //DTOManager.DodajPravnoLice(pl);
            }
            
            MessageBox.Show("Klijent uspešno dodat!", "Uspeh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

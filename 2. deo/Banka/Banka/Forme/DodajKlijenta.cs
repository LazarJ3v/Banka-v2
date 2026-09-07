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
    }
}

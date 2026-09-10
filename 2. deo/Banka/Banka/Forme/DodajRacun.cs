using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka.Forme
{
    public partial class DodajRacun : BaseForm
    {
        public DodajRacun() : base()
        {
            InitializeComponent();
            StilizujGroupBox(
                gbKlijent,
                gbRacun,
                gbTekuci,
                gbZiro);
            StilizujRadioButton(
                rbFizickoLice,
                rbPravnoLice,
                rbTekuci,
                rbZiro,
                rbDevizni,
                rbStedni,
                rbDrugi);
            StilizujLabel(
                lblBrojRacuna,
                lblDozvoljeniMinus,
                lblIntegracijaSaSistemima,
                lblJmbg,
                lblKamatnaStopa,
                lblKomentar,
                lblLimitZaMasovnaPlacanja,
                lblMesecniLimit,
                lblNamena,
                lblPaket,
                lblPib,
                lblTrenutnoStanje,
                lblValuta);
            StilizujTextBox(
                tbBrojRacuna,
                tbDozvoljeniMinus,
                tbJmbg,
                tbLimitZaMasovnaPlacanja,
                tbMesecniLimit,
                tbNamena,
                tbPaket,
                tbPib,
                tbTrenutnoStanje);
            StilizujRichTextBox(
                rtbIntegracijaSaSistemima,
                rtbKomentar);
            StilizujButton(
                btnDodajPaket,
                btnObrisiPaket,
                btnSacuvaj);
            StilizujDataGridView(
                dgvPaketi);
        }

        private void rbFizickoLice_CheckedChanged(object sender, EventArgs e)
        {
            tbJmbg.Enabled = rbFizickoLice.Checked;
            tbPib.Enabled = rbPravnoLice.Checked;
        }

        private void rbTekuci_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTekuci.Checked)
            {
                gbTekuci.Visible = true;
                gbZiro.Visible = false;
                //TODO: napraviti group boxove pa odkomentarisati
                //gbDevizni.Visible = false;
                //gbStedni.Visible = false;
            }
        }

        private void rbZiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZiro.Checked)
            {
                gbZiro.Visible = true;
                gbTekuci.Visible = false;
                //TODO: napraviti group boxove pa odkomentarisati
                //gbDevizni.Visible = false;
                //gbStedni.Visible = false;
            }
        }

        //TODO: implementirati event handlere za rbDevizni_CheckedChanged i rbStedniChackedChanged
    }
}

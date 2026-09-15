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
                gbZiro,
                gbDevizni,
                gbStedni);
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
                lblValuta,
                lblOgranicenje,
                lblDodajValutu,
                lblNamenaDevizni,
                lblKursnaRazlika,
                lblBonus,
                lblUslovPodizanja,
                lblFrekvKapKamate,
                lblMinimalniIznosOtvaranja);
            StilizujTextBox(
                tbBrojRacuna,
                tbDozvoljeniMinus,
                tbJmbg,
                tbLimitZaMasovnaPlacanja,
                tbMesecniLimit,
                tbNamena,
                tbPaket,
                tbPib,
                tbTrenutnoStanje,
                tbNamenaDevizni,
                tbOgranicenje,
                tbBonus,
                tbUslovPodizanja,
                tbFrekvKapKamate,
                tbMinimalniIznosOtvaranja);
            StilizujRichTextBox(
                rtbIntegracijaSaSistemima,
                rtbKomentar);
            StilizujButton(
                btnDodajPaket,
                btnObrisiPaket,
                btnSacuvaj,
                btnDodajOgranicenje,
                btnDodajValutu,
                btnObrisiOgranicenje,
                btnObrisiValutu,
                btnDodajBonus,
                btnObrisiBonus,
                btnDodajUslovPodizanja,
                btnObrisiUslovPodizanja);
            StilizujDataGridView(
                dgvPaketi,
                dgvValute,
                dgvOgranicenja,
                dgvBonusi,
                dgvUsloviPodizanja);
            StilizujComboBox(
                cbDodajValutu,
                cbValuta);
        }

        private void DodajRacun_Load(object sender, EventArgs e)
        {
            rbFizickoLice.Checked = true;
            rbTekuci.Checked = true;
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
                gbDevizni.Visible = false;
                gbStedni.Visible = false;
            }
        }

        private void rbZiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZiro.Checked)
            {
                gbZiro.Visible = true;
                gbTekuci.Visible = false;
                gbDevizni.Visible = false;
                gbStedni.Visible = false;
            }
        }

        private void rbDevizni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDevizni.Checked)
            {
                gbDevizni.Visible = true;
                gbTekuci.Visible = false;
                gbZiro.Visible = false;
                gbStedni.Visible = false;
            }
        }

        private void rbDrugi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDrugi.Checked)
            {
                gbDevizni.Visible = false;
                gbTekuci.Visible = false;
                gbZiro.Visible = false;
                gbStedni.Visible = false;
            }
        }

        private void rbStedni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStedni.Checked)
            {
                gbStedni.Visible = true;
                gbDevizni.Visible = false;
                gbTekuci.Visible = false;
                gbZiro.Visible = false;
            }
        }

        
    }
}

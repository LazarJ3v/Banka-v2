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
    public partial class IzmeniRacun : BaseForm
    {
        public IzmeniRacun() : base()
        {
            InitializeComponent();
            StilizujLabelHeader(
                lblBonus,
                lblBrojRacuna,
                lblDatumOtvaranja,
                lblDozvoljeniMinus,
                lblFrekvKapitalizacijeKamate,
                lblIntegracijaSaSistemima,
                lblKamatnaStopa,
                lblKomentar,
                lblKursnaRazlika,
                lblLimitZaMasovnaPlacanja,
                lblMesecniLimit,
                lblMinimalniIznosOtvaranja,
                lblNamenaDevizni,
                lblNamenaZiro,
                lblOgranicenje,
                lblPaket,
                lblStatus,
                lblTrenutnoStanje,
                lblUslovPodizanja,
                lblValuta,
                lblValutaDodaj);
            StilizujButton(
                btnDodajBonus,
                btnDodajOgranicenje,
                btnDodajPaket,
                btnDodajUslov,
                btnDodajValutu,
                btnIzmeni,
                btnObrisiBonus,
                btnObrisiOgranicenje,
                btnObrisiPaket,
                btnObrisiUslov,
                btnObrisiValutu);
            StilizujGroupBox(
                gbDevizniInformacije,
                gbOsnovneInformacije,
                gbStedniInformacije,
                gbTekuciInformacije,
                gbZiroInformacije);
            StilizujTextBox(
                tbBonus,
                tbBrojRacuna,
                tbNamenaZiro,
                tbOgranicenje,
                tbPaket,
                tbUslovPodizanja);
            StilizujCheckBox(
                chbElektronskoBankarstvo,
                chbPlatnaKartica);
            StilizujNumericUpDown(
                nudDozvoljeniMinus,
                nudKamatnaStopa,
                nudKursnaRazlika,
                nudLimitZaMasovnaPlacanja,
                nudMesecniLimit,
                nudMinimalniIznosOtvaranja,
                nudTrenutnoStanje);
            StilizujRichTextBox(
                rtbIntegracijaSaSistemima,
                rtbKomentar);
            StilizujDataGridView(
                dgvBonusi,
                dgvOgranicenja,
                dgvPaketi,
                dgvUsloviPodizanja,
                dgvValute);
            StilizujDateTimePicker(
                dtpDatumOtvaranja);
        }
    }
}

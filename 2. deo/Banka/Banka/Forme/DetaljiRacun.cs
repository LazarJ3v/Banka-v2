using Banka.Entiteti;
using Banka.Enumi;
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
    public partial class DetaljiRacun : BaseForm
    {
        public DetaljiRacun() : base()
        {
            InitializeComponent();
            StilizujGroupBox(
                gbDevizniInformacije,
                gbOsnovneInformacije,
                gbStedniInformacije,
                gbTekuciInformacije,
                gbZiroInformacije);
            StilizujLabelHeader(
                lblBonusi,
                lblBrojRacuna,
                lblDatumOtvaranja,
                lblDozvoljeniMinus,
                lblElektronskoBankarstvo,
                lblElektronskoBankarstvo,
                lblFrekvKapitalizKamate,
                lblIntegracijaSaSistemima,
                lblKamatnaStopa,
                lblKomentar,
                lblKursnaRazlika,
                lblLimitZaMasovnaPlacanja,
                lblMesecniLimit,
                lblMinimalniIznosOtvaranja,
                lblNamenaDevizni,
                lblNamenaZiro,
                lblOgranicenja,
                lblPaketi,
                lblPlatnaKartica,
                lblStatus,
                lblTipRacuna,
                lblTrenutnoStanje,
                lblUsloviPodizanja,
                lblValuta,
                lblValute);
            StilizujLabel(
                lblBonusiVrednost,
                lblBrojRacunaVrednost,
                lblDatumOtvaranjaVrednost,
                lblDozvoljeniMinusVrednost,
                lblElektronskoBankarstvoVrednost,
                lblElektronskoBankarstvoVrednost,
                lblFrekvKapitalizKamateVrednost,
                lblIntegracijaSaSistemimaVrednost,
                lblKamatnaStopaVrednost,
                lblKomentarVrednost,
                lblKursnaRazlikaVrednost,
                lblLimitZaMasovnaPlacanjaVrednost,
                lblMesecniLimitVrednost,
                lblMinimalniIznosOtvaranjaVrednost,
                lblNamenaDevizniVrednost,
                lblNamenaZiroVrednost,
                lblOgranicenjaVrednost,
                lblPaketiVrednost,
                lblPlatnaKarticaVrednost,
                lblStatusVrednost,
                lblTipRacunaVrednost,
                lblTrenutnoStanjeVrednost,
                lblUsloviPodizanjaVrednost,
                lblValutaVrednost,
                lblValuteVrednost);
        }

        public void PodesiPrikaz(TipRacuna tip)
        {
            switch (tip)
            {
                case TipRacuna.Ziro:
                    gbZiroInformacije.Visible = true;
                    gbDevizniInformacije.Visible = false;
                    gbStedniInformacije.Visible = false;
                    gbTekuciInformacije.Visible = false;
                    break;

                case TipRacuna.Devizni:
                    gbDevizniInformacije.Visible = true;
                    gbZiroInformacije.Visible = false;
                    gbTekuciInformacije.Visible = false;
                    gbStedniInformacije.Visible = false;
                    break;
                case TipRacuna.Stedni:
                    gbStedniInformacije.Visible = true;
                    gbTekuciInformacije.Visible = false;
                    gbZiroInformacije.Visible = false;
                    gbDevizniInformacije.Visible = false;
                    break;
                case TipRacuna.Tekuci:
                    gbTekuciInformacije.Visible = true;
                    gbDevizniInformacije.Visible = false;
                    gbZiroInformacije.Visible = false;
                    gbStedniInformacije.Visible = false;
                    break;
            }
        }
    }
}

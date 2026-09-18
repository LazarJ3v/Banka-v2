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

        private RacunBasic racun = null;
        private TekuciBasic tekuci = null;
        private DevizniBasic devizni = null;
        private StedniBasic stedni = null;
        private ZiroBasic ziro = null;
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

        public DetaljiRacun(RacunBasic _racun) : this()
        {
            racun = _racun;
        }

        public DetaljiRacun(TekuciBasic _tekuci) : this()
        {
            tekuci = _tekuci;
        }

        public DetaljiRacun(DevizniBasic _devizni) : this()
        {
            devizni = _devizni;
        }

        public DetaljiRacun(StedniBasic _stedni) : this()
        {
            stedni = _stedni;
        }

        public DetaljiRacun(ZiroBasic _ziro) : this()
        {
            ziro = _ziro;
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
                default:
                    gbTekuciInformacije.Visible = false;
                    gbDevizniInformacije.Visible = false;
                    gbZiroInformacije.Visible = false;
                    gbStedniInformacije.Visible = false;
                    break;
            }
        }

        private void DetaljiRacun_Load(object sender, EventArgs e)
        {
            if(racun != null)
            {
                lblBrojRacunaVrednost.Text = racun.BrojRacuna;
                lblValutaVrednost.Text = racun.Valuta;
                lblTrenutnoStanjeVrednost.Text = racun.TrenutnoStanje.ToString();
                lblDatumOtvaranjaVrednost.Text = racun.DatumOtvaranja.ToString();
                lblStatusVrednost.Text = racun.Status;
                lblDozvoljeniMinusVrednost.Text = racun.DozvoljeniMinus.ToString();
                lblKamatnaStopaVrednost.Text = racun.KamatnaStopa.ToString();
                lblTipRacunaVrednost.Text = racun.TipRacuna;
                lblKomentarVrednost.Text = racun.Komentar;
            }
            else if(tekuci != null)
            {
                lblBrojRacunaVrednost.Text = tekuci.BrojRacuna;
                lblValutaVrednost.Text = tekuci.Valuta;
                lblTrenutnoStanjeVrednost.Text = tekuci.TrenutnoStanje.ToString();
                lblDatumOtvaranjaVrednost.Text = tekuci.DatumOtvaranja.ToString();
                lblStatusVrednost.Text = tekuci.Status;
                lblDozvoljeniMinusVrednost.Text = tekuci.DozvoljeniMinus.ToString();
                lblKamatnaStopaVrednost.Text = tekuci.KamatnaStopa.ToString();
                lblTipRacunaVrednost.Text = tekuci.TipRacuna;
                lblKomentarVrednost.Text = tekuci.Komentar;

                lblPlatnaKarticaVrednost.Text = tekuci.PlatnaKartica == true ? "Da" : "Ne";
                lblMesecniLimitVrednost.Text = tekuci.MesecniLimit.ToString();
                string paketi = "";
                foreach(TekuciPaketBasic paket in tekuci.TekuciPaketi)
                {
                    paketi.Concat(paket.Paket.ToString() + ", ");
                }
                lblPaketiVrednost.Text = paketi;
            }
            else if(devizni != null)
            {
                lblBrojRacunaVrednost.Text = devizni.BrojRacuna;
                lblValutaVrednost.Text = devizni.Valuta;
                lblTrenutnoStanjeVrednost.Text = devizni.TrenutnoStanje.ToString();
                lblDatumOtvaranjaVrednost.Text = devizni.DatumOtvaranja.ToString();
                lblStatusVrednost.Text = devizni.Status;
                lblDozvoljeniMinusVrednost.Text = devizni.DozvoljeniMinus.ToString();
                lblKamatnaStopaVrednost.Text = devizni.KamatnaStopa.ToString();
                lblTipRacunaVrednost.Text = devizni.TipRacuna;
                lblKomentarVrednost.Text = devizni.Komentar;

                lblNamenaDevizniVrednost.Text = devizni.Namena;
                lblKursnaRazlikaVrednost.Text = devizni.KursnaRazlika.ToString();

                string ogranicenja = "";
                foreach(DevizniOgranicenjeBasic ogranicenje in devizni.DevizniOgranicenja)
                {
                    ogranicenja.Concat(ogranicenje.Ogranicenje.ToString() + ", ");
                }
                lblOgranicenjaVrednost.Text = ogranicenja;

                string valute = "";
                foreach(DevizniValutaBasic valuta in devizni.DevizniValute)
                {
                    valute.Concat(valuta.DozvoljenaValuta.ToString() + ", ");
                }
                lblValuteVrednost.Text = valute;
            }
            else if(stedni != null)
            {
                lblBrojRacunaVrednost.Text = stedni.BrojRacuna;
                lblValutaVrednost.Text = stedni.Valuta;
                lblTrenutnoStanjeVrednost.Text = stedni.TrenutnoStanje.ToString();
                lblDatumOtvaranjaVrednost.Text = stedni.DatumOtvaranja.ToString();
                lblStatusVrednost.Text = stedni.Status;
                lblDozvoljeniMinusVrednost.Text = stedni.DozvoljeniMinus.ToString();
                lblKamatnaStopaVrednost.Text = stedni.KamatnaStopa.ToString();
                lblTipRacunaVrednost.Text = stedni.TipRacuna;
                lblKomentarVrednost.Text = stedni.Komentar;

                lblMinimalniIznosOtvaranjaVrednost.Text = stedni.MinimalniIznosOtvaranja.ToString();
                lblFrekvKapitalizKamateVrednost.Text = stedni.FrekvKapitalizKamate.ToString();
                
                string bonusi = "";
                foreach(StedniBonusBasic bonus in stedni.StedniBonusi)
                {
                    bonusi.Concat(bonus.Bonus.ToString() + ", ");
                }
                lblBonusiVrednost.Text = bonusi;

                string uslovi = "";
                foreach(StedniUsloviPodizanjaBasic uslov in stedni.StedniUsloviPodizanja)
                {
                    uslovi.Concat(uslov.UslovPodizanja.ToString() + ", ");
                }
                lblUsloviPodizanjaVrednost.Text = uslovi;
            }
            else if(ziro != null)
            {
                lblBrojRacunaVrednost.Text = ziro.BrojRacuna;
                lblValutaVrednost.Text = ziro.Valuta;
                lblTrenutnoStanjeVrednost.Text = ziro.TrenutnoStanje.ToString();
                lblDatumOtvaranjaVrednost.Text = ziro.DatumOtvaranja.ToString();
                lblStatusVrednost.Text = ziro.Status;
                lblDozvoljeniMinusVrednost.Text = ziro.DozvoljeniMinus.ToString();
                lblKamatnaStopaVrednost.Text = ziro.KamatnaStopa.ToString();
                lblTipRacunaVrednost.Text = ziro.TipRacuna;
                lblKomentarVrednost.Text = ziro.Komentar;

                lblNamenaZiroVrednost.Text = ziro.Namena;
                lblElektronskoBankarstvoVrednost.Text = ziro.ElektronskoBankarstvo == true ? "Da" : "Ne";
                lblLimitZaMasovnaPlacanjaVrednost.Text = ziro.LimitZaMasovnaPlacanja.ToString();
                lblIntegracijaSaSistemimaVrednost.Text = ziro.IntegracijaSaSistemima;
            }
        }
    }
}

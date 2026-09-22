using Banka.Entiteti;
using Banka.Enumi;
using FluentNHibernate.Mapping;
using NHibernate.Engine;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Banka.Forme
{
    public partial class IzmeniRacun : BaseForm
    {
        private TekuciBasic tekuci = null;
        private DevizniBasic devizni = null;
        private StedniBasic stedni = null;
        private ZiroBasic ziro = null;
        private RacunBasic racun = null;

        private TipRacuna tip;
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

            StilizujNumericUpDown(
                nudDozvoljeniMinus,
                nudKamatnaStopa,
                nudKursnaRazlika,
                nudLimitZaMasovnaPlacanja,
                nudMesecniLimit,
                nudMinimalniIznosOtvaranja,
                nudTrenutnoStanje);

            StilizujDataGridView(
                dgvBonusi,
                dgvOgranicenja,
                dgvPaketi,
                dgvUsloviPodizanja,
                dgvValute);

            StilizujDateTimePicker(dtpDatumOtvaranja);
            StilizujCheckBox(chbElektronskoBankarstvo, chbPlatnaKartica);
            StilizujRichTextBox(rtbIntegracijaSaSistemima, rtbKomentar);

            #region NumericUpDown podesavanje

            // TrenutnoStanje
            nudTrenutnoStanje.DecimalPlaces = 2;
            nudTrenutnoStanje.Minimum = 0;
            nudTrenutnoStanje.Maximum = 1000000000;
            nudTrenutnoStanje.Increment = 100;

            // DozvoljeniMinus
            nudDozvoljeniMinus.DecimalPlaces = 2;
            nudDozvoljeniMinus.Minimum = 0;
            nudDozvoljeniMinus.Maximum = 500000;
            nudDozvoljeniMinus.Increment = 1000;

            // KamatnaStopa
            nudKamatnaStopa.DecimalPlaces = 2;
            nudKamatnaStopa.Minimum = 0;
            nudKamatnaStopa.Maximum = 100;
            nudKamatnaStopa.Increment = 0.1m;

            // MesecniLimit
            nudMesecniLimit.DecimalPlaces = 2;
            nudMesecniLimit.Minimum = 0;
            nudMesecniLimit.Maximum = 1000000;
            nudMesecniLimit.Increment = 500;

            // MinIznosOtvaranja
            nudMinimalniIznosOtvaranja.DecimalPlaces = 2;
            nudMinimalniIznosOtvaranja.Minimum = 0;
            nudMinimalniIznosOtvaranja.Maximum = 1000000;
            nudMinimalniIznosOtvaranja.Increment = 100;

            // LimitZaMasPlacanja
            nudLimitZaMasovnaPlacanja.DecimalPlaces = 2;
            nudLimitZaMasovnaPlacanja.Minimum = 0;
            nudLimitZaMasovnaPlacanja.Maximum = 5000000;
            nudLimitZaMasovnaPlacanja.Increment = 1000;

            nudKursnaRazlika.DecimalPlaces = 2;
            nudKursnaRazlika.Minimum = 0;
            nudKursnaRazlika.Maximum = 100;
            nudKursnaRazlika.Increment = 0.01m;

            #endregion
        }

        public IzmeniRacun(TekuciBasic tekuci) : this()
        {
            this.tekuci = tekuci;
            tip = TipRacuna.Tekuci;
            PopuniZajednickaPolja(tekuci);
            PopuniTekuci(tekuci);
            PodesiPrikaz();
        }

        public IzmeniRacun(DevizniBasic devizni) : this()
        {
            this.devizni = devizni;
            tip = TipRacuna.Devizni;
            PopuniZajednickaPolja(devizni);
            PopuniDevizni(devizni);
            PodesiPrikaz();
        }

        public IzmeniRacun(StedniBasic stedni) : this()
        {
            this.stedni = stedni;
            tip = TipRacuna.Stedni;
            PopuniZajednickaPolja(stedni);
            PopuniStedni(stedni);
            PodesiPrikaz();
        }

        public IzmeniRacun(ZiroBasic ziro) : this()
        {
            this.ziro = ziro;
            tip = TipRacuna.Ziro;
            PopuniZajednickaPolja(ziro);
            PopuniZiro(ziro);
            PodesiPrikaz();
        }

        public IzmeniRacun(RacunBasic racun) : this()
        {
            this.racun = racun;
            tip = TipRacuna.Ostali;
            PopuniZajednickaPolja(racun);
            PodesiPrikaz();
        }

        private void PopuniZajednickaPolja(RacunBasic r)
        {
            tbBrojRacuna.Text = r.BrojRacuna;
            tbBrojRacuna.ReadOnly = true; // broj računa se ne menja

            cbValuta.Items.Clear();
            foreach (RacunValuta valuta in Enum.GetValues(typeof(RacunValuta)))
            {
                cbValuta.Items.Add(valuta.ToString());
            }
            cbValuta.SelectedIndex = cbValuta.Items.IndexOf(r.Valuta);

            nudTrenutnoStanje.Value = r.TrenutnoStanje;
            dtpDatumOtvaranja.Value = r.DatumOtvaranja;

            cbStatus.Items.Clear();
            foreach (StatusRacuna status in Enum.GetValues(typeof(StatusRacuna)))
            {
                cbStatus.Items.Add(status.ToString());
            }
            cbStatus.SelectedIndex = cbStatus.Items.IndexOf(r.Status);

            nudDozvoljeniMinus.Value = r.DozvoljeniMinus;
            nudKamatnaStopa.Value = r.KamatnaStopa ?? 0;
            rtbKomentar.Text = r.Komentar;
        }

        private void PopuniTekuci(TekuciBasic t)
        {
            chbPlatnaKartica.Checked = t.PlatnaKartica;
            nudMesecniLimit.Value = t.MesecniLimit ?? 0;

            var prikazPaketi = t.TekuciPaketi.Select(x => new
            {
                Paketi = x.Paket
            }).ToList();

            dgvPaketi.DataSource = prikazPaketi;
        }

        private void PopuniDevizni(DevizniBasic d)
        {
            cbNamenaDevizni.Items.Clear();
            foreach (DevizniNamena namena in Enum.GetValues(typeof(DevizniNamena)))
            {
                cbNamenaDevizni.Items.Add(namena.GetDescription());
            }
            cbNamenaDevizni.SelectedItem = cbNamenaDevizni.Items[cbNamenaDevizni.Items.IndexOf(d.Namena)];

            nudKursnaRazlika.Value = d.KursnaRazlika ?? 0;

            var prikazOgranicenja = d.DevizniOgranicenja.Select(x => new
            {
                Ogranicenja = x.Ogranicenje
            }).ToList();

            dgvOgranicenja.DataSource = prikazOgranicenja;

            var prikazValute = d.DevizniValute.Select(x => new
            {
                Valute = x.DozvoljenaValuta
            }).ToList();

            dgvValute.DataSource = prikazValute;
        }

        private void PopuniStedni(StedniBasic s)
        {
            nudMinimalniIznosOtvaranja.Value = s.MinimalniIznosOtvaranja ?? 0;

            cbFrekvKapitalizacijaKamate.DrawMode = DrawMode.Normal;
            cbFrekvKapitalizacijaKamate.DataSource =
                Enum.GetValues(typeof(FrekvencijaKapitalizacijeKamate))
                .Cast<FrekvencijaKapitalizacijeKamate>()
                .Select(x => new
                {
                    Value = (int)x,
                    Description = x.GetDescription()
                }).ToList();

            cbFrekvKapitalizacijaKamate.DisplayMember = "Description";
            cbFrekvKapitalizacijaKamate.ValueMember = "Value";
            cbFrekvKapitalizacijaKamate.SelectedIndex = 0;

            var prikazBonusi = s.StedniBonusi.Select(x => new
            {
                Bonusi = x.Bonus
            }).ToList();

            dgvBonusi.DataSource = prikazBonusi;

            var prikazUsloviPodizanja = s.StedniUsloviPodizanja.Select(x => new
            {
                Uzlovi = x.UslovPodizanja
            }).ToList();

            // TODO: izmeniti header text
            dgvUsloviPodizanja.DataSource = prikazUsloviPodizanja;
        }

        private void PopuniZiro(ZiroBasic z)
        {
            tbNamenaZiro.Text = z.Namena;
            chbElektronskoBankarstvo.Checked = z.ElektronskoBankarstvo;
            nudLimitZaMasovnaPlacanja.Value = z.LimitZaMasovnaPlacanja ?? 0;
            rtbIntegracijaSaSistemima.Text = z.IntegracijaSaSistemima;
        }

        private void PodesiPrikaz()
        {
            // prvo sakrij sve specifične grupe
            gbTekuciInformacije.Visible = false;
            gbDevizniInformacije.Visible = false;
            gbStedniInformacije.Visible = false;
            gbZiroInformacije.Visible = false;

            switch (tip)
            {
                case TipRacuna.Tekuci:
                    gbTekuciInformacije.Visible = true;
                    break;
                case TipRacuna.Devizni:
                    gbDevizniInformacije.Visible = true;
                    break;
                case TipRacuna.Stedni:
                    gbStedniInformacije.Visible = true;
                    break;
                case TipRacuna.Ziro:
                    gbZiroInformacije.Visible = true;
                    break;
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            switch(tip)
            {
                case TipRacuna.Tekuci:
                    var tekuci = new TekuciBasic
                    {
                        Id = this.tekuci.Id,
                        BrojRacuna = tbBrojRacuna.Text,
                        Valuta = cbValuta.Text,
                        TrenutnoStanje = nudTrenutnoStanje.Value,
                        DatumOtvaranja = dtpDatumOtvaranja.Value,
                        Status = cbStatus.Text,
                        DozvoljeniMinus = nudDozvoljeniMinus.Value,
                        Komentar = rtbKomentar.Text,

                        PlatnaKartica = chbPlatnaKartica.Checked,
                        MesecniLimit = nudMesecniLimit.Value
                    };

                    DTOManager.IzmeniTekuci(tekuci);
                    break;
                case TipRacuna.Devizni:
                    var devizni = new DevizniBasic
                    {
                        Id = this.devizni.Id,
                        BrojRacuna = tbBrojRacuna.Text,
                        Valuta = cbValuta.Text,
                        TrenutnoStanje = nudTrenutnoStanje.Value,
                        DatumOtvaranja = dtpDatumOtvaranja.Value,
                        Status = cbStatus.Text,
                        DozvoljeniMinus = nudDozvoljeniMinus.Value,
                        Komentar = rtbKomentar.Text,

                        Namena = cbNamenaDevizni.Text,
                        KursnaRazlika = nudKursnaRazlika.Value
                    };

                    DTOManager.IzmeniDevizni(devizni);
                    break;
                case TipRacuna.Stedni:
                    var stedni = new StedniBasic
                    {
                        Id = this.stedni.Id,
                        BrojRacuna = tbBrojRacuna.Text,
                        Valuta = cbValuta.Text,
                        TrenutnoStanje = nudTrenutnoStanje.Value,
                        DatumOtvaranja = dtpDatumOtvaranja.Value,
                        Status = cbStatus.Text,
                        DozvoljeniMinus = nudDozvoljeniMinus.Value,
                        Komentar = rtbKomentar.Text,

                        MinimalniIznosOtvaranja = nudMinimalniIznosOtvaranja.Value,
                        FrekvKapitalizKamate = (int)cbFrekvKapitalizacijaKamate.SelectedValue
                    };

                    DTOManager.IzmeniStedni(stedni);
                    break;
                case TipRacuna.Ziro:
                    var ziro = new ZiroBasic
                    {
                        Id = this.ziro.Id,
                        BrojRacuna = tbBrojRacuna.Text,
                        Valuta = cbValuta.Text,
                        TrenutnoStanje = nudTrenutnoStanje.Value,
                        DatumOtvaranja = dtpDatumOtvaranja.Value,
                        Status = cbStatus.Text,
                        DozvoljeniMinus = nudDozvoljeniMinus.Value,
                        Komentar = rtbKomentar.Text,

                        Namena = tbNamenaZiro.Text,
                        ElektronskoBankarstvo = chbElektronskoBankarstvo.Checked,
                        LimitZaMasovnaPlacanja = nudLimitZaMasovnaPlacanja.Value,
                        IntegracijaSaSistemima = rtbIntegracijaSaSistemima.Text
                    };

                    DTOManager.IzmeniZiro(ziro);
                    break;
                default:
                    var racun = new RacunBasic
                    {
                        Id = this.racun.Id,
                        BrojRacuna = tbBrojRacuna.Text,
                        Valuta = cbValuta.Text,
                        TrenutnoStanje = nudTrenutnoStanje.Value,
                        DatumOtvaranja = dtpDatumOtvaranja.Value,
                        Status = cbStatus.Text,
                        DozvoljeniMinus = nudDozvoljeniMinus.Value,
                        Komentar = rtbKomentar.Text,
                    };

                    //DTOManager.IzmeniRacun(racun);
                    break;
            }
            MessageBox.Show(
                        "Racun uspešno izmenjen!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banka.Forme
{
    public partial class DodajRacun : BaseForm
    {
        private IList<TekuciPaketBasic> tekuciPaketi;

        private IList<DevizniOgranicenjeBasic> devizniOgranicenja;
        private IList<DevizniValutaBasic> devizniValute;

        private IList<StedniUsloviPodizanjaBasic> stedniUsloviPodizanja;
        private IList<StedniBonusBasic> stedniBonusi;

        private List<DevizniValuta> sveValute = Enum.GetValues(typeof(DevizniValuta)).Cast<DevizniValuta>().ToList();
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
                tbJmbg,
                tbNamena,
                tbPaket,
                tbPib,
                tbOgranicenje,
                tbBonus,
                tbUslovPodizanja);
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
                cbValuta,
                cbFrekvKapitalizKamate,
                cbNamenaDevizni);
            StilizujNumericUpDown(
                nudTrenutnoStanje,
                nudDozvoljeniMinus,
                nudKamatnaStopa,
                nudMesecniLimit,
                nudMinIznosOtvaranja,
                nudLimitZaMasPlacanja,
                nudKursnaRazlika);
        }

        private void DodajRacun_Load(object sender, EventArgs e)
        {
            tekuciPaketi = new BindingList<TekuciPaketBasic>();
            devizniOgranicenja = new BindingList<DevizniOgranicenjeBasic>();
            devizniValute = new BindingList<DevizniValutaBasic>();
            stedniUsloviPodizanja = new BindingList<StedniUsloviPodizanjaBasic>();
            stedniBonusi = new BindingList<StedniBonusBasic>();

            cbValuta.DataSource = new List<DevizniValuta>(sveValute);

            OsveziDodajValutu();

            #region Dinamicki select

            dgvPaketi.AllowUserToAddRows = false;
            dgvPaketi.ReadOnly = true;
            dgvPaketi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaketi.MultiSelect = false;

            // 1. KLIK NA RED - selektuje
            dgvPaketi.CellClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0 && ev.RowIndex < dgvPaketi.Rows.Count)
                {
                    dgvPaketi.Rows[ev.RowIndex].Selected = true;
                }
            };

            // 2. KLIK NA PRAZAN PROSTOR U DGV - odselektuje
            dgvPaketi.MouseDown += (s, ev) =>
            {
                DataGridView.HitTestInfo hit = dgvPaketi.HitTest(ev.X, ev.Y);
                if (hit.RowIndex == -1)
                {
                    dgvPaketi.ClearSelection();
                }
            };

            // 3. KLIK NA FORMU - odselektuje
            this.MouseClick += (s, ev) =>
            {
                dgvPaketi.ClearSelection();
            };

            // 4. KLIK NA GROUPBOX - odselektuje
            gbTekuci.MouseClick += (s, ev) =>
            {
                dgvPaketi.ClearSelection();
            };

            #endregion

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
            nudMinIznosOtvaranja.DecimalPlaces = 2;
            nudMinIznosOtvaranja.Minimum = 0;
            nudMinIznosOtvaranja.Maximum = 1000000;
            nudMinIznosOtvaranja.Increment = 100;

            // LimitZaMasPlacanja
            nudLimitZaMasPlacanja.DecimalPlaces = 2;
            nudLimitZaMasPlacanja.Minimum = 0;
            nudLimitZaMasPlacanja.Maximum = 5000000;
            nudLimitZaMasPlacanja.Increment = 1000;

            nudKursnaRazlika.DecimalPlaces = 2;
            nudKursnaRazlika.Minimum = 0;
            nudKursnaRazlika.Maximum = 100;
            nudKursnaRazlika.Increment = 0.01m;

            #endregion

            foreach (DevizniNamena namena in Enum.GetValues(typeof(DevizniNamena)))
            {
                cbNamenaDevizni.Items.Add(namena.GetDescription());
            }
            cbNamenaDevizni.SelectedItem = cbNamenaDevizni.Items[0];

            var frekvencijeIzbor = new Dictionary<string, int>
            {
                { "Dnevno", (int)FrekvencijaKapitalizacijeKamate.Dnevno },
                { "Mesečno", (int)FrekvencijaKapitalizacijeKamate.Mesecno },
                { "Kvartalno", (int)FrekvencijaKapitalizacijeKamate.Kvartalno },
                { "Polugodišnje", (int)FrekvencijaKapitalizacijeKamate.Polugodisnje },
                { "Godišnje", (int)FrekvencijaKapitalizacijeKamate.Godisnje }
            };

            cbFrekvKapitalizKamate.DataSource = new BindingSource(frekvencijeIzbor, null);
            cbFrekvKapitalizKamate.DisplayMember = "Key";
            cbFrekvKapitalizKamate.ValueMember = "Value";

            dgvPaketi.ClearSelection();

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

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (rbTekuci.Checked)
            {
                TekuciBasic dto = new TekuciBasic
                {
                    BrojRacuna = tbBrojRacuna.Text,
                    Valuta = cbValuta.Text,
                    TrenutnoStanje = nudTrenutnoStanje.Value,
                    DatumOtvaranja = DateTime.Now,
                    Status = StatusRacuna.Aktivan.GetDescription(),
                    DozvoljeniMinus = nudDozvoljeniMinus.Value,
                    Komentar = rtbKomentar.Text,
                    TipRacuna = TipRacuna.Tekuci.GetDescription(),
                    KamatnaStopa = nudKamatnaStopa.Value,
                    

                    PlatnaKartica = cbPlatnaKartica.Checked,
                    MesecniLimit = nudMesecniLimit.Value,
                    TekuciPaketi = tekuciPaketi
                };

                DTOManager.DodajTekuci(dto, tbJmbg.Text, tbPib.Text);
                MessageBox.Show("Tekući račun uspešno dodat!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (rbDevizni.Checked)
            {
                DevizniBasic dto = new DevizniBasic
                {
                    BrojRacuna = tbBrojRacuna.Text,
                    Valuta = cbValuta.Text,
                    TrenutnoStanje = nudTrenutnoStanje.Value,
                    DatumOtvaranja = DateTime.Now,
                    Status = StatusRacuna.Aktivan.GetDescription(),
                    DozvoljeniMinus = nudMesecniLimit.Value,
                    Komentar = rtbKomentar.Text,
                    TipRacuna = TipRacuna.Devizni.GetDescription(),
                    KamatnaStopa = nudKamatnaStopa.Value,

                    Namena = cbNamenaDevizni.Text,
                    KursnaRazlika = nudKursnaRazlika.Value,
                    DevizniOgranicenja = devizniOgranicenja,
                    DevizniValute = devizniValute
                };

                DTOManager.DodajDevizni(dto, tbJmbg.Text, tbPib.Text);
                MessageBox.Show("Devizni račun uspešno dodat!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (rbStedni.Checked)
            {
                StedniBasic dto = new StedniBasic
                {
                    BrojRacuna = tbBrojRacuna.Text,
                    Valuta = cbValuta.Text,
                    TrenutnoStanje = nudTrenutnoStanje.Value,
                    DatumOtvaranja = DateTime.Now,
                    Status = StatusRacuna.Aktivan.GetDescription(),
                    DozvoljeniMinus = nudDozvoljeniMinus.Value,
                    Komentar = rtbKomentar.Text,
                    TipRacuna = TipRacuna.Devizni.GetDescription(),
                    KamatnaStopa = nudKamatnaStopa.Value,

                    MinimalniIznosOtvaranja = nudMinIznosOtvaranja.Value,
                    FrekvKapitalizKamate = (int)cbFrekvKapitalizKamate.SelectedValue,
                    StedniBonusi = stedniBonusi,
                    StedniUsloviPodizanja = stedniUsloviPodizanja
                };

                DTOManager.DodajStedni(dto, tbJmbg.Text, tbPib.Text);
                MessageBox.Show("Štedni račun uspešno dodat!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (rbZiro.Checked)
            {
                ZiroBasic dto = new ZiroBasic
                {
                    BrojRacuna = tbBrojRacuna.Text,
                    Valuta = cbValuta.Text,
                    TrenutnoStanje = nudTrenutnoStanje.Value,
                    DatumOtvaranja = DateTime.Now,
                    Status = StatusRacuna.Aktivan.GetDescription(),
                    DozvoljeniMinus = nudDozvoljeniMinus.Value,
                    Komentar = rtbKomentar.Text,
                    TipRacuna = TipRacuna.Ziro.GetDescription(),
                    KamatnaStopa = nudKamatnaStopa.Value,

                    Namena = tbNamena.Text,
                    ElektronskoBankarstvo = cbElektronskoBankarstvo.Checked,
                    LimitZaMasovnaPlacanja = nudLimitZaMasPlacanja.Value,
                    IntegracijaSaSistemima = rtbIntegracijaSaSistemima.Text
                };

                DTOManager.DodajZiro(dto, tbJmbg.Text, tbPib.Text);
                MessageBox.Show("Žiro račun uspešno dodat!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {

            }
        }

        private void btnDodajPaket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPaket.Text))
            {
                MessageBox.Show("Unesite naziv paketa!");
                return;
            }

            TekuciPaketBasic tpb = new TekuciPaketBasic
            {
                Paket = tbPaket.Text
            };
            tekuciPaketi.Add(tpb);

            var prikaz = tekuciPaketi.Select(tp => new { Paket = tp.Paket }).ToList();
            dgvPaketi.DataSource = prikaz;

            tbPaket.Clear();
        }

        private void btnObrisiPaket_Click(object sender, EventArgs e)
        {
            if (dgvPaketi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            int index = dgvPaketi.SelectedRows[0].Index;
            TekuciPaketBasic dto = tekuciPaketi[index];
            tekuciPaketi.Remove(dto);

            var prikaz = tekuciPaketi.Select(tp => new { Paket = tp.Paket }).ToList();
            dgvPaketi.DataSource = prikaz;
        }

        private void btnDodajOgranicenje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOgranicenje.Text))
            {
                MessageBox.Show("Unesite naziv ogranicenja!");
                return;
            }

            DevizniOgranicenjeBasic dob = new DevizniOgranicenjeBasic
            {
                Ogranicenje = tbOgranicenje.Text
            };
            devizniOgranicenja.Add(dob);

            var prikaz = devizniOgranicenja.Select(o => new { Ogranicenje = o.Ogranicenje }).ToList();
            dgvOgranicenja.DataSource = prikaz;

            tbOgranicenje.Clear();
        }

        private void btnObrisiOgranicenje_Click(object sender, EventArgs e)
        {
            if (dgvOgranicenja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            int index = dgvOgranicenja.SelectedRows[0].Index;
            DevizniOgranicenjeBasic dto = devizniOgranicenja[index];
            devizniOgranicenja.Remove(dto);

            var prikaz = devizniOgranicenja.Select(o => new { Ogranicenje = o.Ogranicenje }).ToList();
            dgvOgranicenja.DataSource = prikaz;
        }

        private void btnDodajValutu_Click(object sender, EventArgs e)
        {
            DevizniValutaBasic dvb = new DevizniValutaBasic
            {
                DozvoljenaValuta = cbDodajValutu.Text
            };
            //TODO: ispitati da selektovana valuta (dvb) vec ne postoji u devizniValuta
            devizniValute.Add(dvb);

            var prikaz = devizniValute.Select(v => new { Valuta = v.DozvoljenaValuta }).ToList();
            dgvValute.DataSource = prikaz;
        }

        private void btnObrisiValutu_Click(object sender, EventArgs e)
        {
            if (dgvValute.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            int index = dgvValute.SelectedRows[0].Index;
            DevizniValutaBasic dto = devizniValute[index];
            devizniValute.Remove(dto);

            var prikaz = devizniValute.Select(v => new { Valuta = v.DozvoljenaValuta }).ToList();
            dgvValute.DataSource = prikaz;
        }

        private void cbValuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsveziDodajValutu();
        }

        private void OsveziDodajValutu()
        {
            if (cbValuta.SelectedItem == null)
                return;

            DevizniValuta izabranaValuta = (DevizniValuta)cbValuta.SelectedItem;

            var preostaleValute = sveValute
                .Where(v => v != izabranaValuta)
                .ToList();

            cbDodajValutu.DataSource = preostaleValute;
        }
    }
}

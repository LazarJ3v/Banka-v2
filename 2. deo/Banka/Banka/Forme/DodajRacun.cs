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
    public partial class DodajRacun : BaseForm
    {
        private IList<TekuciPaketBasic> tekuciPaketi;
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
            tekuciPaketi = new BindingList<TekuciPaketBasic>();

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
                    TrenutnoStanje = 0, // TODO: izmeniti formu iz tb u numeric up down
                    DatumOtvaranja = DateTime.Now,
                    Status = StatusRacuna.Aktivan.ToString(),
                    DozvoljeniMinus = 0, // TODO: izmeniti formu iz tb u numeric up down
                    Komentar = rtbKomentar.Text,
                    TipRacuna = TipRacuna.Tekuci.ToString(),
                    KamatnaStopa = 0, // TODO: izmeniti formu iz tb u numeric up down
                    

                    PlatnaKartica = cbPlatnaKartica.Checked,
                    MesecniLimit = 0, // TODO: izmeniti formu iz tb u numeric up down
                    TekuciPaketi = tekuciPaketi
                };

                DTOManager.DodajTekuci(dto, tbJmbg.Text, tbPib.Text);
                MessageBox.Show("Tekući račun uspešno dodat!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (rbDevizni.Checked)
            {

            }
            else if (rbStedni.Checked)
            {

            }
            else if (rbZiro.Checked)
            {

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
    }
}

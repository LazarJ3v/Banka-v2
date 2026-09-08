using Banka.Forme;
using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Banka.Forme
{
    public partial class KlijentiPregled : BaseForm
    {
        private List<FizickoLiceBasic> svaFizickaLica;
        private List<PravnoLiceBasic> svaPravnaLica;
        public KlijentiPregled() : base()
        {
            InitializeComponent();
            StilizujGroupBox(
                gbFizickaLica,
                gbPravnaLica,
                gbPretraga);
            StilizujDataGridView(
                dgvFizickaLica,
                dgvPravnaLica);
            StilizujTextBox(
                tbEmail);
            StilizujComboBox(
                cbTipKlijenta,
                cbStatusKlijenta);
            StilizujLabel(
                lblEmail,
                lblTipKlijenta,
                lblStatusKlijenta,
                lblBrojKlijenata,
                lblBroj);
            StilizujButton(
                btnPretrazi,
                btnDodaj,
                btnIzmeni,
                btnObrisi);
        }

        private void KlijentiPregled_Load(object sender, EventArgs e)
        {
            #region Dinamicki select

            dgvFizickaLica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPravnaLica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFizickaLica.MultiSelect = false;
            dgvPravnaLica.MultiSelect = false;

            dgvFizickaLica.CellClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0 && ev.RowIndex < dgvFizickaLica.Rows.Count - 1)
                {
                    dgvFizickaLica.Rows[ev.RowIndex].Selected = true;
                    dgvPravnaLica.ClearSelection();
                }
            };

            dgvPravnaLica.CellClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0 && ev.RowIndex < dgvPravnaLica.Rows.Count - 1)
                {
                    dgvPravnaLica.Rows[ev.RowIndex].Selected = true;
                    dgvFizickaLica.ClearSelection();
                }
            };

            // 2. KLIK NA PRAZAN PROSTOR U DGV - odselektuje
            dgvFizickaLica.MouseDown += (s, ev) =>
            {
                DataGridView.HitTestInfo hit = dgvFizickaLica.HitTest(ev.X, ev.Y);
                if (hit.RowIndex == -1 || hit.RowIndex >= dgvFizickaLica.Rows.Count - 1)
                {
                    dgvFizickaLica.ClearSelection();
                    dgvPravnaLica.ClearSelection();
                }
            };

            dgvPravnaLica.MouseDown += (s, ev) =>
            {
                DataGridView.HitTestInfo hit = dgvPravnaLica.HitTest(ev.X, ev.Y);
                if (hit.RowIndex == -1 || hit.RowIndex >= dgvPravnaLica.Rows.Count - 1)
                {
                    dgvPravnaLica.ClearSelection();
                    dgvFizickaLica.ClearSelection();
                }
            };

            // 3. KLIK NA FORMU - odselektuje
            this.MouseClick += (s, ev) =>
            {
                dgvFizickaLica.ClearSelection();
                dgvPravnaLica.ClearSelection();
            };

            // 4. KLIK NA GROUPBOX - odselektuje
            gbFizickaLica.MouseClick += (s, ev) =>
            {
                dgvFizickaLica.ClearSelection();
                dgvPravnaLica.ClearSelection();
            };

            gbPravnaLica.MouseClick += (s, ev) =>
            {
                dgvFizickaLica.ClearSelection();
                dgvPravnaLica.ClearSelection();
            };

            gbPretraga.MouseClick += (s, ev) =>
            {
                dgvFizickaLica.ClearSelection();
                dgvPravnaLica.ClearSelection();
            };

            #endregion

            svaFizickaLica = DTOManager.VratiFizickaLica(10);

            var prikazFl = svaFizickaLica.Select(x => new
            {
                Ime = x.Ime,
                Prezime = x.Prezime,
                JMBG = x.Jmbg,
                Telefon = x.Telefon,
                Email = x.Email,
            }).ToList();

            dgvFizickaLica.DataSource = prikazFl;

            svaPravnaLica = DTOManager.VratiPravnaLica(10);

            var prikazPl = svaPravnaLica.Select(x => new
            {
                Firma = x.NazivFirme,
                PIB = x.Pib,
                Adresa = x.Adresa,
                Grad = x.Grad,
                Email = x.Email,
            }).ToList();

            dgvPravnaLica.DataSource = prikazPl;

            dgvFizickaLica.ClearSelection();
            dgvPravnaLica.ClearSelection();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajKlijenta dodajKlijenta = new DodajKlijenta();
            dodajKlijenta.Show();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvFizickaLica.SelectedRows.Count == 0 && dgvPravnaLica.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvFizickaLica.SelectedRows.Count > 0)
            {
                int index = dgvFizickaLica.SelectedRows[0].Index;
                FizickoLiceBasic dto = svaFizickaLica[index];

                new IzmeniFizickoLice(dto).ShowDialog();
                KlijentiPregled_Load(null, null);
            }
            else if (dgvPravnaLica.SelectedRows.Count > 0)
            {
                int index = dgvPravnaLica.SelectedRows[0].Index;
                PravnoLiceBasic dto = svaPravnaLica[index];

                // new IzmeniPravnoLice(dto).ShowDialog();
                KlijentiPregled_Load(null, null);
            }
        }
    }
}

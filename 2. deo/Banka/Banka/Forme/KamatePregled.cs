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
    public partial class KamatePregled : BaseForm
    {
        private IList<KamataBasic> sveKamate;
        public KamatePregled() : base()
        {
            InitializeComponent();
            StilizujGroupBox(gbKamate);
            StilizujDataGridView(dgvKamate);
            StilizujButton(
                btnDodaj,
                btnIzmeni,
                btnObrisi);

            sveKamate = new List<KamataBasic>();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajKamatu = new DodajKamatu();
            dodajKamatu.ShowDialog();
            KamatePregled_Load(null, null);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvKamate.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvKamate.SelectedRows.Count > 0)
            {
                int index = dgvKamate.SelectedRows[0].Index;

                var kamata = DTOManager.VratiKamatu(sveKamate[index].Id);

                var izmeniKamatu = new IzmeniKamatu(kamata);
                izmeniKamatu.ShowDialog();
                KamatePregled_Load(null, null);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvKamate.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvKamate.SelectedRows.Count > 0)
            {
                int index = dgvKamate.SelectedRows[0].Index;

                DTOManager.ObrisiKamatu(sveKamate[index].Id);
                KamatePregled_Load(null, null);
            }
        }

        private void KamatePregled_Load(object sender, EventArgs e)
        {
            #region Dinamicki select

            dgvKamate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKamate.MultiSelect = false;

            #endregion

            sveKamate = DTOManager.VratiKamate(50);

            var prikazKamata = sveKamate.Select(x => new
            {
                DatumObracuna = x.DatumObracuna,
                PeriodObracuna = x.PeriodObracuna,
                Tip = x.TipKamate,
                Status = x.StatusKamate,
                Iznos = x.Iznos,
                Racun = x.Racun != null ? x.Racun.BrojRacuna : "",
                Kredit = x.Kredit != null ? x.Kredit.Id : 0,
                Depozit = x.Depozit != null ? x.Depozit.Id : 0,
            }).ToList();

            dgvKamate.DataSource = prikazKamata;
        }
    }
}

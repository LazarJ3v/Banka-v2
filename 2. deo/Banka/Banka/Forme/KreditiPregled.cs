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
    public partial class KreditiPregled : BaseForm
    {
        private IList<KreditBasic> sviKrediti;
        public KreditiPregled() : base()
        {
            InitializeComponent();

            StilizujButton(btnDodaj, btnIzmeni, btnObrisi);
            StilizujGroupBox(gbKredit);
            StilizujDataGridView(dgvKrediti);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajKredit = new DodajKredit();
            dodajKredit.ShowDialog();
            KreditiPregled_Load(null, null);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvKrediti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvKrediti.SelectedRows.Count > 0)
            {
                var index = dgvKrediti.SelectedRows[0].Index;

                var kredit = sviKrediti[index];

                var izmeniKredit = new IzmeniKredit(kredit);
                izmeniKredit.ShowDialog();
                KreditiPregled_Load(null, null);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKrediti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selektujte zapis!");
                    return;
                }

                if (dgvKrediti.SelectedRows.Count > 0)
                {
                    var index = dgvKrediti.SelectedRows[0].Index;
                    DTOManager.ObrisiKredit(sviKrediti[index].Id);
                    KreditiPregled_Load(null, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KreditiPregled_Load(object sender, EventArgs e)
        {
            #region Dinamicki select

            dgvKrediti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKrediti.MultiSelect = false;

            #endregion

            sviKrediti = DTOManager.VratiKredite(50);

            var prikazKrediti = sviKrediti.Select(x => new
            {
                Id = x.Id,
                DatumDospeca = x.DatumDospeca,
                DatumOdobrenja = x.DatumOdobrenja,
                Iznos = x.Iznos,
                Valuta = x.Valuta,
                StatusKredita = x.StatusKredita,
                MesecnaRata = x.MesecnaRata,
                RokOtplate = x.RokOtplate,
                Namena = x.Namena,
                KamatnaStopa = x.KamatnaStopa,
                Racun = x.Racun.BrojRacuna
            }).ToList();

            dgvKrediti.DataSource = prikazKrediti;
        }
    }
}

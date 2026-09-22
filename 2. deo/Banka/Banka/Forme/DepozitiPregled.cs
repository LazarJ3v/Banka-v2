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
    public partial class DepozitiPregled : BaseForm
    {
        private IList<DepozitBasic> sviDepoziti;
        public DepozitiPregled() : base()
        {
            InitializeComponent();

            StilizujButton(btnDodaj, btnIzmeni, btnObrisi);
            StilizujGroupBox(gbDepozit);
            StilizujDataGridView(dgvDepoziti);

            sviDepoziti = new List<DepozitBasic>();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajDepozit = new DodajDepozit();
            dodajDepozit.ShowDialog();
            DepozitiPregled_Load(null, null);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvDepoziti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if(dgvDepoziti.SelectedRows.Count > 0)
            {
                var index = dgvDepoziti.SelectedRows[0].Index;
                var depozit = sviDepoziti[index];

                var izmeniDepozit = new IzmeniDepozit(depozit);

                izmeniDepozit.ShowDialog();
                DepozitiPregled_Load(null, null);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepoziti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selektujte zapis!");
                    return;
                }

                if (dgvDepoziti.SelectedRows.Count > 0)
                {
                    var index = dgvDepoziti.SelectedRows[0].Index;

                    DTOManager.ObrisiDepozit(sviDepoziti[index].Id);
                    DepozitiPregled_Load(null, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DepozitiPregled_Load(object sender, EventArgs e)
        {
            #region Dinamicki select

            dgvDepoziti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepoziti.MultiSelect = false;

            #endregion

            sviDepoziti = DTOManager.VratiDepozite(50);
            var prikazDepoziti = sviDepoziti.Select(x => new
            {
                Id = x.Id,
                DatumPocetka = x.DatumPocetka,
                PeriodOrocenja = x.PeriodOrocenja,
                DatumIsteka = x.DatumIsteka,
                StatusDepozita = x.StatusDepozita,
                Valuta = x.Valuta,
                Iznos = x.Iznos,
                KamatnaStopa = x.KamatnaStopa
            }).ToList();

            dgvDepoziti.DataSource = prikazDepoziti;
        }
    }
}

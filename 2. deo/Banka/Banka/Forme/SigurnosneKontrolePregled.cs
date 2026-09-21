using Banka.Enumi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka.Forme
{
    public partial class SigurnosneKontrolePregled : BaseForm
    {
        private IList<SigurnosnaKontrolaBasic> sveSigurnosneKontrole;
        public SigurnosneKontrolePregled() : base()
        {
            InitializeComponent();
            StilizujGroupBox(
                gbSigurnosneKontrole);
            StilizujDataGridView(
                dgvSigurnosneKontrole);
            StilizujButton(
                btnDodaj,
                btnIzmeni,
                btnObrisi);

            sveSigurnosneKontrole = new List<SigurnosnaKontrolaBasic>();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajSigurnosnuKontrolu = new DodajSigurnosnuKontrolu();
            dodajSigurnosnuKontrolu.ShowDialog();
            SigurnosneKontrolePregled_Load(null, null);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvSigurnosneKontrole.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvSigurnosneKontrole.SelectedRows.Count > 0)
            {
                var index = dgvSigurnosneKontrole.SelectedRows[0].Index;
                var sigurnosnaKontrola = sveSigurnosneKontrole[index];

                var izmeniSigurnosnuKontrolu = new IzmeniSigurnosnuKontrolu(sigurnosnaKontrola);
                izmeniSigurnosnuKontrolu.ShowDialog();
                SigurnosneKontrolePregled_Load(null, null);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvSigurnosneKontrole.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvSigurnosneKontrole.SelectedRows.Count > 0)
            {
                var index = dgvSigurnosneKontrole.SelectedRows[0].Index;

                DTOManager.ObrisiSigurnosnuKontrolu(sveSigurnosneKontrole[index].Id);
                SigurnosneKontrolePregled_Load(null, null);
            }
        }

        private void SigurnosneKontrolePregled_Load(object sender, EventArgs e)
        {
            #region Dinamicki select

            dgvSigurnosneKontrole.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSigurnosneKontrole.MultiSelect = false;

            #endregion

            sveSigurnosneKontrole = DTOManager.VratiSigurnosneKontrole(50);

            var prikaziSigurnosneKontrole = sveSigurnosneKontrole.Select(x => new 
            {
                IpAdresa = x.IpAdresa,
                DatumIVreme = x.DatumIVreme,
                TipDogadjaja = x.TipDogadjaja,
                StatusDogadjaja = x.StatusDogadjaja,
                PodaciUredjaja = x.PodaciUredjaja,
                Opis = x.Opis
            }).ToList();

            dgvSigurnosneKontrole.DataSource = prikaziSigurnosneKontrole;
        }
    }
}

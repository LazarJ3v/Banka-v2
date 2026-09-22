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
    public partial class TransakcijePregled : BaseForm
    {
        private IList<TransakcijaBasic> sveTransakcije;
        public TransakcijePregled() : base()
        {
            InitializeComponent();

            StilizujButton(btnDodaj, btnIzmeni, btnObrisi);

            StilizujDataGridView(dgvTransakcije);

            StilizujGroupBox(gbTransakcije);
            
            sveTransakcije = new List<TransakcijaBasic>();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajTransakciju = new DodajTransakciju();
            dodajTransakciju.ShowDialog();
            TransakcijePregled_Load(null, null);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvTransakcije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvTransakcije.SelectedRows.Count > 0)
            {
                var index = dgvTransakcije.SelectedRows[0].Index;

                var transakcija = DTOManager.VratiTransakciju(sveTransakcije[index].Id);

                var izmeniTransakciju = new IzmeniTransakciju(transakcija);
                izmeniTransakciju.ShowDialog();
                TransakcijePregled_Load(null, null);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvTransakcije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvTransakcije.SelectedRows.Count > 0)
            {
                var index = dgvTransakcije.SelectedRows[0].Index;

                DTOManager.ObrisiTransakciju(sveTransakcije[index].Id);
                TransakcijePregled_Load(null, null);
            }
        }

        private void TransakcijePregled_Load(object sender, EventArgs e)
        {
            #region Dinamicki select

            dgvTransakcije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransakcije.MultiSelect = false;

            #endregion

            sveTransakcije = DTOManager.VratiTransakcije(50);

            var prikazTransakcije = sveTransakcije.Select(x => new
            {
                Racun = x.Racun.BrojRacuna,
                DatumIVreme = x.DatumIVreme,
                Tip = x.TipTransakcije,
                Status = x.StatusTransakcije,
                PodaciPrimaoca = x.PodaciPrimaoca,
                Referenca = x.Referenca,
                Valuta = x.Valuta,
                Iznos = x.Iznos,
                Opis = x.Opis,
            }).ToList();

            dgvTransakcije.DataSource = prikazTransakcije;
        }
    }
}

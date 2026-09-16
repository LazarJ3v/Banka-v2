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
    public partial class RacuniPregled : BaseForm
    {
        private List<RacunBasic> sviRacuni;
        public RacuniPregled() : base()
        {
            InitializeComponent();
            StilizujLabel(
                lblBrojRacuna,
                lblTipRacuna);
            StilizujGroupBox(
                gbRacuni,
                gbPretraga);
            StilizujDataGridView(
                dgvRacuni);
            StilizujTextBox(
                tbBrojRacuna);
            StilizujComboBox(
                cbTipRacuna);
            StilizujButton(
                btnDetalji,
                btnDodaj,
                btnPretrazi,
                btnIzmeni,
                btnObrisi);
        }

        private void RacuniPregled_Load(object sender, EventArgs e)
        {
            cbTipRacuna.Items.Clear();
            object[] tipovi = {
                TipRacuna.Svi,
                TipRacuna.Tekuci,
                TipRacuna.Devizni,
                TipRacuna.Stedni,
                TipRacuna.Ziro,
                TipRacuna.Drugi
            };
            cbTipRacuna.Items.AddRange(tipovi);
            cbTipRacuna.SelectedIndex = 0;

            sviRacuni = DTOManager.VratiRacune(50);

            var prikazRacuna = sviRacuni.Select(x => new
            {
                BrojRacuna = x.BrojRacuna,
                Valuta = x.Valuta,
                TrenutnoStanje = x.TrenutnoStanje,
                DatumOtvaranja = x.DatumOtvaranja,
                Status = x.Status,
                TipRacuna = x.TipRacuna,
                Vlasnik = x.FizickoLice != null
                    ? x.FizickoLice.Ime + " " + x.FizickoLice.Prezime
                    : x.PravnoLice.NazivFirme
            }).ToList();

            dgvRacuni.DataSource = prikazRacuna;

            dgvRacuni.Columns["BrojRacuna"].HeaderText = "Broj Racuna";
            dgvRacuni.Columns["TrenutnoStanje"].HeaderText = "Trenutno Stanje";
            dgvRacuni.Columns["DatumOtvaranja"].HeaderText = "Datum Otvaranja";
            dgvRacuni.Columns["TipRacuna"].HeaderText = "Tip Racuna";
            dgvRacuni.Columns["Vlasnik"].HeaderText = "Vlasnik";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajRacun dodajRacun = new DodajRacun();
            dodajRacun.ShowDialog();
            RacuniPregled_Load(null, null);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (dgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zapis!");
                return;
            }

            if (dgvRacuni.SelectedRows.Count > 0)
            {
                int index = dgvRacuni.SelectedRows[0].Index;
                if (sviRacuni[index].TipRacuna == TipRacuna.Tekuci.ToString())
                {
                    //TODO: proveriti da li poredjanje radi kako treba
                    DetaljiRacun tekuci = new DetaljiRacun();
                    tekuci.PodesiPrikaz(TipRacuna.Tekuci);
                    tekuci.ShowDialog(this);
                }
                //TODO: Dodati ostale uslove za ostale tipove
            }
        }
    }
}

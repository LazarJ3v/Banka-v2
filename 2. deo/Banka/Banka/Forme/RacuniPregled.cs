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
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajRacun dodajRacun = new DodajRacun();
            dodajRacun.ShowDialog();
        }
    }
}

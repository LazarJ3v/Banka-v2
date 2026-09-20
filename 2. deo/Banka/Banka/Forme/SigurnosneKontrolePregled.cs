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
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajSigurnosnuKontrolu = new DodajSigurnosnuKontrolu();
            dodajSigurnosnuKontrolu.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            // TODO: Izvuci transakciju iz data grid view-a
            var sigurnosnaKontrola = new SigurnosnaKontrolaBasic();

            var izmeniSigurnosnuKontrolu = new IzmeniSigurnosnuKontrolu();
            izmeniSigurnosnuKontrolu.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}

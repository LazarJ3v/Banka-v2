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
        public KamatePregled() : base()
        {
            InitializeComponent();
            StilizujGroupBox(
                gbKamate);
            StilizujDataGridView(
                dgvKamate);
            StilizujButton(
                btnDodaj,
                btnIzmeni,
                btnObrisi);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajKamatu = new DodajKamatu();
            dodajKamatu.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            // TODO: izvuci dto iz data grid view-a
            var kamate = new KamataBasic();

            var izmeniKamatu = new IzmeniKamatu();
            izmeniKamatu.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}

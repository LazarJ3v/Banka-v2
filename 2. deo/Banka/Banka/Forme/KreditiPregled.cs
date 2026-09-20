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
        public KreditiPregled() : base()
        {
            InitializeComponent();

            StilizujButton(btnDodaj, btnIzmeni, btnObrisi);
            StilizujGroupBox(gbKredit);
            StilizujDataGridView(dgvKredit);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajKredit = new DodajKredit();
            dodajKredit.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            // TODO: izvuci dto iz data grid view-a
            var kredit = new KreditBasic();

            var izmeniKredit = new IzmeniKredit(kredit);
            izmeniKredit.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}

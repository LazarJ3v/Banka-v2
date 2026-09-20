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
        public DepozitiPregled() : base()
        {
            InitializeComponent();

            StilizujButton(btnDodaj, btnIzmeni, btnObrisi);
            StilizujGroupBox(gbDepozit);
            StilizujDataGridView(dgvDepozit);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajDepozit = new DodajDepozit();
            dodajDepozit.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            // TODO: Izvuci depozit iz data grid view-a
            var depozit = new DepozitBasic();

            var izmeniDepozit = new IzmeniDepozit(depozit);
            izmeniDepozit.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}

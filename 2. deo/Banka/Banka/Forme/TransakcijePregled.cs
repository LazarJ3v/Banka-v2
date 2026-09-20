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
        public TransakcijePregled() : base()
        {
            InitializeComponent();

            StilizujButton(btnDodaj, btnIzmeni, btnObrisi);

            StilizujDataGridView(dgvTransakcije);

            StilizujGroupBox(gbTransakcije);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajTransakciju = new DodajTransakciju();
            dodajTransakciju.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            // TODO: Izvuci transakciju iz data grid view-a
            var transakcija = new TransakcijaBasic();

            var izmeniTransakciju = new IzmeniTransakciju(transakcija);
            izmeniTransakciju.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}

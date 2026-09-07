using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banka.Forme;

namespace Banka.Forme
{
    public partial class KlijentiPregled : BaseForm
    {
        public KlijentiPregled() : base()
        {
            InitializeComponent();
            StilizujGroupBox(
                gbFizickaLica,
                gbPravnaLica,
                gbPretraga);
            StilizujDataGridView(
                dgvFizickaLica,
                dgvPravnaLica);
            StilizujTextBox(
                tbEmail);
            StilizujComboBox(
                cbTipKlijenta,
                cbStatusKlijenta);
            StilizujLabel(
                lblEmail,
                lblTipKlijenta,
                lblStatusKlijenta,
                lblBrojKlijenata,
                lblBroj);
            StilizujButton(
                btnPretrazi,
                btnDodaj,
                btnIzmeni,
                btnObrisi);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajKlijenta dodajKlijenta = new DodajKlijenta();
            dodajKlijenta.Show();
        }
    }
}

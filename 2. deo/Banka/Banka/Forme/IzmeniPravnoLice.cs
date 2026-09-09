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
    public partial class IzmeniPravnoLice : BaseForm
    {
        private PravnoLiceBasic pravnoLice;
        public IzmeniPravnoLice(PravnoLiceBasic _pravnoLice) : base()
        {
            InitializeComponent();
            pravnoLice = _pravnoLice;
            StilizujLabel(
                lblAdresa,
                lblEmail,
                lblGrad,
                lblKomentar,
                lblNazivFirme,
                lblPib,
                lblStatus,
                lblTelefon);
            StilizujTextBox(
                tbAdresa,
                tbEmail,
                tbGrad,
                tbNazivFirme,
                tbPib,
                tbTelefon);
            StilizujComboBox(
                cbStatus);
            StilizujRichTextBox(
                rtbKomentar);
            StilizujButton(
                btnIzmeni);
        }

        private void IzmeniPravnoLice_Load(object sender, EventArgs e)
        {
            tbNazivFirme.Text = pravnoLice.NazivFirme;
            tbPib.Text = pravnoLice.Pib;
            tbAdresa.Text = pravnoLice.Adresa;
            tbGrad.Text = pravnoLice.Grad;
            tbTelefon.Text = pravnoLice.Telefon;
            tbEmail.Text = pravnoLice.Email;
            cbStatus.Items.Add(KlijentStatus.Neaktivan);
            cbStatus.Items.Add(KlijentStatus.Aktivan);
            cbStatus.Text = pravnoLice.Status;
            rtbKomentar.Text = pravnoLice.Komentar;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            pravnoLice.NazivFirme = tbNazivFirme.Text.Trim();
            pravnoLice.Pib = tbPib.Text.Trim();
            pravnoLice.Adresa = tbAdresa.Text.Trim();
            pravnoLice.Grad = tbGrad.Text.Trim();
            pravnoLice.Telefon = tbTelefon.Text.Trim();
            pravnoLice.Email = tbEmail.Text.Trim();
            pravnoLice.Status = cbStatus.SelectedItem.ToString();
            pravnoLice.Komentar = rtbKomentar.Text.Trim();

            DTOManager.IzmeniPravnoLice(pravnoLice);

            MessageBox.Show("Podaci uspešno izmenjeni!", "Uspeh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

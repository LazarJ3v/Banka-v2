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
    public partial class IzmeniSigurnosnuKontrolu : BaseForm
    {
        public IzmeniSigurnosnuKontrolu() : base()
        {
            InitializeComponent();
            StilizujLabel(
                lblDatumIVreme,
                lblIpAdresa,
                lblOpis,
                lblPodaciUredjaja,
                lblStatusDogadjaja,
                lblTipDogadjaja);
            StilizujTextBox(
                tbIpAdresa);
            StilizujRichTextBox(
                rtbOpis,
                rtbPodaciUredjaja);
            StilizujComboBox(
                cbStatusDogadjaja,
                cbTipDogadjaja);
            StilizujButton(
                btnSacuvaj);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class DodajSigurnosnuKontrolu : BaseForm
    {
        public DodajSigurnosnuKontrolu() : base()
        {
            InitializeComponent();
            StilizujButton(
                btnSacuvaj);
            StilizujComboBox(
                cbStatusDogadjaja,
                cbTipDogadjaja);
            StilizujTextBox(
                tbBrojRacuna,
                tbIpAdresa);
            StilizujRichTextBox(
                rtbOpis,
                rtbPodaciUredjaja);
            StilizujLabel(
                lblBrojRacuna,
                lblDatumIVreme,
                lblIpAdresa,
                lblOpis,
                lblPodaciUredjaja,
                lblStatusDogadjaja,
                lblTipDogaljaja);
            StilizujDateTimePicker(
                dtpDatumIVreme);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

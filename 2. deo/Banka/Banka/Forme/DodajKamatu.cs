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
    public partial class DodajKamatu : BaseForm
    {
        public DodajKamatu() : base()
        {
            InitializeComponent();
            StilizujRadioButton(
                    rbKamataNaDepozit,
                    rbKamataNaKredit,
                    rbKamataNaRacun);
            StilizujLabel(
                lblBrojRacuna,
                lblDatumObracuna,
                lblIdDepozita,
                lblIdKredita,
                lblIznos,
                lblPeriodObracuna,
                lblStatus,
                lblTip);
            StilizujComboBox(
                cbPeriodObracuna,
                cbStatus,
                cbTip);
            StilizujDateTimePicker(
                dtpDatumObracuna);
            StilizujButton(
                btnSacuvaj);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            //TODO: implementirati obradu eventa za dodavalje kamate
            this.Close();
        }

        private void rbKamataNaRacun_CheckedChanged(object sender, EventArgs e)
        {
            tbBrojRacuna.Enabled = rbKamataNaRacun.Checked;
            tbKamataNaDepozit.Enabled = rbKamataNaDepozit.Checked;
            tbKamataNaKredit.Enabled = rbKamataNaKredit.Checked;
        }

        private void rbKamataNaKredit_CheckedChanged(object sender, EventArgs e)
        {
            tbBrojRacuna.Enabled = rbKamataNaRacun.Checked;
            tbKamataNaDepozit.Enabled = rbKamataNaDepozit.Checked;
            tbKamataNaKredit.Enabled = rbKamataNaKredit.Checked;
        }

        private void rbKamataNaDepozit_CheckedChanged(object sender, EventArgs e)
        {
            tbBrojRacuna.Enabled = rbKamataNaRacun.Checked;
            tbKamataNaDepozit.Enabled = rbKamataNaDepozit.Checked;
            tbKamataNaKredit.Enabled = rbKamataNaKredit.Checked;
        }
    }
}

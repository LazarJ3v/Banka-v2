using Banka.Entiteti;
using Banka.Enumi;
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
            StilizujNumericUpDown(
                nudIdDepozita,
                nudIdKredita);
            StilizujTextBox(
                tbBrojRacuna);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            //TODO: implementirati obradu eventa za dodavalje kamate
            var kamata = new KamataBasic
            {
                DatumObracuna = dtpDatumObracuna.Value,
                PeriodObracuna = cbPeriodObracuna.Text,
                TipKamate = cbTip.Text,
                StatusKamate = cbStatus.Text,
                Iznos = nudIznos.Value,

                Racun = null,
                Kredit = null,
                Depozit = null
            };

            if (rbKamataNaRacun.Checked)
            {
                var racun = DTOManager.VratiRacun(tbBrojRacuna.Text.Trim());
                kamata.Racun = racun;
            }
            else if(rbKamataNaKredit.Checked)
            {
                var kredit = DTOManager.VratiKredit((int)nudIdKredita.Value);
                kamata.Kredit = kredit;

            }
            else if (rbKamataNaDepozit.Checked)
            {
                var depozit = DTOManager.VratiDepozit((int)nudIdDepozita.Value);
                kamata.Depozit = depozit;
            }
            DTOManager.DodajKamatu(kamata);
            MessageBox.Show(
                        "Kamata uspešno dodata!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rbKamataNaRacun_CheckedChanged(object sender, EventArgs e)
        {
            tbBrojRacuna.Enabled = rbKamataNaRacun.Checked;
            nudIdDepozita.Enabled = rbKamataNaDepozit.Checked;
            nudIdKredita.Enabled = rbKamataNaKredit.Checked;
        }

        private void rbKamataNaKredit_CheckedChanged(object sender, EventArgs e)
        {
            tbBrojRacuna.Enabled = rbKamataNaRacun.Checked;
            nudIdDepozita.Enabled = rbKamataNaDepozit.Checked;
            nudIdKredita.Enabled = rbKamataNaKredit.Checked;
        }

        private void rbKamataNaDepozit_CheckedChanged(object sender, EventArgs e)
        {
            tbBrojRacuna.Enabled = rbKamataNaRacun.Checked;
            nudIdDepozita.Enabled = rbKamataNaDepozit.Checked;
            nudIdKredita.Enabled = rbKamataNaKredit.Checked;
        }

        private void DodajKamatu_Load(object sender, EventArgs e)
        {
            cbPeriodObracuna.DataSource = Enum.GetValues(typeof(FrekvencijaKapitalizacijeKamate));
            cbTip.DataSource = Enum.GetValues(typeof(TipKamate));
            var statusi = Enum.GetValues(typeof(StatusKamate));
            foreach(StatusKamate s in statusi)
            {
                cbStatus.Items.Add(s.GetDescription());
            }
            cbStatus.SelectedIndex = 0;
        }
    }
}

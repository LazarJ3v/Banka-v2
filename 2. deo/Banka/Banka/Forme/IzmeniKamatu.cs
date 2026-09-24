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
    public partial class IzmeniKamatu : BaseForm
    {
        private KamataBasic kamata;
        public IzmeniKamatu(KamataBasic kamata  ) : base()
        {
            InitializeComponent();
            StilizujButton(
                btnSacuvaj);
            StilizujNumericUpDown(
                nudIznos);
            StilizujDateTimePicker(
                dtpDatumObracuna);
            StilizujComboBox(
                cbStatus,
                cbTip,
                cbPeriodObracuna);
            StilizujLabel(
                lblDatumObracuna,
                lblIznos,
                lblPeriodObracuna,
                lblStatus,
                lblTipKamate);
            StilizujNumericUpDown(
                nudIznos);
            this.kamata = kamata;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var dto = new KamataBasic
            {
                Id = kamata.Id,
                DatumObracuna = dtpDatumObracuna.Value,
                PeriodObracuna = cbPeriodObracuna.Text,
                TipKamate = cbTip.Text,
                StatusKamate = cbStatus.Text,
                Iznos = nudIznos.Value
            };

            try
            {
                DTOManager.IzmeniKamatu(dto);
                MessageBox.Show(
                            "Kamata uspešno izmenjena!",
                            "Uspeh",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzmeniKamatu_Load(object sender, EventArgs e)
        {
            dtpDatumObracuna.Value = kamata.DatumObracuna;

            foreach (FrekvencijaKapitalizacijeKamate period in 
                Enum.GetValues(typeof(FrekvencijaKapitalizacijeKamate)))
            {
                cbPeriodObracuna.Items.Add(period.GetDescription());
            }
            cbPeriodObracuna.SelectedIndex = 
               cbPeriodObracuna.Items.IndexOf(kamata.PeriodObracuna);

            foreach (TipKamate tip in 
                Enum.GetValues(typeof(TipKamate)))
            {
                cbTip.Items.Add(tip.GetDescription());
            }
            cbTip.SelectedItem = cbTip.Items[cbTip.Items.IndexOf(kamata.TipKamate)];

            foreach (StatusKamate status in
                Enum.GetValues(typeof(StatusKamate)))
            {
                cbStatus.Items.Add(status.GetDescription());
            }
            cbStatus.SelectedItem = cbStatus.Items[cbStatus.Items.IndexOf(kamata.StatusKamate)];

            nudIznos.Value = kamata.Iznos;
        }
    }
}

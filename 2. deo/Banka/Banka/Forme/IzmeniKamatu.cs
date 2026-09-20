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
        public IzmeniKamatu() : base()
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
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            //TODO: implementirati obradu eventa za izmenu kamate
            this.Close();
        }
    }
}

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
    public partial class DodajDepozit : BaseForm
    {
        public DodajDepozit() : base()
        {
            InitializeComponent();

            StilizujLabel(
                lblDatumPocetka,
                lblDatumIsteka,
                lblPeriodOrocenja,
                lblStatusDepozita,
                lblValuta,
                lblIznos,
                lblKamatnaStopa,
                lblKomentar);

            StilizujDateTimePicker(dtpDatumPocetka, dtpDatumIsteka);
            StilizujNumericUpDown(nudPeriodOrocenja, nudIznos, nudKamatnaStopa);
            StilizujComboBox(cbStatusDepozita, cbValuta);
            StilizujRichTextBox(rtbKomentar);
            StilizujButton(btnSacuvaj);
        }

        private void DodajDepozit_Load(object sender, EventArgs e)
        {

        }
    }
}

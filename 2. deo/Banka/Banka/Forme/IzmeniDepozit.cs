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
    public partial class IzmeniDepozit : BaseForm
    {
        private DepozitBasic depozit;
        public IzmeniDepozit(DepozitBasic depozit) : base()
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

            this.depozit = depozit;
        }

        private void IzmeniDepozit_Load(object sender, EventArgs e)
        {

        }
    }
}

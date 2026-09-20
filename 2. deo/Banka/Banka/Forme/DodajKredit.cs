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
    public partial class DodajKredit : BaseForm
    {
        public DodajKredit() : base()
        {
            InitializeComponent();

            StilizujDateTimePicker(dtpDatumDospeca, dtpDatumOdobrenja);
            StilizujNumericUpDown(nudIznos, nudMesecnaRata, nudRokOtplate, nudKamatnaStopa);
            StilizujComboBox(cbValuta, cbStatus);
            StilizujTextBox(tbNapomena);
            StilizujRichTextBox(rtbKomentar);
            StilizujButton(btnSacuvaj);
        }

        private void DodajKredit_Load(object sender, EventArgs e)
        {
            // TODO: popuniti combo boxove sa podacima
        }
    }
}

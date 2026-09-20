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
    public partial class IzmeniTransakciju : BaseForm
    {
        private TransakcijaBasic transakcija;
        public IzmeniTransakciju(TransakcijaBasic transakcija) : base()
        {
            InitializeComponent();

            StilizujLabel(
                lblTip,
                lblStatus,
                lblPodaciPrimaoca,
                lblReferenca,
                lblValuta,
                lblIznos,
                lblOpis,
                lblKomentar);

            StilizujComboBox(cbTip, cbStatus, cbValuta);
            StilizujTextBox(tbReferenca, tbIznos, tbOpis);
            StilizujRichTextBox(rtbPodaciPrimaoca, rtbKomentar);
            StilizujButton(btnSacuvaj);

            this.transakcija = transakcija;
        }

        private void IzmeniTransakciju_Load(object sender, EventArgs e)
        {

        }
    }
}

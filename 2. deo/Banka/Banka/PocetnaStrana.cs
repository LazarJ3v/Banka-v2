using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banka.Entiteti;
using Banka.Forme;
using NHibernate;

namespace Banka
{
    public partial class PocetnaStrana : BaseForm
    {
        public PocetnaStrana() : base()
        {
            InitializeComponent();
            StilizujButton(
                btnKlijenti,
                btnRacuni);
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            KlijentiPregled klijentPregled = new KlijentiPregled();
            klijentPregled.Show();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            RacuniPregled racuniPregled = new RacuniPregled();
            racuniPregled.ShowDialog();
        }
    }
}

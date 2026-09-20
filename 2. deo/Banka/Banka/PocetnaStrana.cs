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
                btnRacuni,
                btnTransakcije,
                btnDepoziti,
                btnKrediti);
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            var klijentPregled = new KlijentiPregled();
            klijentPregled.Show();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            var racuniPregled = new RacuniPregled();
            racuniPregled.ShowDialog();
        }

        private void btnTransakcije_Click(object sender, EventArgs e)
        {
            var transakcijePregled = new TransakcijePregled();
            transakcijePregled.ShowDialog();
        }

        private void btnDepoziti_Click(object sender, EventArgs e)
        {
            var depozitiPregled = new DepozitiPregled();
            depozitiPregled.ShowDialog();
        }

        private void btnKrediti_Click(object sender, EventArgs e)
        {
            var kreditiPregled = new KreditiPregled();
            kreditiPregled.ShowDialog();
        }
    }
}

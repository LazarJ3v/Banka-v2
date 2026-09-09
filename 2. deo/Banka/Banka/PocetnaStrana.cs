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
            try
            {
                ISession s = DataLayer.GetSession();

                Racun r = s.Load<Racun>(1);

                MessageBox.Show(r.BrojRacuna);
                MessageBox.Show(r.PripadaFizickomLicu.Ime);

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}

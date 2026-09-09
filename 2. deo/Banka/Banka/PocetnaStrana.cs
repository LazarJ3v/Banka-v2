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

                FizickoLice fl = new FizickoLice()
                {
                    Ime = "Lazar",
                    Prezime = "Jevtic",
                    BrojLicneKarte = "222222222",
                    Jmbg = "5555555555555",
                    DatumRodjenja = new DateTime(2022, 2, 1),
                    Adresa = "Adresaaaa",
                    Grad = "Gradddd",
                    Telefon = "42130523",
                    Email = "lj@gmail.com",
                    Status = "Aktivan",
                    Komentar = "blabla"
                };

                Racun r1 = new Racun()
                {
                    BrojRacuna = "160-0000000005-55",
                    Valuta = "RSD",
                    TrenutnoStanje = (decimal)11423.32,
                    DatumOtvaranja = new DateTime(),
                    Status = "Aktivan",
                    DozvoljeniMinus = 10000,
                    Komentar = "dsds",
                    TipRacuna = "Dinarski",
                    KamatnaStopa = 5
                };

                fl.Racuni.Add(r1);
                r1.PripadaFizickomLicu = fl;
                r1.PripadaPravnomLicu = null;

                //MessageBox.Show(r.BrojRacuna);
                //MessageBox.Show(r.PripadaFizickomLicu.Ime);

                s.Save(fl);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}

using Banka.Entiteti;
using Prodavnica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using System.Windows.Forms;

namespace Banka
{
    internal class DTOManager
    {
        #region FizickaLica

        public static void DodajFizickoLice(FizickoLice fl)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                FizickoLice f = new FizickoLice();

                f.Ime = fl.Ime;
                f.Prezime = fl.Prezime;
                f.Jmbg = fl.Jmbg;
                f.BrojLicneKarte = fl.BrojLicneKarte;
                f.DatumRodjenja = fl.DatumRodjenja;
                f.Adresa = fl.Adresa;
                f.Grad = fl.Grad;
                f.Telefon = fl.Telefon;
                f.Email = fl.Email;
                f.Status = fl.Status;
                f.Komentar = fl.Komentar;

                s.Save(f);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (s.IsOpen)
                {
                    s.Flush();
                    s.Close();
                }
            }
        }

        public static FizickoLiceBasic VratiFizickoLice(int id)
        {
            FizickoLiceBasic fl = new FizickoLiceBasic();
            ISession s = DataLayer.GetSession();

            try
            { 
                FizickoLice f = s.Load<FizickoLice>(id);
                fl = new FizickoLiceBasic
                {
                    Id = f.Id,
                    Ime = f.Ime,
                    Prezime = f.Prezime,
                    Jmbg = f.Jmbg,
                    BrojLicneKarte = f.BrojLicneKarte,
                    DatumRodjenja = f.DatumRodjenja,
                    Adresa = f.Adresa,
                    Grad = f.Grad,
                    Telefon = f.Telefon,
                    Email = f.Email,
                    Status = f.Status,
                    Komentar = f.Komentar
                };
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
            finally
            {
                if (s.IsOpen)
                {
                    s.Flush();
                    s.Close();
                }
            }

            return fl;
        }

        #endregion
    }
}

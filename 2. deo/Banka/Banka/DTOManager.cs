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

        // TODO: Uvesti transakcije u funkcijama koje menjaju podatke u bazi
        #region FizickaLica

        public static void DodajFizickoLice(FizickoLiceBasic fl)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    FizickoLice f = new FizickoLice
                    {
                        Ime = fl.Ime?.Trim(),
                        Prezime = fl.Prezime?.Trim(),
                        Jmbg = fl.Jmbg?.Trim(),
                        BrojLicneKarte = fl.BrojLicneKarte?.Trim(),
                        DatumRodjenja = fl.DatumRodjenja,
                        Adresa = fl.Adresa?.Trim(),
                        Grad = fl.Grad?.Trim(),
                        Telefon = fl.Telefon?.Trim(),
                        Email = fl.Email?.Trim(),
                        Status = fl.Status,
                        Komentar = fl.Komentar?.Trim()
                    };

                    session.Save(f);
                    transaction.Commit();

                    // Vrati generisani ID
                    fl.Id = f.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju fizičkog lica", ex);
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

        public static FizickoLiceBasic IzmeniFizickoLice(FizickoLiceBasic fl)
        {
            FizickoLice f = new FizickoLice();
            ISession s = DataLayer.GetSession();

            try
            {
                f = s.Load<FizickoLice>(fl.Id);

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

                s.Update(f);
            }
            catch(Exception ec)
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

        public static void Obrisi(int id)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                FizickoLice f = s.Load<FizickoLice>(id);

                s.Delete(id);
            }
            catch(Exception ec)
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
        }

        public static List<FizickoLiceBasic> VratiFizickaLica(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<FizickoLice> entiteti = session.Query<FizickoLice>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new FizickoLiceBasic
                {
                    Id = x.Id,
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    Jmbg = x.Jmbg,
                    BrojLicneKarte = x.BrojLicneKarte,
                    DatumRodjenja = x.DatumRodjenja,
                    Adresa = x.Adresa,
                    Grad = x.Grad,
                    Telefon = x.Telefon,
                    Email = x.Email,
                    Status = x.Status,
                    Komentar = x.Komentar
                }).ToList();
            }
        }

        #endregion

        #region PravnaLica

        public static List<PravnoLiceBasic> VratiPravnaLica(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<PravnoLice> entiteti = session.Query<PravnoLice>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new PravnoLiceBasic
                {
                    Id = x.Id,
                    NazivFirme = x.NazivFirme,
                    Pib = x.Pib,
                    Adresa = x.Adresa,
                    Grad = x.Grad,
                    Telefon = x.Telefon,
                    Email = x.Email,
                    Status = x.Status,
                    Komentar = x.Komentar
                }).ToList();
            }
        }

        // TODO: Implementirati sledece funkcije:
        // * DodajPravnoLice(PravnoLiceBasic pl)
        // * VratiPravnoLice(int id)
        // * IzmeniPravnoLice(PravnoLiceBasic pl)
        // * ObrisiPravnoLice(int id)

        #endregion
    }
}

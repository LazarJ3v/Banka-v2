using Banka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using System.Windows.Forms;
using Banka.Enumi;

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

        public static void ObrisiFizickoLice(int id)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                FizickoLice f = s.Load<FizickoLice>(id);

                s.Delete(f);
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

        public static void DodajPravnoLice(PravnoLiceBasic pl)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    PravnoLice p = new PravnoLice
                    {
                        NazivFirme = pl.NazivFirme?.Trim(),
                        Pib = pl.Pib?.Trim(),
                        Adresa = pl.Adresa?.Trim(),
                        Grad = pl.Grad?.Trim(),
                        Telefon = pl.Telefon?.Trim(),
                        Email = pl.Email?.Trim(),
                        Status = pl.Status?.Trim(),
                        Komentar = pl.Komentar?.Trim()
                    };

                    session.Save(p);
                    transaction.Commit();

                    // Vrati generisani ID
                    pl.Id = p.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        public static PravnoLiceBasic VratiPravnoLice(int id)
        {
            PravnoLiceBasic pl = new PravnoLiceBasic();
            ISession s = DataLayer.GetSession();

            try
            {
                PravnoLice p = s.Load<PravnoLice>(id);
                pl = new PravnoLiceBasic
                {
                    Id = p.Id,
                    NazivFirme = p.NazivFirme,
                    Pib = p.Pib,
                    Adresa = p.Adresa,
                    Grad = p.Grad,
                    Telefon = p.Telefon,
                    Email = p.Email,
                    Status = p.Status,
                    Komentar = p.Komentar
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

            return pl;
        }

        public static PravnoLiceBasic IzmeniPravnoLice(PravnoLiceBasic pl)
        {
            PravnoLice p = new PravnoLice();
            ISession s = DataLayer.GetSession();

            try
            {
                p = s.Load<PravnoLice>(pl.Id);

                p.NazivFirme = pl.NazivFirme;
                p.Pib = pl.Pib;
                p.Adresa = pl.Adresa;
                p.Grad = pl.Grad;
                p.Telefon = pl.Telefon;
                p.Email = pl.Email;
                p.Status = pl.Status;
                p.Komentar = pl.Komentar;

                s.Update(p);
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

            return pl;
        }

        public static void ObrisiPravnoLice(int id)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                PravnoLice p = s.Load<PravnoLice>(id);

                s.Delete(p);
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
        }

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

        #endregion

        #region Racun

        public static void DodajRacun(RacunBasic r)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    if(r.TipRacuna == TipRacuna.Tekuci.ToString())
                    {

                    }
                    else if(r.TipRacuna == TipRacuna.Devizni.ToString())
                    {

                    }
                    else if(r.TipRacuna == TipRacuna.Stedni.ToString())
                    {

                    }
                    else if(r.TipRacuna == TipRacuna.Ziro.ToString())
                    {

                    }
                    else
                    {

                    }
                }
                catch(Exception ec)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju računa", ec);
                }
            }
        }

        public static List<RacunBasic> VratiRacune(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Racun> entiteti = session.Query<Racun>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new RacunBasic
                {
                    Id = x.Id,
                    BrojRacuna = x.BrojRacuna,
                    Valuta = x.Valuta,
                    TrenutnoStanje = x.TrenutnoStanje,
                    DatumOtvaranja = x.DatumOtvaranja,
                    Status = x.Status,
                    DozvoljeniMinus = x.DozvoljeniMinus,
                    Komentar = x.Komentar,
                    KamatnaStopa = x.KamatnaStopa,
                    TipRacuna = x.TipRacuna,
                    FizickoLice = x.PripadaFizickomLicu != null
                        ? new FizickoLiceBasic
                        {
                            Id = x.PripadaFizickomLicu.Id,
                            Ime = x.PripadaFizickomLicu.Ime,
                            Prezime = x.PripadaFizickomLicu.Prezime
                        }
                        : null,

                    PravnoLice = x.PripadaPravnomLicu != null
                        ? new PravnoLiceBasic
                        {
                            Id = x.PripadaPravnomLicu.Id,
                            NazivFirme = x.PripadaPravnomLicu.NazivFirme
                        }
                        : null
                }).ToList();
            }
        }

        public static void DodajTekuci(TekuciBasic tb, string jmbg, string pib)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    FizickoLice fl = new FizickoLice();
                    PravnoLice pl = new PravnoLice();

                    fl = session.Query<FizickoLice>()
                        .Where(x => x.Jmbg == jmbg)
                        .FirstOrDefault();
                    pl = session.Query<PravnoLice>()
                        .Where(x => x.Pib == pib)
                        .FirstOrDefault();

                    Tekuci t = new Tekuci
                    {
                        BrojRacuna = tb.BrojRacuna?.Trim(),
                        Valuta = tb.Valuta?.Trim(),
                        TrenutnoStanje = tb.TrenutnoStanje,
                        DatumOtvaranja = tb.DatumOtvaranja,
                        Status = tb.Status?.Trim(),
                        DozvoljeniMinus = tb.DozvoljeniMinus,
                        Komentar = tb.Komentar?.Trim(),
                        TipRacuna = tb.TipRacuna?.Trim(),
                        KamatnaStopa = tb.KamatnaStopa,

                        PlatnaKartica = tb.PlatnaKartica,
                        MesecniLimit = tb.MesecniLimit ?? 0,

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl
                    };

                    foreach(TekuciPaketBasic paket in tb.TekuciPaketi)
                    {
                        TekuciPaket tp = new TekuciPaket
                        {
                            Paket = paket.Paket,
                            PripadaTekucem = t
                        };
                        t.Paketi.Add(tp);
                    }

                    session.Save(t);
                    transaction.Commit();

                    // Vrati generisani ID
                    tb.Id = t.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        public static void DodajDevizni(DevizniBasic db, string jmbg, string pib)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    FizickoLice fl = new FizickoLice();
                    PravnoLice pl = new PravnoLice();

                    fl = session.Query<FizickoLice>()
                        .Where(x => x.Jmbg == jmbg)
                        .FirstOrDefault();
                    pl = session.Query<PravnoLice>()
                        .Where(x => x.Pib == pib)
                        .FirstOrDefault();

                    Devizni d = new Devizni
                    {
                        BrojRacuna = db.BrojRacuna?.Trim(),
                        Valuta = db.Valuta?.Trim(),
                        TrenutnoStanje = db.TrenutnoStanje,
                        DatumOtvaranja = db.DatumOtvaranja,
                        Status = db.Status?.Trim(),
                        DozvoljeniMinus = db.DozvoljeniMinus,
                        Komentar = db.Komentar?.Trim(),
                        TipRacuna = db.TipRacuna?.Trim(),
                        KamatnaStopa = db.KamatnaStopa,

                        Namena = db.Namena.Trim(),
                        KursnaRazlika = db.KursnaRazlika ?? 0,

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl
                    };

                    foreach (DevizniOgranicenjeBasic ogranicenje in db.DevizniOgranicenja)
                    {
                        DevizniOgranicenje o = new DevizniOgranicenje
                        {
                            Ogranicenje = ogranicenje.Ogranicenje,
                            PripadaDeviznom = d
                        };
                        d.Ogranicanja.Add(o);
                    }

                    foreach (DevizniValutaBasic valuta in db.DevizniValute)
                    {
                        Entiteti.DevizniValuta v = new Entiteti.DevizniValuta
                        {
                            DozvoljenaValuta = valuta.DozvoljenaValuta,
                            PripadaDeviznom = d
                        };
                        d.Valute.Add(v);
                    }

                    session.Save(d);
                    transaction.Commit();

                    // Vrati generisani ID
                    db.Id = d.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        public static void DodajStedni(StedniBasic sb, string jmbg, string pib)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    FizickoLice fl = new FizickoLice();
                    PravnoLice pl = new PravnoLice();

                    fl = session.Query<FizickoLice>()
                        .Where(x => x.Jmbg == jmbg)
                        .FirstOrDefault();
                    pl = session.Query<PravnoLice>()
                        .Where(x => x.Pib == pib)
                        .FirstOrDefault();

                    Stedni s = new Stedni
                    {
                        BrojRacuna = sb.BrojRacuna?.Trim(),
                        Valuta = sb.Valuta?.Trim(),
                        TrenutnoStanje = sb.TrenutnoStanje,
                        DatumOtvaranja = sb.DatumOtvaranja,
                        Status = sb.Status?.Trim(),
                        DozvoljeniMinus = sb.DozvoljeniMinus,
                        Komentar = sb.Komentar?.Trim(),
                        TipRacuna = sb.TipRacuna?.Trim(),
                        KamatnaStopa = sb.KamatnaStopa,

                        MinimalniIznosOtvaranja = sb.MinimalniIznosOtvaranja ?? 0,
                        FrekvKapitKamate = sb.FrekvKapitalizKamate,

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl
                    };

                    foreach (StedniBonusBasic bonus in sb.StedniBonusi)
                    {
                        StedniBonus sbonus = new StedniBonus
                        {
                            Bonus = bonus.Bonus,
                            PripadaStednom = s
                        };
                        s.Bonusi.Add(sbonus);
                    }

                    foreach (StedniUsloviPodizanjaBasic su in sb.StedniUsloviPodizanja)
                    {
                        StedniUslovPodizanja uslov = new StedniUslovPodizanja
                        {
                            UslovPodizanja = su.UslovPodizanja,
                            PripadaStednom = s
                        };
                        s.UsloviPodizanja.Add(uslov);
                    }

                    session.Save(s);
                    transaction.Commit();

                    // Vrati generisani ID
                    sb.Id = s.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        public static void DodajZiro(ZiroBasic zb, string jmbg, string pib)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    FizickoLice fl = new FizickoLice();
                    PravnoLice pl = new PravnoLice();

                    fl = session.Query<FizickoLice>()
                        .Where(x => x.Jmbg == jmbg)
                        .FirstOrDefault();
                    pl = session.Query<PravnoLice>()
                        .Where(x => x.Pib == pib)
                        .FirstOrDefault();

                    Ziro z = new Ziro
                    {
                        BrojRacuna = zb.BrojRacuna?.Trim(),
                        Valuta = zb.Valuta?.Trim(),
                        TrenutnoStanje = zb.TrenutnoStanje,
                        DatumOtvaranja = zb.DatumOtvaranja,
                        Status = zb.Status?.Trim(),
                        DozvoljeniMinus = zb.DozvoljeniMinus,
                        Komentar = zb.Komentar?.Trim(),
                        TipRacuna = zb.TipRacuna?.Trim(),
                        KamatnaStopa = zb.KamatnaStopa,

                        Namena = zb.Namena?.Trim(),
                        ElektronskoBankarstvo = zb.ElektronskoBankarstvo,
                        LimitZaMasovnaPlacanja = zb.LimitZaMasovnaPlacanja ?? 0,
                        IntegracijaSaSistemima = zb.IntegracijaSaSistemima,

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl
                    };

                    session.Save(z);
                    transaction.Commit();

                    // Vrati generisani ID
                    zb.Id = z.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        #endregion
    }
}

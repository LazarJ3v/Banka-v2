using Banka.Entiteti;
using DatabaseAccess.DTOs;
using DatabaseAccess.Enumi;
using FluentNHibernate.Conventions;
using NHibernate;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace DatabaseAccess
{
    public class DataProvider
    {
        #region FizickaLica

        public static void DodajFizickoLice(FizickoLicePregled fl)
        {
            Validacija.ValidirajIme(fl.Ime, "Ime");
            Validacija.ValidirajIme(fl.Prezime, "Prezime");
            Validacija.ValidirajJmbg(fl.Jmbg);
            Validacija.ValidirajBrojLicneKarte(fl.BrojLicneKarte);
            Validacija.ValidirajDatumRodjenja(fl.DatumRodjenja);
            Validacija.ValidirajAdresu(fl.Adresa);
            Validacija.ValidirajGrad(fl.Grad);
            Validacija.ValidirajTelefon(fl.Telefon);
            Validacija.ValidirajEmail(fl.Email);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var f = session.Query<FizickoLice>()
                        .Where(x => x.Jmbg == fl.Jmbg || x.BrojLicneKarte == fl.BrojLicneKarte)
                        .FirstOrDefault();

                    if (f != null)
                    {
                        if (f.Jmbg == fl.Jmbg)
                            throw new InvalidOperationException("Postoji fizičko lice sa istim JMBG.");
                        throw new InvalidOperationException("Postoji fizičko lice sa istim brojem lične karte.");
                    }

                    var fizickoLice = new FizickoLice
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

                    session.Save(fizickoLice);
                    transaction.Commit();

                    fl.Id = fizickoLice.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju fizičkog lica: " + ex.Message, ex);
                }
            }
        }

        public static FizickoLicePregled VratiFizickoLice(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                try
                {
                    var fizickoLice = session.Get<FizickoLice>(id);

                    if (fizickoLice == null)
                        return null;

                    return new FizickoLicePregled
                    {
                        Id = fizickoLice.Id,
                        Ime = fizickoLice.Ime,
                        Prezime = fizickoLice.Prezime,
                        Jmbg = fizickoLice.Jmbg,
                        BrojLicneKarte = fizickoLice.BrojLicneKarte,
                        DatumRodjenja = fizickoLice.DatumRodjenja,
                        Adresa = fizickoLice.Adresa,
                        Grad = fizickoLice.Grad,
                        Telefon = fizickoLice.Telefon,
                        Email = fizickoLice.Email,
                        Status = fizickoLice.Status,
                        Komentar = fizickoLice.Komentar
                    };
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(
                        "Greška pri učitavanju fizičkog lica.", ex);
                }
            }
        }

        public static FizickoLicePregled IzmeniFizickoLice(FizickoLicePregled fl)
        {
            Validacija.ValidirajIme(fl.Ime, "Ime");
            Validacija.ValidirajIme(fl.Prezime, "Prezime");
            Validacija.ValidirajJmbg(fl.Jmbg);
            Validacija.ValidirajBrojLicneKarte(fl.BrojLicneKarte);
            Validacija.ValidirajDatumRodjenja(fl.DatumRodjenja);
            Validacija.ValidirajAdresu(fl.Adresa);
            Validacija.ValidirajGrad(fl.Grad);
            Validacija.ValidirajTelefon(fl.Telefon);
            Validacija.ValidirajEmail(fl.Email);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var f = session.Query<FizickoLice>()
                        .Where(x => x.Jmbg == fl.Jmbg || x.BrojLicneKarte == fl.BrojLicneKarte)
                        .FirstOrDefault();

                    if (f != null)
                    {
                        if (f.Jmbg == fl.Jmbg)
                            throw new InvalidOperationException("Postoji fizičko lice sa istim JMBG.");
                        throw new InvalidOperationException("Postoji fizičko lice sa istim brojem lične karte.");
                    }

                    var fizickoLice = session.Get<FizickoLice>(fl.Id);

                    if (fizickoLice == null)
                        return null;

                    fizickoLice.Ime = fl.Ime?.Trim();
                    fizickoLice.Prezime = fl.Prezime?.Trim();
                    fizickoLice.Jmbg = fl.Jmbg?.Trim();
                    fizickoLice.BrojLicneKarte = fl.BrojLicneKarte?.Trim();
                    fizickoLice.DatumRodjenja = fl.DatumRodjenja;
                    fizickoLice.Adresa = fl.Adresa?.Trim();
                    fizickoLice.Grad = fl.Grad?.Trim();
                    fizickoLice.Telefon = fl.Telefon?.Trim();
                    fizickoLice.Email = fl.Email?.Trim();
                    fizickoLice.Status = fl.Status;
                    fizickoLice.Komentar = fl.Komentar?.Trim();

                    session.Update(fizickoLice);
                    transaction.Commit();

                    return fl;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw new InvalidOperationException(
                        "Greška pri izmeni fizičkog lica: " + ex.Message, ex);
                }
            }
        }

        public static void ObrisiFizickoLice(int id)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var fizickoLice = session.Get<FizickoLice>(id);

                    if (fizickoLice == null)
                        return;

                    if (!fizickoLice.Racuni.IsEmpty())
                        throw new InvalidOperationException(
                            "Ne možete obrisati fizičko lice koje poseduje račune.");

                    session.Delete(fizickoLice);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw new InvalidOperationException(
                        "Greška pri brisanju fizičkog lica: " + ex.Message, ex);
                }
            }
        }

        public static List<FizickoLicePregled> VratiFizickaLica(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<FizickoLice> entiteti = session.Query<FizickoLice>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new FizickoLicePregled
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

        public static void DodajPravnoLice(PravnoLicePregled pl)
        {
            Validacija.ValidirajNazivFirme(pl.NazivFirme);
            Validacija.ValidirajPib(pl.Pib);
            Validacija.ValidirajAdresu(pl.Adresa);
            Validacija.ValidirajGrad(pl.Grad);
            Validacija.ValidirajTelefon(pl.Telefon);
            Validacija.ValidirajEmail(pl.Email);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var p = session.Query<PravnoLice>()
                        .Where(x => x.Pib == pl.Pib)
                        .FirstOrDefault();

                    if (p != null)
                        throw new InvalidOperationException("Postoji pravno lice sa istim PIB.");

                    var pravnoLice = new PravnoLice
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

                    session.Save(pravnoLice);
                    transaction.Commit();

                    pl.Id = pravnoLice.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju pravnog lica: " + ex.Message, ex);
                }
            }
        }

        public static PravnoLicePregled VratiPravnoLice(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                try
                {
                    var pravnoLice = session.Load<PravnoLice>(id);

                    return new PravnoLicePregled
                    {
                        Id = pravnoLice.Id,
                        NazivFirme = pravnoLice.NazivFirme,
                        Pib = pravnoLice.Pib,
                        Adresa = pravnoLice.Adresa,
                        Grad = pravnoLice.Grad,
                        Telefon = pravnoLice.Telefon,
                        Email = pravnoLice.Email,
                        Status = pravnoLice.Status,
                        Komentar = pravnoLice.Komentar
                    };
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(
                        "Greška pri učitavanju pravnog lica.", ex);
                }
            }
        }

        public static PravnoLicePregled IzmeniPravnoLice(PravnoLicePregled pl)
        {
            Validacija.ValidirajNazivFirme(pl.NazivFirme);
            Validacija.ValidirajPib(pl.Pib);
            Validacija.ValidirajAdresu(pl.Adresa);
            Validacija.ValidirajGrad(pl.Grad);
            Validacija.ValidirajTelefon(pl.Telefon);
            Validacija.ValidirajEmail(pl.Email);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var p = session.Query<PravnoLice>()
                        .Where(x => x.Pib == pl.Pib)
                        .FirstOrDefault();

                    if (p != null)
                        throw new InvalidOperationException("Postoji pravno lice sa istim PIB.");

                    var pravnoLice = session.Load<PravnoLice>(pl.Id);

                    pravnoLice.NazivFirme = pl.NazivFirme;
                    pravnoLice.Pib = pl.Pib;
                    pravnoLice.Adresa = pl.Adresa;
                    pravnoLice.Grad = pl.Grad;
                    pravnoLice.Telefon = pl.Telefon;
                    pravnoLice.Email = pl.Email;
                    pravnoLice.Status = pl.Status;
                    pravnoLice.Komentar = pl.Komentar;

                    session.Update(pravnoLice);
                    transaction.Commit();

                    return pl;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw new InvalidOperationException(
                        "Greška pri izmeni pravnog lica: " + ex.Message, ex);
                }
            }
        }

        public static void ObrisiPravnoLice(int id)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var pravnoLice = session.Get<PravnoLice>(id);

                    if (pravnoLice == null)
                        return;

                    if (!pravnoLice.Racuni.IsEmpty())
                        throw new InvalidOperationException(
                            "Ne možete obrisati pravno lice koje poseduje račune.");

                    session.Delete(pravnoLice);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw new InvalidOperationException(
                        "Greška pri brisanju pravnog lica: " + ex.Message, ex);
                }
            }
        }

        public static List<PravnoLicePregled> VratiPravnaLica(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<PravnoLice> entiteti = session.Query<PravnoLice>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new PravnoLicePregled
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

        public static void DodajRacun(RacunPregled r, string jmbg, string pib)
        {
            Validacija.ValidirajBrojRacuna(r.BrojRacuna);
            Validacija.ValidirajValutu(r.Valuta);
            r.Status = Validacija.ValidirajEnum<StatusRacuna>(r.Status, nameof(r.Status));
            r.TipRacuna = Validacija.ValidirajEnum<TipRacuna>(r.TipRacuna, nameof(r.TipRacuna));
            Validacija.ValidirajIznos(r.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(r.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(r.KamatnaStopa);

            if (r == null)
                throw new ArgumentNullException(nameof(r));

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

                    if (fl == null && pl == null)
                    {
                        throw new InvalidOperationException("Nema pravnog ili fizickog lica");
                    }

                    var rac = session.Query<Racun>()
                        .Where(x => x.BrojRacuna == r.BrojRacuna)
                        .FirstOrDefault();

                    if (rac != null)
                        throw new InvalidOperationException(
                            "Ovaj broj računa već postoji.");

                    Racun racun = new Racun
                    {
                        BrojRacuna = r.BrojRacuna?.Trim(),
                        Valuta = r.Valuta?.Trim(),
                        TrenutnoStanje = r.TrenutnoStanje,
                        DatumOtvaranja = r.DatumOtvaranja,
                        Status = r.Status,
                        DozvoljeniMinus = r.DozvoljeniMinus,
                        Komentar = r.Komentar?.Trim(),
                        TipRacuna = r.TipRacuna.Trim(),
                        KamatnaStopa = r.KamatnaStopa,

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl
                    };

                    session.Save(racun);
                    transaction.Commit();

                    r.Id = racun.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju računa: " + ex.Message, ex);
                }
            }
        }

        public static RacunPregled VratiRacun(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Racun r = session.Load<Racun>(id);

                return new RacunPregled
                {
                    Id = r.Id,
                    BrojRacuna = r.BrojRacuna,
                    Valuta = r.Valuta,
                    TrenutnoStanje = r.TrenutnoStanje,
                    DatumOtvaranja = r.DatumOtvaranja,
                    Status = r.Status,
                    DozvoljeniMinus = r.DozvoljeniMinus,
                    Komentar = r.Komentar,
                    TipRacuna = r.TipRacuna,
                    KamatnaStopa = r.KamatnaStopa,

                    FizickoLice = r.PripadaFizickomLicu != null
                        ? new FizickoLicePregled
                        {
                            Id = r.PripadaFizickomLicu.Id,
                            Ime = r.PripadaFizickomLicu.Ime,
                            Prezime = r.PripadaFizickomLicu.Prezime,
                            Jmbg = r.PripadaFizickomLicu.Jmbg
                        }
                        : null,

                    PravnoLice = r.PripadaPravnomLicu != null
                        ? new PravnoLicePregled
                        {
                            Id = r.PripadaPravnomLicu.Id,
                            NazivFirme = r.PripadaPravnomLicu.NazivFirme,
                            Pib = r.PripadaPravnomLicu.Pib
                        }
                        : null
                };
            }
        }

        public static RacunPregled VratiRacun(string brojRacuna)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Racun r = session.Query<Racun>()
                    .Where(x => x.BrojRacuna == brojRacuna)
                    .FirstOrDefault();

                return new RacunPregled
                {
                    Id = r.Id,
                    BrojRacuna = r.BrojRacuna,
                    Valuta = r.Valuta,
                    TrenutnoStanje = r.TrenutnoStanje,
                    DatumOtvaranja = r.DatumOtvaranja,
                    Status = r.Status,
                    DozvoljeniMinus = r.DozvoljeniMinus,
                    Komentar = r.Komentar,
                    TipRacuna = r.TipRacuna,
                    KamatnaStopa = r.KamatnaStopa,

                    FizickoLice = r.PripadaFizickomLicu != null
                        ? new FizickoLicePregled
                        {
                            Id = r.PripadaFizickomLicu.Id,
                            Ime = r.PripadaFizickomLicu.Ime,
                            Prezime = r.PripadaFizickomLicu.Prezime,
                            Jmbg = r.PripadaFizickomLicu.Jmbg
                        }
                        : null,

                    PravnoLice = r.PripadaPravnomLicu != null
                        ? new PravnoLicePregled
                        {
                            Id = r.PripadaPravnomLicu.Id,
                            NazivFirme = r.PripadaPravnomLicu.NazivFirme,
                            Pib = r.PripadaPravnomLicu.Pib
                        }
                        : null
                };
            }
        }

        public static void IzmeniRacun(RacunPregled r)
        {
            Validacija.ValidirajBrojRacuna(r.BrojRacuna);
            Validacija.ValidirajValutu(r.Valuta);
            r.Status = Validacija.ValidirajEnum<StatusRacuna>(r.Status, nameof(r.Status));
            Validacija.ValidirajIznos(r.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(r.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(r.KamatnaStopa);

            if (r == null)
                throw new ArgumentNullException(nameof(r));

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var racun = session.Load<Racun>(r.Id);

                    racun.BrojRacuna = r.BrojRacuna?.Trim();
                    racun.Valuta = r.Valuta?.Trim();
                    racun.TrenutnoStanje = r.TrenutnoStanje;
                    racun.DatumOtvaranja = r.DatumOtvaranja;
                    racun.Status = r.Status;
                    racun.DozvoljeniMinus = r.DozvoljeniMinus;
                    racun.Komentar = r.Komentar?.Trim();
                    racun.KamatnaStopa = r.KamatnaStopa;

                    session.Update(racun);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izmeni računa", ex);
                }
            }
        }

        public static void ObrisiRacun(int id)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Racun r = session.Load<Racun>(id);

                    if (!r.Transakcije.IsEmpty() ||
                        !r.Depoziti.IsEmpty() ||
                        !r.Krediti.IsEmpty() ||
                        !r.Kamate.IsEmpty() ||
                        !r.SigurnosneKontrole.IsEmpty())
                    {
                        throw new InvalidOperationException("Račun ima poslovne zapise i ne može biti obrisan");
                    }
                    session.Delete(r);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri brisanju računa: " + ex.Message, ex);
                }
            }
        }

        public static List<RacunPregled> VratiRacune(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Racun> entiteti = session.Query<Racun>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new RacunPregled
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
                        ? new FizickoLicePregled
                        {
                            Id = x.PripadaFizickomLicu.Id,
                            Ime = x.PripadaFizickomLicu.Ime,
                            Prezime = x.PripadaFizickomLicu.Prezime
                        }
                        : null,

                    PravnoLice = x.PripadaPravnomLicu != null
                        ? new PravnoLicePregled
                        {
                            Id = x.PripadaPravnomLicu.Id,
                            NazivFirme = x.PripadaPravnomLicu.NazivFirme
                        }
                        : null
                }).ToList();
            }
        }

        #region Tekuci

        public static void DodajTekuci(TekuciPregled tb, string jmbg, string pib)
        {
            Validacija.ValidirajBrojRacuna(tb.BrojRacuna);
            Validacija.ValidirajValutu(tb.Valuta);
            tb.Status = Validacija.ValidirajEnum<StatusRacuna>(tb.Status, nameof(tb.Status));
            Validacija.ValidirajIznos(tb.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(tb.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(tb.KamatnaStopa);
            Validacija.ValidirajIznos(tb.MesecniLimit ?? 0, "Mesečni limit");

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

                    if (fl == null && pl == null)
                    {
                        throw new InvalidOperationException("Nema pravnog ili fizickog lica");
                    }

                    var rac = session.Query<Racun>()
                       .Where(x => x.BrojRacuna == tb.BrojRacuna)
                       .FirstOrDefault();

                    if (rac != null)
                        throw new InvalidOperationException(
                            "Ovaj broj računa već postoji.");

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

                    session.Save(t);
                    transaction.Commit();

                    tb.Id = t.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju tekućeg računa: " + ex.Message, ex);
                }
            }
        }

        public static TekuciPregled VratiTekuci(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                var tekuci = session.Load<Tekuci>(id);

                var dto = new TekuciPregled
                {
                    Id = tekuci.Id,
                    BrojRacuna = tekuci.BrojRacuna,
                    Valuta = tekuci.Valuta,
                    TrenutnoStanje = tekuci.TrenutnoStanje,
                    DatumOtvaranja = tekuci.DatumOtvaranja,
                    Status = tekuci.Status,
                    DozvoljeniMinus = tekuci.DozvoljeniMinus,
                    Komentar = tekuci.Komentar,
                    TipRacuna = tekuci.TipRacuna,
                    KamatnaStopa = tekuci.KamatnaStopa,

                    PlatnaKartica = tekuci.PlatnaKartica,
                    MesecniLimit = tekuci.MesecniLimit,

                    FizickoLice = tekuci.PripadaFizickomLicu != null
                        ? new FizickoLicePregled { Id = tekuci.PripadaFizickomLicu.Id, Ime = tekuci.PripadaFizickomLicu.Ime, Prezime = tekuci.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = tekuci.PripadaPravnomLicu != null
                        ? new PravnoLicePregled { Id = tekuci.PripadaPravnomLicu.Id, NazivFirme = tekuci.PripadaPravnomLicu.NazivFirme }
                        : null
                };

                return dto;
            }
        }

        public static void IzmeniTekuci(TekuciPregled tb)
        {
            Validacija.ValidirajBrojRacuna(tb.BrojRacuna);
            Validacija.ValidirajValutu(tb.Valuta);
            tb.Status = Validacija.ValidirajEnum<StatusRacuna>(tb.Status, nameof(tb.Status));
            Validacija.ValidirajIznos(tb.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(tb.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(tb.KamatnaStopa);
            Validacija.ValidirajIznos(tb.MesecniLimit ?? 0, "Mesečni limit");

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var tekuci = session.Load<Tekuci>(tb.Id);

                    tekuci.BrojRacuna = tb.BrojRacuna?.Trim();
                    tekuci.Valuta = tb.Valuta?.Trim();
                    tekuci.TrenutnoStanje = tb.TrenutnoStanje;
                    tekuci.Status = tb.Status?.Trim();
                    tekuci.DozvoljeniMinus = tb.DozvoljeniMinus;
                    tekuci.Komentar = tb.Komentar?.Trim();
                    tekuci.KamatnaStopa = tb.KamatnaStopa;

                    tekuci.PlatnaKartica = tb.PlatnaKartica;
                    tekuci.MesecniLimit = tb.MesecniLimit ?? 0;

                    session.Update(tekuci);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri izmeni tekućeg računa", ex);
                }
            }
        }

        public static IList<TekuciPregled> VratiTekuce(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Tekuci> entiteti = session.Query<Tekuci>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(t => new TekuciPregled
                {
                    Id = t.Id,
                    BrojRacuna = t.BrojRacuna,
                    Valuta = t.Valuta,
                    TrenutnoStanje = t.TrenutnoStanje,
                    DatumOtvaranja = t.DatumOtvaranja,
                    Status = t.Status,
                    DozvoljeniMinus = t.DozvoljeniMinus,
                    Komentar = t.Komentar,
                    TipRacuna = t.TipRacuna,
                    KamatnaStopa = t.KamatnaStopa,

                    PlatnaKartica = t.PlatnaKartica,
                    MesecniLimit = t.MesecniLimit,

                    FizickoLice = t.PripadaFizickomLicu != null
                        ? new FizickoLicePregled { Id = t.PripadaFizickomLicu.Id, Ime = t.PripadaFizickomLicu.Ime, Prezime = t.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = t.PripadaPravnomLicu != null
                        ? new PravnoLicePregled { Id = t.PripadaPravnomLicu.Id, NazivFirme = t.PripadaPravnomLicu.NazivFirme }
                        : null
                }).ToList();
            }
        }

        #endregion

        #region Devizni

        public static void DodajDevizni(DevizniPregled db, string jmbg, string pib)
        {
            Validacija.ValidirajBrojRacuna(db.BrojRacuna);
            Validacija.ValidirajValutu(db.Valuta);
            db.Status = Validacija.ValidirajEnum<StatusRacuna>(db.Status, nameof(db.Status));
            db.Namena = Validacija.ValidirajEnum<DevizniNamena>(db.Namena, nameof(db.Namena));
            Validacija.ValidirajIznos(db.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(db.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(db.KamatnaStopa);
            Validacija.ValidirajIznos(db.KursnaRazlika ?? 0, "Kursna razlika");

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

                    if (fl == null && pl == null)
                    {
                        throw new InvalidOperationException("Nema pravnog ili fizickog lica");
                    }

                    var rac = session.Query<Racun>()
                       .Where(x => x.BrojRacuna == db.BrojRacuna)
                       .FirstOrDefault();

                    if (rac != null)
                        throw new InvalidOperationException(
                            "Ovaj broj računa već postoji.");

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

                        Namena = db.Namena?.Trim(),
                        KursnaRazlika = db.KursnaRazlika ?? 0,

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl
                    };

                    session.Save(d);
                    transaction.Commit();

                    db.Id = d.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju deviznog računa: " + ex.Message, ex);
                }
            }
        }

        public static DevizniPregled VratiDevizni(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Devizni d = session.Load<Devizni>(id);

                DevizniPregled dto = new DevizniPregled
                {
                    Id = d.Id,
                    BrojRacuna = d.BrojRacuna,
                    Valuta = d.Valuta,
                    TrenutnoStanje = d.TrenutnoStanje,
                    DatumOtvaranja = d.DatumOtvaranja,
                    Status = d.Status,
                    DozvoljeniMinus = d.DozvoljeniMinus,
                    Komentar = d.Komentar,
                    TipRacuna = d.TipRacuna,
                    KamatnaStopa = d.KamatnaStopa,

                    Namena = d.Namena,
                    KursnaRazlika = d.KursnaRazlika,

                    FizickoLice = d.PripadaFizickomLicu != null
                        ? new FizickoLicePregled { Id = d.PripadaFizickomLicu.Id, Ime = d.PripadaFizickomLicu.Ime, Prezime = d.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = d.PripadaPravnomLicu != null
                        ? new PravnoLicePregled { Id = d.PripadaPravnomLicu.Id, NazivFirme = d.PripadaPravnomLicu.NazivFirme }
                        : null
                };

                return dto;
            }
        }

        public static void IzmeniDevizni(DevizniPregled db)
        {
            Validacija.ValidirajBrojRacuna(db.BrojRacuna);
            Validacija.ValidirajValutu(db.Valuta);
            db.Status = Validacija.ValidirajEnum<StatusRacuna>(db.Status, nameof(db.Status));
            db.Namena = Validacija.ValidirajEnum<DevizniNamena>(db.Namena, nameof(db.Namena));
            Validacija.ValidirajIznos(db.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(db.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(db.KamatnaStopa);
            Validacija.ValidirajIznos(db.KursnaRazlika ?? 0, "Kursna razlika");

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Devizni d = session.Load<Devizni>(db.Id);

                    d.BrojRacuna = db.BrojRacuna?.Trim();
                    d.Valuta = db.Valuta?.Trim();
                    d.TrenutnoStanje = db.TrenutnoStanje;
                    d.Status = db.Status?.Trim();
                    d.DozvoljeniMinus = db.DozvoljeniMinus;
                    d.Komentar = db.Komentar?.Trim();
                    d.KamatnaStopa = db.KamatnaStopa;

                    d.Namena = db.Namena?.Trim();
                    d.KursnaRazlika = db.KursnaRazlika ?? 0;

                    session.Update(d);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izmeni deviznog računa", ex);
                }
            }
        }

        public static IList<DevizniPregled> VratiDevizne(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Devizni> entiteti = session.Query<Devizni>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(d => new DevizniPregled
                {
                    Id = d.Id,
                    BrojRacuna = d.BrojRacuna,
                    Valuta = d.Valuta,
                    TrenutnoStanje = d.TrenutnoStanje,
                    DatumOtvaranja = d.DatumOtvaranja,
                    Status = d.Status,
                    DozvoljeniMinus = d.DozvoljeniMinus,
                    Komentar = d.Komentar,
                    TipRacuna = d.TipRacuna,
                    KamatnaStopa = d.KamatnaStopa,

                    Namena = d.Namena,
                    KursnaRazlika = d.KursnaRazlika,

                    FizickoLice = d.PripadaFizickomLicu != null
                        ? new FizickoLicePregled { Id = d.PripadaFizickomLicu.Id, Ime = d.PripadaFizickomLicu.Ime, Prezime = d.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = d.PripadaPravnomLicu != null
                        ? new PravnoLicePregled { Id = d.PripadaPravnomLicu.Id, NazivFirme = d.PripadaPravnomLicu.NazivFirme }
                        : null
                }).ToList();
            }
        }

        #endregion

        #region Stedni

        public static void DodajStedni(StedniPregled sb, string jmbg, string pib)
        {
            Validacija.ValidirajBrojRacuna(sb.BrojRacuna);
            Validacija.ValidirajValutu(sb.Valuta);
            sb.Status = Validacija.ValidirajEnum<StatusRacuna>(sb.Status, nameof(sb.Status));
            Validacija.ValidirajIznos(sb.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(sb.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(sb.KamatnaStopa);
            Validacija.ValidirajIznos(sb.MinimalniIznosOtvaranja ?? 0, "Minimalni iznos otvaranja");

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

                    if (fl == null && pl == null)
                    {
                        throw new InvalidOperationException("Nema pravnog ili fizickog lica");
                    }

                    var rac = session.Query<Racun>()
                       .Where(x => x.BrojRacuna == sb.BrojRacuna)
                       .FirstOrDefault();

                    if (rac != null)
                        throw new InvalidOperationException(
                            "Ovaj broj računa već postoji.");

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

                    session.Save(s);
                    transaction.Commit();

                    sb.Id = s.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju štednog računa: " + ex.Message, ex);
                }
            }
        }

        public static StedniPregled VratiStedni(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Stedni s = session.Load<Stedni>(id);

                StedniPregled dto = new StedniPregled
                {
                    Id = s.Id,
                    BrojRacuna = s.BrojRacuna,
                    Valuta = s.Valuta,
                    TrenutnoStanje = s.TrenutnoStanje,
                    DatumOtvaranja = s.DatumOtvaranja,
                    Status = s.Status,
                    DozvoljeniMinus = s.DozvoljeniMinus,
                    Komentar = s.Komentar,
                    TipRacuna = s.TipRacuna,
                    KamatnaStopa = s.KamatnaStopa,

                    MinimalniIznosOtvaranja = s.MinimalniIznosOtvaranja,
                    FrekvKapitalizKamate = s.FrekvKapitKamate,

                    FizickoLice = s.PripadaFizickomLicu != null
                        ? new FizickoLicePregled { Id = s.PripadaFizickomLicu.Id, Ime = s.PripadaFizickomLicu.Ime, Prezime = s.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = s.PripadaPravnomLicu != null
                        ? new PravnoLicePregled { Id = s.PripadaPravnomLicu.Id, NazivFirme = s.PripadaPravnomLicu.NazivFirme }
                        : null
                };

                return dto;
            }
        }

        public static void IzmeniStedni(StedniPregled sb)
        {
            Validacija.ValidirajBrojRacuna(sb.BrojRacuna);
            Validacija.ValidirajValutu(sb.Valuta);
            sb.Status = Validacija.ValidirajEnum<StatusRacuna>(sb.Status, nameof(sb.Status));
            Validacija.ValidirajIznos(sb.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(sb.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(sb.KamatnaStopa);
            Validacija.ValidirajIznos(sb.MinimalniIznosOtvaranja ?? 0, "Minimalni iznos otvaranja");

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Stedni s = session.Load<Stedni>(sb.Id);

                    s.BrojRacuna = sb.BrojRacuna?.Trim();
                    s.Valuta = sb.Valuta?.Trim();
                    s.TrenutnoStanje = sb.TrenutnoStanje;
                    s.Status = sb.Status?.Trim();
                    s.DozvoljeniMinus = sb.DozvoljeniMinus;
                    s.Komentar = sb.Komentar?.Trim();
                    s.KamatnaStopa = sb.KamatnaStopa;

                    s.MinimalniIznosOtvaranja = sb.MinimalniIznosOtvaranja ?? 0;
                    s.FrekvKapitKamate = sb.FrekvKapitalizKamate;

                    session.Update(s);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izmeni štednog računa", ex);
                }
            }
        }

        public static IList<StedniPregled> VratiStedne(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Stedni> entiteti = session.Query<Stedni>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(s => new StedniPregled
                {
                    Id = s.Id,
                    BrojRacuna = s.BrojRacuna,
                    Valuta = s.Valuta,
                    TrenutnoStanje = s.TrenutnoStanje,
                    DatumOtvaranja = s.DatumOtvaranja,
                    Status = s.Status,
                    DozvoljeniMinus = s.DozvoljeniMinus,
                    Komentar = s.Komentar,
                    TipRacuna = s.TipRacuna,
                    KamatnaStopa = s.KamatnaStopa,

                    MinimalniIznosOtvaranja = s.MinimalniIznosOtvaranja,
                    FrekvKapitalizKamate = s.FrekvKapitKamate,

                    FizickoLice = s.PripadaFizickomLicu != null
                        ? new FizickoLicePregled { Id = s.PripadaFizickomLicu.Id, Ime = s.PripadaFizickomLicu.Ime, Prezime = s.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = s.PripadaPravnomLicu != null
                        ? new PravnoLicePregled { Id = s.PripadaPravnomLicu.Id, NazivFirme = s.PripadaPravnomLicu.NazivFirme }
                        : null
                }).ToList();
            }
        }

        #endregion

        #region Ziro

        public static void DodajZiro(ZiroPregled zb, string jmbg, string pib)
        {
            Validacija.ValidirajBrojRacuna(zb.BrojRacuna);
            Validacija.ValidirajValutu(zb.Valuta);
            zb.Status = Validacija.ValidirajEnum<StatusRacuna>(zb.Status, nameof(zb.Status));
            Validacija.ValidirajIznos(zb.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(zb.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(zb.KamatnaStopa);
            Validacija.ValidirajIznos(zb.LimitZaMasovnaPlacanja ?? 0, "Limit za masovna plaćanja");

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

                    if (fl == null && pl == null)
                    {
                        throw new InvalidOperationException("Nema pravnog ili fizickog lica");
                    }

                    var rac = session.Query<Racun>()
                       .Where(x => x.BrojRacuna == zb.BrojRacuna)
                       .FirstOrDefault();

                    if (rac != null)
                        throw new InvalidOperationException(
                            "Ovaj broj računa već postoji.");

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

                    zb.Id = z.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju žiro računa: " + ex.Message, ex);
                }
            }
        }

        public static ZiroPregled VratiZiro(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Ziro z = session.Load<Ziro>(id);

                return new ZiroPregled
                {
                    Id = z.Id,
                    BrojRacuna = z.BrojRacuna,
                    Valuta = z.Valuta,
                    TrenutnoStanje = z.TrenutnoStanje,
                    DatumOtvaranja = z.DatumOtvaranja,
                    Status = z.Status,
                    DozvoljeniMinus = z.DozvoljeniMinus,
                    Komentar = z.Komentar,
                    TipRacuna = z.TipRacuna,
                    KamatnaStopa = z.KamatnaStopa,

                    Namena = z.Namena,
                    ElektronskoBankarstvo = z.ElektronskoBankarstvo,
                    LimitZaMasovnaPlacanja = z.LimitZaMasovnaPlacanja,
                    IntegracijaSaSistemima = z.IntegracijaSaSistemima,

                    FizickoLice = z.PripadaFizickomLicu != null
                        ? new FizickoLicePregled { Id = z.PripadaFizickomLicu.Id, Ime = z.PripadaFizickomLicu.Ime, Prezime = z.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = z.PripadaPravnomLicu != null
                        ? new PravnoLicePregled { Id = z.PripadaPravnomLicu.Id, NazivFirme = z.PripadaPravnomLicu.NazivFirme }
                        : null
                };
            }
        }

        public static void IzmeniZiro(ZiroPregled zb)
        {
            Validacija.ValidirajBrojRacuna(zb.BrojRacuna);
            Validacija.ValidirajValutu(zb.Valuta);
            zb.Status = Validacija.ValidirajEnum<StatusRacuna>(zb.Status, nameof(zb.Status));
            Validacija.ValidirajIznos(zb.TrenutnoStanje, "Trenutno stanje");
            Validacija.ValidirajIznos(zb.DozvoljeniMinus, "Dozvoljeni minus");
            Validacija.ValidirajKamatnuStopu(zb.KamatnaStopa);
            Validacija.ValidirajIznos(zb.LimitZaMasovnaPlacanja ?? 0, "Limit za masovna plaćanja");

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Ziro z = session.Load<Ziro>(zb.Id);

                    z.BrojRacuna = zb.BrojRacuna?.Trim();
                    z.Valuta = zb.Valuta?.Trim();
                    z.TrenutnoStanje = zb.TrenutnoStanje;
                    z.Status = zb.Status?.Trim();
                    z.DozvoljeniMinus = zb.DozvoljeniMinus;
                    z.Komentar = zb.Komentar?.Trim();
                    z.KamatnaStopa = zb.KamatnaStopa;

                    z.Namena = zb.Namena?.Trim();
                    z.ElektronskoBankarstvo = zb.ElektronskoBankarstvo;
                    z.LimitZaMasovnaPlacanja = zb.LimitZaMasovnaPlacanja ?? 0;
                    z.IntegracijaSaSistemima = zb.IntegracijaSaSistemima;

                    session.Update(z);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izmeni žiro računa", ex);
                }
            }
        }

        public static IList<ZiroPregled> VratiZiroe(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Ziro> entiteti = session.Query<Ziro>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(z => new ZiroPregled
                {
                    Id = z.Id,
                    BrojRacuna = z.BrojRacuna,
                    Valuta = z.Valuta,
                    TrenutnoStanje = z.TrenutnoStanje,
                    DatumOtvaranja = z.DatumOtvaranja,
                    Status = z.Status,
                    DozvoljeniMinus = z.DozvoljeniMinus,
                    Komentar = z.Komentar,
                    TipRacuna = z.TipRacuna,
                    KamatnaStopa = z.KamatnaStopa,

                    Namena = z.Namena,
                    ElektronskoBankarstvo = z.ElektronskoBankarstvo,
                    LimitZaMasovnaPlacanja = z.LimitZaMasovnaPlacanja,
                    IntegracijaSaSistemima = z.IntegracijaSaSistemima,

                    FizickoLice = z.PripadaFizickomLicu != null
                        ? new FizickoLicePregled { Id = z.PripadaFizickomLicu.Id, Ime = z.PripadaFizickomLicu.Ime, Prezime = z.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = z.PripadaPravnomLicu != null
                        ? new PravnoLicePregled { Id = z.PripadaPravnomLicu.Id, NazivFirme = z.PripadaPravnomLicu.NazivFirme }
                        : null
                }).ToList();
            }
        }

        #endregion

        #endregion

        #region Transakcija

        public static void DodajTransakciju(TransakcijaPregled tb, string brojRacuna)
        {
            Validacija.ValidirajBrojRacuna(brojRacuna);
            Validacija.ValidirajValutu(tb.Valuta);
            tb.TipTransakcije = Validacija.ValidirajEnum<TipTransakcije>(tb.TipTransakcije, nameof(tb.TipTransakcije));
            tb.StatusTransakcije = Validacija.ValidirajEnum<StatusTransakcije>(tb.StatusTransakcije, nameof(tb.StatusTransakcije));
            Validacija.ValidirajIznos(tb.Iznos, "Iznos", dozvoliNulu: false);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Racun r = session.Query<Racun>()
                        .Where(x => x.BrojRacuna == brojRacuna)
                        .FirstOrDefault();

                    if (r == null)
                        throw new InvalidOperationException("Ne postoji račun.");

                    Transakcija t = new Transakcija
                    {
                        DatumIVreme = tb.DatumIVreme,
                        Tip = tb.TipTransakcije?.Trim(),
                        Status = tb.StatusTransakcije?.Trim(),
                        PodaciPrimaoca = tb.PodaciPrimaoca?.Trim(),
                        Referenca = tb.Referenca?.Trim(),
                        Valuta = tb.Valuta?.Trim(),
                        Iznos = tb.Iznos,
                        Opis = tb.Opis?.Trim(),
                        Komentar = tb.Komentar?.Trim(),

                        OdvijaSeNaRacun = r
                    };

                    session.Save(t);
                    transaction.Commit();

                    tb.Id = t.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju transakcije: " + ex.Message, ex);
                }
            }
        }

        public static TransakcijaPregled VratiTransakciju(int id)
        {
            ISession s = DataLayer.GetSession();
            using (ISession session = DataLayer.GetSession())
            {
                try
                {
                    Transakcija t = s.Load<Transakcija>(id);

                    return new TransakcijaPregled
                    {
                        Id = t.Id,
                        DatumIVreme = t.DatumIVreme,
                        TipTransakcije = t.Tip,
                        StatusTransakcije = t.Status,
                        PodaciPrimaoca = t.PodaciPrimaoca,
                        Referenca = t.Referenca,
                        Valuta = t.Valuta,
                        Iznos = t.Iznos,
                        Opis = t.Opis,
                        Komentar = t.Komentar,

                        Racun = t.OdvijaSeNaRacun != null
                            ? new RacunPregled
                            {
                                Id = t.OdvijaSeNaRacun.Id,
                                BrojRacuna = t.OdvijaSeNaRacun.BrojRacuna
                            }
                            : null
                    };
                }
                catch (Exception ec)
                {
                    throw new InvalidOperationException("Greška pri vraćanju transakcije", ec);
                }
            }
        }

        public static List<TransakcijaPregled> VratiTransakcije(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Transakcija> entiteti = session.Query<Transakcija>()
                    .OrderByDescending(x => x.DatumIVreme)
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new TransakcijaPregled
                {
                    Id = x.Id,
                    DatumIVreme = x.DatumIVreme,
                    TipTransakcije = x.Tip,
                    StatusTransakcije = x.Status,
                    PodaciPrimaoca = x.PodaciPrimaoca,
                    Referenca = x.Referenca,
                    Valuta = x.Valuta,
                    Iznos = x.Iznos,
                    Opis = x.Opis,
                    Komentar = x.Komentar,

                    Racun = x.OdvijaSeNaRacun != null
                        ? new RacunPregled
                        {
                            Id = x.OdvijaSeNaRacun.Id,
                            BrojRacuna = x.OdvijaSeNaRacun.BrojRacuna
                        }
                        : null
                }).ToList();
            }
        }

        public static List<TransakcijaPregled> VratiTransakcijeZaRacun(int racunId, int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Transakcija> entiteti = session.Query<Transakcija>()
                    .Where(x => x.OdvijaSeNaRacun.Id == racunId)
                    .OrderByDescending(x => x.DatumIVreme)
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new TransakcijaPregled
                {
                    Id = x.Id,
                    DatumIVreme = x.DatumIVreme,
                    TipTransakcije = x.Tip,
                    StatusTransakcije = x.Status,
                    PodaciPrimaoca = x.PodaciPrimaoca,
                    Referenca = x.Referenca,
                    Valuta = x.Valuta,
                    Iznos = x.Iznos,
                    Opis = x.Opis,
                    Komentar = x.Komentar,

                    Racun = x.OdvijaSeNaRacun != null
                        ? new RacunPregled
                        {
                            Id = x.OdvijaSeNaRacun.Id,
                            BrojRacuna = x.OdvijaSeNaRacun.BrojRacuna
                        }
                        : null
                }).ToList();
            }
        }

        public static void IzmeniTransakciju(TransakcijaPregled tb)
        {
            Validacija.ValidirajValutu(tb.Valuta);
            tb.TipTransakcije = Validacija.ValidirajEnum<TipTransakcije>(tb.TipTransakcije, nameof(tb.TipTransakcije));
            tb.StatusTransakcije = Validacija.ValidirajEnum<StatusTransakcije>(tb.StatusTransakcije, nameof(tb.StatusTransakcije));
            Validacija.ValidirajIznos(tb.Iznos, "Iznos", dozvoliNulu: false);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Transakcija t = session.Load<Transakcija>(tb.Id);

                    t.DatumIVreme = tb.DatumIVreme;
                    t.Tip = tb.TipTransakcije?.Trim();
                    t.Status = tb.StatusTransakcije?.Trim();
                    t.PodaciPrimaoca = tb.PodaciPrimaoca?.Trim();
                    t.Referenca = tb.Referenca?.Trim();
                    t.Valuta = tb.Valuta?.Trim();
                    t.Iznos = tb.Iznos;
                    t.Opis = tb.Opis?.Trim();
                    t.Komentar = tb.Komentar?.Trim();

                    session.Update(t);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izmeni transakcije", ex);
                }
            }
        }

        public static void ObrisiTransakciju(int id)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Transakcija t = session.Load<Transakcija>(id);
                    session.Delete(t);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri brisanju transakcije", ex);
                }
            }
        }

        public static void IzvrsiTransferIzmedjuRacuna(
            int racunPosiljaocaId, int racunPrimaocaId, decimal iznos, string opis, string komentar)
        {
            Validacija.ValidirajIznos(iznos, "Iznos", dozvoliNulu: false);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Racun posiljalac = session.Load<Racun>(racunPosiljaocaId);
                    Racun primalac = session.Load<Racun>(racunPrimaocaId);

                    if (posiljalac.TrenutnoStanje - posiljalac.DozvoljeniMinus < iznos)
                        throw new InvalidOperationException(
                            "Nedovoljno sredstava na računu pošiljaoca.");

                    string referenca = "TRF-" + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
                    DateTime datumIVreme = DateTime.Now;

                    Transakcija odliv = new Transakcija
                    {
                        DatumIVreme = datumIVreme,
                        Tip = "TRANSFER",
                        Status = "Izvršena",
                        PodaciPrimaoca = $"{primalac.BrojRacuna}",
                        Referenca = referenca,
                        Valuta = posiljalac.Valuta,
                        Iznos = iznos,
                        Opis = opis,
                        Komentar = komentar,
                        OdvijaSeNaRacun = posiljalac
                    };

                    Transakcija priliv = new Transakcija
                    {
                        DatumIVreme = datumIVreme,
                        Tip = "TRANSFER",
                        Status = "Izvršena",
                        PodaciPrimaoca = $"{posiljalac.BrojRacuna}",
                        Referenca = referenca,
                        Valuta = primalac.Valuta,
                        Iznos = iznos,
                        Opis = opis,
                        Komentar = komentar,
                        OdvijaSeNaRacun = primalac
                    };

                    posiljalac.TrenutnoStanje -= iznos;
                    primalac.TrenutnoStanje += iznos;

                    session.Save(odliv);
                    session.Save(priliv);
                    session.Update(posiljalac);
                    session.Update(primalac);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izvršavanju transfera", ex);
                }
            }
        }

        #endregion

        #region Depozit

        public static void DodajDepozit(DepozitPregled db, string brojRacuna)
        {
            Validacija.ValidirajBrojRacuna(brojRacuna);
            Validacija.ValidirajValutu(db.Valuta);
            db.StatusDepozita = Validacija.ValidirajEnum<StatusDepozita>(db.StatusDepozita, nameof(db.StatusDepozita));
            Validacija.ValidirajIznos(db.Iznos, "Iznos", dozvoliNulu: false);
            Validacija.ValidirajKamatnuStopu(db.KamatnaStopa);
            Validacija.ValidirajPeriodOrocenja(db.PeriodOrocenja);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    FizickoLice fl;
                    PravnoLice pl;

                    Racun r = session.Query<Racun>()
                        .Where(x => x.BrojRacuna == brojRacuna)
                        .FirstOrDefault();

                    if (r == null)
                        throw new InvalidOperationException("Ne postoji račun.");

                    if (r.PripadaFizickomLicu != null)
                    {
                        fl = r.PripadaFizickomLicu;
                        pl = null;
                    }
                    else
                    {
                        pl = r.PripadaPravnomLicu;
                        fl = null;
                    }

                    Depozit d = new Depozit
                    {
                        DatumPocetka = db.DatumPocetka,
                        PeriodOrocenja = db.PeriodOrocenja,
                        DatumIsteka = db.DatumIsteka,
                        StatusDepozita = db.StatusDepozita?.Trim(),
                        Valuta = db.Valuta?.Trim(),
                        Iznos = db.Iznos,
                        KamatnaStopa = db.KamatnaStopa,
                        Komentar = db.Komentar?.Trim(),

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl,
                        PripadaRacunu = r
                    };

                    session.Save(d);
                    transaction.Commit();

                    db.Id = d.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju depozita: " + ex.Message, ex);
                }
            }
        }

        public static DepozitPregled VratiDepozit(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Depozit d = session.Load<Depozit>(id);

                return new DepozitPregled
                {
                    Id = d.Id,
                    DatumPocetka = d.DatumPocetka,
                    PeriodOrocenja = d.PeriodOrocenja,
                    DatumIsteka = d.DatumIsteka,
                    StatusDepozita = d.StatusDepozita,
                    Valuta = d.Valuta,
                    Iznos = d.Iznos,
                    KamatnaStopa = d.KamatnaStopa,
                    Komentar = d.Komentar,

                    FizickoLice = d.PripadaFizickomLicu != null
                        ? new FizickoLicePregled
                        {
                            Id = d.PripadaFizickomLicu.Id,
                            Ime = d.PripadaFizickomLicu.Ime,
                            Prezime = d.PripadaFizickomLicu.Prezime
                        }
                        : null,

                    PravnoLice = d.PripadaPravnomLicu != null
                        ? new PravnoLicePregled
                        {
                            Id = d.PripadaPravnomLicu.Id,
                            NazivFirme = d.PripadaPravnomLicu.NazivFirme
                        }
                        : null,
                    Racun = d.PripadaRacunu != null
                        ? new RacunPregled
                        {
                            Id = d.PripadaRacunu.Id,
                            BrojRacuna = d.PripadaRacunu.BrojRacuna
                        }
                        : null
                };
            }
        }

        public static List<DepozitPregled> VratiDepozite(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Depozit> entiteti = session.Query<Depozit>()
                    .OrderByDescending(x => x.DatumPocetka)
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new DepozitPregled
                {
                    Id = x.Id,
                    DatumPocetka = x.DatumPocetka,
                    PeriodOrocenja = x.PeriodOrocenja,
                    DatumIsteka = x.DatumIsteka,
                    StatusDepozita = x.StatusDepozita,
                    Valuta = x.Valuta,
                    Iznos = x.Iznos,
                    KamatnaStopa = x.KamatnaStopa,
                    Komentar = x.Komentar,
                    OcekivanaKamata = x.OcekivanaKamata,

                    FizickoLice = x.PripadaFizickomLicu != null
                        ? new FizickoLicePregled
                        {
                            Id = x.PripadaFizickomLicu.Id,
                            Ime = x.PripadaFizickomLicu.Ime,
                            Prezime = x.PripadaFizickomLicu.Prezime
                        }
                        : null,

                    PravnoLice = x.PripadaPravnomLicu != null
                        ? new PravnoLicePregled
                        {
                            Id = x.PripadaPravnomLicu.Id,
                            NazivFirme = x.PripadaPravnomLicu.NazivFirme
                        }
                        : null,

                    Racun = x.PripadaRacunu != null
                        ? new RacunPregled
                        {
                            Id = x.PripadaRacunu.Id,
                            BrojRacuna = x.PripadaRacunu.BrojRacuna
                        }
                        : null
                }).ToList();
            }
        }

        public static List<DepozitPregled> VratiDepoziteZaRacun(int racunId, int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Depozit> entiteti = session.Query<Depozit>()
                    .Where(x => x.PripadaRacunu.Id == racunId)
                    .OrderByDescending(x => x.DatumPocetka)
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new DepozitPregled
                {
                    Id = x.Id,
                    DatumPocetka = x.DatumPocetka,
                    PeriodOrocenja = x.PeriodOrocenja,
                    DatumIsteka = x.DatumIsteka,
                    StatusDepozita = x.StatusDepozita,
                    Valuta = x.Valuta,
                    Iznos = x.Iznos,
                    KamatnaStopa = x.KamatnaStopa,
                    Komentar = x.Komentar,
                    OcekivanaKamata = x.OcekivanaKamata,

                    Racun = x.PripadaRacunu != null
                        ? new RacunPregled { Id = x.PripadaRacunu.Id, BrojRacuna = x.PripadaRacunu.BrojRacuna }
                        : null
                }).ToList();
            }
        }

        public static void IzmeniDepozit(DepozitPregled db)
        {
            Validacija.ValidirajValutu(db.Valuta);
            db.StatusDepozita = Validacija.ValidirajEnum<StatusDepozita>(db.StatusDepozita, nameof(db.StatusDepozita));
            Validacija.ValidirajIznos(db.Iznos, "Iznos", dozvoliNulu: false);
            Validacija.ValidirajKamatnuStopu(db.KamatnaStopa);
            Validacija.ValidirajPeriodOrocenja(db.PeriodOrocenja);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Depozit d = session.Load<Depozit>(db.Id);

                    d.DatumPocetka = db.DatumPocetka;
                    d.PeriodOrocenja = db.PeriodOrocenja;
                    d.DatumIsteka = db.DatumIsteka;
                    d.StatusDepozita = db.StatusDepozita?.Trim();
                    d.Valuta = db.Valuta?.Trim();
                    d.Iznos = db.Iznos;
                    d.KamatnaStopa = db.KamatnaStopa;
                    d.Komentar = db.Komentar?.Trim();

                    session.Update(d);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izmeni depozita", ex);
                }
            }
        }

        public static void ObrisiDepozit(int id)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Depozit d = session.Load<Depozit>(id);

                    if (!d.Kamate.IsEmpty())
                    {
                        throw new InvalidOperationException("Depozit poseduje kamate.");
                    }
                    session.Delete(d);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri brisanju depozita: " + ex.Message, ex);
                }
            }
        }

        #endregion

        #region Kredit

        public static void DodajKredit(KreditPregled kb, string brojRacuna)
        {
            Validacija.ValidirajBrojRacuna(brojRacuna);
            Validacija.ValidirajValutu(kb.Valuta);
            kb.StatusKredita = Validacija.ValidirajEnum<StatusKredita>(kb.StatusKredita, nameof(kb.StatusKredita));
            Validacija.ValidirajIznos(kb.Iznos, "Iznos", dozvoliNulu: false);
            Validacija.ValidirajKamatnuStopu(kb.KamatnaStopa);
            Validacija.ValidirajRokOtplate(kb.RokOtplate);
            Validacija.ValidirajIznos(kb.MesecnaRata, "Mesečna rata", dozvoliNulu: false);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    FizickoLice fl;
                    PravnoLice pl;

                    Racun r = session.Query<Racun>()
                        .Where(x => x.BrojRacuna == brojRacuna)
                        .FirstOrDefault();

                    if (r == null)
                        throw new InvalidOperationException("Ne postoji račun.");

                    if (r.PripadaFizickomLicu != null)
                    {
                        fl = r.PripadaFizickomLicu;
                        pl = null;
                    }
                    else
                    {
                        pl = r.PripadaPravnomLicu;
                        fl = null;
                    }

                    Kredit k = new Kredit
                    {
                        DatumDospeca = kb.DatumDospeca,
                        DatumOdobrenja = kb.DatumOdobrenja,
                        Iznos = kb.Iznos,
                        Valuta = kb.Valuta?.Trim(),
                        StatusKredita = kb.StatusKredita?.Trim(),
                        MesecnaRata = kb.MesecnaRata,
                        RokOtplate = kb.RokOtplate,
                        Namena = kb.Namena?.Trim(),
                        KamatnaStopa = kb.KamatnaStopa,
                        Komentar = kb.Komentar?.Trim(),

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl,
                        PripadaRacunu = r
                    };

                    session.Save(k);
                    transaction.Commit();

                    kb.Id = k.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju kredita: " + ex.Message, ex);
                }
            }
        }

        public static KreditPregled VratiKredit(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Kredit k = session.Load<Kredit>(id);

                return new KreditPregled
                {
                    Id = k.Id,
                    DatumDospeca = k.DatumDospeca,
                    DatumOdobrenja = k.DatumOdobrenja,
                    Iznos = k.Iznos,
                    Valuta = k.Valuta,
                    StatusKredita = k.StatusKredita,
                    MesecnaRata = k.MesecnaRata,
                    RokOtplate = k.RokOtplate,
                    Namena = k.Namena,
                    KamatnaStopa = k.KamatnaStopa,
                    Komentar = k.Komentar,

                    FizickoLice = k.PripadaFizickomLicu != null
                        ? new FizickoLicePregled
                        {
                            Id = k.PripadaFizickomLicu.Id,
                            Ime = k.PripadaFizickomLicu.Ime,
                            Prezime = k.PripadaFizickomLicu.Prezime
                        }
                        : null,

                    PravnoLice = k.PripadaPravnomLicu != null
                        ? new PravnoLicePregled
                        {
                            Id = k.PripadaPravnomLicu.Id,
                            NazivFirme = k.PripadaPravnomLicu.NazivFirme
                        }
                        : null,
                    Racun = k.PripadaRacunu != null
                        ? new RacunPregled
                        {
                            Id = k.PripadaRacunu.Id,
                            BrojRacuna = k.PripadaRacunu.BrojRacuna
                        }
                        : null
                };
            }
        }

        public static List<KreditPregled> VratiKredite(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Kredit> entiteti = session.Query<Kredit>()
                    .OrderByDescending(x => x.DatumOdobrenja)
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new KreditPregled
                {
                    Id = x.Id,
                    DatumDospeca = x.DatumDospeca,
                    DatumOdobrenja = x.DatumOdobrenja,
                    Iznos = x.Iznos,
                    Valuta = x.Valuta,
                    StatusKredita = x.StatusKredita,
                    MesecnaRata = x.MesecnaRata,
                    RokOtplate = x.RokOtplate,
                    Namena = x.Namena,
                    KamatnaStopa = x.KamatnaStopa,
                    Komentar = x.Komentar,

                    FizickoLice = x.PripadaFizickomLicu != null
                        ? new FizickoLicePregled
                        {
                            Id = x.PripadaFizickomLicu.Id,
                            Ime = x.PripadaFizickomLicu.Ime,
                            Prezime = x.PripadaFizickomLicu.Prezime
                        }
                        : null,

                    PravnoLice = x.PripadaPravnomLicu != null
                        ? new PravnoLicePregled
                        {
                            Id = x.PripadaPravnomLicu.Id,
                            NazivFirme = x.PripadaPravnomLicu.NazivFirme
                        }
                        : null,

                    Racun = x.PripadaRacunu != null
                        ? new RacunPregled
                        {
                            Id = x.PripadaRacunu.Id,
                            BrojRacuna = x.PripadaRacunu.BrojRacuna
                        }
                        : null
                }).ToList();
            }
        }

        public static List<KreditPregled> VratiKrediteZaRacun(int racunId, int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Kredit> entiteti = session.Query<Kredit>()
                    .Where(x => x.PripadaRacunu.Id == racunId)
                    .OrderByDescending(x => x.DatumOdobrenja)
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new KreditPregled
                {
                    Id = x.Id,
                    DatumDospeca = x.DatumDospeca,
                    DatumOdobrenja = x.DatumOdobrenja,
                    Iznos = x.Iznos,
                    Valuta = x.Valuta,
                    StatusKredita = x.StatusKredita,
                    MesecnaRata = x.MesecnaRata,
                    RokOtplate = x.RokOtplate,
                    Namena = x.Namena,
                    KamatnaStopa = x.KamatnaStopa,
                    Komentar = x.Komentar,

                    Racun = x.PripadaRacunu != null
                        ? new RacunPregled { Id = x.PripadaRacunu.Id, BrojRacuna = x.PripadaRacunu.BrojRacuna }
                        : null
                }).ToList();
            }
        }

        public static void IzmeniKredit(KreditPregled kb)
        {
            Validacija.ValidirajValutu(kb.Valuta);
            kb.StatusKredita = Validacija.ValidirajEnum<StatusKredita>(kb.StatusKredita, nameof(kb.StatusKredita));
            Validacija.ValidirajIznos(kb.Iznos, "Iznos", dozvoliNulu: false);
            Validacija.ValidirajKamatnuStopu(kb.KamatnaStopa);
            Validacija.ValidirajRokOtplate(kb.RokOtplate);
            Validacija.ValidirajIznos(kb.MesecnaRata, "Mesečna rata", dozvoliNulu: false);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Kredit k = session.Load<Kredit>(kb.Id);

                    k.DatumDospeca = kb.DatumDospeca;
                    k.DatumOdobrenja = kb.DatumOdobrenja;
                    k.Iznos = kb.Iznos;
                    k.Valuta = kb.Valuta?.Trim();
                    k.StatusKredita = kb.StatusKredita?.Trim();
                    k.MesecnaRata = kb.MesecnaRata;
                    k.RokOtplate = kb.RokOtplate;
                    k.Namena = kb.Namena?.Trim();
                    k.KamatnaStopa = kb.KamatnaStopa;
                    k.Komentar = kb.Komentar?.Trim();

                    session.Update(k);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izmeni kredita", ex);
                }
            }
        }

        public static void ObrisiKredit(int id)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Kredit k = session.Load<Kredit>(id);

                    if (!k.Kamate.IsEmpty())
                    {
                        throw new InvalidOperationException("Kredit poseduje kamate.");
                    }

                    session.Delete(k);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri brisanju kredita: " + ex.Message, ex);
                }
            }
        }

        #endregion

        #region Kamata

        public static void DodajKamatuNaRacun(KamataPregled kmb, string brojRacuna)
        {
            Validacija.ValidirajBrojRacuna(brojRacuna);
            kmb.TipKamate = Validacija.ValidirajEnum<TipKamate>(kmb.TipKamate, nameof(kmb.TipKamate));
            kmb.StatusKamate = Validacija.ValidirajEnum<StatusKamate>(kmb.StatusKamate, nameof(kmb.StatusKamate));
            Validacija.ValidirajIznos(kmb.Iznos);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Racun r = session.Query<Racun>()
                        .Where(x => x.BrojRacuna == brojRacuna)
                        .FirstOrDefault();

                    if (r == null)
                        throw new InvalidOperationException("Ne postoji račun.");

                    Kamata kam = new Kamata
                    {
                        DatumObracuna = kmb.DatumObracuna,
                        PeriodObracuna = kmb.PeriodObracuna?.Trim(),
                        TipKamate = kmb.TipKamate?.Trim(),
                        StatusKamate = kmb.StatusKamate?.Trim(),
                        Iznos = kmb.Iznos,

                        PripadaKreditu = null,
                        PripadaDepozitu = null,
                        PripadaRacunu = r
                    };

                    session.Save(kam);
                    transaction.Commit();

                    // Vrati generisani ID
                    kmb.Id = kam.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju kamate: " + ex.Message, ex);
                }
            }
        }

        public static void DodajKamatuNaKredit(KamataPregled kmb, int kreditId)
        {
            kmb.TipKamate = Validacija.ValidirajEnum<TipKamate>(kmb.TipKamate, nameof(kmb.TipKamate));
            kmb.StatusKamate = Validacija.ValidirajEnum<StatusKamate>(kmb.StatusKamate, nameof(kmb.StatusKamate));
            Validacija.ValidirajIznos(kmb.Iznos, "Iznos", dozvoliNulu: false);
            if (kreditId <= 0)
                throw new InvalidOperationException("Id kredita mora biti veći od 0.");

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Kredit k = session.Get<Kredit>(kreditId);

                    if (k == null)
                        throw new InvalidOperationException("Ne postoji kredit.");

                    Kamata kam = new Kamata
                    {
                        DatumObracuna = kmb.DatumObracuna,
                        PeriodObracuna = kmb.PeriodObracuna?.Trim(),
                        TipKamate = kmb.TipKamate?.Trim(),
                        StatusKamate = kmb.StatusKamate?.Trim(),
                        Iznos = kmb.Iznos,

                        PripadaKreditu = k,
                        PripadaDepozitu = null,
                        PripadaRacunu = null
                    };

                    session.Save(kam);
                    transaction.Commit();

                    // Vrati generisani ID
                    kmb.Id = kam.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju kamate: " + ex.Message, ex);
                }
            }
        }

        public static void DodajKamatuNaDepozit(KamataPregled kmb, int depozitId)
        {
            kmb.TipKamate = Validacija.ValidirajEnum<TipKamate>(kmb.TipKamate, nameof(kmb.TipKamate));
            kmb.StatusKamate = Validacija.ValidirajEnum<StatusKamate>(kmb.StatusKamate, nameof(kmb.StatusKamate));
            Validacija.ValidirajIznos(kmb.Iznos, "Iznos", dozvoliNulu: false);
            if (depozitId <= 0)
                throw new InvalidOperationException("Id depozita mora biti veći od 0.");

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Depozit d = session.Get<Depozit>(depozitId);

                    if (d == null)
                        throw new InvalidOperationException("Ne postoji depozit.");

                    Kamata kam = new Kamata
                    {
                        DatumObracuna = kmb.DatumObracuna,
                        PeriodObracuna = kmb.PeriodObracuna?.Trim(),
                        TipKamate = kmb.TipKamate?.Trim(),
                        StatusKamate = kmb.StatusKamate?.Trim(),
                        Iznos = kmb.Iznos,

                        PripadaKreditu = null,
                        PripadaDepozitu = d,
                        PripadaRacunu = null
                    };

                    session.Save(kam);
                    transaction.Commit();

                    // Vrati generisani ID
                    kmb.Id = kam.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju kamate: " + ex.Message, ex);
                }
            }
        }

        public static KamataPregled VratiKamatu(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                var kamata = session.Load<Kamata>(id);

                return new KamataPregled
                {
                    Id = kamata.Id,
                    DatumObracuna = kamata.DatumObracuna,
                    PeriodObracuna = kamata.PeriodObracuna,
                    TipKamate = kamata.TipKamate,
                    StatusKamate = kamata.StatusKamate,
                    Iznos = kamata.Iznos,

                    Kredit = kamata.PripadaKreditu != null ?
                    new KreditPregled
                    {
                        Id = kamata.PripadaKreditu.Id,
                    } : null,

                    Depozit = kamata.PripadaDepozitu != null ?
                    new DepozitPregled
                    {
                        Id = kamata.PripadaDepozitu.Id
                    } : null,

                    Racun = kamata.PripadaRacunu != null ?
                    new RacunPregled
                    {
                        Id = kamata.PripadaRacunu.Id,
                        BrojRacuna = kamata.PripadaRacunu.BrojRacuna
                    } : null
                };
            }
        }

        public static List<KamataPregled> VratiKamate(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<Kamata> entiteti = session.Query<Kamata>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new KamataPregled
                {
                    Id = x.Id,
                    DatumObracuna = x.DatumObracuna,
                    PeriodObracuna = x.PeriodObracuna,
                    TipKamate = x.TipKamate,
                    StatusKamate = x.StatusKamate,
                    Iznos = x.Iznos,

                    Kredit = x.PripadaKreditu != null ?
                    new KreditPregled
                    {
                        Id = x.PripadaKreditu.Id,
                    } : null,

                    Depozit = x.PripadaDepozitu != null ?
                    new DepozitPregled
                    {
                        Id = x.PripadaDepozitu.Id
                    } : null,

                    Racun = x.PripadaRacunu != null ?
                    new RacunPregled
                    {
                        Id = x.PripadaRacunu.Id,
                        BrojRacuna = x.PripadaRacunu.BrojRacuna
                    } : null
                }).ToList();
            }
        }

        public static void IzmeniKamatu(KamataPregled kmb)
        {
            kmb.TipKamate = Validacija.ValidirajEnum<TipKamate>(kmb.TipKamate, nameof(kmb.TipKamate));
            kmb.StatusKamate = Validacija.ValidirajEnum<StatusKamate>(kmb.StatusKamate, nameof(kmb.StatusKamate));
            Validacija.ValidirajIznos(kmb.Iznos, "Iznos", dozvoliNulu: false);

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Kamata kam = session.Load<Kamata>(kmb.Id);

                    kam.DatumObracuna = kmb.DatumObracuna;
                    kam.PeriodObracuna = kmb.PeriodObracuna?.Trim();
                    kam.TipKamate = kmb.TipKamate?.Trim();
                    kam.StatusKamate = kmb.StatusKamate?.Trim();
                    kam.Iznos = kmb.Iznos;

                    session.Update(kam);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri izmeni kamate", ex);
                }
            }
        }

        public static void ObrisiKamatu(int id)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Kamata kam = session.Load<Kamata>(id);
                    session.Delete(kam);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri brisanju kamate", ex);
                }
            }
        }

        #endregion

        #region SigurnosnaKontrola

        public static void DodajSigurnosnuKontrolu(SigurnosnaKontrolaPregled skb, string brojRacuna)
        {
            Validacija.ValidirajBrojRacuna(brojRacuna);
            Validacija.ValidirajIPAdresu(skb.IpAdresa);
            skb.TipDogadjaja = Validacija.ValidirajEnum<TipDogadjaja>(skb.TipDogadjaja, nameof(skb.TipDogadjaja));
            skb.StatusDogadjaja = Validacija.ValidirajEnum<StatusDogadjaja>(skb.StatusDogadjaja, nameof(skb.StatusDogadjaja));

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Racun r = session.Query<Racun>()
                        .Where(x => x.BrojRacuna == brojRacuna)
                        .FirstOrDefault();

                    if (r == null)
                        throw new InvalidOperationException("Ne postoji račun.");

                    SigurnosnaKontrola sk = new SigurnosnaKontrola
                    {
                        IpAdresa = skb.IpAdresa?.Trim(),
                        DatumIVreme = skb.DatumIVreme,
                        TipDogadjaja = skb.TipDogadjaja?.Trim(),
                        StatusDogadjaja = skb.StatusDogadjaja?.Trim(),
                        PodaciUredjaja = skb.PodaciUredjaja?.Trim(),
                        Opis = skb.Opis?.Trim(),

                        PripadaRacunu = r
                    };

                    session.Save(sk);
                    transaction.Commit();

                    skb.Id = sk.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju sigurnosne kontrole: " + ex.Message, ex);
                }
            }
        }

        public static SigurnosnaKontrolaPregled VratiSigurnosnuKontrolu(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                var kontrola = session.Load<SigurnosnaKontrola>(id);

                return new SigurnosnaKontrolaPregled
                {
                    Id = kontrola.Id,
                    IpAdresa = kontrola.IpAdresa,
                    DatumIVreme = kontrola.DatumIVreme,
                    TipDogadjaja = kontrola.TipDogadjaja,
                    StatusDogadjaja = kontrola.StatusDogadjaja,
                    PodaciUredjaja = kontrola.PodaciUredjaja,
                    Opis = kontrola.Opis,

                    Racun = new RacunPregled
                    {
                        Id = kontrola.PripadaRacunu.Id,
                        BrojRacuna = kontrola.PripadaRacunu.BrojRacuna
                    }
                };
            }
        }

        public static List<SigurnosnaKontrolaPregled> VratiSigurnosneKontrole(int brojPoStrani, int strana = 1)
        {
            using (ISession session = DataLayer.GetSession())
            {
                List<SigurnosnaKontrola> entiteti = session.Query<SigurnosnaKontrola>()
                    .Skip((strana - 1) * brojPoStrani)
                    .Take(brojPoStrani)
                    .ToList();

                return entiteti.Select(x => new SigurnosnaKontrolaPregled
                {
                    Id = x.Id,
                    IpAdresa = x.IpAdresa,
                    DatumIVreme = x.DatumIVreme,
                    TipDogadjaja = x.TipDogadjaja,
                    StatusDogadjaja = x.StatusDogadjaja,
                    PodaciUredjaja = x.PodaciUredjaja,
                    Opis = x.Opis,

                    Racun = new RacunPregled
                    {
                        Id = x.PripadaRacunu.Id,
                        BrojRacuna = x.PripadaRacunu.BrojRacuna
                    }
                }).ToList();
            }
        }

        public static void IzmeniSigurnosnuKontrolu(SigurnosnaKontrolaPregled skb)
        {
            Validacija.ValidirajIPAdresu(skb.IpAdresa);
            skb.TipDogadjaja = Validacija.ValidirajEnum<TipDogadjaja>(skb.TipDogadjaja, nameof(skb.TipDogadjaja));
            skb.StatusDogadjaja = Validacija.ValidirajEnum<StatusDogadjaja>(skb.StatusDogadjaja, nameof(skb.StatusDogadjaja));

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    SigurnosnaKontrola sk = session.Load<SigurnosnaKontrola>(skb.Id);

                    sk.IpAdresa = skb.IpAdresa?.Trim();
                    sk.DatumIVreme = skb.DatumIVreme;
                    sk.TipDogadjaja = skb.TipDogadjaja?.Trim();
                    sk.StatusDogadjaja = skb.StatusDogadjaja?.Trim();
                    sk.PodaciUredjaja = skb.PodaciUredjaja?.Trim();
                    sk.Opis = skb.Opis?.Trim();

                    session.Update(sk);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri izmeni sigurnosne kontrole", ex);
                }
            }
        }

        public static void ObrisiSigurnosnuKontrolu(int id)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    SigurnosnaKontrola sk = session.Load<SigurnosnaKontrola>(id);
                    session.Delete(sk);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri brisanju sigurnosne kontrole", ex);
                }
            }
        }

        #endregion
    }
}
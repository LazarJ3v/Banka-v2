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
        #region FizickaLica

        public static void DodajFizickoLice(FizickoLiceBasic fl)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
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
                        "Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        public static FizickoLiceBasic VratiFizickoLice(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                try
                {
                    var fizickoLice = session.Get<FizickoLice>(id);

                    if (fizickoLice == null)
                        return null;

                    return new FizickoLiceBasic
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

        public static FizickoLiceBasic IzmeniFizickoLice(FizickoLiceBasic fl)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
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
                        "Greška pri izmeni fizičkog lica.", ex);
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

                    session.Delete(fizickoLice);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw new InvalidOperationException(
                        "Greška pri brisanju fizičkog lica.", ex);
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

                    // Vrati generisani ID
                    pl.Id = pravnoLice.Id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException(
                        "Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        public static PravnoLiceBasic VratiPravnoLice(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                try
                {
                    var pravnoLice = session.Load<PravnoLice>(id);

                    if (pravnoLice == null)
                        return null;

                    return new PravnoLiceBasic
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

        public static PravnoLiceBasic IzmeniPravnoLice(PravnoLiceBasic pl)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
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
                        "Greška pri izmeni pravnog lica.", ex);
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

                    session.Delete(pravnoLice);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw new InvalidOperationException(
                        "Greška pri brisanju pravnog lica.", ex);
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
        // TODO: Proveriti metodu DodajRacun (dodaje tip racuna koji nije podrazumevani)
        public static void DodajRacun(RacunBasic r)
        {
            if (r == null)
                throw new ArgumentNullException(nameof(r));

            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    FizickoLice fl = r.FizickoLice != null
                ? session.Load<FizickoLice>(r.FizickoLice.Id)
                : null;

                    PravnoLice pl = r.PravnoLice != null
                        ? session.Load<PravnoLice>(r.PravnoLice.Id)
                        : null;

                    Racun racun = new Racun
                    {
                        BrojRacuna = r.BrojRacuna?.Trim(),
                        Valuta = r.Valuta?.Trim(),
                        TrenutnoStanje = r.TrenutnoStanje,
                        DatumOtvaranja = r.DatumOtvaranja,
                        Status = r.Status,
                        DozvoljeniMinus = r.DozvoljeniMinus,
                        Komentar = r.Komentar?.Trim(),
                        TipRacuna = string.IsNullOrWhiteSpace(r.TipRacuna)
                            ? "Drugi"
                            : r.TipRacuna.Trim(),
                        KamatnaStopa = r.KamatnaStopa,

                        PripadaFizickomLicu = fl,
                        PripadaPravnomLicu = pl
                    };

                    session.Save(racun);
                    transaction.Commit();

                    r.Id = racun.Id;
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri dodavanju računa", ex);
                }
            }
        }

        public static RacunBasic VratiRacun(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Racun r = session.Load<Racun>(id);

                return new RacunBasic
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
                        ? new FizickoLiceBasic
                        {
                            Id = r.PripadaFizickomLicu.Id,
                            Ime = r.PripadaFizickomLicu.Ime,
                            Prezime = r.PripadaFizickomLicu.Prezime
                        }
                        : null,

                    PravnoLice = r.PripadaPravnomLicu != null
                        ? new PravnoLiceBasic
                        {
                            Id = r.PripadaPravnomLicu.Id,
                            NazivFirme = r.PripadaPravnomLicu.NazivFirme
                        }
                        : null
                };
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
                    session.Delete(r);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new InvalidOperationException("Greška pri brisanju računa", ex);
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

        #region Tekuci

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

        public static TekuciBasic VratiTekuci(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                var tekuci = session.Load<Tekuci>(id);

                var dto = new TekuciBasic
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
                        ? new FizickoLiceBasic { Id = tekuci.PripadaFizickomLicu.Id, Ime = tekuci.PripadaFizickomLicu.Ime, Prezime = tekuci.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = tekuci.PripadaPravnomLicu != null
                        ? new PravnoLiceBasic { Id = tekuci.PripadaPravnomLicu.Id, NazivFirme = tekuci.PripadaPravnomLicu.NazivFirme }
                        : null
                };

                dto.TekuciPaketi = tekuci.Paketi.Select(p => new TekuciPaketBasic
                {
                    Id = p.Id,
                    Paket = p.Paket
                }).ToList();

                return dto;
            }
        }
        // TODO: Testirati metodu IzmeniTekuci
        public static void IzmeniTekuci(TekuciBasic tb)
        {
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

                    SinhronizujPakete(tekuci, tb.TekuciPaketi);

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

        private static void SinhronizujPakete(Tekuci tekuci, IList<TekuciPaketBasic> noviPaketi)
        {
            // Zaštita od null liste
            //noviPaketi ??= new List<TekuciPaketBasic>();
            if (noviPaketi == null)
            {
                noviPaketi = new List<TekuciPaketBasic>();
            }

            // 1. Postojeći paketi iz baze, indeksirani po Id-u
            var postojeciPoId = tekuci.Paketi
                .ToDictionary(p => p.Id);

            // 2. Id-evi koji treba da ostanu (iz DTO-a, samo oni sa Id != 0)
            var noviIdjevi = new HashSet<int>(
                noviPaketi.Where(p => p.Id != 0).Select(p => p.Id));

            // 3. Obriši orphan-ove (postojeći u bazi, ali ih nema u DTO listi)
            //    Pošto je Cascade.AllDeleteOrphan, dovoljno ih je ukloniti iz kolekcije.
            var zaBrisanje = tekuci.Paketi
                .Where(p => !noviIdjevi.Contains(p.Id))
                .ToList();

            foreach (var paket in zaBrisanje)
            {
                tekuci.Paketi.Remove(paket);
            }

            // 4. Ažuriraj postojeće i dodaj nove
            foreach (var dto in noviPaketi)
            {
                if (dto.Id != 0 && postojeciPoId.TryGetValue(dto.Id, out var postojeci))
                {
                    // Postojeći — ažuriraj vrednost ako se promenila
                    if (postojeci.Paket != dto.Paket)
                    {
                        postojeci.Paket = dto.Paket;
                    }
                }
                else
                {
                    // Novi — dodaj u kolekciju, NHibernate će ga upisati na Commit
                    tekuci.Paketi.Add(new TekuciPaket
                    {
                        Paket = dto.Paket,
                        PripadaTekucem = tekuci
                    });
                }
            }
        }

        #endregion

        #region Devizni

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
                    throw new InvalidOperationException(
                        "Greška pri dodavanju deviznog računa", ex);
                }
            }
        }

        public static DevizniBasic VratiDevizni(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Devizni d = session.Load<Devizni>(id);

                DevizniBasic dto = new DevizniBasic
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
                        ? new FizickoLiceBasic { Id = d.PripadaFizickomLicu.Id, Ime = d.PripadaFizickomLicu.Ime, Prezime = d.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = d.PripadaPravnomLicu != null
                        ? new PravnoLiceBasic { Id = d.PripadaPravnomLicu.Id, NazivFirme = d.PripadaPravnomLicu.NazivFirme }
                        : null
                };

                dto.DevizniOgranicenja = d.Ogranicanja.Select(o => new DevizniOgranicenjeBasic
                {
                    Id = o.Id,
                    Ogranicenje = o.Ogranicenje
                }).ToList();

                dto.DevizniValute = d.Valute.Select(v => new DevizniValutaBasic
                {
                    Id = v.Id,
                    DozvoljenaValuta = v.DozvoljenaValuta
                }).ToList();

                return dto;
            }
        }
        // TODO: Testirati metodu IzmeniDevizni
        public static void IzmeniDevizni(DevizniBasic db)
        {
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

                    SinhronizujOgranicenja(d, db.DevizniOgranicenja);
                    SinhronizujValute(d, db.DevizniValute);

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

        private static void SinhronizujOgranicenja(Devizni devizni, IList<DevizniOgranicenjeBasic> novi)
        {
            if (novi == null)
            {
                novi = new List<DevizniOgranicenjeBasic>();
            }

            // 1. Postojeći iz baze, indeksirani po Id-u
            var postojeciPoId = devizni.Ogranicanja.ToDictionary(o => o.Id);

            // 2. Id-evi koji treba da ostanu
            var noviIdjevi = new HashSet<int>(
                novi.Where(o => o.Id != 0).Select(o => o.Id));

            // 3. Ukloni orphan-ove (cascade će ih obrisati iz DEVIZNI_OGRANICENJE)
            var zaBrisanje = devizni.Ogranicanja
                .Where(o => !noviIdjevi.Contains(o.Id))
                .ToList();

            foreach (var o in zaBrisanje)
            {
                devizni.Ogranicanja.Remove(o);
            }

            // 4. Ažuriraj postojeće i dodaj nove
            foreach (var dto in novi)
            {
                if (dto.Id != 0 && postojeciPoId.TryGetValue(dto.Id, out var postojeci))
                {
                    if (postojeci.Ogranicenje != dto.Ogranicenje)
                    {
                        postojeci.Ogranicenje = dto.Ogranicenje;
                    }
                }
                else
                {
                    devizni.Ogranicanja.Add(new DevizniOgranicenje
                    {
                        Ogranicenje = dto.Ogranicenje,
                        PripadaDeviznom = devizni
                    });
                }
            }
        }

        private static void SinhronizujValute(Devizni devizni, IList<DevizniValutaBasic> novi)
        {
            if (novi == null)
            {
                novi = new List<DevizniValutaBasic>();
            }

            var postojeciPoId = devizni.Valute.ToDictionary(v => v.Id);

            var noviIdjevi = new HashSet<int>(
                novi.Where(v => v.Id != 0).Select(v => v.Id));

            var zaBrisanje = devizni.Valute
                .Where(v => !noviIdjevi.Contains(v.Id))
                .ToList();

            foreach (var v in zaBrisanje)
            {
                devizni.Valute.Remove(v);
            }

            foreach (var dto in novi)
            {
                if (dto.Id != 0 && postojeciPoId.TryGetValue(dto.Id, out var postojeci))
                {
                    if (postojeci.DozvoljenaValuta != dto.DozvoljenaValuta)
                    {
                        postojeci.DozvoljenaValuta = dto.DozvoljenaValuta;
                    }
                }
                else
                {
                    devizni.Valute.Add(new Entiteti.DevizniValuta
                    {
                        DozvoljenaValuta = dto.DozvoljenaValuta,
                        PripadaDeviznom = devizni
                    });
                }
            }
        }

        #endregion

        #region Stedni

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
                    throw new InvalidOperationException(
                        "Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        public static StedniBasic VratiStedni(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Stedni s = session.Load<Stedni>(id);

                StedniBasic dto = new StedniBasic
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
                        ? new FizickoLiceBasic { Id = s.PripadaFizickomLicu.Id, Ime = s.PripadaFizickomLicu.Ime, Prezime = s.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = s.PripadaPravnomLicu != null
                        ? new PravnoLiceBasic { Id = s.PripadaPravnomLicu.Id, NazivFirme = s.PripadaPravnomLicu.NazivFirme }
                        : null
                };

                dto.StedniBonusi = s.Bonusi.Select(b => new StedniBonusBasic
                {
                    Id = b.Id,
                    Bonus = b.Bonus
                }).ToList();

                dto.StedniUsloviPodizanja = s.UsloviPodizanja.Select(u => new StedniUsloviPodizanjaBasic
                {
                    Id = u.Id,
                    UslovPodizanja = u.UslovPodizanja
                }).ToList();

                return dto;
            }
        }
        // TODO: Testirati metodu IzmeniStedni

        public static void IzmeniStedni(StedniBasic sb)
        {
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

                    SinhronizujBonuse(s, sb.StedniBonusi);
                    SinhronizujUslovePodizanja(s, sb.StedniUsloviPodizanja);

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

        private static void SinhronizujBonuse(Stedni stedni, IList<StedniBonusBasic> novi)
        {
            if (novi == null)
            {
                novi = new List<StedniBonusBasic>();
            }

            // 1. Postojeći iz baze, indeksirani po Id-u
            var postojeciPoId = stedni.Bonusi.ToDictionary(b => b.Id);

            // 2. Id-evi koji treba da ostanu (samo oni sa Id != 0)
            var noviIdjevi = new HashSet<int>(
                novi.Where(b => b.Id != 0).Select(b => b.Id));

            // 3. Ukloni orphan-ove (cascade → DELETE iz STEDNI_BONUS)
            var zaBrisanje = stedni.Bonusi
                .Where(b => !noviIdjevi.Contains(b.Id))
                .ToList();

            foreach (var b in zaBrisanje)
            {
                stedni.Bonusi.Remove(b);
            }

            // 4. Ažuriraj postojeće i dodaj nove
            foreach (var dto in novi)
            {
                if (dto.Id != 0 && postojeciPoId.TryGetValue(dto.Id, out var postojeci))
                {
                    if (postojeci.Bonus != dto.Bonus)
                    {
                        postojeci.Bonus = dto.Bonus;
                    }
                }
                else
                {
                    stedni.Bonusi.Add(new StedniBonus
                    {
                        Bonus = dto.Bonus,
                        PripadaStednom = stedni
                    });
                }
            }
        }

        private static void SinhronizujUslovePodizanja(Stedni stedni, IList<StedniUsloviPodizanjaBasic> novi)
        {
            if (novi == null)
            {
                novi = new List<StedniUsloviPodizanjaBasic>();
            }

            var postojeciPoId = stedni.UsloviPodizanja.ToDictionary(u => u.Id);

            var noviIdjevi = new HashSet<int>(
                novi.Where(u => u.Id != 0).Select(u => u.Id));

            var zaBrisanje = stedni.UsloviPodizanja
                .Where(u => !noviIdjevi.Contains(u.Id))
                .ToList();

            foreach (var u in zaBrisanje)
            {
                stedni.UsloviPodizanja.Remove(u);
            }

            foreach (var dto in novi)
            {
                if (dto.Id != 0 && postojeciPoId.TryGetValue(dto.Id, out var postojeci))
                {
                    if (postojeci.UslovPodizanja != dto.UslovPodizanja)
                    {
                        postojeci.UslovPodizanja = dto.UslovPodizanja;
                    }
                }
                else
                {
                    stedni.UsloviPodizanja.Add(new StedniUslovPodizanja
                    {
                        UslovPodizanja = dto.UslovPodizanja,
                        PripadaStednom = stedni
                    });
                }
            }
        }

        #endregion

        #region Ziro

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
                    throw new InvalidOperationException(
                        "Greška pri dodavanju fizičkog lica", ex);
                }
            }
        }

        public static ZiroBasic VratiZiro(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Ziro z = session.Load<Ziro>(id);

                return new ZiroBasic
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
                        ? new FizickoLiceBasic { Id = z.PripadaFizickomLicu.Id, Ime = z.PripadaFizickomLicu.Ime, Prezime = z.PripadaFizickomLicu.Prezime }
                        : null,
                    PravnoLice = z.PripadaPravnomLicu != null
                        ? new PravnoLiceBasic { Id = z.PripadaPravnomLicu.Id, NazivFirme = z.PripadaPravnomLicu.NazivFirme }
                        : null
                };
            }
        }

        public static void IzmeniZiro(ZiroBasic zb)
        {
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

        #endregion

        #endregion
    }
}

using Banka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banka
{

    enum KlijentStatus
    {
        Aktivan,
        Neaktivan
    }

    #region FizickoLice
    public class FizickoLicePregled
    {
        public int Id;
        public string Ime;
        public string Prezime;
        public string Jmbg;
        public string BrojLicneKarte;
        public DateTime? DatumRodjenja;
        public string Adresa;
        public string Grad;
        public string Telefon;
        public string Email;
        public string Status;
        public string Komentar;

        public FizickoLicePregled() { }

        public FizickoLicePregled(int id, string ime, string prezime, string jmbg, string brojLicneKarte,
            DateTime? datumRodjenja, string adresa, string grad, string telefon, string email,
            string status, string komentar)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
            this.BrojLicneKarte = brojLicneKarte;
            this.DatumRodjenja = datumRodjenja;
            this.Adresa = adresa;
            this.Grad = grad;
            this.Telefon = telefon;
            this.Email = email;
            this.Status = status;
            this.Komentar = komentar;
        }

        public override string ToString() => Ime + " " + Prezime;
    }

    public class FizickoLiceBasic
    {
        public int Id;
        public string Ime;
        public string Prezime;
        public string Jmbg;
        public string BrojLicneKarte;
        public DateTime? DatumRodjenja;
        public string Adresa;
        public string Grad;
        public string Telefon;
        public string Email;
        public string Status;
        public string Komentar;

        public IList<RacunBasic> Racuni { get; set; }
        public IList<DepozitBasic> Depoziti { get; set; }
        public IList<KreditBasic> Krediti { get; set; }

        public FizickoLiceBasic()
        {
            Racuni = new List<RacunBasic>();
            Depoziti = new List<DepozitBasic>();
            Krediti = new List<KreditBasic>();
        }

        public FizickoLiceBasic(int id, string ime, string prezime, string jmbg, string brojLicneKarte,
            DateTime? datumRodjenja, string adresa, string grad, string telefon, string email,
            string status, string komentar) : this()
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
            this.BrojLicneKarte = brojLicneKarte;
            this.DatumRodjenja = datumRodjenja;
            this.Adresa = adresa;
            this.Grad = grad;
            this.Telefon = telefon;
            this.Email = email;
            this.Status = status;
            this.Komentar = komentar;
        }

        public override string ToString() => Ime + " " + Prezime;
    }
    #endregion

    #region PravnoLice
    public class PravnoLicePregled
    {
        public int Id;
        public string NazivFirme;
        public string Pib;
        public string Adresa;
        public string Grad;
        public string Telefon;
        public string Email;
        public string Status;
        public string Komentar;

        public PravnoLicePregled() { }

        public PravnoLicePregled(int id, string nazivFirme, string pib, string adresa, string grad,
            string telefon, string email, string status, string komentar)
        {
            this.Id = id;
            this.NazivFirme = nazivFirme;
            this.Pib = pib;
            this.Adresa = adresa;
            this.Grad = grad;
            this.Telefon = telefon;
            this.Email = email;
            this.Status = status;
            this.Komentar = komentar;
        }

        public override string ToString() => NazivFirme;
    }

    public class PravnoLiceBasic
    {
        public int Id;
        public string NazivFirme;
        public string Pib;
        public string Adresa;
        public string Grad;
        public string Telefon;
        public string Email;
        public string Status;
        public string Komentar;

        public IList<RacunBasic> Racuni { get; set; }
        public IList<DepozitBasic> Depoziti { get; set; }
        public IList<KreditBasic> Krediti { get; set; }

        public PravnoLiceBasic()
        {
            Racuni = new List<RacunBasic>();
            Depoziti = new List<DepozitBasic>();
            Krediti = new List<KreditBasic>();
        }
        public PravnoLiceBasic(int id, string nazivFirme, string pib, string adresa, string grad,
            string telefon, string email, string status, string komentar) : this()
        {
            this.Id = id;
            this.NazivFirme = nazivFirme;
            this.Pib = pib;
            this.Adresa = adresa;
            this.Grad = grad;
            this.Telefon = telefon;
            this.Email = email;
            this.Status = status;
            this.Komentar = komentar;
        }

        public override string ToString() => NazivFirme;
    }
    #endregion

    #region Racun
    public class RacunPregled
    {
        public int Id;
        public string BrojRacuna;
        public string Valuta;
        public decimal TrenutnoStanje;
        public DateTime DatumOtvaranja;
        public string Status;
        public decimal DozvoljeniMinus;
        public string Komentar;
        public string TipRacuna;
        public decimal? KamatnaStopa;
        public FizickoLicePregled FizickoLice;
        public PravnoLicePregled PravnoLice;

        public RacunPregled() { }

        public RacunPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice)
        {
            this.Id = id;
            this.BrojRacuna = brojRacuna;
            this.Valuta = valuta;
            this.TrenutnoStanje = trenutnoStanje;
            this.DatumOtvaranja = datumOtvaranja;
            this.Status = status;
            this.DozvoljeniMinus = dozvoljeniMinus;
            this.Komentar = komentar;
            this.TipRacuna = tipRacuna;
            this.KamatnaStopa = kamatnaStopa;
            this.FizickoLice = fizickoLice;
            this.PravnoLice = pravnoLice;
        }

        public override string ToString() => BrojRacuna;
    }

    public class RacunBasic
    {
        public int Id;
        public string BrojRacuna;
        public string Valuta;
        public decimal TrenutnoStanje;
        public DateTime DatumOtvaranja;
        public string Status;
        public decimal DozvoljeniMinus;
        public string Komentar;
        public string TipRacuna;
        public decimal? KamatnaStopa;
        public FizickoLiceBasic FizickoLice;
        public PravnoLiceBasic PravnoLice;

        public IList<DepozitBasic> Depoziti { get; set; }
        public IList<KreditBasic> Krediti { get; set; }
        public IList<TransakcijaBasic> Transakcije { get; set; }
        public IList<KamataBasic> Kamate { get; set; }
        public IList<SigurnosnaKontrolaBasic> SigurnosneKontrole { get; set; }

        public RacunBasic()
        {
            Depoziti = new List<DepozitBasic>();
            Krediti = new List<KreditBasic>();
            Transakcije = new List<TransakcijaBasic>();
            Kamate = new List<KamataBasic>();
            SigurnosneKontrole = new List<SigurnosnaKontrolaBasic>();
        }

        public RacunBasic(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLiceBasic fizickoLice, PravnoLiceBasic pravnoLice) : this()
        {
            this.Id = id;
            this.BrojRacuna = brojRacuna;
            this.Valuta = valuta;
            this.TrenutnoStanje = trenutnoStanje;
            this.DatumOtvaranja = datumOtvaranja;
            this.Status = status;
            this.DozvoljeniMinus = dozvoljeniMinus;
            this.Komentar = komentar;
            this.TipRacuna = tipRacuna;
            this.KamatnaStopa = kamatnaStopa;
            this.FizickoLice = fizickoLice;
            this.PravnoLice = pravnoLice;
        }

        public override string ToString() => BrojRacuna;
    }
    #endregion

    #region Tekuci
    public class TekuciPregled : RacunPregled
    {
        public bool PlatnaKartica;
        public decimal? MesecniLimit;

        public TekuciPregled() { }

        public TekuciPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            bool platnaKartica, decimal? mesecniLimit)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.PlatnaKartica = platnaKartica;
            this.MesecniLimit = mesecniLimit;
        }
    }

    public class TekuciBasic : RacunBasic
    {
        public bool PlatnaKartica;
        public decimal? MesecniLimit;

        public IList<TekuciPaketBasic> TekuciPaketi { get; set; }

        public TekuciBasic()
        {
            TekuciPaketi = new List<TekuciPaketBasic>();
        }

        public TekuciBasic(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLiceBasic fizickoLice, PravnoLiceBasic pravnoLice,
            bool platnaKartica, decimal? mesecniLimit)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            TekuciPaketi = new List<TekuciPaketBasic>();
            this.PlatnaKartica = platnaKartica;
            this.MesecniLimit = mesecniLimit;
        }
    }
    #endregion

    #region Stedni
    public class StedniPregled : RacunPregled
    {
        public decimal? MinimalniIznosOtvaranja;
        public int FrekvKapitalizKamate;

        public StedniPregled() { }

        public StedniPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            decimal? minimalniIznosOtvaranja, int frekvKapitalizKamate)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.MinimalniIznosOtvaranja = minimalniIznosOtvaranja;
            this.FrekvKapitalizKamate = frekvKapitalizKamate;
        }
    }

    public class StedniBasic : RacunBasic
    {
        public decimal? MinimalniIznosOtvaranja;
        public int FrekvKapitalizKamate;

        public IList<StedniUsloviPodizanjaBasic> StedniUsloviPodizanja { get; set; }
        public IList<StedniBonusBasic> StedniBonusi { get; set; }

        public StedniBasic()
        {
            StedniUsloviPodizanja = new List<StedniUsloviPodizanjaBasic>();
            StedniBonusi = new List<StedniBonusBasic>();
        }

        public StedniBasic(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLiceBasic fizickoLice, PravnoLiceBasic pravnoLice,
            decimal? minimalniIznosOtvaranja, int frekvKapitalizKamate)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            StedniUsloviPodizanja = new List<StedniUsloviPodizanjaBasic>();
            StedniBonusi = new List<StedniBonusBasic>();
            this.MinimalniIznosOtvaranja = minimalniIznosOtvaranja;
            this.FrekvKapitalizKamate = frekvKapitalizKamate;
        }
    }
    #endregion

    #region Devizni
    public class DevizniPregled : RacunPregled
    {
        public string Namena;
        public decimal? KursnaRazlika;

        public DevizniPregled() { }

        public DevizniPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            string namena, decimal? kursnaRazlika)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.Namena = namena;
            this.KursnaRazlika = kursnaRazlika;
        }
    }

    public class DevizniBasic : RacunBasic
    {
        public string Namena;
        public decimal? KursnaRazlika;

        public IList<DevizniOgranicenjeBasic> DevizniOgranicenja { get; set; }
        public IList<DevizniValutaBasic> DevizniValute { get; set; }

        public DevizniBasic()
        {
            DevizniOgranicenja = new List<DevizniOgranicenjeBasic>();
            DevizniValute = new List<DevizniValutaBasic>();
        }

        public DevizniBasic(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLiceBasic fizickoLice, PravnoLiceBasic pravnoLice,
            string namena, decimal? kursnaRazlika)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            DevizniOgranicenja = new List<DevizniOgranicenjeBasic>();
            DevizniValute = new List<DevizniValutaBasic>();
            this.Namena = namena;
            this.KursnaRazlika = kursnaRazlika;
        }
    }
    #endregion

    #region Ziro
    public class ZiroPregled : RacunPregled
    {
        public string Namena;
        public bool ElektronskoBankarstvo;
        public decimal? LimitZaMasovnaPlacanja;
        public string IntegracijaSaSistemima;

        public ZiroPregled() { }

        public ZiroPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            string namena, bool elektronskoBankarstvo, decimal? limitZaMasovnaPlacanja, string integracijaSaSistemima)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.Namena = namena;
            this.ElektronskoBankarstvo = elektronskoBankarstvo;
            this.LimitZaMasovnaPlacanja = limitZaMasovnaPlacanja;
            this.IntegracijaSaSistemima = integracijaSaSistemima;
        }
    }

    public class ZiroBasic : RacunBasic
    {
        public string Namena;
        public bool ElektronskoBankarstvo;
        public decimal? LimitZaMasovnaPlacanja;
        public string IntegracijaSaSistemima;

        public ZiroBasic() { }

        public ZiroBasic(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLiceBasic fizickoLice, PravnoLiceBasic pravnoLice,
            string namena, bool elektronskoBankarstvo, decimal? limitZaMasovnaPlacanja, string integracijaSaSistemima)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.Namena = namena;
            this.ElektronskoBankarstvo = elektronskoBankarstvo;
            this.LimitZaMasovnaPlacanja = limitZaMasovnaPlacanja;
            this.IntegracijaSaSistemima = integracijaSaSistemima;
        }
    }
    #endregion

    #region TekuciPaket
    public class TekuciPaketPregled
    {
        public int Id;
        public string Paket;
        public TekuciPregled Tekuci;

        public TekuciPaketPregled() { }

        public TekuciPaketPregled(int id, string paket, TekuciPregled tekuci)
        {
            this.Id = id;
            this.Paket = paket;
            this.Tekuci = tekuci;
        }
    }

    public class TekuciPaketBasic
    {
        public int Id;
        public string Paket;
        public TekuciBasic Tekuci;

        public TekuciPaketBasic() { }

        public TekuciPaketBasic(int id, string paket, TekuciBasic tekuci)
        {
            this.Id = id;
            this.Paket = paket;
            this.Tekuci = tekuci;
        }
    }
    #endregion

    #region StedniUsloviPodizanja
    public class StedniUsloviPodizanjaPregled
    {
        public int Id;
        public string UslovPodizanja;
        public StedniPregled Stedni;

        public StedniUsloviPodizanjaPregled() { }

        public StedniUsloviPodizanjaPregled(int id, string uslovPodizanja, StedniPregled stedni)
        {
            this.Id = id;
            this.UslovPodizanja = uslovPodizanja;
            this.Stedni = stedni;
        }
    }

    public class StedniUsloviPodizanjaBasic
    {
        public int Id;
        public string UslovPodizanja;
        public StedniBasic Stedni;

        public StedniUsloviPodizanjaBasic() { }

        public StedniUsloviPodizanjaBasic(int id, string uslovPodizanja, StedniBasic stedni)
        {
            this.Id = id;
            this.UslovPodizanja = uslovPodizanja;
            this.Stedni = stedni;
        }
    }
    #endregion

    #region StedniBonus
    public class StedniBonusPregled
    {
        public int Id;
        public string Bonus;
        public StedniPregled Stedni;

        public StedniBonusPregled() { }

        public StedniBonusPregled(int id, string bonus, StedniPregled stedni)
        {
            this.Id = id;
            this.Bonus = bonus;
            this.Stedni = stedni;
        }
    }

    public class StedniBonusBasic
    {
        public int Id;
        public string Bonus;
        public StedniBasic Stedni;

        public StedniBonusBasic() { }

        public StedniBonusBasic(int id, string bonus, StedniBasic stedni)
        {
            this.Id = id;
            this.Bonus = bonus;
            this.Stedni = stedni;
        }
    }
    #endregion

    #region DevizniOgranicenje
    public class DevizniOgranicenjePregled
    {
        public int Id;
        public string Ogranicenje;
        public DevizniPregled Devizni;

        public DevizniOgranicenjePregled() { }

        public DevizniOgranicenjePregled(int id, string ogranicenje, DevizniPregled devizni)
        {
            this.Id = id;
            this.Ogranicenje = ogranicenje;
            this.Devizni = devizni;
        }
    }

    public class DevizniOgranicenjeBasic
    {
        public int Id;
        public string Ogranicenje;
        public DevizniBasic Devizni;

        public DevizniOgranicenjeBasic() { }

        public DevizniOgranicenjeBasic(int id, string ogranicenje, DevizniBasic devizni)
        {
            this.Id = id;
            this.Ogranicenje = ogranicenje;
            this.Devizni = devizni;
        }
    }
    #endregion

    #region DevizniValuta
    public class DevizniValutaPregled
    {
        public int Id;
        public string DozvoljenaValuta;
        public DevizniPregled Devizni;

        public DevizniValutaPregled() { }

        public DevizniValutaPregled(int id, string dozvoljenaValuta, DevizniPregled devizni)
        {
            this.Id = id;
            this.DozvoljenaValuta = dozvoljenaValuta;
            this.Devizni = devizni;
        }
    }

    public class DevizniValutaBasic
    {
        public int Id;
        public string DozvoljenaValuta;
        public DevizniBasic Devizni;

        public DevizniValutaBasic() { }

        public DevizniValutaBasic(int id, string dozvoljenaValuta, DevizniBasic devizni)
        {
            this.Id = id;
            this.DozvoljenaValuta = dozvoljenaValuta;
            this.Devizni = devizni;
        }
    }
    #endregion

    #region Depozit
    public class DepozitPregled
    {
        public int Id;
        public DateTime DatumPocetka;
        public int PeriodOrocenja;
        public DateTime DatumIsteka;
        public string StatusDepozita;
        public string Valuta;
        public decimal Iznos;
        public decimal KamatnaStopa;
        public string Komentar;
        public decimal OcekivanaKamata;
        public FizickoLicePregled FizickoLice;
        public PravnoLicePregled PravnoLice;
        public RacunPregled Racun;

        public DepozitPregled() { }

        public DepozitPregled(int id, DateTime datumPocetka, int periodOrocenja, DateTime datumIsteka,
            string statusDepozita, string valuta, decimal iznos, decimal kamatnaStopa, string komentar,
            decimal ocekivanaKamata, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice, RacunPregled racun)
        {
            this.Id = id;
            this.DatumPocetka = datumPocetka;
            this.PeriodOrocenja = periodOrocenja;
            this.DatumIsteka = datumIsteka;
            this.StatusDepozita = statusDepozita;
            this.Valuta = valuta;
            this.Iznos = iznos;
            this.KamatnaStopa = kamatnaStopa;
            this.Komentar = komentar;
            this.OcekivanaKamata = ocekivanaKamata;
            this.FizickoLice = fizickoLice;
            this.PravnoLice = pravnoLice;
            this.Racun = racun;
        }
    }

    public class DepozitBasic
    {
        public int Id;
        public DateTime DatumPocetka;
        public int PeriodOrocenja;
        public DateTime DatumIsteka;
        public string StatusDepozita;
        public string Valuta;
        public decimal Iznos;
        public decimal KamatnaStopa;
        public string Komentar;
        public decimal OcekivanaKamata;
        public FizickoLiceBasic FizickoLice;
        public PravnoLiceBasic PravnoLice;
        public RacunBasic Racun;

        public IList<KamataBasic> Kamate { get; set; }

        public DepozitBasic()
        {
            Kamate = new List<KamataBasic>();
        }

        public DepozitBasic(int id, DateTime datumPocetka, int periodOrocenja, DateTime datumIsteka,
            string statusDepozita, string valuta, decimal iznos, decimal kamatnaStopa, string komentar,
            decimal ocekivanaKamata, FizickoLiceBasic fizickoLice, PravnoLiceBasic pravnoLice, RacunBasic racun) : this()
        {
            this.Id = id;
            this.DatumPocetka = datumPocetka;
            this.PeriodOrocenja = periodOrocenja;
            this.DatumIsteka = datumIsteka;
            this.StatusDepozita = statusDepozita;
            this.Valuta = valuta;
            this.Iznos = iznos;
            this.KamatnaStopa = kamatnaStopa;
            this.Komentar = komentar;
            this.OcekivanaKamata = ocekivanaKamata;
            this.FizickoLice = fizickoLice;
            this.PravnoLice = pravnoLice;
            this.Racun = racun;
        }
    }
    #endregion

    #region Kredit
    public class KreditPregled
    {
        public int Id;
        public DateTime DatumDospeca;
        public DateTime DatumOdobrenja;
        public decimal Iznos;
        public string Valuta;
        public string StatusKredita;
        public decimal MesecnaRata;
        public int RokOtplate;
        public string Namena;
        public decimal KamatnaStopa;
        public string Komentar;
        public FizickoLicePregled FizickoLice;
        public PravnoLicePregled PravnoLice;
        public RacunPregled Racun;

        public KreditPregled() { }

        public KreditPregled(int id, DateTime datumDospeca, DateTime datumOdobrenja, decimal iznos,
            string valuta, string statusKredita, decimal mesecnaRata, int rokOtplate, string namena,
            decimal kamatnaStopa, string komentar, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            RacunPregled racun)
        {
            this.Id = id;
            this.DatumDospeca = datumDospeca;
            this.DatumOdobrenja = datumOdobrenja;
            this.Iznos = iznos;
            this.Valuta = valuta;
            this.StatusKredita = statusKredita;
            this.MesecnaRata = mesecnaRata;
            this.RokOtplate = rokOtplate;
            this.Namena = namena;
            this.KamatnaStopa = kamatnaStopa;
            this.Komentar = komentar;
            this.FizickoLice = fizickoLice;
            this.PravnoLice = pravnoLice;
            this.Racun = racun;
        }
    }

    public class KreditBasic
    {
        public int Id;
        public DateTime DatumDospeca;
        public DateTime DatumOdobrenja;
        public decimal Iznos;
        public string Valuta;
        public string StatusKredita;
        public decimal MesecnaRata;
        public int RokOtplate;
        public string Namena;
        public decimal KamatnaStopa;
        public string Komentar;
        public FizickoLiceBasic FizickoLice;
        public PravnoLiceBasic PravnoLice;
        public RacunBasic Racun;

        public IList<KamataBasic> Kamate { get; set; }

        public KreditBasic()
        {
            Kamate = new List<KamataBasic>();
        }

        public KreditBasic(int id, DateTime datumDospeca, DateTime datumOdobrenja, decimal iznos,
            string valuta, string statusKredita, decimal mesecnaRata, int rokOtplate, string namena,
            decimal kamatnaStopa, string komentar, FizickoLiceBasic fizickoLice, PravnoLiceBasic pravnoLice,
            RacunBasic racun) : this()
        {
            this.Id = id;
            this.DatumDospeca = datumDospeca;
            this.DatumOdobrenja = datumOdobrenja;
            this.Iznos = iznos;
            this.Valuta = valuta;
            this.StatusKredita = statusKredita;
            this.MesecnaRata = mesecnaRata;
            this.RokOtplate = rokOtplate;
            this.Namena = namena;
            this.KamatnaStopa = kamatnaStopa;
            this.Komentar = komentar;
            this.FizickoLice = fizickoLice;
            this.PravnoLice = pravnoLice;
            this.Racun = racun;
        }
    }
    #endregion

    #region Transakcija
    public class TransakcijaPregled
    {
        public int Id;
        public DateTime DatumIVreme;
        public string TipTransakcije;
        public string StatusTransakcije;
        public string PodaciPrimaoca;
        public string Referenca;
        public string Valuta;
        public decimal Iznos;
        public string Opis;
        public string Komentar;
        public RacunPregled Racun;

        public TransakcijaPregled() { }

        public TransakcijaPregled(int id, DateTime datumIVreme, string tipTransakcije, string statusTransakcije,
            string podaciPrimaoca, string referenca, string valuta, decimal iznos, string opis, string komentar,
            RacunPregled racun)
        {
            this.Id = id;
            this.DatumIVreme = datumIVreme;
            this.TipTransakcije = tipTransakcije;
            this.StatusTransakcije = statusTransakcije;
            this.PodaciPrimaoca = podaciPrimaoca;
            this.Referenca = referenca;
            this.Valuta = valuta;
            this.Iznos = iznos;
            this.Opis = opis;
            this.Komentar = komentar;
            this.Racun = racun;
        }
    }

    public class TransakcijaBasic
    {
        public int Id;
        public DateTime DatumIVreme;
        public string TipTransakcije;
        public string StatusTransakcije;
        public string PodaciPrimaoca;
        public string Referenca;
        public string Valuta;
        public decimal Iznos;
        public string Opis;
        public string Komentar;
        public RacunBasic Racun;

        public TransakcijaBasic() { }

        public TransakcijaBasic(int id, DateTime datumIVreme, string tipTransakcije, string statusTransakcije,
            string podaciPrimaoca, string referenca, string valuta, decimal iznos, string opis, string komentar,
            RacunBasic racun)
        {
            this.Id = id;
            this.DatumIVreme = datumIVreme;
            this.TipTransakcije = tipTransakcije;
            this.StatusTransakcije = statusTransakcije;
            this.PodaciPrimaoca = podaciPrimaoca;
            this.Referenca = referenca;
            this.Valuta = valuta;
            this.Iznos = iznos;
            this.Opis = opis;
            this.Komentar = komentar;
            this.Racun = racun;
        }
    }
    #endregion

    #region Kamata
    public class KamataPregled
    {
        public int Id;
        public DateTime DatumObracuna;
        public string PeriodObracuna;
        public string TipKamate;
        public string StatusKamate;
        public decimal Iznos;
        public KreditPregled Kredit;
        public DepozitPregled Depozit;
        public RacunPregled Racun;

        public KamataPregled() { }

        public KamataPregled(int id, DateTime datumObracuna, string periodObracuna, string tipKamate,
            string statusKamate, decimal iznos, KreditPregled kredit, DepozitPregled depozit, RacunPregled racun)
        {
            this.Id = id;
            this.DatumObracuna = datumObracuna;
            this.PeriodObracuna = periodObracuna;
            this.TipKamate = tipKamate;
            this.StatusKamate = statusKamate;
            this.Iznos = iznos;
            this.Kredit = kredit;
            this.Depozit = depozit;
            this.Racun = racun;
        }
    }

    public class KamataBasic
    {
        public int Id;
        public DateTime DatumObracuna;
        public string PeriodObracuna;
        public string TipKamate;
        public string StatusKamate;
        public decimal Iznos;
        public KreditBasic Kredit;
        public DepozitBasic Depozit;
        public RacunBasic Racun;

        public KamataBasic() { }

        public KamataBasic(int id, DateTime datumObracuna, string periodObracuna, string tipKamate,
            string statusKamate, decimal iznos, KreditBasic kredit, DepozitBasic depozit, RacunBasic racun)
        {
            this.Id = id;
            this.DatumObracuna = datumObracuna;
            this.PeriodObracuna = periodObracuna;
            this.TipKamate = tipKamate;
            this.StatusKamate = statusKamate;
            this.Iznos = iznos;
            this.Kredit = kredit;
            this.Depozit = depozit;
            this.Racun = racun;
        }
    }
    #endregion

    #region SigurnosnaKontrola
    public class SigurnosnaKontrolaPregled
    {
        public int Id;
        public string IpAdresa;
        public DateTime DatumIVreme;
        public string TipDogadjaja;
        public string StatusDogadjaja;
        public string PodaciUredjaja;
        public string Opis;
        public RacunPregled Racun;

        public SigurnosnaKontrolaPregled() { }

        public SigurnosnaKontrolaPregled(int id, string ipAdresa, DateTime datumIVreme, string tipDogadjaja,
            string statusDogadjaja, string podaciUredjaja, string opis, RacunPregled racun)
        {
            this.Id = id;
            this.IpAdresa = ipAdresa;
            this.DatumIVreme = datumIVreme;
            this.TipDogadjaja = tipDogadjaja;
            this.StatusDogadjaja = statusDogadjaja;
            this.PodaciUredjaja = podaciUredjaja;
            this.Opis = opis;
            this.Racun = racun;
        }
    }

    public class SigurnosnaKontrolaBasic
    {
        public int Id;
        public string IpAdresa;
        public DateTime DatumIVreme;
        public string TipDogadjaja;
        public string StatusDogadjaja;
        public string PodaciUredjaja;
        public string Opis;
        public RacunBasic Racun;

        public SigurnosnaKontrolaBasic() { }

        public SigurnosnaKontrolaBasic(int id, string ipAdresa, DateTime datumIVreme, string tipDogadjaja,
            string statusDogadjaja, string podaciUredjaja, string opis, RacunBasic racun)
        {
            this.Id = id;
            this.IpAdresa = ipAdresa;
            this.DatumIVreme = datumIVreme;
            this.TipDogadjaja = tipDogadjaja;
            this.StatusDogadjaja = statusDogadjaja;
            this.PodaciUredjaja = podaciUredjaja;
            this.Opis = opis;
            this.Racun = racun;
        }
    }
    #endregion
}
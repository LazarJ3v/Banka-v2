using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class RacunPregled
    {
        public int Id { get; set; }
        public string BrojRacuna { get; set; }
        public string Valuta { get; set; }
        public decimal TrenutnoStanje { get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public string Status { get; set; }
        public decimal DozvoljeniMinus { get; set; }
        public string Komentar { get; set; }
        public string TipRacuna { get; set; }
        public decimal? KamatnaStopa { get; set; }
        public FizickoLicePregled FizickoLice { get; set; }
        public PravnoLicePregled PravnoLice { get; set; }
        [JsonIgnore]
        public IList<TransakcijaPregled> Transakcije { get; set; } = new List<TransakcijaPregled>();
        [JsonIgnore]
        public IList<DepozitPregled> Depoziti { get; set; } = new List<DepozitPregled>();
        [JsonIgnore]
        public IList<KreditPregled> Krediti { get; set; } = new List<KreditPregled>();
        [JsonIgnore]
        public IList<KamataPregled> Kamate { get; set; } = new List<KamataPregled>();
        [JsonIgnore]
        public IList<SigurnosnaKontrolaPregled> SigurnosneKontrole { get; set; } = new List<SigurnosnaKontrolaPregled>();

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

        public override string? ToString() => BrojRacuna;
    }
}

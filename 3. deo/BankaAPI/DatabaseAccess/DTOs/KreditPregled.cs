using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class KreditPregled
    {
        public int Id { get; set; }
        public DateTime DatumDospeca { get; set; }
        public DateTime DatumOdobrenja { get; set; }
        public decimal Iznos { get; set; }
        public string Valuta { get; set; }
        public string StatusKredita { get; set; }
        public decimal MesecnaRata { get; set; }
        public int RokOtplate { get; set; }
        public string Namena { get; set; }
        public decimal KamatnaStopa { get; set; }
        public string Komentar { get; set; }
        public FizickoLicePregled FizickoLice { get; set; }
        public PravnoLicePregled PravnoLice { get; set; }
        public RacunPregled Racun { get; set; }
        [JsonIgnore]
        public IList<KamataPregled> Kamate { get; set; } = new List<KamataPregled>();

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
}

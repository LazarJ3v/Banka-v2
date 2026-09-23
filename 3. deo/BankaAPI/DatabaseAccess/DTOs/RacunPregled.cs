using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
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

        public override string? ToString() => BrojRacuna;
    }
}

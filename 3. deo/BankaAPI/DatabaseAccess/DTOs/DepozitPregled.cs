using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class DepozitPregled
    {
        public int Id { get; set; }
        public DateTime DatumPocetka { get; set; }
        public int PeriodOrocenja { get; set; }
        public DateTime DatumIsteka { get; set; }
        public string StatusDepozita { get; set; }
        public string Valuta { get; set; }
        public decimal Iznos { get; set; }
        public decimal KamatnaStopa { get; set; }
        public string Komentar { get; set; }
        public decimal OcekivanaKamata { get; set; }
        public FizickoLicePregled FizickoLice { get; set; }
        public PravnoLicePregled PravnoLice { get; set; }
        public RacunPregled Racun { get; set; }

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
}

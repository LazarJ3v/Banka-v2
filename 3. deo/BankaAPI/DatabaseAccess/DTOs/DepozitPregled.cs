using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
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
}

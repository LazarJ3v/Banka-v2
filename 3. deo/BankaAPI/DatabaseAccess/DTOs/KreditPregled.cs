using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
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
}

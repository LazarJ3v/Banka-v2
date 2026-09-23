using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class KamataPregled
    {
        public int Id { get; set; }
        public DateTime DatumObracuna { get; set; }
        public string PeriodObracuna { get; set; }
        public string TipKamate { get; set; }
        public string StatusKamate { get; set; }
        public decimal Iznos { get; set; }
        public KreditPregled Kredit { get; set; }
        public DepozitPregled Depozit { get; set; }
        public RacunPregled Racun { get; set; }

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
}

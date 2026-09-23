using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
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
}

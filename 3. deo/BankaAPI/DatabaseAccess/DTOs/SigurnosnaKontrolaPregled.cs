using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class SigurnosnaKontrolaPregled
    {
        public int Id { get; set; }
        public string IpAdresa { get; set; }
        public DateTime DatumIVreme { get; set; }
        public string TipDogadjaja { get; set; }
        public string StatusDogadjaja { get; set; }
        public string PodaciUredjaja { get; set; }
        public string Opis { get; set; }
        public RacunPregled Racun { get; set; }

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
}

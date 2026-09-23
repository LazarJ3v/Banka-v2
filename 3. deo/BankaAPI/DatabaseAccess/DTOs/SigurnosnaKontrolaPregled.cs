using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class SigurnosnaKontrolaPregled
    {
        public int Id;
        public string? IpAdresa;
        public DateTime? DatumIVreme;
        public string? TipDogadjaja;
        public string? StatusDogadjaja;
        public string? PodaciUredjaja;
        public string? Opis;
        public RacunPregled? Racun;

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

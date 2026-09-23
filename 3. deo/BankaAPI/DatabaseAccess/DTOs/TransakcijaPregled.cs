using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class TransakcijaPregled
    {
        public int Id { get; set; }
        public DateTime DatumIVreme { get; set; }
        public string TipTransakcije { get; set; }
        public string StatusTransakcije { get; set; }
        public string PodaciPrimaoca { get; set; }
        public string Referenca { get; set; }
        public string Valuta { get; set; }
        public decimal Iznos { get; set; }
        public string Opis { get; set; }
        public string Komentar { get; set; }
        public RacunPregled Racun { get; set; }

        public TransakcijaPregled() { }

        public TransakcijaPregled(int id, DateTime datumIVreme, string tipTransakcije, string statusTransakcije,
            string podaciPrimaoca, string referenca, string valuta, decimal iznos, string opis, string komentar,
            RacunPregled racun)
        {
            this.Id = id;
            this.DatumIVreme = datumIVreme;
            this.TipTransakcije = tipTransakcije;
            this.StatusTransakcije = statusTransakcije;
            this.PodaciPrimaoca = podaciPrimaoca;
            this.Referenca = referenca;
            this.Valuta = valuta;
            this.Iznos = iznos;
            this.Opis = opis;
            this.Komentar = komentar;
            this.Racun = racun;
        }
    }
}

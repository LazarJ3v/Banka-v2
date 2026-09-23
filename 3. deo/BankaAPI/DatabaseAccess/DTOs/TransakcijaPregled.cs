using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class TransakcijaPregled
    {
        public int Id;
        public DateTime? DatumIVreme;
        public string? TipTransakcije;
        public string? StatusTransakcije;
        public string? PodaciPrimaoca;
        public string? Referenca;
        public string? Valuta;
        public decimal? Iznos;
        public string? Opis;
        public string? Komentar;
        public RacunPregled? Racun;

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

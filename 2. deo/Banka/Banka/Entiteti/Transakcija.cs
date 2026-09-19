using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class Transakcija
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumIVreme { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Status { get; set; }
        public virtual string PodaciPrimaoca { get; set; }
        public virtual string Referenca { get; set; }
        public virtual string Valuta { get; set; }
        public virtual decimal Iznos { get; set; }
        public virtual string Opis { get; set; }
        public virtual string Komentar { get; set; }

        public virtual Racun OdvijaSeNaRacun { get; set; }

        public Transakcija()
        {

        }
    }
}

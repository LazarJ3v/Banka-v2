using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    class Kamata
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumObracuna { get; set; }
        public virtual string PeriodObracuna { get; set; }
        public virtual string TipKamate { get; set; }
        public virtual string StatusKamate { get; set; }
        public virtual decimal Iznos { get; set; }

        public virtual Kredit PripadaKreditu { get; set; }
        public virtual Depozit PripadaDepozitu { get; set; }
        public virtual Racun PripadaRacunu { get; set; }

        public Kamata()
        {

        }
    }
}

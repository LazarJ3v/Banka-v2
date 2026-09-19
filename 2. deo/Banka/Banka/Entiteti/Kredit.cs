using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class Kredit
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumDospeca { get; set; }
        public virtual DateTime DatumOdobrenja { get; set; }
        public virtual decimal Iznos { get; set; }
        public virtual string Valuta { get; set; }
        public virtual string StatusKredita { get; set; }
        public virtual decimal MesecnaRata { get; set; }
        public virtual int RokOtplate { get; set; }
        public virtual string Namena { get; set; }
        public virtual decimal KamatnaStopa { get; set; }
        public virtual string Komentar { get; set; }

        public virtual FizickoLice PripadaFizickomLicu { get; set; }
        public virtual PravnoLice PripadaPravnomLicu { get; set; }
        public virtual Racun PripadaRacunu { get; set; }

        public Kredit()
        {

        }
    }
}

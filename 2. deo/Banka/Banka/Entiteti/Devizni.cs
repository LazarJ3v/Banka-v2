using Banka.Enumi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class Devizni : Racun
    {
        public virtual string Namena { get; set; }
        public virtual decimal? KursnaRazlika { get; set; }

        public virtual IList<DevizniOgranicenje> Ogranicanja { get; set; }
        public virtual IList<DevizniValuta> Valute { get; set; }

        public Devizni()
        {
            Ogranicanja = new List<DevizniOgranicenje>();
            Valute = new List<DevizniValuta>();
        }
    }
}

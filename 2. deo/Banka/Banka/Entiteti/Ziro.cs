using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class Ziro : Racun
    {
        public virtual string Namena { get; set; }
        public virtual bool ElektronskoBankarstvo { get; set; }
        public virtual decimal LimitZaMasovnaPlacanja { get; set; }
        public virtual string IntegracijaSaSistemima { get; set; }

        public Ziro()
        {

        }
    }
}

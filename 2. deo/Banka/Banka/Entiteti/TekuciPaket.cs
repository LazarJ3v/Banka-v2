using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class TekuciPaket
    {
        public virtual int Id { get; set; }
        public virtual string Paket { get; set; }

        public virtual Tekuci PripadaTekucem { get; set; }

        public TekuciPaket()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class Tekuci : Racun
    {
        public virtual bool PlatnaKartica { get; set; }
        public virtual decimal MesecniLimit { get; set; }

        public virtual IList<TekuciPaket> Paketi { get; set; }

        public Tekuci()
        {
            Paketi = new List<TekuciPaket>();
        }
    }
}

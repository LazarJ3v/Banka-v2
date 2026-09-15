using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class Stedni : Racun
    {
        public virtual decimal MinimalniIznosOtvaranja { get; set; }
        public virtual int FrekvKapitKamate { get; set; }

        public virtual IList<StedniBonus> Bonusi { get; set; }
        public virtual IList<StedniUslovPodizanja> UsloviPodizanja { get; set; }

        public Stedni()
        {
            Bonusi = new List<StedniBonus>();
            UsloviPodizanja = new List<StedniUslovPodizanja>();
        }
    }
}

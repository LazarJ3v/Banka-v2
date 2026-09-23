using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class StedniBonus
    {
        public virtual int Id { get; set; }
        public virtual string Bonus { get; set; }

        public virtual Stedni PripadaStednom { get; set; }

        public StedniBonus()
        {

        }
    }
}

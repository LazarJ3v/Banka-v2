using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class DevizniValuta
    {
        public virtual int Id { get; set; }
        public virtual string DozvoljenaValuta { get; set; }

        public virtual Devizni PripadaDeviznom { get; set; }

        public DevizniValuta()
        {

        }
    }
}

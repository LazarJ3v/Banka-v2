using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class DevizniValutaPregled
    {
        public int Id;
        public string DozvoljenaValuta;
        public DevizniPregled Devizni;

        public DevizniValutaPregled() { }

        public DevizniValutaPregled(int id, string dozvoljenaValuta, DevizniPregled devizni)
        {
            this.Id = id;
            this.DozvoljenaValuta = dozvoljenaValuta;
            this.Devizni = devizni;
        }
    }
}

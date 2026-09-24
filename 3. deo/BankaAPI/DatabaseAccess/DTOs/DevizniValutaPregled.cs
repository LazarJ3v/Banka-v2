using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class DevizniValutaPregled
    {
        public int Id { get; set; }
        public string DozvoljenaValuta { get; set; }
        [JsonIgnore]
        public DevizniPregled Devizni { get; set; }

        public DevizniValutaPregled() { }

        public DevizniValutaPregled(int id, string dozvoljenaValuta, DevizniPregled devizni)
        {
            this.Id = id;
            this.DozvoljenaValuta = dozvoljenaValuta;
            this.Devizni = devizni;
        }
    }
}

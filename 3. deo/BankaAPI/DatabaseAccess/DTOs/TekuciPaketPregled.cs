using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class TekuciPaketPregled
    {
        public int Id { get; set; }
        public string Paket { get; set; }
        [JsonIgnore]
        public TekuciPregled Tekuci { get; set; }

        public TekuciPaketPregled() { }

        public TekuciPaketPregled(int id, string paket, TekuciPregled tekuci)
        {
            this.Id = id;
            this.Paket = paket;
            this.Tekuci = tekuci;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class TekuciPaketPregled
    {
        public int Id;
        public string Paket;
        public TekuciPregled Tekuci;

        public TekuciPaketPregled() { }

        public TekuciPaketPregled(int id, string paket, TekuciPregled tekuci)
        {
            this.Id = id;
            this.Paket = paket;
            this.Tekuci = tekuci;
        }
    }
}

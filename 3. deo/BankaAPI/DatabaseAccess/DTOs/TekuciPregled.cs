using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class TekuciPregled : RacunPregled
    {
        public bool PlatnaKartica { get; set; }
        public decimal? MesecniLimit { get; set; }

        public TekuciPregled() { }

        public TekuciPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            bool platnaKartica, decimal? mesecniLimit)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.PlatnaKartica = platnaKartica;
            this.MesecniLimit = mesecniLimit;
        }
    }
}

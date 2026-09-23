using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class DevizniPregled : RacunPregled
    {
        public string Namena;
        public decimal? KursnaRazlika;

        public DevizniPregled() { }

        public DevizniPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            string namena, decimal? kursnaRazlika)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.Namena = namena;
            this.KursnaRazlika = kursnaRazlika;
        }
    }
}

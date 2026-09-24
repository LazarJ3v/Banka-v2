using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class StedniPregled : RacunPregled
    {
        public decimal? MinimalniIznosOtvaranja { get; set; }
        public int FrekvKapitalizKamate { get; set; }
        public IList<StedniBonusPregled> Bonusi { get; set; } = new List<StedniBonusPregled>();
        public IList<StedniUslovPodizanjaPregled> UsloviPodizanja { get; set; } = new List<StedniUslovPodizanjaPregled>();
        public StedniPregled() { }

        public StedniPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            decimal? minimalniIznosOtvaranja, int frekvKapitalizKamate)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.MinimalniIznosOtvaranja = minimalniIznosOtvaranja;
            this.FrekvKapitalizKamate = frekvKapitalizKamate;
        }
    }
}

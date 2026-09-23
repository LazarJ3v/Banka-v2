using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class ZiroPregled : RacunPregled
    {
        public string? Namena;
        public bool? ElektronskoBankarstvo;
        public decimal? LimitZaMasovnaPlacanja;
        public string? IntegracijaSaSistemima;

        public ZiroPregled() { }

        public ZiroPregled(int id, string brojRacuna, string valuta, decimal trenutnoStanje,
            DateTime datumOtvaranja, string status, decimal dozvoljeniMinus, string komentar,
            string tipRacuna, decimal? kamatnaStopa, FizickoLicePregled fizickoLice, PravnoLicePregled pravnoLice,
            string namena, bool elektronskoBankarstvo, decimal? limitZaMasovnaPlacanja, string integracijaSaSistemima)
            : base(id, brojRacuna, valuta, trenutnoStanje, datumOtvaranja, status, dozvoljeniMinus,
                  komentar, tipRacuna, kamatnaStopa, fizickoLice, pravnoLice)
        {
            this.Namena = namena;
            this.ElektronskoBankarstvo = elektronskoBankarstvo;
            this.LimitZaMasovnaPlacanja = limitZaMasovnaPlacanja;
            this.IntegracijaSaSistemima = integracijaSaSistemima;
        }
    }
}

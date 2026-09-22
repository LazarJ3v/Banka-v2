using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class Racun
    {
        public virtual int Id { get; set; }
        public virtual string BrojRacuna { get; set; }
        public virtual string Valuta { get; set; }
        public virtual decimal TrenutnoStanje { get; set; }
        public virtual DateTime DatumOtvaranja { get; set; }
        public virtual string Status { get; set; }
        public virtual decimal DozvoljeniMinus { get; set; }
        public virtual string Komentar { get; set; }
        public virtual string TipRacuna { get; set; }
        public virtual decimal? KamatnaStopa { get; set; }

        public virtual FizickoLice PripadaFizickomLicu { get; set; }
        public virtual PravnoLice PripadaPravnomLicu { get; set; }

        public virtual IList<Transakcija> Transakcije { get; set; }
        public virtual IList<Depozit> Depoziti { get; set; }
        public virtual IList<Kredit> Krediti { get; set; }
        public virtual IList<Kamata> Kamate { get; set; }
        public virtual IList<SigurnosnaKontrola> SigurnosneKontrole { get; set; }

        public Racun()
        {
            Transakcije = new List<Transakcija>();
            Depoziti = new List<Depozit>();
            Krediti = new List<Kredit>();
            Kamate = new List<Kamata>();
            SigurnosneKontrole = new List<SigurnosnaKontrola>();
        }
    }
}

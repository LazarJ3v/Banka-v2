using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class Depozit
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual int PeriodOrocenja { get; set; }
        public virtual DateTime DatumIsteka { get; set; }
        public virtual string StatusDepozita { get; set; }
        public virtual string Valuta { get; set; }
        public virtual decimal Iznos { get; set; }
        public virtual decimal KamatnaStopa { get; set; }
        public virtual string Komentar { get; set; }

        public virtual FizickoLice PripadaFizickomLicu { get; set; }
        public virtual PravnoLice PripadaPravnomLicu { get; set; }
        public virtual Racun PripadaRacunu { get; set; }

        // Izvedeni atribut - NIJE mapiran u bazi (baza ga ne skladišti,
        // vidi napomenu u "1. deo/Baza podataka - BANKA.txt").
        // Formula: Iznos * (KamatnaStopa/100) * (PeriodOrocenja/12)
        public virtual decimal OcekivanaKamata =>
            Iznos * (KamatnaStopa / 100m) * (PeriodOrocenja / 12m);

        public Depozit()
        {

        }
    }
}

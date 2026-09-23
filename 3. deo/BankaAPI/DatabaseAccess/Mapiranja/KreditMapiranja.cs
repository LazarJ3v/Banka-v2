using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class KreditMapiranja : ClassMap<Kredit>
    {
        public KreditMapiranja()
        {
            Table("KREDIT");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumDospeca).Column("DATUMDOSPECA").Not.Nullable();
            Map(x => x.DatumOdobrenja).Column("DATUMODOBRENJA").Not.Nullable();
            Map(x => x.Iznos).Column("IZNOS").Not.Nullable();
            Map(x => x.Valuta).Column("VALUTA").Not.Nullable();
            Map(x => x.StatusKredita).Column("STATUSKREDITA");
            Map(x => x.MesecnaRata).Column("MESECNARATA").Not.Nullable();
            Map(x => x.RokOtplate).Column("ROKOTPLATE").Not.Nullable();
            Map(x => x.Namena).Column("NAMENA");
            Map(x => x.KamatnaStopa).Column("KAMATNASTOPA").Not.Nullable();
            Map(x => x.Komentar).Column("KOMENTAR");

            // Isto kao kod Depozita - CHK_Kredit_Klijent obezbeđuje da makar
            // jedno od dvoje bude popunjeno, ovde su oba nullable.
            References(x => x.PripadaFizickomLicu).Column("FIZICKOLICEID").LazyLoad();
            References(x => x.PripadaPravnomLicu).Column("PRAVNOLICEID").LazyLoad();

            References(x => x.PripadaRacunu).Column("RACUNID").Not.Nullable().LazyLoad();

            HasMany(x => x.Kamate)
                .KeyColumn("KREDITID")
                .Inverse();
        }
    }
}

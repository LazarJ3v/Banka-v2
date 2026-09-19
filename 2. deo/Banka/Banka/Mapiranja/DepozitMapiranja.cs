using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class DepozitMapiranja : ClassMap<Depozit>
    {
        public DepozitMapiranja()
        {
            Table("DEPOZIT");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumPocetka).Column("DATUMPOCETKA").Not.Nullable();
            Map(x => x.PeriodOrocenja).Column("PERIODOROCENJA").Not.Nullable();
            Map(x => x.DatumIsteka).Column("DATUMISTEKA").Not.Nullable();
            Map(x => x.StatusDepozita).Column("STATUSDEPOZITA");
            Map(x => x.Valuta).Column("VALUTA").Not.Nullable();
            Map(x => x.Iznos).Column("IZNOS").Not.Nullable();
            Map(x => x.KamatnaStopa).Column("KAMATNASTOPA").Not.Nullable();
            Map(x => x.Komentar).Column("KOMENTAR");

            // Not.Nullable() se namerno NE stavlja na ova dva - baza dozvoljava
            // da jedno od njih bude NULL (CHK_Depozit_Klijent obezbeđuje da
            // makar jedno bude popunjeno, to se mora proveriti u DTOManager-u).
            References(x => x.PripadaFizickomLicu).Column("FIZICKOLICEID").LazyLoad();
            References(x => x.PripadaPravnomLicu).Column("PRAVNOLICEID").LazyLoad();

            References(x => x.PripadaRacunu).Column("RACUNID").Not.Nullable().LazyLoad();
        }
    }
}

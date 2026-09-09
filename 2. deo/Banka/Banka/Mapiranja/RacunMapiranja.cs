using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class RacunMapiranja : ClassMap<Racun>
    {
        RacunMapiranja()
        {
            Table("RACUN");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojRacuna).Column("BROJRACUNA");
            Map(x => x.Valuta).Column("VALUTA");
            Map(x => x.TrenutnoStanje).Column("TRENUTNOSTANJE");
            Map(x => x.DatumOtvaranja).Column("DATUMOTVARANJA");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.DozvoljeniMinus).Column("DOZVOLJENIMINUS");
            Map(x => x.Komentar).Column("KOMENTAR");
            Map(x => x.TipRacuna).Column("TIPRACUNA");
            Map(x => x.KamatnaStopa).Column("KAMATNASTOPA");

            References(x => x.PripadaFizickomLicu).Column("FIZICKOLICEID").LazyLoad();
            References(x => x.PripadaPravnomLicu).Column("PRAVNOLICEID").LazyLoad();
        }
    }
}

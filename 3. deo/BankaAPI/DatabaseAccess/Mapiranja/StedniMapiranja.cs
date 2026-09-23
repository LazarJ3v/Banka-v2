using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class StedniMapiranja : SubclassMap<Stedni>
    {
        public StedniMapiranja()
        {
            Table("STEDNI");

            KeyColumn("RACUNID");

            Map(x => x.MinimalniIznosOtvaranja).Column("MINIMALNIIZNOSOTVARANJA");
            Map(x => x.FrekvKapitKamate).Column("FREKVKAPITALIZKAMATE");

            HasMany(x => x.Bonusi)
                .Table("STEDNI_BONUS")
                .KeyColumn("RACUNID")
                .Inverse()
                .Cascade.AllDeleteOrphan();

            HasMany(x => x.UsloviPodizanja)
                .Table("STEDNI_USLOVI_PODIZANJA")
                .KeyColumn("RACUNID")
                .Inverse()
                .Cascade.AllDeleteOrphan();
        }
    }
}

using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class TekuciMapiranja : SubclassMap<Tekuci>
    {
        TekuciMapiranja()
        {
            Table("TEKUCI");

            KeyColumn("RACUNID");

            Map(x => x.PlatnaKartica).Column("PLATNAKARTICA");
            Map(x => x.MesecniLimit).Column("MESECNILIMIT");

            HasMany(x => x.Paketi)
                .Table("TEKUCI_PAKET")
                .KeyColumn("RACUNID")
                .Inverse()
                .Cascade.AllDeleteOrphan();
        }
    }
}

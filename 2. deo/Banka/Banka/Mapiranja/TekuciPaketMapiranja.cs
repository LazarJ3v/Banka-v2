using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class TekuciPaketMapiranja : ClassMap<TekuciPaket>
    {
        TekuciPaketMapiranja()
        {
            Table("TEKUCI_PAKET");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Paket).Column("PAKET");

            References(x => x.PripadaTekucem).Column("RACUNID").LazyLoad();
        }
    }
}

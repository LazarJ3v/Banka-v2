using FluentNHibernate.Mapping;
using Banka.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class DevizniValutaMapiranja : ClassMap<DevizniValuta>
    {
        public DevizniValutaMapiranja()
        {
            Table("DEVIZNI_VALUTA");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DozvoljenaValuta).Column("DOZVOLJENAVALUTA");

            References(x => x.PripadaDeviznom).Column("RACUNID").LazyLoad();
        }
    }
}

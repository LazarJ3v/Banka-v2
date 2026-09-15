using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class DevizniOgranicenjeMapiranja : ClassMap<DevizniOgranicenje>
    {
        public DevizniOgranicenjeMapiranja()
        {
            Table("DEVIZNI_OGRANICENJE");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ogranicenje).Column("OGRANICENJE");

            References(x => x.PripadaDeviznom).Column("RACUNID").LazyLoad();
        }
    }
}

using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class StedniUslovPodizanjaMapiranja : ClassMap<StedniUslovPodizanja>
    {
        public StedniUslovPodizanjaMapiranja()
        {
            Table("STEDNI_USLOVI_PODIZANJA");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.UslovPodizanja).Column("USLOVPODIZANJA");

            References(x => x.PripadaStednom).Column("RACUNID").LazyLoad();
        }
    }
}

using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class StedniBonusMapiranja : ClassMap<StedniBonus>
    {
        public StedniBonusMapiranja()
        {
            Table("STEDNI_BONUS");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Bonus).Column("BONUS");

            References(x => x.PripadaStednom).Column("RACUNID").LazyLoad();
        }
    }
}

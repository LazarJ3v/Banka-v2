using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class SigurnosnaKontrolaMapiranja : ClassMap<SigurnosnaKontrola>
    {
        public SigurnosnaKontrolaMapiranja()
        {
            Table("SIGURNOSNA_KONTROLA");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.IpAdresa).Column("IPADRESA").Not.Nullable();
            Map(x => x.DatumIVreme).Column("DATUMIVREME").Not.Nullable();
            Map(x => x.TipDogadjaja).Column("TIPDOGADJAJA").Not.Nullable();
            Map(x => x.StatusDogadjaja).Column("STATUSDOGADJAJA");
            Map(x => x.PodaciUredjaja).Column("PODACIUREDJAJA");
            Map(x => x.Opis).Column("OPIS");

            References(x => x.PripadaRacunu).Column("RACUNID").Not.Nullable().LazyLoad();
        }
    }
}

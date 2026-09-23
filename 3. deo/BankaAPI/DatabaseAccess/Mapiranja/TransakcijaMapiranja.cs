using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class TransakcijaMapiranja : ClassMap<Transakcija>
    {
        public TransakcijaMapiranja()
        {
            Table("TRANSAKCIJA");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumIVreme).Column("DATUMIVREME").Not.Nullable();
            Map(x => x.Tip).Column("TIPTRANSAKCIJE").Not.Nullable();
            Map(x => x.Status).Column("STATUSTRANSAKCIJE");
            Map(x => x.PodaciPrimaoca).Column("PODACIPRIMAOCA");
            Map(x => x.Referenca).Column("REFERENCA");
            Map(x => x.Valuta).Column("VALUTA").Not.Nullable();
            Map(x => x.Iznos).Column("IZNOS").Not.Nullable();
            Map(x => x.Opis).Column("OPIS");
            Map(x => x.Komentar).Column("KOMENTAR");

            References(x => x.OdvijaSeNaRacun)
                .Column("RACUNID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}

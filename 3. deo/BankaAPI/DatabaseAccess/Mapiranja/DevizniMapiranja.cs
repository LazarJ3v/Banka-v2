using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class DevizniMapiranja : SubclassMap<Devizni>
    {
        public DevizniMapiranja()
        {
            Table("DEVIZNI");

            KeyColumn("RACUNID");

            Map(x => x.Namena).Column("NAMENA");
            Map(x => x.KursnaRazlika).Column("KURSNARAZLIKA");

            HasMany(x => x.Ogranicanja)
                .Table("DEVIZNI_OGRANICENJE")
                .KeyColumn("RACUNID")
                .Inverse()
                .Cascade.AllDeleteOrphan();

            HasMany(x => x.Valute)
                .Table("DEVIZNI_VALUTA")
                .KeyColumn("RACUNID")
                .Inverse()
                .Cascade.AllDeleteOrphan();
        }
    }
}

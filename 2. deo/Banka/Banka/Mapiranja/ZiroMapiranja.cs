using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class ZiroMapiranja : SubclassMap<Ziro>
    {
        public ZiroMapiranja()
        {
            Table("ZIRO");
            //Id(x => x.RacunId).Column("RACUNID"); // proveriti
            KeyColumn("RACUNID");

            Map(x => x.Namena).Column("NAMENA");
            Map(x => x.ElektronskoBankarstvo).Column("ELEKTRONSKOBANKARSTVO");
            Map(x => x.LimitZaMasovnaPlacanja).Column("LIMITZAMASOVNAPLACANJA");
            Map(x => x.IntegracijaSaSistemima).Column("INTEGRACIJASASISTEMIMA");
        }
    }
}

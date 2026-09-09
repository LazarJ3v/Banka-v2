using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Banka.Entiteti;

namespace Banka.Mapiranja
{
    class FizickoLiceMapiranja : ClassMap<FizickoLice>
    {
        public FizickoLiceMapiranja()
        {
            Table("FIZICKO_LICE");
            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Jmbg).Column("JMBG");
            Map(x => x.BrojLicneKarte).Column("BROJLICNEKARTE");
            Map(x => x.DatumRodjenja).Column("DATUMRODJENJA");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Grad).Column("GRAD");
            Map(x => x.Telefon).Column("TELEFON");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.Komentar).Column("KOMENTAR");

            HasMany(x => x.Racuni).KeyColumn("FIZICKOLICEID").Cascade.All().Inverse();
        }
    }
}

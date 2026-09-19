using Banka.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Mapiranja
{
    class KamataMapiranja : ClassMap<Kamata>
    {
        public KamataMapiranja()
        {
            Table("KAMATA");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumObracuna).Column("DATUMOBRACUNA").Not.Nullable();
            Map(x => x.PeriodObracuna).Column("PERIODOBRACUNA");
            Map(x => x.TipKamate).Column("TIPKAMATE").Not.Nullable();
            Map(x => x.StatusKamate).Column("STATUSKAMATE");
            Map(x => x.Iznos).Column("IZNOS").Not.Nullable();

            // Sve tri veze su nullable - CHK_Kamata_Izvor u bazi obezbeđuje
            // da bude popunjena makar jedna (proveriti u DTOManager-u pre upisa).
            References(x => x.PripadaKreditu).Column("KREDITID").LazyLoad();
            References(x => x.PripadaDepozitu).Column("DEPOZITID").LazyLoad();
            References(x => x.PripadaRacunu).Column("RACUNID").LazyLoad();
        }
    }
}

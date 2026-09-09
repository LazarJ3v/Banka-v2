using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.Enumi;

namespace Banka.Entiteti
{
    public class FizickoLice
    {
        // propertiji su virtual jer ce NHibernate da ih override-uje
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Jmbg { get; set; }
        public virtual string BrojLicneKarte { get; set; }
        public virtual DateTime? DatumRodjenja { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }
        public virtual string Status { get; set; }
        public virtual string Komentar { get; set; }

        public virtual IList<Racun> Racuni { get; set; }
        public FizickoLice()
        {
            Racuni = new List<Racun>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Entiteti
{
    public class PravnoLice
    {
        public virtual int Id { get; set; }
        public virtual string NazivFirme { get; set; }
        public virtual string Pib { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }
        public virtual string Status { get; set; }
        public virtual string Komentar { get; set; }

        public PravnoLice()
        {

        }
    }
}

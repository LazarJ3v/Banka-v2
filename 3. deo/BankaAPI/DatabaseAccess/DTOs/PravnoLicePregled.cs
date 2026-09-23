using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class PravnoLicePregled
    {
        public int Id;
        public string? NazivFirme;
        public string? Pib;
        public string? Adresa;
        public string? Grad;
        public string? Telefon;
        public string? Email;
        public string? Status;
        public string? Komentar;

        public PravnoLicePregled() { }

        public PravnoLicePregled(int id, string nazivFirme, string pib, string adresa, string grad,
            string telefon, string email, string status, string komentar)
        {
            this.Id = id;
            this.NazivFirme = nazivFirme;
            this.Pib = pib;
            this.Adresa = adresa;
            this.Grad = grad;
            this.Telefon = telefon;
            this.Email = email;
            this.Status = status;
            this.Komentar = komentar;
        }

        public override string? ToString() => NazivFirme;
    }
}

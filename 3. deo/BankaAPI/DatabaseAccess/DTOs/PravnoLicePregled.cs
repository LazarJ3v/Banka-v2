using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class PravnoLicePregled
    {
        public int Id { get; set; }
        public string NazivFirme { get; set; }
        public string Pib { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Komentar { get; set; }

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

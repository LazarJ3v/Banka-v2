using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class FizickoLicePregled
    {
        public int Id;
        public string Ime;
        public string Prezime;
        public string Jmbg;
        public string BrojLicneKarte;
        public DateTime? DatumRodjenja;
        public string Adresa;
        public string Grad;
        public string Telefon;
        public string Email;
        public string Status;
        public string Komentar;

        public FizickoLicePregled() { }

        public FizickoLicePregled(int id, string ime, string prezime, string jmbg, string brojLicneKarte,
            DateTime? datumRodjenja, string adresa, string grad, string telefon, string email,
            string status, string komentar)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
            this.BrojLicneKarte = brojLicneKarte;
            this.DatumRodjenja = datumRodjenja;
            this.Adresa = adresa;
            this.Grad = grad;
            this.Telefon = telefon;
            this.Email = email;
            this.Status = status;
            this.Komentar = komentar;
        }

        public override string ToString() => Ime + " " + Prezime;
    }
}

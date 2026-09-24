using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class FizickoLicePregled
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }
        public string BrojLicneKarte { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Komentar { get; set; }
        [JsonIgnore]
        public IList<RacunPregled> Racuni { get; set; } = new List<RacunPregled>();
        [JsonIgnore]
        public IList<DepozitPregled> Depoziti { get; set; } = new List<DepozitPregled>();
        [JsonIgnore]
        public IList<KreditPregled> Krediti { get; set; } = new List<KreditPregled>();

        public FizickoLicePregled() { }

        public FizickoLicePregled(int id, string ime, string prezime, string jmbg, string brojLicneKarte,
            DateTime datumRodjenja, string adresa, string grad, string telefon, string email,
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

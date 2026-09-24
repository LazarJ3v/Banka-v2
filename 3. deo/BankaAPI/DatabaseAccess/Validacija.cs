using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DatabaseAccess.Enumi;

namespace DatabaseAccess
{
    public static class Validacija
    {
        // ==========================================
        // FIZICKO LICE
        // ==========================================

        public static void ValidirajJmbg(string jmbg)
        {
            if (string.IsNullOrWhiteSpace(jmbg))
                throw new ArgumentException("JMBG je obavezno polje.");

            jmbg = jmbg.Trim();

            if (!Regex.IsMatch(jmbg, @"^\d{13}$"))
                throw new ArgumentException("JMBG mora sadržati tačno 13 cifara.");
        }

        public static void ValidirajBrojLicneKarte(string brojLicneKarte)
        {
            if (string.IsNullOrWhiteSpace(brojLicneKarte))
                throw new ArgumentException("Broj lične karte je obavezno polje.");

            brojLicneKarte = brojLicneKarte.Trim();

            if (!Regex.IsMatch(brojLicneKarte, @"^\d{9}$"))
                throw new ArgumentException("Broj lične karte mora sadržati tačno 9 cifara.");
        }

        public static void ValidirajIme(string ime, string nazivPolja = "Ime")
        {
            if (string.IsNullOrWhiteSpace(ime))
                throw new ArgumentException($"{nazivPolja} je obavezno polje.");

            if (ime.Trim().Length < 2)
                throw new ArgumentException($"{nazivPolja} mora imati bar 2 karaktera.");
        }

        public static void ValidirajDatumRodjenja(DateTime? datum)
        {
            if (datum == null)
                throw new ArgumentException("Datum rođenja je obavezno polje.");

            if (datum.Value > DateTime.Now)
                throw new ArgumentException("Datum rođenja ne može biti u budućnosti.");

            if (datum.Value < new DateTime(1900, 1, 1))
                throw new ArgumentException("Datum rođenja nije validan.");
        }

        // ==========================================
        // PRAVNO LICE
        // ==========================================

        public static void ValidirajPib(string pib)
        {
            if (string.IsNullOrWhiteSpace(pib))
                throw new ArgumentException("PIB je obavezno polje.");

            pib = pib.Trim();

            if (!Regex.IsMatch(pib, @"^\d{9}$"))
                throw new ArgumentException("PIB mora sadržati tačno 9 cifara.");
        }

        public static void ValidirajNazivFirme(string naziv)
        {
            if (string.IsNullOrWhiteSpace(naziv))
                throw new ArgumentException("Naziv firme je obavezno polje.");

            if (naziv.Trim().Length < 2)
                throw new ArgumentException("Naziv firme mora imati bar 2 karaktera.");
        }

        // ==========================================
        // ZAJEDNICKA POLJA (Fizicko/Pravno lice)
        // ==========================================

        public static void ValidirajEmail(string email, bool obavezno = false)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                if (obavezno)
                    throw new ArgumentException("Email je obavezno polje.");
                return; // dozvoljeno prazno ako nije obavezno
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email.Trim(), pattern))
                throw new ArgumentException("Email adresa nije u ispravnom formatu.");
        }

        public static void ValidirajTelefon(string telefon, bool obavezno = false)
        {
            if (string.IsNullOrWhiteSpace(telefon))
            {
                if (obavezno)
                    throw new ArgumentException("Telefon je obavezno polje.");
                return;
            }

            // dozvoljava cifre, razmake, +, -, ()
            if (!Regex.IsMatch(telefon.Trim(), @"^[\d\s\+\-\(\)]{6,20}$"))
                throw new ArgumentException("Broj telefona nije u ispravnom formatu.");
        }

        public static void ValidirajGrad(string grad)
        {
            if (string.IsNullOrWhiteSpace(grad))
                throw new ArgumentException("Grad je obavezno polje.");
        }

        public static void ValidirajAdresu(string adresa)
        {
            if (string.IsNullOrWhiteSpace(adresa))
                throw new ArgumentException("Adresa je obavezno polje.");
        }

        // ==========================================
        // RACUN
        // ==========================================

        public static void ValidirajBrojRacuna(string brojRacuna)
        {
            if (string.IsNullOrWhiteSpace(brojRacuna))
                throw new ArgumentException("Broj računa je obavezno polje.");

            // primer formata: 160-0000000001-11
            if (!Regex.IsMatch(brojRacuna.Trim(), @"^\d{3}-\d{10}-\d{2}$"))
                throw new ArgumentException("Broj računa mora biti u formatu XXX-XXXXXXXXXX-XX.");
        }

        public static void ValidirajValutu(string valuta)
        {
            string[] dozvoljene = { "RSD", "EUR", "USD", "CHF", "GBP" };

            if (string.IsNullOrWhiteSpace(valuta))
                throw new ArgumentException("Valuta je obavezno polje.");

            if (!dozvoljene.Contains(valuta.Trim().ToUpper()))
                throw new ArgumentException($"Valuta mora biti jedna od: {string.Join(", ", dozvoljene)}.");
        }

        public static void ValidirajIznos(decimal iznos, string nazivPolja = "Iznos", bool dozvoliNulu = true)
        {
            if (iznos < 0)
                throw new ArgumentException($"{nazivPolja} ne može biti negativan.");

            if (!dozvoliNulu && iznos == 0)
                throw new ArgumentException($"{nazivPolja} mora biti veći od 0.");
        }

        public static void ValidirajKamatnuStopu(decimal? kamatnaStopa)
        {
            if (kamatnaStopa.HasValue && (kamatnaStopa < 0 || kamatnaStopa > 100))
                throw new ArgumentException("Kamatna stopa mora biti između 0 i 100.");
        }

        // ==========================================
        // DEPOZIT / KREDIT
        // ==========================================

        public static void ValidirajPeriodOrocenja(int mesecu)
        {
            if (mesecu <= 0 || mesecu > 120)
                throw new ArgumentException("Period oročenja mora biti između 1 i 120 meseci.");
        }

        public static void ValidirajRokOtplate(int meseci)
        {
            if (meseci <= 0 || meseci > 360)
                throw new ArgumentException("Rok otplate mora biti između 1 i 360 meseci.");
        }

        // ==========================================
        // SIGURNOSNA KONTROLA
        // ==========================================

        public static void ValidirajIPAdresu(string ipAdresa, string nazivPolja = "IP adresa")
        {
            if (string.IsNullOrWhiteSpace(ipAdresa))
                throw new ArgumentException($"{nazivPolja} je obavezno polje.");

            string pattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            if (!Regex.IsMatch(ipAdresa.Trim(), pattern))
                throw new ArgumentException($"{nazivPolja} nije u ispravnom formatu (XXX.XXX.XXX.XXX).");
        }

        public static string ValidirajEnum<TEnum>(string vrednost, string nazivPolja)
            where TEnum : struct, Enum
        {
            if (string.IsNullOrWhiteSpace(vrednost))
                throw new ArgumentException($"{nazivPolja} je obavezno polje.");

            foreach (TEnum e in Enum.GetValues(typeof(TEnum)))
            {
                if (string.Equals(e.GetDescription(), vrednost.Trim(), StringComparison.OrdinalIgnoreCase))
                    return e.GetDescription();
            }

            var dozvoljene = string.Join(", ",
                ((TEnum[])Enum.GetValues(typeof(TEnum))).Select(e => e.GetDescription()));
            throw new ArgumentException($"{nazivPolja}: nepoznata vrednost '{vrednost}'. Dozvoljeno: {dozvoljene}.");
        }

        public static void ValidirajFrekvKapitalizKamate(int vrednost)
        {
            if (!Enum.IsDefined(typeof(FrekvencijaKapitalizacijeKamate), vrednost))
                throw new ArgumentException("Frekvencija kapitalizacije kamate mora biti jedna od: 365, 12, 4, 2, 1.");
        }

        // ==========================================
        // KLIJENT (cross-field)
        // ==========================================

        public static void ValidirajKlijentaTacnoJedan(object fizickoLice, object pravnoLice)
        {
            bool imaFl = fizickoLice != null;
            bool imaPl = pravnoLice != null;

            if (imaFl == imaPl) // oba null ili oba popunjena
                throw new ArgumentException("Račun mora pripadati tačno jednom klijentu (fizičkom ili pravnom licu, ne oba i ne nijednom).");
        }

        public static void ValidirajKlijentaBarJedan(object fizickoLice, object pravnoLice)
        {
            if (fizickoLice == null && pravnoLice == null)
                throw new ArgumentException("Mora biti vezano za fizičko ili pravno lice.");
        }

        public static void ValidirajIzvorKamate(object kredit, object depozit, object racun)
        {
            if (kredit == null && depozit == null && racun == null)
                throw new ArgumentException("Kamata mora biti vezana za kredit, depozit ili račun.");
        }

    }
}

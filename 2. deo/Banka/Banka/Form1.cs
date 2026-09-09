using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Banka.Entiteti;

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                FizickoLice fl = session.Load<FizickoLice>(1);

                string poruka = $"Id: {fl.Id}\n" +
                $"Ime: {fl.Ime}\n" +
                $"Prezime: {fl.Prezime}\n" +
                $"Jmbg: {fl.Jmbg}\n" +
                $"BrojLicneKarte: {fl.BrojLicneKarte}\n" +
                $"DatumRodjenja: {fl.DatumRodjenja}\n" +
                $"Adresa: {fl.Adresa}\n" +
                $"Grad: {fl.Grad}\n" +
                $"Telefon: {fl.Telefon}\n" +
                $"Email: {fl.Email}\n" +
                $"Status: {fl.Status}\n" +
                $"Komentar: {fl.Komentar}";

                MessageBox.Show(poruka);
                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            try
            {
                FizickoLice fl = new FizickoLice();

                fl.Ime = "Lazar";
                fl.Prezime = "Jevtic";
                fl.Jmbg = "0413046723231";
                fl.BrojLicneKarte = "017654430";
                fl.DatumRodjenja = new DateTime(2000, 2, 18);
                fl.Adresa = "Bore Stankovica 16";
                fl.Grad = "Paracin";
                fl.Telefon = "06165434433";
                fl.Email = "aleksa.jevtic@gmail.com";
                fl.Status = "Aktivan";
                fl.Komentar = "test komentar";

                session.SaveOrUpdate(fl);
                
                MessageBox.Show("Uspesno dodato fizicko lice");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (session.IsOpen)
                {
                    session.Flush();
                    session.Close();
                }  
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            try
            {
                FizickoLice fl = session.Load<FizickoLice>(1);

                fl.Status = "Neaktivan";

                session.SaveOrUpdate(fl);

                MessageBox.Show("Uspesno izmenjeno fizicko lice");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (session.IsOpen)
                {
                    session.Flush();
                    session.Close();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            try
            {
                FizickoLice fl = session.Load<FizickoLice>(4);

                if(fl == null)
                {
                    MessageBox.Show("Nije pronadjeno fizicko lice");
                    return;
                }

                session.Delete(fl);

                MessageBox.Show("Uspesno obrisan fizicko lice");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (session.IsOpen)
                {
                    session.Flush();
                    session.Close();
                }
            }
        }
    }
}

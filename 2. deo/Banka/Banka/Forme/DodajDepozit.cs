using Banka.Entiteti;
using Banka.Enumi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka.Forme
{
    public partial class DodajDepozit : BaseForm
    {
        public DodajDepozit() : base()
        {
            InitializeComponent();

            StilizujLabel(
                lblDatumPocetka,
                lblDatumIsteka,
                lblPeriodOrocenja,
                lblStatusDepozita,
                lblValuta,
                lblIznos,
                lblKamatnaStopa,
                lblKomentar,
                lblBrRacuna);

            StilizujDateTimePicker(dtpDatumPocetka, dtpDatumIsteka);
            StilizujNumericUpDown(nudPeriodOrocenja, nudIznos, nudKamatnaStopa);
            StilizujComboBox(cbStatusDepozita, cbValuta);
            StilizujRichTextBox(rtbKomentar);
            StilizujButton(btnSacuvaj);
            StilizujTextBox(tbBrRacuna);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var racun = DTOManager.VratiRacun(tbBrRacuna.Text?.Trim());

            if (racun == null)
            {
                MessageBox.Show("Pogrešan broj računa.");
                return;
            }

            var dto = new DepozitBasic
            {
                DatumPocetka = dtpDatumPocetka.Value,
                PeriodOrocenja = (int)nudPeriodOrocenja.Value,
                DatumIsteka = dtpDatumIsteka.Value,
                StatusDepozita = cbStatusDepozita.Text,
                Valuta = cbValuta.Text,
                Iznos = nudIznos.Value,
                KamatnaStopa = nudKamatnaStopa.Value,
                Komentar = rtbKomentar.Text
            };

            string jmbg = racun.FizickoLice == null ? "null" : racun.FizickoLice.Jmbg;
            string pib = racun.PravnoLice == null ? "null" : racun.PravnoLice.Pib;

            DTOManager.DodajDepozit(dto, jmbg, pib, racun.Id);
            MessageBox.Show(
                        "Depozit uspešno dodat!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DodajDepozit_Load(object sender, EventArgs e)
        {
            foreach (StatusDepozita status in Enum.GetValues(typeof(StatusDepozita)))
            {
                cbStatusDepozita.Items.Add(status.GetDescription());
            }
            cbStatusDepozita.SelectedIndex = 0;

            foreach (RacunValuta valuta in Enum.GetValues(typeof(RacunValuta)))
            {
                cbValuta.Items.Add(valuta.GetDescription());
            }
            cbValuta.SelectedIndex = 0;
        }
    }
}

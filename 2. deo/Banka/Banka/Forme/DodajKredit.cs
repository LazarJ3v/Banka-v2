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
    public partial class DodajKredit : BaseForm
    {
        public DodajKredit() : base()
        {
            InitializeComponent();

            StilizujLabel(
                lblBrRacuna,
                lblDatumDospeca,
                lblDatumOdobrenja,
                lblIznos,
                lblValuta,
                lblStatus,
                lblMesecnaRata,
                lblRokOtplate,
                lblNamena,
                lblKamatnaStopa,
                lblKomentar);

            StilizujDateTimePicker(dtpDatumDospeca, dtpDatumOdobrenja);
            StilizujNumericUpDown(nudIznos, nudMesecnaRata, nudRokOtplate, nudKamatnaStopa);
            StilizujComboBox(cbValuta, cbStatus);
            StilizujTextBox(tbNamena, tbBrRacuna);
            StilizujRichTextBox(rtbKomentar);
            StilizujButton(btnSacuvaj);
        }

        private void DodajKredit_Load(object sender, EventArgs e)
        {
            foreach (RacunValuta valuta in Enum.GetValues(typeof(RacunValuta)))
            {
                cbValuta.Items.Add(valuta.GetDescription());
            }
            cbValuta.SelectedIndex = 0;

            foreach (StatusKredita status in Enum.GetValues(typeof(StatusKredita)))
            {
                cbStatus.Items.Add(status.GetDescription());
            }
            cbStatus.SelectedIndex = 0;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var racun = DTOManager.VratiRacun(tbBrRacuna.Text?.Trim());

            if (racun == null)
            {
                MessageBox.Show("Pogrešan broj računa.");
                return;
            }

            var dto = new KreditBasic
            {
                DatumDospeca = dtpDatumDospeca.Value,
                DatumOdobrenja = dtpDatumOdobrenja.Value,
                Iznos = nudIznos.Value,
                Valuta = cbValuta.Text,
                StatusKredita = cbStatus.Text,
                MesecnaRata = nudMesecnaRata.Value,
                RokOtplate = (int)nudRokOtplate.Value,
                Namena = tbNamena.Text,
                KamatnaStopa = nudKamatnaStopa.Value,
                Komentar = rtbKomentar.Text
            };

            string jmbg = racun.FizickoLice == null ? "null" : racun.FizickoLice.Jmbg;
            string pib = racun.PravnoLice == null ? "null" : racun.PravnoLice.Pib;

            DTOManager.DodajKredit(dto, jmbg, pib, racun.Id);
            MessageBox.Show(
                        "Kredit uspešno dodat!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

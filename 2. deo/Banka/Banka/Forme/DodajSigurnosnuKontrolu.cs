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
    public partial class DodajSigurnosnuKontrolu : BaseForm
    {
        public DodajSigurnosnuKontrolu() : base()
        {
            InitializeComponent();
            StilizujButton(
                btnSacuvaj);
            StilizujComboBox(
                cbStatusDogadjaja,
                cbTipDogadjaja);
            StilizujTextBox(
                tbBrojRacuna,
                tbIpAdresa);
            StilizujRichTextBox(
                rtbOpis,
                rtbPodaciUredjaja);
            StilizujLabel(
                lblBrojRacuna,
                lblDatumIVreme,
                lblIpAdresa,
                lblOpis,
                lblPodaciUredjaja,
                lblStatusDogadjaja,
                lblTipDogaljaja,
                lblBrojRacuna);
            StilizujDateTimePicker(
                dtpDatumIVreme);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var racun = DTOManager.VratiRacun(tbBrojRacuna.Text?.Trim());

            if (racun == null)
            {
                MessageBox.Show("Pogrešan broj računa.");
                return;
            }

            var dto = new SigurnosnaKontrolaBasic
            {
                IpAdresa = tbIpAdresa.Text,
                DatumIVreme = dtpDatumIVreme.Value,
                TipDogadjaja = cbTipDogadjaja.Text,
                StatusDogadjaja = cbStatusDogadjaja.Text,
                PodaciUredjaja = rtbPodaciUredjaja.Text,
                Opis = rtbOpis.Text
            };

            DTOManager.DodajSigurnosnuKontrolu(dto, racun.Id);
            MessageBox.Show(
                        "Sigurnosna kontrola uspešno dodata!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DodajSigurnosnuKontrolu_Load(object sender, EventArgs e)
        {
            foreach (TipDogadjaja tip in Enum.GetValues(typeof(TipDogadjaja)))
            {
                cbTipDogadjaja.Items.Add(tip.GetDescription());
            }
            cbTipDogadjaja.SelectedIndex = 0;

            foreach (StatusDogadjaja status in Enum.GetValues(typeof(StatusDogadjaja)))
            {
                cbStatusDogadjaja.Items.Add(status.GetDescription());
            }
            cbStatusDogadjaja.SelectedIndex = 0;
        }
    }
}

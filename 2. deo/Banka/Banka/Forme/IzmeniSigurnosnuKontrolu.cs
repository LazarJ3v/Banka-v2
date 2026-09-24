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
    public partial class IzmeniSigurnosnuKontrolu : BaseForm
    {
        private SigurnosnaKontrolaBasic sigurnosnaKontrola;
        public IzmeniSigurnosnuKontrolu(SigurnosnaKontrolaBasic sigurnosnaKontrola) : base()
        {
            InitializeComponent();
            StilizujLabel(
                lblDatumIVreme,
                lblIpAdresa,
                lblOpis,
                lblPodaciUredjaja,
                lblStatusDogadjaja,
                lblTipDogadjaja);
            StilizujTextBox(
                tbIpAdresa);
            StilizujRichTextBox(
                rtbOpis,
                rtbPodaciUredjaja);
            StilizujComboBox(
                cbStatusDogadjaja,
                cbTipDogadjaja);
            StilizujButton(
                btnSacuvaj);

            this.sigurnosnaKontrola = sigurnosnaKontrola;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var dto = new SigurnosnaKontrolaBasic
            {
                Id = sigurnosnaKontrola.Id,
                IpAdresa = tbIpAdresa.Text,
                DatumIVreme = dtpDatumIVreme.Value,
                TipDogadjaja = cbTipDogadjaja.Text,
                StatusDogadjaja = cbStatusDogadjaja.Text,
                PodaciUredjaja = rtbPodaciUredjaja.Text,
                Opis = rtbOpis.Text
            };

            try
            {
                DTOManager.IzmeniSigurnosnuKontrolu(dto);
                MessageBox.Show(
                            "Sigurnosna kontrola uspešno izmenjena!",
                            "Uspeh",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzmeniSigurnosnuKontrolu_Load(object sender, EventArgs e)
        {
            foreach (TipDogadjaja tip in Enum.GetValues(typeof(TipDogadjaja)))
            {
                cbTipDogadjaja.Items.Add(tip.GetDescription());
            }
            cbTipDogadjaja.SelectedIndex =
                cbTipDogadjaja.Items.IndexOf(sigurnosnaKontrola.TipDogadjaja);

            foreach (StatusDogadjaja status in Enum.GetValues(typeof(StatusDogadjaja)))
            {
                cbStatusDogadjaja.Items.Add(status.GetDescription());
            }
            cbStatusDogadjaja.SelectedIndex = 
                cbStatusDogadjaja.Items.IndexOf(sigurnosnaKontrola.StatusDogadjaja);

            tbIpAdresa.Text = sigurnosnaKontrola.IpAdresa;
            dtpDatumIVreme.Value = sigurnosnaKontrola.DatumIVreme;
            rtbPodaciUredjaja.Text = sigurnosnaKontrola.PodaciUredjaja;
            rtbOpis.Text = sigurnosnaKontrola.Opis;
        }
    }
}

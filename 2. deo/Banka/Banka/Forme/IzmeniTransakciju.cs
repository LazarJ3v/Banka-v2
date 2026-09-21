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
    public partial class IzmeniTransakciju : BaseForm
    {
        private TransakcijaBasic transakcija;
        public IzmeniTransakciju(TransakcijaBasic transakcija) : base()
        {
            InitializeComponent();

            StilizujLabel(
                lblTip,
                lblStatus,
                lblPodaciPrimaoca,
                lblReferenca,
                lblValuta,
                lblIznos,
                lblOpis,
                lblKomentar);

            StilizujComboBox(cbTip, cbStatus, cbValuta);
            StilizujTextBox(tbReferenca, tbOpis);
            StilizujRichTextBox(rtbPodaciPrimaoca, rtbKomentar);
            StilizujButton(btnSacuvaj);
            StilizujNumericUpDown(nudIznos);

            this.transakcija = transakcija;
        }

        private void IzmeniTransakciju_Load(object sender, EventArgs e)
        {
            foreach (TipTransakcije tip in Enum.GetValues(typeof(TipTransakcije)))
            {
                cbTip.Items.Add(tip.GetDescription());
            }
            cbTip.SelectedIndex = cbTip.Items.IndexOf(transakcija.TipTransakcije);

            foreach (StatusTransakcije status in Enum.GetValues(typeof(StatusTransakcije)))
            {
                cbStatus.Items.Add(status.GetDescription());
            }
            cbStatus.SelectedIndex = cbStatus.Items.IndexOf(transakcija.StatusTransakcije);

            foreach (RacunValuta valuta in Enum.GetValues(typeof(RacunValuta)))
            {
                cbValuta.Items.Add(valuta.GetDescription());
            }
            cbValuta.SelectedIndex = cbValuta.Items.IndexOf(transakcija.Valuta);

            rtbPodaciPrimaoca.Text = transakcija.PodaciPrimaoca;
            tbReferenca.Text = transakcija.Referenca;
            nudIznos.Value = transakcija.Iznos;
            tbOpis.Text = transakcija.Opis;
            rtbKomentar.Text = transakcija.Komentar;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var dto = new TransakcijaBasic
            {
                Id = transakcija.Id,
                DatumIVreme = DateTime.Now,
                TipTransakcije = cbTip.Text,
                StatusTransakcije = cbStatus.Text,
                PodaciPrimaoca = rtbPodaciPrimaoca.Text,
                Referenca = tbReferenca.Text,
                Valuta = cbValuta.Text,
                Iznos = nudIznos.Value,
                Opis = tbOpis.Text,
                Komentar = rtbKomentar.Text
            };

            DTOManager.IzmeniTransakciju(dto);
            MessageBox.Show(
                        "Transakcija uspešno izmenjena!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

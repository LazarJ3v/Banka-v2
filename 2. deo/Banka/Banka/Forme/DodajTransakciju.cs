using Banka.Enumi;
using NHibernate.Loader.Entity;
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
    public partial class DodajTransakciju : BaseForm
    {
        public DodajTransakciju() : base()
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
                lblKomentar,
                lblBrRacuna);

            StilizujComboBox(cbTip, cbStatus, cbValuta);
            StilizujTextBox(tbReferenca, tbOpis, tbBrRacuna);
            StilizujRichTextBox(rtbPodaciPrimaoca, rtbKomentar);
            StilizujButton(btnSacuvaj);
            StilizujNumericUpDown(nudIznos);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var dto = new TransakcijaBasic
            {
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
            try
            {
                DTOManager.DodajTransakciju(dto, tbBrRacuna.Text?.Trim());
                MessageBox.Show(
                        "Transakcija uspešno dodata!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodajTransakciju_Load(object sender, EventArgs e)
        {
            foreach (TipTransakcije tip in Enum.GetValues(typeof(TipTransakcije)))
            {
                cbTip.Items.Add(tip.GetDescription());
            }
            cbTip.SelectedIndex = 0;

            foreach (StatusTransakcije status in Enum.GetValues(typeof(StatusTransakcije)))
            {
                cbStatus.Items.Add(status.GetDescription());
            }
            cbStatus.SelectedIndex = 0;

            foreach (RacunValuta valuta in Enum.GetValues(typeof(RacunValuta)))
            {
                cbValuta.Items.Add(valuta.GetDescription());
            }
            cbValuta.SelectedIndex = 0;
        }
    }
}

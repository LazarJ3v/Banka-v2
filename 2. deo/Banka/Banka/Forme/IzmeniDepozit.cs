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
    public partial class IzmeniDepozit : BaseForm
    {
        private DepozitBasic depozit;
        public IzmeniDepozit(DepozitBasic depozit) : base()
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
                lblKomentar);

            StilizujDateTimePicker(dtpDatumPocetka, dtpDatumIsteka);
            StilizujNumericUpDown(nudPeriodOrocenja, nudIznos, nudKamatnaStopa);
            StilizujComboBox(cbStatusDepozita, cbValuta);
            StilizujRichTextBox(rtbKomentar);
            StilizujButton(btnSacuvaj);

            this.depozit = depozit;
        }

        private void IzmeniDepozit_Load(object sender, EventArgs e)
        {
            foreach (StatusDepozita status in Enum.GetValues(typeof(StatusDepozita)))
            {
                cbStatusDepozita.Items.Add(status.GetDescription());
            }
            cbStatusDepozita.SelectedIndex = cbStatusDepozita.Items.IndexOf(depozit.StatusDepozita);

            foreach (RacunValuta valuta in Enum.GetValues(typeof(RacunValuta)))
            {
                cbValuta.Items.Add(valuta.GetDescription());
            }
            cbValuta.SelectedIndex = cbValuta.Items.IndexOf(depozit.Valuta);

            dtpDatumPocetka.Value = depozit.DatumPocetka;
            dtpDatumIsteka.Value = depozit.DatumIsteka;
            nudPeriodOrocenja.Value = depozit.PeriodOrocenja;
            nudIznos.Value = depozit.Iznos;
            nudKamatnaStopa.Value = depozit.KamatnaStopa;
            rtbKomentar.Text = depozit.Komentar;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var dto = new DepozitBasic
            {
                Id = depozit.Id,
                DatumPocetka = dtpDatumPocetka.Value,
                DatumIsteka = dtpDatumIsteka.Value,
                PeriodOrocenja = (int)nudPeriodOrocenja.Value,
                StatusDepozita = cbStatusDepozita.Text,
                Valuta = cbValuta.Text,
                Iznos = nudIznos.Value,
                KamatnaStopa = nudKamatnaStopa.Value,
                Komentar = rtbKomentar.Text
            };

            DTOManager.IzmeniDepozit(dto);
            MessageBox.Show(
                        "Depozit uspešno izmenjen!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

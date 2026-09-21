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
    public partial class IzmeniKredit : BaseForm
    {
        private KreditBasic kredit;
        public IzmeniKredit(KreditBasic kredit) : base()
        {
            InitializeComponent();

            StilizujDateTimePicker(dtpDatumDospeca, dtpDatumOdobrenja);
            StilizujNumericUpDown(nudIznos, nudMesecnaRata, nudRokOtplate, nudKamatnaStopa);
            StilizujComboBox(cbValuta, cbStatus);
            StilizujTextBox(tbNamena);
            StilizujRichTextBox(rtbKomentar);
            StilizujButton(btnSacuvaj);

            this.kredit = kredit;
        }

        private void IzmeniKredit_Load(object sender, EventArgs e)
        {
            foreach (RacunValuta valuta in Enum.GetValues(typeof(RacunValuta)))
            {
                cbValuta.Items.Add(valuta.GetDescription());
            }
            cbValuta.SelectedIndex = cbValuta.Items.IndexOf(kredit.Valuta);

            foreach (StatusKredita status in Enum.GetValues(typeof(StatusKredita)))
            {
                cbStatus.Items.Add(status.GetDescription());
            }
            cbStatus.SelectedIndex = cbStatus.Items.IndexOf(kredit.StatusKredita);

            dtpDatumDospeca.Value = kredit.DatumDospeca;
            dtpDatumOdobrenja.Value = kredit.DatumOdobrenja;
            nudIznos.Value = kredit.Iznos;
            nudMesecnaRata.Value = kredit.MesecnaRata;
            nudRokOtplate.Value = kredit.RokOtplate;
            tbNamena.Text = kredit.Namena;
            nudKamatnaStopa.Value = kredit.KamatnaStopa;
            rtbKomentar.Text = kredit.Komentar;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var dto = new KreditBasic
            {
                Id = kredit.Id,
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

            DTOManager.IzmeniKredit(dto);
            MessageBox.Show(
                        "Kredit uspešno izmenjen!",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

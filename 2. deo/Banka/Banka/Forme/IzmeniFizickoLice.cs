using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banka.Forme;

namespace Banka.Forme
{
    public partial class IzmeniFizickoLice : BaseForm
    {
        public IzmeniFizickoLice() : base()
        {
            InitializeComponent();
            StilizujButton(
                btnIzmeni);
            StilizujLabel(
                lblAdresa,
                lblBrojLicneKarte,
                lblDatumRodjenja,
                lblEmail,
                lblGrad,
                lblIme,
                lblJmbg,
                lblKomentar,
                lblPrezime,
                lblStatus,
                lblTelefon);
            StilizujTextBox(
                tbAdresa,
                tbBrojLicneKarte,
                tbEmail,
                tbGrad,
                tbIme,
                tbJmbg,
                tbPrezime,
                tbTelefon
                );
            StilizujDateTimePicker(
                dtpDatumRodjenja);
            StilizujRichTextBox(
                rtbKomentar);
        }
    }
}

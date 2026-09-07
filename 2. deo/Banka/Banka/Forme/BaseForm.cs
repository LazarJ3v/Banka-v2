using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Prodavnica.Forme
{
    public class BaseForm : Form
    {
        // ==========================================
        // PALETA BOJA
        // ==========================================
        protected static readonly Color BojaNajtamnija = Color.FromArgb(28, 28, 28);        // pozadina forme
        protected static readonly Color BojaTamna = Color.FromArgb(41, 41, 41);             // pozadina panela/groupbox
        protected static readonly Color BojaSrednja = Color.FromArgb(51, 51, 51);           // pozadina input kontrola
        protected static readonly Color BojaSvetlija = Color.FromArgb(61, 61, 61);          // border / dgv pozadina
        protected static readonly Color BojaNajsvetlija = Color.FromArgb(71, 71, 71);       // hover / dgv border / akcenti
        protected static readonly Color BojaGridCellSelect = Color.FromArgb(255, 149, 81);  // select

        protected static readonly Color TekstBoja = Color.FromArgb(230, 230, 230);
        protected static readonly Color TekstBojaSekundarna = Color.FromArgb(160, 160, 160);

        // ==========================================
        // KONSTRUKTOR
        // ==========================================
        public BaseForm()
        {
            this.BackColor = BojaNajtamnija;
            this.ForeColor = TekstBoja;
            this.Font = new Font("Segoe UI", 9);
        }

        // ==========================================
        // DATA GRID VIEW
        // ==========================================
        protected void StilizujDataGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;

            dgv.BackgroundColor = BojaSvetlija;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = BojaNajsvetlija;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.EnableHeadersVisualStyles = false;

            // Column header - ista boja kao ostatak grida
            dgv.ColumnHeadersDefaultCellStyle.BackColor = BojaSvetlija;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TekstBoja;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = BojaSvetlija;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = TekstBoja;
            dgv.ColumnHeadersHeight = 32;

            // Row header - ista boja kao ostatak grida
            dgv.RowHeadersDefaultCellStyle.BackColor = BojaSvetlija;
            dgv.RowHeadersDefaultCellStyle.ForeColor = TekstBoja;
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = BojaGridCellSelect;
            dgv.RowHeadersDefaultCellStyle.SelectionForeColor = TekstBoja;
            dgv.RowHeadersVisible = false;

            // Ćelije
            dgv.DefaultCellStyle.BackColor = BojaSvetlija;
            dgv.DefaultCellStyle.ForeColor = TekstBoja;
            dgv.DefaultCellStyle.SelectionBackColor = BojaGridCellSelect;
            dgv.DefaultCellStyle.SelectionForeColor = TekstBoja;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = BojaSvetlija;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = TekstBoja;

            dgv.RowTemplate.Height = 28;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        // ==========================================
        // DUGME (moderan Flat izgled)
        // ==========================================
        protected void StilizujButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = BojaNajsvetlija;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.MouseOverBackColor = BojaNajsvetlija;
            btn.FlatAppearance.MouseDownBackColor = BojaSvetlija;

            btn.BackColor = BojaSrednja;
            btn.ForeColor = TekstBoja;
            btn.Font = new Font("Segoe UI", 9);
            btn.Cursor = Cursors.Hand;
            btn.Height = Math.Max(btn.Height, 32);
        }

        // ==========================================
        // GROUP BOX
        // ==========================================
        protected void StilizujGroupBox(GroupBox box)
        {
            box.BackColor = BojaTamna;
            box.ForeColor = TekstBoja;
            box.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            box.Paint -= GroupBox_Paint;
            box.Paint += GroupBox_Paint;
        }

        private void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            e.Graphics.Clear(box.BackColor);

            SizeF textSize = e.Graphics.MeasureString(box.Text, box.Font);
            Rectangle rect = new Rectangle(0, (int)(textSize.Height / 2), box.Width - 1, box.Height - (int)(textSize.Height / 2) - 1);

            using (Pen pen = new Pen(BojaNajsvetlija))
            {
                e.Graphics.DrawLine(pen, rect.X, rect.Y, rect.X + 8, rect.Y);
                e.Graphics.DrawLine(pen, rect.X + 8 + textSize.Width, rect.Y, rect.Right, rect.Y);
                e.Graphics.DrawLine(pen, rect.X, rect.Y, rect.X, rect.Bottom);
                e.Graphics.DrawLine(pen, rect.X, rect.Bottom, rect.Right, rect.Bottom);
                e.Graphics.DrawLine(pen, rect.Right, rect.Y, rect.Right, rect.Bottom);
            }

            using (SolidBrush textBrush = new SolidBrush(box.ForeColor))
            {
                e.Graphics.DrawString(box.Text, box.Font, textBrush, 8, 0);
            }
        }

        // ==========================================
        // LABELA
        // ==========================================

        protected void StilizujLabel(Label lbl)
        {
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = TekstBoja;
            lbl.Font = new Font("Segoe UI", 9);
        }

        protected void StilizujLabelSection(Label lbl)
        {
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = TekstBojaSekundarna;
            lbl.Font = new Font("Segoe UI", 10);
        }

        protected void StilizujLabelHeader(Label lbl)
        {
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Segoe UI", 11);
        }

        // ==========================================
        // TEXT BOX (border preko panela)
        // ==========================================
        protected void StilizujTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = BojaSrednja;
            txt.ForeColor = TekstBoja;
            txt.Font = new Font("Segoe UI", 9);
        }

        // ==========================================
        // COMBO BOX
        // ==========================================
        protected void StilizujComboBox(ComboBox cmb)
        {
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.BackColor = BojaSrednja;
            cmb.ForeColor = TekstBoja;
            cmb.Font = new Font("Segoe UI", 9);
            cmb.DrawMode = DrawMode.OwnerDrawFixed;

            cmb.DrawItem -= ComboBox_DrawItem;
            cmb.DrawItem += ComboBox_DrawItem;
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (e.Index < 0) return;

            e.DrawBackground();

            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color pozadina = selected ? BojaNajsvetlija : BojaSrednja;

            using (SolidBrush backBrush = new SolidBrush(pozadina))
                e.Graphics.FillRectangle(backBrush, e.Bounds);

            using (SolidBrush textBrush = new SolidBrush(TekstBoja))
                e.Graphics.DrawString(cmb.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds);

            e.DrawFocusRectangle();
        }

        // ==========================================
        // PANEL
        // ==========================================
        protected void StilizujPanel(Panel panel)
        {
            panel.BackColor = BojaTamna;
        }

        // ==========================================
        // CHECKBOX / RADIOBUTTON
        // ==========================================
        protected void StilizujCheckBox(CheckBox chk)
        {
            chk.BackColor = Color.Transparent;
            chk.ForeColor = TekstBoja;
            chk.Font = new Font("Segoe UI", 9);
        }

        protected void StilizujRadioButton(RadioButton rdb)
        {
            rdb.BackColor = Color.Transparent;
            rdb.ForeColor = TekstBoja;
            rdb.Font = new Font("Segoe UI", 9);
        }

        // ==========================================
        // DATE TIME PICKER
        // ==========================================
        protected void StilizujDateTimePicker(DateTimePicker dtp)
        {
            dtp.Font = new Font("Segoe UI", 9);
            dtp.CalendarFont = new Font("Segoe UI", 9);
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd-MM-yyyy";

            // Boje same kontrole (WinForms ograničeno podržava custom BackColor/ForeColor
            // na DateTimePicker-u dok je Format = Long/Short, ali postavljamo radi konzistentnosti)
            dtp.CalendarForeColor = TekstBoja;
            dtp.CalendarMonthBackground = BojaSrednja;
            dtp.CalendarTitleBackColor = BojaTamna;
            dtp.CalendarTitleForeColor = TekstBoja;
            dtp.CalendarTrailingForeColor = TekstBojaSekundarna;
        }

        // ==========================================
        // RICH TEXT BOX
        // ==========================================
        protected void StilizujRichTextBox(RichTextBox rtb)
        {
            rtb.BorderStyle = BorderStyle.FixedSingle;
            rtb.BackColor = BojaSrednja;
            rtb.ForeColor = TekstBoja;
            rtb.Font = new Font("Segoe UI", 9);

            // Da boja selekcije teksta prati temu
            rtb.SelectionColor = TekstBoja;
        }

        protected void StilizujButton(params Button[] prms)
        {
            foreach (Button btn in prms)
            {
                StilizujButton(btn);
            }
        }

        protected void StilizujDataGridView(params DataGridView[] prms)
        {
            foreach (DataGridView dgv in prms)
            {
                StilizujDataGridView(dgv);
            }
        }

        protected void StilizujGroupBox(params GroupBox[] prms)
        {
            foreach (GroupBox gb in prms)
            {
                StilizujGroupBox(gb);
            }
        }

        protected void StilizujLabel(params Label[] prms)
        {
            foreach (Label lbl in prms)
            {
                StilizujLabel(lbl);
            }
        }

        protected void StilizujLabelHeader(params Label[] prms)
        {
            foreach (Label lbl in prms)
            {
                StilizujLabelHeader(lbl);
            }
        }

        protected void StilizujLabelSection(params Label[] prms)
        {
            foreach (Label lbl in prms)
            {
                StilizujLabelSection(lbl);
            }
        }

        protected void StilizujComboBox(params ComboBox[] prms)
        {
            foreach (ComboBox cb in prms)
            {
                StilizujComboBox(cb);
            }
        }

        protected void StilizujTextBox(params TextBox[] prms)
        {
            foreach (TextBox tb in prms)
            {
                StilizujTextBox(tb);
            }
        }

        protected void StilizujPanel(params Panel[] prms)
        {
            foreach (Panel p in prms)
            {
                StilizujPanel(p);
            }
        }

        protected void StilizujCheckBox(params CheckBox[] prms)
        {
            foreach (CheckBox cb in prms)
            {
                StilizujCheckBox(cb);
            }
        }

        protected void StilizujRadioButton(params RadioButton[] prms)
        {
            foreach (RadioButton rb in prms)
            {
                StilizujRadioButton(rb);
            }
        }

        protected void StilizujDateTimePicker(params DateTimePicker[] prms)
        {
            foreach (DateTimePicker dtp in prms)
            {
                StilizujDateTimePicker(dtp);
            }
        }

        protected void StilizujRichTextBox(params RichTextBox[] prms)
        {
            foreach (RichTextBox rtb in prms)
            {
                StilizujRichTextBox(rtb);
            }
        }
    }

}
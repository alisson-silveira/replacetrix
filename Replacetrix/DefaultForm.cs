using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Replacetrix
{
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
        }

        void PasteFromClipboard()
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                var table = new DataTable();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");

                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        pastedRowCells.ToList().ForEach(x => table.Columns.Add(x));
                        columnsAdded = true;
                        continue;
                    }

                    var rowCells = new List<object>();
                    rowCells.AddRange(pastedRowCells);

                    table.Rows.Add(rowCells.ToArray());
                }

                DgvData.DataSource = table;
            }
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            PasteFromClipboard();
        }

        public void ClearGrid()
        {
            DgvData.Columns.Clear();
        }

        bool _cancel;

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtInput.Text) || string.IsNullOrWhiteSpace(TxtInput.Text))
                return;

            BtnPaste.Enabled = false;
            BtnReplace.Enabled = false;
            BtnCancel.Enabled = true;

            DgvData.EndEdit();
            TxtOutput.Clear();

            var output = new StringBuilder();

            foreach (DataGridViewRow r in DgvData.Rows)
            {
                var inputText = TxtInput.Text;

                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value == null)
                        continue;

                    inputText = inputText.Replace(c.OwningColumn.HeaderText, c.Value.ToString());
                }

                if (inputText != TxtInput.Text)
                    output.Append(inputText + Environment.NewLine);

                if (_cancel)
                {
                    CancelOperation();
                    return;
                }

                Application.DoEvents();
            }

            TxtOutput.Text = output.ToString();

            BtnPaste.Enabled = true;
            BtnCancel.Enabled = false;
            MessageBox.Show("Operation complete");
            BtnReplace.Enabled = true;
        }


        public void CancelOperation()
        {
            BtnPaste.Enabled = true;
            BtnReplace.Enabled = true;
            BtnCancel.Enabled = false;
            _cancel = false;
            MessageBox.Show("Operation cancelled");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _cancel = true;
        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm("Column name:");
            inputForm.ShowDialog();
            DgvData.Columns.Add("col" + DgvData.Columns.Count + 1, inputForm.InputText);
        }

        private void clearGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvData.Columns.Count > 0)
                if (MessageBox.Show("Are you sure?", "Confirm clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    ClearGrid();
        }
    }
}


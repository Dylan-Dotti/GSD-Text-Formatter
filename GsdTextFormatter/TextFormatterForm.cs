using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GsdTextFormatter
{
    public partial class TextFormatterForm : Form
    {
        private readonly TextConverter converter;

        public TextFormatterForm()
        {
            InitializeComponent();
            converter = new TextConverter();
        }

        private void SynqFormatButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = converter.GetSynqFormatted(inputBox.Text,
                separateSpacesCheck.Checked);
        }

        private void CsvFormatButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = converter.GetCsvFormatted(inputBox.Text,
                separateSpacesCheck.Checked, !noCsvSpacesCheck.Checked);
        }

        private void NewlineFormatButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = converter.GetNewlineFormatted(inputBox.Text,
                separateSpacesCheck.Checked);
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {
            clipboardCopyButton.Enabled =
                !resultBox.Text.IsNullOrEmptyOrWhiteSpace();
        }

        private void ClipboardCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultBox.Text);
        }

        private void ClipboardPasteButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = Clipboard.GetText();
        }

        private void SQLINFormatButton_Click_1(object sender, EventArgs e)
        {
            resultBox.Text = converter.GetSQLINFormatted(inputBox.Text,
                separateSpacesCheck.Checked);
        }
    }
}

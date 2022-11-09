using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utility
{
    public partial class Alignment : UserControl
    {
        public Alignment()
        {
            InitializeComponent();
        }

        private void alignandcopy_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = inputTextBox.Text.Replace("\n", "\t").Replace("Cr\t", "Cr\n").Replace("Lakh\t", "Lakh\n");

            Clipboard.SetText(outputTextBox.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
        }
    }
}

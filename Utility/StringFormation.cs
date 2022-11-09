using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utility
{
    public partial class StringFormation : UserControl
    {
        public StringFormation()
        {
            InitializeComponent();
        }

        private void Format_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = inputTextBox.Text.Trim().Replace(":\n", ": ").Replace(": \n", ": ").Replace(":\n\n", ": ").Replace("\n\n", "\n");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
        }
    }
}

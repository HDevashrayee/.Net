using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trimmer
{
    public partial class formTrim : Form
    {
        public formTrim()
        {
            InitializeComponent();
        }

        private void buttonTrim_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Trim().Replace(":\n", ": ").Replace(": \n", ": ").Replace(":\n\n", ": ").Replace("\n\n","\n");
            

            //string[] array=richTextBox1.Text.Split(" ");

            //StringBuilder sb = new StringBuilder();
           
            //foreach (var item in array)
            //{
            //    sb = sb.Append(item);
            //}

            //string text = sb.ToString().Replace("\n","");

            //richTextBox1.Text = sb.ToString();
        }
    }
}

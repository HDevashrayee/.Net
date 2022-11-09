using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utility
{
    public partial class Utilites : Form
    {
        public Utilites()
        {
            InitializeComponent();
            
        }

        private void AddControl(UserControl userControl)
        {
            if (utilitypanel.Controls.Count > 0)
                utilitypanel.Controls.Clear();
            utilitypanel.Controls.Add(userControl);
        }

        private void alignment_Click(object sender, EventArgs e)
        {
            Alignment alignment = new Alignment();
            AddControl(alignment);
        }

        private void holding_Click(object sender, EventArgs e)
        {
            Holding holding = new Holding();
            AddControl(holding);
        }

        private void Cryptography_Click(object sender, EventArgs e)
        {
            Cryptography cryptography = new Cryptography();
            AddControl(cryptography);
        }
    }
}

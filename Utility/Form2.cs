using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Utility
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            string result = "";
            string[] items = richTextBox1.Text.Split("\n");
            decimal TotalAmount = 0;
            List<PorfolioList> list = new List<PorfolioList>();
            foreach (var item in items)
            {                
                PorfolioList porfolioList = new PorfolioList();

                string[] strings = item.Split("\t");

                if (strings[0] != "")
                {
                    porfolioList.Company = strings[0];

                    if (strings[2].Contains("Cr"))
                    {
                        strings[2] = strings[2].Replace("Cr", "").Replace("₹", "");
                        porfolioList.Amount = Convert.ToDecimal(strings[2]) * 10000000;
                    }
                    else if (strings[2].Contains("Lakh"))
                    {
                        strings[2] = strings[2].Replace("Lakh", "").Replace("₹", "");
                        porfolioList.Amount = Convert.ToDecimal(strings[2]) * 10000000 / 100;
                    }

                    TotalAmount = TotalAmount + porfolioList.Amount;

                    if (list.Any(D => D.Company == porfolioList.Company))
                    {
                        PorfolioList porfolioList1 = list.FirstOrDefault(D => D.Company == porfolioList.Company);
                        porfolioList1.Amount = porfolioList1.Amount + porfolioList.Amount;                        
                    }
                    else if (porfolioList != null && porfolioList.Company != "")
                        list.Add(porfolioList);                    
                }
              
            }
            foreach (var newItem in list)
            {
                newItem.Percent = (newItem.Amount / TotalAmount) * 100;

                result = result + newItem.Company + "\t" + newItem.Percent.ToString(".00000") + "%\t" + newItem.Amount / 10000000 + "Cr\n";
            }

            richTextBox2.Text = result;
        }

        public class PorfolioList
        {
            public string Company { get; set; }
            public decimal Percent { get; set; }
            public decimal Amount { get; set; }
        }

    }
}

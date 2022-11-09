using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewWinFormsApp
{

    internal class Program
    {
        private ArrayList customerArray = new ArrayList();
        //The following code example demonstrates the use of the TreeView control.


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        private void FillMyTreeView()
        {
            for (int x = 0; x < 1000; x++)
            {
                customerArray.Add(new Customer("Customer" + x.ToString()));
            }

            foreach (Customer customer in customerArray)
            {
                for (int y = 0; y < 15; y++)
                {
                    customer.CustomerOrders.Add(new Order("Order" + y.ToString()));
                }
            }
            // Display a wait cursor while the TreeNodes are being created.

            Cursor.Current = new Cursor("Wait Cursot");
        }
    }

    public class Customer : Object
    {
        private string customerName = string.Empty;
        protected ArrayList customerOrders = new ArrayList();

        public Customer(string customerName)
        {
            this.customerName = customerName;
        }

        public string CustomerName
        {
            get { return customerName; }
            set { this.customerName = value; }
        }
        
        public ArrayList CustomerOrders
        { get { return customerOrders; } }
    }

    public class Order : Object
    {
        private string orderID = string.Empty;

        public Order(string orderID)
        {
            this.orderID = orderID;
        }

        public String OrderID
        { get { return orderID; } set { this.OrderID = value; } }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
namespace Tree_View
{
    internal class TreeView
    {
        private ArrayList customerArray = new ArrayList();
        //The following code example demonstrates the use of the TreeView control.

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
            
        }

        internal void InitializeTreeView()
        {

        }
    }

    public class Customer : System.Object
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

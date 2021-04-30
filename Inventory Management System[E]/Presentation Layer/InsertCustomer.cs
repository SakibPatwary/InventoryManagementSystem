using Sales_and_Inventory_Management_System.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    public partial class InsertCustomer : Form
    {
        string username;
        public InsertCustomer(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void CustomerAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void incertButton_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            int result = customerService.AddNewCustomer(customerNameTextBox.Text, phoneNoTextBox.Text);
            this.Hide();
            OrderManagement createSale = new OrderManagement(username);
            createSale.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderManagement createSale = new OrderManagement(username);
            createSale.Show();
        }
    }
}

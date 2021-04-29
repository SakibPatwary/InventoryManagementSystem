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
    public partial class HomeForUser : Form
    {
        string username;
        public HomeForUser(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void HomeForUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeForUser_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            EmployeeNameLinkLabel.Text = userService.GetName(username);
        }

        private void EmployeeNameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserManagement userManagement = new UserManagement(username);
            userManagement.Show();
            this.Hide();
        }


        private void logOutButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void orderManagementButton_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement(username);
            orderManagement.Show();
            this.Hide();
        }

        private void customerManagementButton_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement(username);
            customerManagement.Show();
            this.Hide();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement(username);
            categoryManagement.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement(username);
            productManagement.Show();
            this.Hide();
        }

    }
}

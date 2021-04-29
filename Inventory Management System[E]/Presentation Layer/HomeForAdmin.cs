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
    public partial class HomeForAdmin : Form
    {
        string username;
        public HomeForAdmin(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void HomeForAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement(username);
            categoryManagement.Show();
            this.Hide();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement(username);
            productManagement.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement(username);
            employeeManagement.Show();
            this.Hide();
        }

        private void HomeForAdmin_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            AdminNamelinkLabel.Text = userService.GetName(username);
            SaleService saleService = new SaleService();
            orderCount.Text = saleService.TotalSalesCount();
            totalOrderedAmount.Text = saleService.TotalSalesAmount();
            lastOrderedLebel.Text = saleService.LastSalesDate();
        }

        private void AdminNamelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminAccountManagement adminAccountManagement = new AdminAccountManagement(username);
            adminAccountManagement.Show();
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

        private void salesRecordButton_Click(object sender, EventArgs e)
        {
            SalesRecord salesRecord = new SalesRecord(username);
            salesRecord.Show();
            this.Hide();
        }
    }
}

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

    public partial class CustomerManagement : Form
    {
        int orderId = 0;
        int customerId = 0;
        int productId = 0;
        int availableQuantity = 0;
        int removableQuantity = 0;
        string username;
        public CustomerManagement(string username)
        {
            InitializeComponent();
            this.username = username;
            IncertCustomerButton.Click += this.RefreshGridview;
            IncertCustomerButton.Click += this.ClearFields;
            updateCustomerButton.Click += this.RefreshGridview;
            removeCustomerbutton.Click += this.RefreshGridview;
            removeCustomerbutton.Click += this.ClearFields;
            updateCustomerButton.Click += this.RefreshLabels;
            RemoveOrderButton.Click += this.RefreshLabels;
            RemoveOrderButton.Click += this.RefreshGridview;
        }

        private void CustomerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerLoadDataGridView.DataSource = customerService.GetListOfCustomer();
        }
        void RefreshGridview(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerLoadDataGridView.DataSource = customerService.GetListOfCustomer();
            SaleService saleService = new SaleService();
            ordersLoadGridView.DataSource = saleService.GetCustomerOrdersListById(customerId);
        }
        void RefreshLabels(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            totalOrderedAmount.Text = saleService.TotalOrderedAmount(customerId);
            lastOrderedLebel.Text = saleService.LastOrderedDate(customerId);
            orderCount.Text = saleService.OrderCount(customerId);
            customerNameLabel.Text = customerNameTextBox.Text;
        }
        void ClearFields(object sender, EventArgs e)
        {
            customerNameTextBox.Text = phoneNoTextBox.Text = customerNameLabel.Text = totalOrderedAmount.Text = lastOrderedLebel.Text = orderCount.Text = string.Empty;
        }

        private void customerSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerLoadDataGridView.DataSource = customerService.GetCustomerListForSearch(customerSearchTextBox.Text);
        }

        private void CustomerLoadDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerNameTextBox.Text = customerLoadDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            customerNameLabel.Text = customerLoadDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            customerId = (int)customerLoadDataGridView.Rows[e.RowIndex].Cells[0].Value;
            phoneNoTextBox.Text = customerLoadDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            SaleService saleService = new SaleService();
            ordersLoadGridView.DataSource = saleService.GetCustomerOrdersListById(customerId);
            totalOrderedAmount.Text = saleService.TotalOrderedAmount(customerId);
            lastOrderedLebel.Text = saleService.LastOrderedDate(customerId);
            orderCount.Text = saleService.OrderCount(customerId);
        }

        private void IncertCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            int result = customerService.AddNewCustomer(customerNameTextBox.Text, phoneNoTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Customer Inserted Successfully", "Insert Customer");
            }
            else
            {
                MessageBox.Show("Problem in Inserting", "Insert Customer");
            }
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            int result = customerService.UpdateCustomer(customerNameTextBox.Text, phoneNoTextBox.Text, customerId);
            if (result > 0)
            {
                MessageBox.Show("Customer Updated successfully", "Update Customer");
            }
            else
            {
                MessageBox.Show("Problem in Updating", "Update Customer");
            }
            SaleService saleService = new SaleService();
            saleService.UpdateCustomerName(customerNameTextBox.Text, customerId);
        }

        private void removeCustomerbutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(orderCount.Text) != 0)
            {
                MessageBox.Show("Remove Customer's Orders First!", "Error in removing");
            }
            else
            {
                CustomerService customerService = new CustomerService();
                int result = customerService.RemoveCustomer(customerId);
                if (result > 0)
                {
                    MessageBox.Show("Customer Removed successfully", "Remove Customer");
                }
                else
                {
                    MessageBox.Show("Problem in Removing", "Remove Customer");
                }
            }
        }

        private void ordersLoadGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveTextBox.Text = ordersLoadGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            orderId = (int)ordersLoadGridView.Rows[e.RowIndex].Cells[0].Value;
            productId = (int)ordersLoadGridView.Rows[e.RowIndex].Cells[4].Value;
            removableQuantity = (int)ordersLoadGridView.Rows[e.RowIndex].Cells[6].Value;
            ProductService productService = new ProductService();
            availableQuantity = productService.GetProductQuantity((int)ordersLoadGridView.Rows[e.RowIndex].Cells[4].Value);
        }

        private void RemoveOrderButton_Click(object sender, EventArgs e)
        {
            {
                SaleService saleService = new SaleService();
                int result = saleService.RemoveOrder(orderId, productId, availableQuantity, removableQuantity);
                if (result > 0)
                {
                    MessageBox.Show("Order removed successfully", "Remove order");
                    RemoveTextBox.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Problem in Removing", "Remove order");
                }
            }
        }

        private void OrdersByDateButton_Click(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            ordersLoadGridView.DataSource = saleService.GetAllSalesListByDateAndId(fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"),customerId);
            totalOrderedAmount.Text = saleService.TotalOrderedAmountByDate(customerId, fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
            lastOrderedLebel.Text = saleService.LastOrderedDateByDate(customerId, fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
            orderCount.Text = saleService.OrderCountByDate(customerId, fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
        }

        private void tillDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fromDateTimePicker.Text);
            DateTime tillDate = Convert.ToDateTime(tillDateTimePicker.Text);
            if (fromDate <= tillDate)
            {
                TimeSpan ts = tillDate.Subtract(fromDate);
                string days = Convert.ToString(ts.Days);
                totalDaysLabel.Text = days;
            }
            else
            {
                MessageBox.Show("Till Date Should be greater than From Date", "Date");
                tillDateTimePicker.Text = Convert.ToString(fromDate);
                totalDaysLabel.Text = string.Empty;
            }
        }

        private void fromDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fromDateTimePicker.Text);
            DateTime tillDate = Convert.ToDateTime(tillDateTimePicker.Text);
            if (fromDate <= tillDate)
            {
                TimeSpan ts = tillDate.Subtract(fromDate);
                string days = Convert.ToString(ts.Days);
                totalDaysLabel.Text = days;
            }
            else
            {
                MessageBox.Show("From Date Should be Lesser than Till Date", "Date");
                fromDateTimePicker.Text = Convert.ToString(tillDate);
                totalDaysLabel.Text = string.Empty;
            }
        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (userService.GetUserType(username) == "Admin")
            {
                HomeForAdmin homeForAdmin = new HomeForAdmin(username);
                homeForAdmin.Show();
                this.Hide();
            }
            else
            {
                HomeForUser homeForUser = new HomeForUser(username);
                homeForUser.Show();
                this.Hide();
            }
        }
    }
}

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
    public partial class OrderManagement : Form
    {
        int orderId=0;
        int customerId=0;
        int productId=0;
        double unitPrice=0;
        int availableQuantity=0;
        //int removableQuantity = 0;
        int orderedQuantity = 0;
        string username;
        public OrderManagement(string username)
        {
            InitializeComponent();
            this.username = username;
            placeOrderButton.Click += this.RefreshGridview;
            placeOrderButton.Click += this.ClearFields;
            removeProductbutton.Click += this.RefreshGridview;
            removeProductbutton.Click += this.ClearFields;
            placeOrderButton.Click += this.RefreshLabels;
            removeProductbutton.Click += this.RefreshLabels;
        }

        private void CreateSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CustomersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerNameTextBox.Text = customersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            customerId = (int)customersDataGridView.Rows[e.RowIndex].Cells[0].Value;
            SaleService saleService = new SaleService();
            salesDataGridView.DataSource = saleService.GetAllSalesListByCustomerId(customerId);
            totalOrderedAmount.Text = saleService.TotalOrderedAmount(customerId);
            lastOrderedLebel.Text = saleService.LastOrderedDate(customerId);
            orderCount.Text = saleService.OrderCount(customerId);
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productNameTextBox.Text = productsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            productId = (int)productsDataGridView.Rows[e.RowIndex].Cells[0].Value;
            unitPrice = Convert.ToDouble(productsDataGridView.Rows[e.RowIndex].Cells[2].Value);
            availableQuantity = (int)productsDataGridView.Rows[e.RowIndex].Cells[3].Value;
        }
        private void CreateSale_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            categoryComboBox.DataSource = categoryService.GetCategoryNameList();
            CustomerService customerService = new CustomerService();
            customersDataGridView.DataSource = customerService.GetListOfCustomer();
            ProductService productService = new ProductService();
            productsDataGridView.DataSource = productService.GetProductList();
            categoryComboBox.Text = string.Empty;
        }
        void RefreshGridview(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            productsDataGridView.DataSource = productService.GetProductList();
            CustomerService customerService = new CustomerService();
            customersDataGridView.DataSource = customerService.GetListOfCustomer();
            SaleService saleService = new SaleService();
            salesDataGridView.DataSource = saleService.GetAllSalesListByCustomerId(customerId);
        }
        void RefreshLabels(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            totalOrderedAmount.Text = saleService.TotalOrderedAmount(customerId);
            lastOrderedLebel.Text = saleService.LastOrderedDate(customerId);
            orderCount.Text = saleService.OrderCount(customerId);
        }
        void ClearFields(object sender, EventArgs e)
        {
            productNameTextBox.Text = quantityTextBox.Text = RemoveTextBox.Text = categoryComboBox.Text = string.Empty;

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            
            SaleService saleService = new SaleService();
            if (quantityTextBox.Text == "")
            {
                MessageBox.Show("Plaese Mention A Quantity", "Quantity");
            }
            
            int result = saleService.CreateSale(customerNameTextBox.Text, customerId, productNameTextBox.Text, productId,saleDateTimePicker.Value.ToString("MM/dd/yyyy"), Convert.ToInt32(quantityTextBox.Text) ,unitPrice, availableQuantity);
            if(result>0)
            {
                MessageBox.Show("Order created successfully","Order");
            }
            else
            {
                MessageBox.Show("Insufficient Stock", "Order");
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            productsDataGridView.DataSource = categoryService.GetProductListByCategory(categoryComboBox.Text);
        }

        private void salesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveTextBox.Text = salesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            orderId = (int)salesDataGridView.Rows[e.RowIndex].Cells[0].Value;
            productId = (int)salesDataGridView.Rows[e.RowIndex].Cells[2].Value;
            orderedQuantity = (int)salesDataGridView.Rows[e.RowIndex].Cells[4].Value;
            ProductService productService = new ProductService();
            availableQuantity = productService.GetProductQuantity((int)salesDataGridView.Rows[e.RowIndex].Cells[2].Value);
        }

        private void removeProductbutton_Click(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            int result = saleService.RemoveOrder(orderId,productId,availableQuantity, orderedQuantity);
            if (result > 0)
            {
                MessageBox.Show("Order removed successfully","Remove order");
            }
            else
            {
                MessageBox.Show("Problem in Removing", "Remove order");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            productsDataGridView.DataSource = productService.GetProductListForSearch(searchTextBox.Text);
        }

        private void addNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncertCustomer customerAdd = new IncertCustomer(username);
            customerAdd.Show();

        }
        private void customerSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customersDataGridView.DataSource = customerService.GetCustomerListForSearch(customerSearchTextBox.Text);
        }

        private void OrdersByDateButton_Click(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            salesDataGridView.DataSource = saleService.GetCustomerOrderByDateAndId(fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"), customerId);
            totalOrderedAmount.Text = saleService.TotalOrderedAmountByDate(customerId, fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
            lastOrderedLebel.Text = saleService.LastOrderedDateByDate(customerId, fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
            orderCount.Text = saleService.OrderCountByDate(customerId, fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
        }

        private void saleDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTime saleDate = Convert.ToDateTime(saleDateTimePicker.Text);
            DateTime today = DateTime.Today;
            if (saleDate > today)
            {
                MessageBox.Show("Sale Date Cant be greater than Today's Date", "Date");
                saleDateTimePicker.Text = Convert.ToString(today);
            }
        }

        private void tillDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fromDateTimePicker.Text);
            DateTime tillDate = Convert.ToDateTime(tillDateTimePicker.Text);
            if(fromDate <= tillDate)
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

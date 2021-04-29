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
    public partial class SalesRecord : Form
    {
        string username;
        public SalesRecord(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void SalesRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SalesRecord_Load(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            loadSalesGridView.DataSource = saleService.GetAllSalesList();
            orderCount.Text = saleService.TotalSalesCount();
            totalOrderedAmount.Text = saleService.TotalSalesAmount();
            lastOrderedLebel.Text = saleService.LastSalesDate();
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

        private void salesByDateButton_Click(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            loadSalesGridView.DataSource = saleService.GetAllSalesListByDate(fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
            totalOrderedAmount.Text = saleService.TotalSalesByDate(fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
            lastOrderedLebel.Text = saleService.LastSalesDateBydate(fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
            orderCount.Text = saleService.SalesCountBydate(fromDateTimePicker.Value.ToString("MM/dd/yyyy"), tillDateTimePicker.Value.ToString("MM/dd/yyyy"));
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();
            loadSalesGridView.DataSource = saleService.GetAllSalesList();
            orderCount.Text = saleService.TotalSalesCount();
            totalOrderedAmount.Text = saleService.TotalSalesAmount();
            lastOrderedLebel.Text = saleService.LastSalesDate();
        }

        private void HomeButton_Click(object sender, EventArgs e)
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

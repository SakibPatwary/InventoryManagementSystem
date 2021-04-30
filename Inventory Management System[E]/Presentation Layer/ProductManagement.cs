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
    public partial class ProductManagement : Form
    {
        int id = 0;
        int pid = 0;
        string username;
        int cid;
        int value = 0;
        int min = 10;
        public ProductManagement(string username)
        {
            this.username = username;
            InitializeComponent();
            addProductButton.Click += this.RefreshGridView;
            addProductButton.Click += this.ClearFields;
            UpdateProductButton.Click += this.RefreshGridView;
            UpdateProductButton.Click += this.ClearFields;
            DeleteProductButton.Click += this.RefreshGridView;
            DeleteProductButton.Click += this.ClearFields;
            addProductQuantityButton.Click += this.RefreshGridView;
            addProductQuantityButton.Click += this.ClearFields;
        }

        private void ProductManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            loadProductListGridView.DataSource = productService.GetProductList();
            CategoryService categoryService = new CategoryService();
            productCategoryComboBox.DataSource = categoryService.GetCategoryNameList();
            productService = new ProductService();                                                                         //
            loadInsufficientQuantityProductsListGridView.DataSource = productService.GetProductsForQuantity(min);          //
        }
        void RefreshGridView(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            loadProductListGridView.DataSource = productService.GetProductList();
            CategoryService categoryService = new CategoryService();
            productCategoryComboBox.DataSource = categoryService.GetCategoryNameList();
            productService = new ProductService();                                                                         //
            loadInsufficientQuantityProductsListGridView.DataSource = productService.GetProductsForQuantity(min);          //
        }

        void ClearFields(object sender, EventArgs e)
        {
            productNameTextBox.Text= productPriceTextBox.Text = productQuantityTextBox.Text = productCategoryComboBox.Text = searchProductNameTextBox.Text=addQuantityProductNameTextBox.Text=addProductQuantityTextBox.Text = searchByQuantityNumberTextBox.Text = string.Empty;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (productNameTextBox.Text == "" || productPriceTextBox.Text=="" || productQuantityTextBox.Text=="" || productCategoryComboBox.Text=="" )
            {
                MessageBox.Show("All boxes have to be filled");
            }
            else
            {
                ProductService productService = new ProductService();
                int result = productService.AddNewProduct(productNameTextBox.Text, productPriceTextBox.Text, productQuantityTextBox.Text, productCategoryComboBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Product added successfully");
                }
                else
                {
                    MessageBox.Show("Error in adding product");
                }
            }
        }
        private void loadProductListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id=pid = (int)loadProductListGridView.Rows[e.RowIndex].Cells[0].Value;
            productNameTextBox.Text = addQuantityProductNameTextBox.Text = loadProductListGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            productPriceTextBox.Text= loadProductListGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            productQuantityTextBox.Text = loadProductListGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            value = (int)loadProductListGridView.Rows[e.RowIndex].Cells[3].Value;
            cid = (int)loadProductListGridView.Rows[e.RowIndex].Cells[4].Value;
            CategoryService categoryService = new CategoryService();
            productCategoryComboBox.Text = categoryService.GetCategoryName(cid);
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            int result = productService.UpdateProduct(id, productNameTextBox.Text, productPriceTextBox.Text, productQuantityTextBox.Text, productCategoryComboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Product updated successfully");
            }
            else
            {
                MessageBox.Show("Error in updating product");
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            int result = productService.DeleteProduct(id);
            if (result > 0)
            {
                
                MessageBox.Show("Product deleted successfully");
            }
            else
            {
                MessageBox.Show("Remove Customers Orders First to Remove Product.","Error in Removing");
            }
        }

        private void searchProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            loadProductListGridView.DataSource = productService.GetProductListForSearch(searchProductNameTextBox.Text);
        }

        private void searchByQuantityNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchByQuantityNumberTextBox.Text))
            {
                ProductService productService = new ProductService();
                loadInsufficientQuantityProductsListGridView.DataSource = productService.GetProductsForQuantity(Convert.ToInt32(searchByQuantityNumberTextBox.Text));
            }
            else
            {

                ProductService productService = new ProductService();
                loadInsufficientQuantityProductsListGridView.DataSource = productService.GetProductsForQuantity(min);

            }
        }

        private void loadInsufficientQuantityProductsListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pid = (int)loadInsufficientQuantityProductsListGridView.Rows[e.RowIndex].Cells[0].Value;
            addQuantityProductNameTextBox.Text = loadInsufficientQuantityProductsListGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            value = (int)loadInsufficientQuantityProductsListGridView.Rows[e.RowIndex].Cells[3].Value;
        }

        private void addProductQuantityButton_Click(object sender, EventArgs e)
        {
            int updatedQuantity = Convert.ToInt32(addProductQuantityTextBox.Text) + value;

            ProductService productService = new ProductService();
            int result = productService.UpdateQuantity(updatedQuantity,pid);
            if (result > 0)
            {
                MessageBox.Show("Product Quantity added successfully");
            }
            else
            {
                MessageBox.Show("Error in adding product quentity");
            }
        }

        private void backToHomeBuktton1_Click(object sender, EventArgs e)
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

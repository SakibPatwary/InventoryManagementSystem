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
    public partial class CategoryManagement : Form
    {
        int id = 0;
        string username;
        public CategoryManagement(string username)
        {
            this.username = username;
            InitializeComponent();
            addCategoryButton.Click += this.RefreshGridView;
            addCategoryButton.Click += this.ClearFields;
            updateCategoryButton.Click += this.RefreshGridView;
            updateCategoryButton.Click += this.ClearFields;
            deleteCategoryButton.Click += this.RefreshGridView;
            deleteCategoryButton.Click += this.ClearFields;
        }

        private void CategoryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            loadCategoryDataGridView.DataSource = categoryService.GetListOfCategories();
            categoryService = new CategoryService();
            categoryWiseProductcomboBox.DataSource = categoryService.GetCategoryNameList();
        }
        void RefreshGridView(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            loadCategoryDataGridView.DataSource = categoryService.GetListOfCategories();
        }
        void ClearFields(object sender, EventArgs e)
        {
            categoryNameTextBox.Text = string.Empty;
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            if (categoryNameTextBox.Text == "" )
            {
                MessageBox.Show("Name box has to be filled");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.AddNewCategory(categoryNameTextBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Category added successfully");
                }
                else
                {
                    MessageBox.Show("Error in adding category");
                }
            }
                
        }

        private void loadCategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)loadCategoryDataGridView.Rows[e.RowIndex].Cells[0].Value;
            categoryNameTextBox.Text = loadCategoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            int result = categoryService.UpdateCategory(id, categoryNameTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Category updated successfully");
            }
            else
            {
                MessageBox.Show("Error in updating category");
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            bool result = categoryService.GetProductForDeleteCategory(id);
            if (result)
            {
                MessageBox.Show("This Catehory have products");
            }
            else
            {
                categoryService = new CategoryService();
                int results = categoryService.DeleteCategory(id);
                if (results > 0)
                {
                    MessageBox.Show("Category deleted successfully");
                }
                else
                {
                    MessageBox.Show("Error in deleting category");
                }
            }

        }

        private void categoryWiseProductcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            categoryWiseProductDataGridView.DataSource = categoryService.GetProductListByCategory(categoryWiseProductcomboBox.Text);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            categoryWiseProductDataGridView.DataSource = productService.GetProductList();
        }

        private void backToHomeButton_Click(object sender, EventArgs e)
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

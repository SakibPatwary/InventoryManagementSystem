using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Data_Access_Layer
{
    class CategoryDataAccess
    {
        DataAccess dataAccess;
        public CategoryDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Category> GetAllCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = (int)reader["CategoryId"];
                category.CategoryName = reader["CategoryName"].ToString();
                categories.Add(category);
            }
            return categories;
        }

        public Category GetCategory(int id)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryId="+id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Category category = new Category();
            category.CategoryId = (int)reader["CategoryId"];
            category.CategoryName = reader["CategoryName"].ToString();
            return category;
        }

        public string GetCategoryName(int id)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryId='" + id + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["CategoryName"].ToString();
        }
        public int InsertCategory(Category category)
        {
            string sql = "INSERT INTO Categories(CategoryName) VALUES('"+category.CategoryName+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateCategory(Category category)
        {
            string sql = "UPDATE Categories SET CategoryName='"+category.CategoryName+"' WHERE CategoryId="+category.CategoryId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteCategory(int id)
        {
            string sql = "DELETE FROM Categories WHERE CategoryId="+id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public List<string> GetCategoryNames()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> categories = new List<string>();
            while (reader.Read())
            {
                categories.Add(reader["CategoryName"].ToString());
            }
            return categories;
        }

        public List<Product> GetProductByCategory(string categoryName)
        {
            string categoryIdSearch = "SELECT * FROM Categories WHERE CategoryName='"+categoryName+"'";
            SqlDataReader reader = this.dataAccess.GetData(categoryIdSearch);
            reader.Read();
            int categoryId = (int)reader["CategoryId"];
            string sql = "SELECT * FROM Products WHERE CategoryId=" + categoryId;
            this.dataAccess = new DataAccess();
            reader = this.dataAccess.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product= new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
        public bool GetProductByCategoryId(int categoryId)
        {
            string sql = "SELECT * FROM Products WHERE CategoryId=" + categoryId;
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

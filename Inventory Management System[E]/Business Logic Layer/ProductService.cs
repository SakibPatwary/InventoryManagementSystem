using Sales_and_Inventory_Management_System.Data_Access_Layer;
using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Business_Logic_Layer
{
    class ProductService
    {
        ProductDataAccess productDataAcess;
        public ProductService()
        {
            productDataAcess = new ProductDataAccess();
        }

        public List<Product> GetProductList()
        {
            return productDataAcess.GetAllProducts();
        }
        public int AddNewProduct(string productName,string price,string quantity,string categoryName)
        {
            int categoryId = productDataAcess.GetCategoryId(categoryName);
            Product product = new Product()
            {
                ProductName=productName,
                Price=Convert.ToDouble(price),
                Quantity=Convert.ToInt32(quantity),
                CategoryId=categoryId
            };
            productDataAcess = new ProductDataAccess();
            return productDataAcess.InsertProduct(product);
        }
        public int UpdateProduct(int productId, string productName, string price, string quantity, string categoryName)
        {
            int categoryId = productDataAcess.GetCategoryId(categoryName);
            Product product = new Product()
            {
                ProductId = productId,
                ProductName = productName,
                Price = Convert.ToDouble(price),
                Quantity = Convert.ToInt32(quantity),
                CategoryId = categoryId
            };
            productDataAcess = new ProductDataAccess();
            return productDataAcess.UpdateProduct(product);
        }
        public int DeleteProduct(int productId)
        {
            SaleService saleService = new SaleService();
            int orderCount = Convert.ToInt32(saleService.productOrderCount(productId));
            if (orderCount == 0)
            {
                return this.productDataAcess.DeleteProduct(productId);
            }
            else return 0;
        }
        public List<Product> GetProductListForSearch(string productName)
        {
            return productDataAcess.GetProductsForSearch(productName);
        }
        public List<Product> GetProductsForQuantity(int quantity)
        {
            return productDataAcess.GetProductsForQuantity(quantity);
        }
        public int GetProductQuantity(int productId)
        {
            return productDataAcess.GetProductQuantity(productId);
        }
        public int UpdateQuantity(int quantity, int id)
        {
            return productDataAcess.UpdateQuantity(quantity, id);
        }
    }
}

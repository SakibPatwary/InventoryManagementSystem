using Sales_and_Inventory_Management_System.Entities;
using Sales_and_Inventory_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Data_Access_Layer
{
    class SaleDataAccess
    {
        DataAccess dataAccess;
        public SaleDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public int CreateSale(Sale sale)
        {
            string sql = "INSERT INTO SALES (CustomerName,CustomerId,ProductName,ProductId,SalesDate,Quantity,UnitPrice,TotalPrice) VALUES('" + sale.CustomerName + "'," + sale.CustomerId + ",'" + sale.ProductName + "'," + sale.ProductId + ",'" + sale.SalesDate + "'," + sale.Quantity + "," + sale.UnitPrice + ","+sale.TotalPrice+")";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public List<Sale> GetAllSalesList()
        {
            string sql = "SELECT * FROM Sales";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.OrderId = (int)reader["OrderId"];
                sale.CustomerName = reader["CustomerName"].ToString();
                sale.CustomerId = (int)reader["CustomerId"];
                sale.ProductName = reader["ProductName"].ToString();
                sale.ProductId = (int)reader["ProductId"];
                sale.SalesDate = reader["SalesDate"].ToString();
                sale.Quantity = (int)reader["Quantity"];
                sale.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                sale.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                sales.Add(sale);
            }
            return sales;
        }
        public List<Sale> GetAllSalesListByDate(string from, string to)
        {
            string sql = "SELECT * FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.OrderId = (int)reader["OrderId"];
                sale.CustomerName = reader["CustomerName"].ToString();
                sale.CustomerId = (int)reader["CustomerId"];
                sale.ProductName = reader["ProductName"].ToString();
                sale.ProductId = (int)reader["ProductId"];
                sale.SalesDate = reader["SalesDate"].ToString();
                sale.Quantity = (int)reader["Quantity"];
                sale.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                sale.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                sales.Add(sale);
            }
            return sales;
        }
        public List<Sale> GetAllSalesListByDateAndId(string from, string to,int id)
        {
            string sql = "SELECT * FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "' AND CustomerId="+id;
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.OrderId = (int)reader["OrderId"];
                sale.CustomerName = reader["CustomerName"].ToString();
                sale.CustomerId = (int)reader["CustomerId"];
                sale.ProductName = reader["ProductName"].ToString();
                sale.ProductId = (int)reader["ProductId"];
                sale.SalesDate = reader["SalesDate"].ToString();
                sale.Quantity = (int)reader["Quantity"];
                sale.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                sale.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                sales.Add(sale);
            }
            return sales;
        }
        public List<Sale> GetCustomerOrdersListById(int id)
        {
            string sql = "SELECT * FROM Sales WHERE CustomerId= " + id;
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.OrderId = (int)reader["OrderId"];
                sale.CustomerName = reader["CustomerName"].ToString();
                sale.CustomerId = (int)reader["CustomerId"];
                sale.ProductName = reader["ProductName"].ToString();
                sale.ProductId = (int)reader["ProductId"];
                sale.SalesDate = reader["SalesDate"].ToString();
                sale.Quantity = (int)reader["Quantity"];
                sale.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                sale.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                sales.Add(sale);
            }
            return sales;
        }
        public List<CustomerOrder> GetCustomerOrderById(int id)
        {
            string sql = "SELECT * FROM Sales WHERE CustomerId= "+ id;
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<CustomerOrder> customerOrders = new List<CustomerOrder>();
            while (reader.Read())
            {
                CustomerOrder customerOrder = new CustomerOrder();
                customerOrder.OrderId = (int)reader["OrderId"];
                customerOrder.ProductName = reader["ProductName"].ToString();
                customerOrder.ProductId = (int)reader["ProductId"];
                customerOrder.SalesDate = reader["SalesDate"].ToString();
                customerOrder.Quantity = (int)reader["Quantity"];
                customerOrder.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                customerOrder.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                customerOrders.Add(customerOrder);
            }
            return customerOrders;
        }
        public List<CustomerOrder> GetCustomerOrderByDateAndId(string from, string to, int id)
        {
            string sql = "SELECT * FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "' AND CustomerId=" + id;
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<CustomerOrder> customerOrders = new List<CustomerOrder>();
            while (reader.Read())
            {
                CustomerOrder customerOrder = new CustomerOrder();
                customerOrder.OrderId = (int)reader["OrderId"];
                customerOrder.ProductName = reader["ProductName"].ToString();
                customerOrder.ProductId = (int)reader["ProductId"];
                customerOrder.SalesDate = reader["SalesDate"].ToString();
                customerOrder.Quantity = (int)reader["Quantity"];
                customerOrder.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                customerOrder.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                customerOrders.Add(customerOrder);
            }
            return customerOrders;
        }
        public int RemoveOrder(int id)
        {
            string sql = "DELETE FROM Sales WHERE OrderId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int RemoveOrderByProductId(int id)
        {
            string sql = "DELETE FROM Sales WHERE ProductId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int RemoveOrderByCusId(int id)
        {
            string sql = "DELETE FROM Sales WHERE CustomerId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public string TotalAmount(int id)
        {
            string sql = "SELECT SUM (TotalPrice) FROM Sales WHERE CustomerId="+id;
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string LastOrderedDate(int id)
        {
            string sql = "SELECT MAX (SalesDate) FROM Sales WHERE CustomerId=" + id;
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string OrderCount(int id)
        {
            string sql = "SELECT COUNT (ProductId) FROM Sales WHERE CustomerId=" + id;
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string productOrderCount(int id)
        {
            string sql = "SELECT COUNT (ProductId) FROM Sales WHERE ProductId=" + id;
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string TotalAmountByDate(int id, string from, string to)
        {
            string sql = "SELECT SUM (TotalPrice) FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "' And CustomerId=" + id;
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string LastOrderedDateBydate(int id, string from, string to)
        {
            string sql = "SELECT MAX (SalesDate) FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "' And CustomerId=" + id;
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string OrderCountBydate(int id, string from, string to)
        {
            string sql = "SELECT COUNT (ProductId) FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "' And CustomerId=" + id;
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public int UpdateCustomerName(string customerName, int customerId)
        {
            string sql = "UPDATE Sales SET CustomerName='" + customerName + "' WHERE CustomerId=" + customerId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public string TotalSalesCount()
        {
            string sql = "SELECT COUNT (ProductId) FROM Sales";
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string TotalSalesAmount()
        {
            string sql = "SELECT SUM (TotalPrice) FROM Sales";
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string LastSalesDate()
        {
            string sql = "SELECT MAX (SalesDate) FROM Sales";
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string TotalSalesByDate(string from, string to)
        {
            string sql = "SELECT SUM (TotalPrice) FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "'";
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string LastSalesDateBydate(string from, string to)
        {
            string sql = "SELECT MAX (SalesDate) FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "'";
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
        public string SalesCountBydate(string from, string to)
        {
            string sql = "SELECT COUNT (ProductId) FROM Sales WHERE SalesDate BETWEEN '" + from + "' AND '" + to + "'";
            this.dataAccess = new DataAccess();
            string result = this.dataAccess.ExecuteScalar(sql);
            return result;
        }
    }
}


using Sales_and_Inventory_Management_System.Entities;
using Sales_and_Inventory_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Business_Logic_Layer
{
    class SaleService
    {
        SaleDataAccess saleDataAccess;
        public SaleService()
        {
            this.saleDataAccess = new SaleDataAccess();
        }
        public List<Sale> GetAllSalesList()
        {
            return this.saleDataAccess.GetAllSalesList();
        }
        public List<Sale> GetAllSalesListByDate(string from, string to)
        {
            return this.saleDataAccess.GetAllSalesListByDate(from, to);
        }
        public List<Sale> GetAllSalesListByDateAndId(string from, string to, int id)
        {
            return this.saleDataAccess.GetAllSalesListByDateAndId(from, to, id);
        }
        public List<Sale> GetCustomerOrdersListById(int id)
        {
            return this.saleDataAccess.GetCustomerOrdersListById(id);
        }
        public List<CustomerOrder> GetAllSalesListByCustomerId(int id)
        {
            return this.saleDataAccess.GetCustomerOrderById(id);
        }
        public List<CustomerOrder> GetCustomerOrderByDateAndId(string from, string to, int id)
        {
            return this.saleDataAccess.GetCustomerOrderByDateAndId(from, to, id);
        }
        
        
        public int CreateSale(string customerName, int customerId, string productName, int productId, string salesDate, int quantity, double unitPrice, int availableQuantity)
        {
            int newQuantity = 0;
            double totalPrice = unitPrice * quantity;
            if (availableQuantity >= quantity)
            {
                Sale sale = new Sale()
                {
                    CustomerName = customerName,
                    CustomerId = customerId,
                    ProductName = productName,
                    ProductId = productId,
                    SalesDate = salesDate,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    TotalPrice = totalPrice
                };
                newQuantity = availableQuantity - quantity;
                ProductDataAccess productDataAccess = new ProductDataAccess();
                productDataAccess.UpdateQuantity(newQuantity, productId);
                return saleDataAccess.CreateSale(sale);
            }
            else return 0;
        }
        public int RemoveOrder(int orderId,int productId, int availableQuantity,int orderedQuantity)
        {
            int newQuantity = 0;
            newQuantity = availableQuantity + orderedQuantity;
            ProductDataAccess productDataAccess = new ProductDataAccess();
            productDataAccess.UpdateQuantity(newQuantity, productId);
            return saleDataAccess.RemoveOrder(orderId);
        }
        public string TotalOrderedAmount(int id)
        {
            return saleDataAccess.TotalAmount(id);
        }
        public string LastOrderedDate(int id)
        {
            return saleDataAccess.LastOrderedDate(id);
        }
        public string OrderCount(int id)
        {
            return saleDataAccess.OrderCount(id);
        }
        public string productOrderCount(int id)
        {
            return saleDataAccess.productOrderCount(id);
        }
        public string TotalOrderedAmountByDate(int id, string from, string to)
        {
            return saleDataAccess.TotalAmountByDate(id,from,to);
        }
        public string LastOrderedDateByDate(int id, string from, string to)
        {
            return saleDataAccess.LastOrderedDateBydate(id, from, to);
        }
        public string OrderCountByDate(int id, string from, string to)
        {
            return saleDataAccess.OrderCountBydate(id, from, to);
        }
        public void UpdateCustomerName(string customerName, int customerId)
        {
            saleDataAccess.UpdateCustomerName(customerName, customerId);
        }
        public string TotalSalesCount()
        {
            return saleDataAccess.TotalSalesCount();
        }
        public string TotalSalesAmount()
        {
            return saleDataAccess.TotalSalesAmount();
        }
        public string LastSalesDate()
        {
            return saleDataAccess.LastSalesDate();
        }
        public string TotalSalesByDate(string from, string to)
        {
            return saleDataAccess.TotalSalesByDate(from, to);
        }
        public string LastSalesDateBydate(string from, string to)
        {
            return saleDataAccess.LastSalesDateBydate(from, to);
        }
        public string SalesCountBydate(string from, string to)
        {
            return saleDataAccess.SalesCountBydate(from, to);
        }
    }
}

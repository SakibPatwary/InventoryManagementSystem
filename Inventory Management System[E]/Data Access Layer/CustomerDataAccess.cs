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
    class CustomerDataAccess
    {
        DataAccess dataAccess;
        public CustomerDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Customer> GetAllCustomer()
        {
            string sql = "SELECT * FROM Customers";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = (int)reader["CustomerId"];
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.PhoneNo = reader["PhoneNo"].ToString();
                customers.Add(customer);
            }
            return customers;
        }
        public List<Customer> GetCustomerForSearch(string customerName)
        {
            string sql = "SELECT * FROM Customers WHERE CustomerName LIKE '%" + customerName + "%'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = (int)reader["CustomerId"];
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.PhoneNo = reader["PhoneNo"].ToString();
                customers.Add(customer);
            }
            return customers;
        }
        public Customer GetCustomer(int id)
        {
            string sql = "SELECT * FROM Customers WHERE CustomerId=" + id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Customer customer = new Customer();
            customer.CustomerId = (int)reader["CustomerId"];
            customer.CustomerName = reader["CustomerName"].ToString();
            customer.PhoneNo = reader["PhoneNo"].ToString();
            return customer;
        }
        public int InsertCustomer(Customer customer)
        {
            string sql = "INSERT INTO Customers(CustomerName,PhoneNo) VALUES('" + customer.CustomerName + "'," + customer.PhoneNo + ")";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public int UpdateCustomer(Customer customer)
        {
            string sql = "UPDATE Customers SET CustomerName='" + customer.CustomerName + "',PhoneNo="+customer.PhoneNo+" WHERE CustomerId=" + customer.CustomerId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int RemoveCustomer(int id)
        {
            string sql = "DELETE FROM Customers WHERE CustomerId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}

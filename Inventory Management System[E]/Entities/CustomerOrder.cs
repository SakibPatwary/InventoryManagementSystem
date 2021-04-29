using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Entities
{
    class CustomerOrder
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string SalesDate { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}

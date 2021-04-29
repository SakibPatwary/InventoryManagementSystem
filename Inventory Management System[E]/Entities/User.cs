using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Entities
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Type { get; set; }
    }
}

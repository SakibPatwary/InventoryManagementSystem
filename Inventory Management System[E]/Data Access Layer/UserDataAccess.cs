using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Data_Access_Layer
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        string value = "User";
        public UserDataAccess()
        {

            this.dataAccess = new DataAccess();
        }
        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";
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
        public bool UsernameValidation(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "'";
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
        public List<User> GetAllUsers()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["UserName"].ToString();
                //user.Password = reader["Password"].ToString();
                user.Email = reader["Email"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.Type = reader["Type"].ToString();
                users.Add(user);
            }
            return users;
        }
        public User GetUser(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id=" + id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            User user = new User();
            user.Id = (int)reader["Id"];
            user.Name = reader["Name"].ToString();
            user.Username = reader["UserName"].ToString();
            user.Email = reader["Email"].ToString();
            user.DateOfBirth = reader["DateOfBirth"].ToString();
            user.Gender = reader["Gender"].ToString();
            user.Type = reader["Type"].ToString();
            return user;
        }
        public int InsertUser(User user)
        {
            string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,Type) VALUES('" + user.Name + "','" + user.Username + "','" + user.Password + "','" + user.Email + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.Type + "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int InsertUserForReg(User user)
        {
            string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup,Type) VALUES('" + user.Name + "','" + user.Username + "','" + user.Password + "','" + user.Email + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.BloodGroup + "','" + value + "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdateUserForAdmin(User user)
        {
            string sql = "UPDATE Users SET Name='" + user.Name + "',Username='" + user.Username + "',Password='" + user.Password + "',Email='" + user.Email + "',DateOfBirth='" + user.DateOfBirth + "',Gender='" + user.Gender + "',Type='" + user.Type + "' WHERE Id=" + user.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdateUser(User user)
        {
            string sql = "UPDATE Users SET Name='" + user.Name + "',Username='" + user.Username + "',Password='" + user.Password + "',Email='" + user.Email + "',DateOfBirth='" + user.DateOfBirth + "',Gender='" + user.Gender + "' WHERE Id=" + user.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeleteUser(int id)
        {
            string sql = "DELETE FROM Users WHERE Id=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public string GetUserType(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["Type"].ToString();
        }
        public string GetName(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["Name"].ToString();
        }

        public string GetUserDateOfBirth(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id='" + id + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["DateOfBirth"].ToString();
        }
        public string GetUserGender(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id='" + id + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["Gender"].ToString();
        }
        public List<string> GetUserNames()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> users = new List<string>();
            while (reader.Read())
            {
                users.Add(reader["UserName"].ToString());
            }
            return users;
        }


        public int GetUserId(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return (int)reader["Id"];
        }
        public string GetUserName(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id='" + id + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["Name"].ToString();
        }
        public string GetUserUsername(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id='" + id + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["Username"].ToString();
        }
        public string GetUserPassword(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id='" + id + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["Password"].ToString();
        }
        public string GetUserEmail(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id='" + id + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return reader["Email"].ToString();
        }



        /*public List<Event> GetEventByUser(string userName)
        {
            string userIdSearch = "SELECT * FROM Users WHERE Username='" + userName + "'";
            SqlDataReader reader = this.dataAccess.GetData(userIdSearch);
            reader.Read();
            int userId = (int)reader["Id"];
            string sql = "SELECT * FROM Events WHERE Id=" + userId;
            this.dataAccess = new DataAccess();
            reader = this.dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                Event eventz = new Event();
                eventz.EventID = (int)reader["EventID"];
                eventz.EventTitle = reader["EventTitle"].ToString();
                eventz.Date = reader["Date"].ToString();
                eventz.EventDescription = reader["EventDescription"].ToString();
                eventz.UpdatedDate = reader["UpdatedDate"].ToString();
                eventz.Importance = reader["Importance"].ToString();
                eventz.Id = (int)reader["Id"];
                events.Add(eventz);
            }
            return events;
        }*/
    }
}

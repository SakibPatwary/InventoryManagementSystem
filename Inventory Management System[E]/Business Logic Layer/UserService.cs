using Sales_and_Inventory_Management_System.Data_Access_Layer;
using Sales_and_Inventory_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_and_Inventory_Management_System.Business_Logic_Layer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            this.userDataAccess = new UserDataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            return userDataAccess.LoginValidation(username, password);
        }
        public bool UsernameValidation(string username)
        {
            return userDataAccess.UsernameValidation(username);
        }

        public List<User> GetListOfUsers()
        {
            return this.userDataAccess.GetAllUsers();
        }

        public User GetUser(int id)
        {
            return this.userDataAccess.GetUser(id);
        }


        public int AddNewUser(string name, string userName, string password, string email, string dateOfBirth, string gender, string type)
        {
            User user = new User()
            {
                Name = name,
                Username = userName,
                Password = password,
                Email = email,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Type = type
            };
            return this.userDataAccess.InsertUser(user);
        }
        public int AddNewUserForReg(string name, string userName, string password, string email, string dateOfBirth, string gender, string bloodGroup)
        {
            User user = new User()
            {
                Name = name,
                Username = userName,
                Password = password,
                Email = email,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                BloodGroup = bloodGroup
            };
            return this.userDataAccess.InsertUserForReg(user);
        }
        public int UpdateUserForAdmin(int id, string name, string userName, string passsword, string email, string dateOfBirth, string gender, string type)
        {
            User user = new User()
            {
                Id = id,
                Name = name,
                Username = userName,
                Password = passsword,
                Email = email,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Type = type
            };
            return this.userDataAccess.UpdateUserForAdmin(user);
        }
        public int UpdateUser(int id, string name, string userName, string passsword, string email, string dateOfBirth, string gender)
        {
            User user = new User()
            {
                Id = id,
                Name = name,
                Username = userName,
                Password = passsword,
                Email = email,
                DateOfBirth = dateOfBirth,
                Gender = gender
            };
            return this.userDataAccess.UpdateUser(user);
        }

        //internal bool LginValidation(string text1, string text2)
        //{
        //   throw new NotImplementedException();
        //}

        public int DeleteUser(int id)
        {
            return this.userDataAccess.DeleteUser(id);
        }
        public string GetUserType(string username)
        {
            return this.userDataAccess.GetUserType(username);
        }

        public string GetName(string username)
        {
            return this.userDataAccess.GetName(username);
        }

        public string GetUserDateOfBirth(int id)
        {
            return this.userDataAccess.GetUserDateOfBirth(id);
        }
        public string GetUserGender(int id)
        {
            return this.userDataAccess.GetUserGender(id);
        }
        public List<string> GetUserNameList()
        {
            return this.userDataAccess.GetUserNames();
        }


        public int GetUserId(string username)
        {
            return this.userDataAccess.GetUserId(username);
        }
        public string GetUserName(int id)
        {
            return this.userDataAccess.GetUserName(id);
        }
        public string GetUserUsername(int id)
        {
            return this.userDataAccess.GetUserUsername(id);
        }
        public string GetUserPassword(int id)
        {
            return this.userDataAccess.GetUserPassword(id);
        }
        public string GetUserEmail(int id)
        {
            return this.userDataAccess.GetUserEmail(id);
        }

        /*public List<Event> GetEventListByUser(string userName)
        {
            return this.userDataAccess.GetEventByUser(userName);
        }*/
    }
}

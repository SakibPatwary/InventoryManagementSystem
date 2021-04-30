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
    public partial class EmployeeManagement : Form
    {
        int id = 0;
        string username;
        public EmployeeManagement(string username)
        {
            this.username = username;
            InitializeComponent();
            addUserButton.Click += this.RefreshGridView;
            updateUserButton.Click += this.RefreshGridView;
            updateUserButton.Click += this.ClearFields;
            deleteUserButton.Click += this.RefreshGridView;
            deleteUserButton.Click += this.ClearFields;
        }

        private void HomeForAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeForAdmin_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            loadListOfUsersGridView.DataSource = userService.GetListOfUsers();
        }

        void RefreshGridView(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            loadListOfUsersGridView.DataSource = userService.GetListOfUsers();
        }

        void ClearFields(object sender, EventArgs e)
        {
            nameTextBox.Text = userNameTextBox.Text = passwordTextBox.Text=emailTextBox.Text=GenderComboBox.Text = userTypeComboBox.Text = string.Empty;

        }

        private void dateOfBirthDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTime BirthOfDate = Convert.ToDateTime(dateOfBirthDateTimePicker.Text);
            DateTime today = DateTime.Today;
            if (BirthOfDate >= today)
            {
                MessageBox.Show("Date of Birth Can't be Today's Date or greater than Today's Date", "Selected Date Error");
                dateOfBirthDateTimePicker.Text = Convert.ToString(today);
            }
        }

        private void loadListOfUsersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)loadListOfUsersGridView.Rows[e.RowIndex].Cells[0].Value;
            nameTextBox.Text = loadListOfUsersGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            userNameTextBox.Text = loadListOfUsersGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailTextBox.Text = loadListOfUsersGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            userTypeComboBox.Text= loadListOfUsersGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            UserService userService = new UserService();
            GenderComboBox.Text = userService.GetUserGender(id);
            userService = new UserService();
            passwordTextBox.Text = userService.GetUserPassword(id);
            userService = new UserService();
            dateOfBirthDateTimePicker.Text = userService.GetUserDateOfBirth(id);

        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            DateTime BirthOfDate = Convert.ToDateTime(dateOfBirthDateTimePicker.Text);
            DateTime today = DateTime.Today;
            if (BirthOfDate >= today)
            {
                MessageBox.Show("Date of Birth Can't be Today's Date or greater than Today's Date", "Selected Date Error");
                dateOfBirthDateTimePicker.Text = Convert.ToString(today);
            }
            else
            {
                UserService userService = new UserService();
                int result = userService.UpdateUserForAdmin(id, nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text, emailTextBox.Text, dateOfBirthDateTimePicker.Text, GenderComboBox.Text, userTypeComboBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("User updated successfully");
                }
                else
                {
                    MessageBox.Show("Error updating user");
                }
            }
            
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (userService.GetUserType(userNameTextBox.Text) == "Admin")
            {
                MessageBox.Show("Can not delete Admin");
            }
            else
            {
                userService = new UserService();
                int result = userService.DeleteUser(id);
                if (result > 0)
                {
                    MessageBox.Show("User deleted successfully");
                }
                else
                {
                    MessageBox.Show("Error delating user");
                }
            }
            
        }


        private void backToHomeBuktton_Click(object sender, EventArgs e)
        {
            HomeForAdmin homeForAdmin = new HomeForAdmin(username);
            homeForAdmin.Show();
            this.Hide();
        }

    }
}

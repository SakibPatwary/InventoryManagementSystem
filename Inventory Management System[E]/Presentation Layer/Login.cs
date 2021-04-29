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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Username or password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(usernameTextBox.Text,passwordTextBox.Text);
                if (result)
                {
                    userService = new UserService();
                    if (userService.GetUserType(usernameTextBox.Text)=="Admin")
                    {
                        HomeForAdmin homeForAdmin = new HomeForAdmin(usernameTextBox.Text);
                        homeForAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        HomeForUser homeForUser = new HomeForUser(usernameTextBox.Text);
                        homeForUser.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Username or password ");
                }
            }
        }

        private void RestrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

    }
}

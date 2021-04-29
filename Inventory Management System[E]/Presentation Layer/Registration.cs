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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            DateTime BirthOfDate = Convert.ToDateTime(dateOfBirthDateTimePicker.Text);
            DateTime today = DateTime.Today;

            if (nameTextBox.Text == "")
            {
                DialogResult result = MessageBox.Show("Name box can not be empty.", "Confirmation",  MessageBoxButtons.OK);
            }
            else if (userNameTextBox.Text == "")
            {
                DialogResult result = MessageBox.Show("User Name sectiom can not be empty.", "Confirmation", MessageBoxButtons.OK);
            }
            else if (passwordTextBox.Text == "")
            {
                DialogResult result = MessageBox.Show("Password field can not be empty.", "Confirmation", MessageBoxButtons.OK);
            }
            else if (confirmPasswordTextBox.Text != passwordTextBox.Text)
            {
                DialogResult result = MessageBox.Show("Given password not matched.", "Confirmation", MessageBoxButtons.OK);
            }
            else if (emailTextBox.Text == "")
            {
                DialogResult result = MessageBox.Show("Email field can not be empty.", "Confirmation", MessageBoxButtons.OK);
            }
            else if (BirthOfDate >= today)
            {
                MessageBox.Show("Date of Birth Can't be Today's Date or greater than Today's Date");
                dateOfBirthDateTimePicker.Text = Convert.ToString(today);
            }
            
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                DialogResult result = MessageBox.Show("Select Gender.", "Confirmation", MessageBoxButtons.OK);
            }
            else if (comboBox1.Text == "")
            {
                DialogResult result = MessageBox.Show("Select your blood group. ", "Confirmation" , MessageBoxButtons.OK);
            }
            else if (checkBox1.Checked == false)
            {
                DialogResult result = MessageBox.Show("You have to agree with all the term and condition.", "Confirmation", MessageBoxButtons.OK);
            }
            else
            {
                string gen = null;
                if (radioButton1.Checked)
                {
                    gen = radioButton1.Text;
                }
                else
                {
                    gen = radioButton2.Text;
                }

                UserService userService = new UserService();
                bool results = userService.UsernameValidation(userNameTextBox.Text);
                if (results)
                {
                    MessageBox.Show("This Username already exist");
                }
                else
                {
                    userService = new UserService();
                    int result = userService.AddNewUserForReg(nameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text, emailTextBox.Text, dateOfBirthDateTimePicker.Text, gen, comboBox1.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("User added successfully");
                        
                        nameTextBox.Text = userNameTextBox.Text = passwordTextBox.Text = confirmPasswordTextBox.Text = emailTextBox.Text = dateOfBirthDateTimePicker.Text = comboBox1.Text = string.Empty;
                        radioButton1.Checked = radioButton2.Checked = checkBox1.Checked = false;

                        Login login = new Login();
                        login.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error adding user");
                    }
                }
            }
        }
    }
}

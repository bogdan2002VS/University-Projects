using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Repository;
using Logic;
using Logic.Account.Service;
using Logic.Model;

namespace EmployeeApp
{
    public partial class Login : Form
    {
        IUserService userService;
        public UserModel User = null;
        public Login()
        {
            try
            {
                InitializeComponent();
                userService = new UserService(new UserRepository()); 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error initializing the app login page");
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (username != String.Empty && password != String.Empty)
            {
                try
                {
                    UserModel userModel = new UserModel()
                    {
                        Username = username,
                        Password = password
                    };
                    User = userService.Login(userModel);
                    if (User != null)
                    {
                        if (User.Role == "Staff")
                        {
                            HomePage homePage = new HomePage();
                            homePage.Show();
                            this.Hide();
                            // When/if the main form is closed, pop up the login form again.
                        }
                        else if (User.Role == "HR")
                        {
                            AccountCreationForm accountCreationForm = new AccountCreationForm();
                            accountCreationForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show($"This application can only be used by supermaret Staff.\nYour role is: {User.Role}.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid username and/or password.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Unable to retrieve user data.\n" +
                        $"Please try again later.");
                }
            }
            else
            {
                MessageBox.Show($"Username and/or password field empty.\nPlease input a valid username and password.");
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbShowPassword.Checked)
                {
                    tbPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    tbPassword.UseSystemPasswordChar = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ups could not show your password at the moment");

            }
            

        }
    }
}

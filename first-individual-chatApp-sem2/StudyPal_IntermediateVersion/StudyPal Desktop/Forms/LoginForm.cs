using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyPalDesktop.Presentation;
using BUSLOGIC;
using DAL;
using StudyPalDesktop.Forms;
using BUSLOGIC.Classes.UserHandler;
using BUSLOGIC.Classes;

namespace StudyPalDesktop
{
    public partial class LoginForm : Form
    {
        public string Username { get; set; }

        public string Password { get; set; }
        IUserManager dal = new UserManager(new QueryExecutor(SQLConnect._connectionstring));

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          

            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please enter username and password.",
                    "Required data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            User databaseUser = null;
            try
            {
                databaseUser = dal.LogIn(username, password);
                UserHomePage userHomePage = new UserHomePage(databaseUser);
                userHomePage.Show();
                this.Hide();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(
                            "That account does not exist. Please check your username and password and try again.",
                            "Invalid credentials",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            if (databaseUser == null)
            {
                MessageBox.Show(
                            "That account does not exist. Please check your username and password and try again.",
                            "Invalid credentials !!!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }


        }
    }

       
 }


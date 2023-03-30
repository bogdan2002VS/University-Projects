using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSLOGIC.Classes.UserHandler;
using DAL;
using DAL.Exception;

namespace StudyPalDesktop.Forms
{
    public partial class RegisterForm : Form
    {
        UserManager dal = new UserManager(new QueryExecutor<Object>(SQLConnect._connectionstring));
        bool update = false;
        User currentUser;
        public RegisterForm()
        {
            InitializeComponent();
        }
        public RegisterForm(bool forUpdate,User currentUser)
        {
            InitializeComponent();
            btnRegister.Text = "Update";
            update = true;
            this.currentUser = currentUser;
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (update)
            {
                dal.UpdateUser(tbName.Text, tbUsername.Text, tbPassword.Text, currentUser.ID.ToString().Trim());
                MessageBox.Show("Account Updated");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else if (tbName.Text != string.Empty && tbUsername.Text != string.Empty && tbPassword.Text != string.Empty)
            {
                
                try
                {
                    dal.AddUser(tbName.Text, tbUsername.Text, tbPassword.Text);
                    MessageBox.Show("Account was successfully created!");
                    tbName.Clear();
                    tbUsername.Clear();
                    tbPassword.Clear();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                catch (DatabaseException ex)
                {
                    MessageBox.Show("Fatal Error with Database" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal Error" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please fill in all fields!");
            }

        }
    }
}

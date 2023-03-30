using System.Net.Mail;
using DAL.Repository;
using Logic;
using Logic.Account.Service;
using Logic.Account.Util;
using Logic.Model;
using Logic.Product.Model;

namespace EmployeeApp
{
    public partial class AccountCreationForm : Form
    {

        IUserService userService;
        public AccountCreationForm()
        {
            try
            {
                InitializeComponent();
                userService = new UserService(new UserRepository());

            }
            catch (Exception)
            {
                MessageBox.Show("Error creating the Account");
            }

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_createAcc_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string fullName = tbFullName.Text;
            string email = tbEmail.Text;

            try
            {
                if (username == String.Empty || fullName == String.Empty || email == String.Empty || password == String.Empty)
                {
                    MessageBox.Show($"One or more fiels have been left empty.\nPlease fill all fields before proceeding.");
                }
                else
                {
                    try
                    {
                        email = new MailAddress(email).Address;
                        UserModel userModel = new UserModel()
                        {
                            Name = fullName,
                            Username = username,
                            Password = password,
                            Email = email
                        };
                        userService.RegisterEmployee(userModel);
                        MessageBox.Show($"Account successfully created.");
                         tbUsername.Text = String.Empty;
                         tbPassword.Text = String.Empty;
                         tbFullName.Text = String.Empty;
                         tbEmail.Text = String.Empty;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show($"Invalid e-mail address.\nPlease input a valid e-mail address.");
                    }
                }

            }
            catch
            {
                MessageBox.Show($"There was an issue processing your request.\nPlease try again later.");
            }
        }
    }
}
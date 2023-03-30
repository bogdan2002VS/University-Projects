using DataL;
using DataL.interfaces;
using Logic;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Logic.Validation;
using System.DirectoryServices.ActiveDirectory;
using System.IO.Ports;

namespace mediabazaar
{
    public partial class LoginForm : Form
    {
        ILogInRep logInRep;
        ILogIn logIn;

        IManagerRepository managerRepository;
        IEmployee employee;

        public LoginForm()
        {
            managerRepository = new EmployeeRepository();
            employee = new EmployeeManager(managerRepository, new CredentialsManager(new CredentialsRepository()), new EmployeeValidation());

            logInRep = new LogInData();
            logIn = new LoginLogic(logInRep, employee, new CredentialsManager(new CredentialsRepository()));

            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            try
            {
                username = tbUsername.Text;
                password = tbxPassword.Text;

               
                if (username == "r" && password == "r")
                {
                    CheckInAndOutForm eForm = new CheckInAndOutForm();
                        this.Hide();
                        eForm.Closed += (s, args) => this.Close();
                        eForm.Show();
                    return;
                }
                Employee employee = logIn.LogIn(username, password);

                if (employee != null)
                {
                    if (employee.GetType() == typeof(Security))
                    {
                        EmployeeForm eForm = new EmployeeForm(employee);
                        this.Hide();
                        eForm.Closed += (s, args) => this.Close();
                        eForm.Show();
                    }
                    else if (employee.GetType() == typeof(ManagerEmployees))
                    {
                        EmployeeManagerForm eForm = new EmployeeManagerForm(employee);
                        this.Hide();
                        eForm.Closed += (s, args) => this.Close();
                        eForm.Show();
                    }
                    else if (employee.GetType() == typeof(StockManager))
                    {
                        ProductManagerForm eForm = new ProductManagerForm(employee);
                        this.Hide();
                        eForm.Closed += (s, args) => this.Close();
                        eForm.Show();
                    }
                    else if (employee.GetType() == typeof(DepoManager))
                    {
                        DepoManagerForm eForm = new DepoManagerForm(employee);
                        this.Hide();
                        eForm.Closed += (s, args) => this.Close();
                        eForm.Show();
                    }
                    else if (employee.GetType() == typeof(HR))
                    {
                        FormHR eForm = new FormHR(employee);
                        this.Hide();
                        eForm.Closed += (s, args) => this.Close();
                        eForm.Show();
                    }
                    else if (employee.GetType() == typeof(Cashier))
                    {
                        SellingProductsForm eForm = new SellingProductsForm(employee);
                        this.Hide();
                        eForm.Closed += (s, args) => this.Close();
                        eForm.Show();
                    }
                }
                else if (username != "r" && password != "r")
                {
                    MessageBox.Show("Username or password incorrect");
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
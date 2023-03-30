using DataL;
using Logic;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Logic.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediabazaar
{
    public partial class FormHR : Form
    {
        IHR employeeManager;
        Employee employee;
        List<Employee> employees;
        public FormHR(Employee e)
        {
            InitializeComponent();
            employee = e;
            employees = new List<Employee>();

            employeeManager = new EmployeeManager(new EmployeeRepository(), new CredentialsManager(new CredentialsRepository()), new EmployeeValidation());

            LoadEmployees();

            employeeManager.EmployeeAdded += new EmailSender().OnEmployeeAdded;
        }

        private void dataGridViewEmployeeManagers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                tbUserControl.SelectedTab = tbUpdateEmployeeInfo;
                LoadEmploeeyInfo(employees[dataGridViewEmployeeManagers.CurrentCell.RowIndex]);
            }
        }

        private void dataGridViewEmployeeManagers_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = CreateEmployee();

                Result<bool> result = employeeManager.UpdateEmployee(employee);

                DialogResult dialogResult = MessageBox.Show("Do you want to update this employee information?", "Applying Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (result.Success)
                    {
                        MessageBox.Show("Employee Information Updated");
                        LoadEmployees();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.tbUpdateEmployeeInfo.Controls.OfType<TextBox>())
            {
                tb.Enabled = true;
            }
        }

        private void btnAddEmployeeManager_Click(object sender, EventArgs e)
        {
            tbUserControl.SelectedTab = tbAddEmployee;
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = CreateEmployee();

                Result<bool> success = employeeManager.AddEmployee(employee);

                if (success.IsExceptionType<ArgumentException>())
                {
                    MessageBox.Show(success.Exception.Message);
                }

                DialogResult dialogResult = MessageBox.Show("Do you want to add this employee?", "Applying Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (success.Success)
                    {
                        MessageBox.Show("Employee Added");
                        LoadEmployees();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = employeeManager.RemoveEmployee(employees[dataGridViewEmployeeManagers.CurrentCell.RowIndex].Id, employees[dataGridViewEmployeeManagers.CurrentCell.RowIndex].GetType());

                
                DialogResult dialogResult = MessageBox.Show("Do you want to remove this employee?", "Applying Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (success)
                    {
                        MessageBox.Show("Employee Removed");
                        LoadEmployees();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == string.Empty)
            {
                LoadEmployees();
            }
            else
            {
                dataGridViewEmployeeManagers.Rows.Clear();

                string[] search = tbxSearch.Text.ToLower().Split(" ");

                employees = SearchSystem<Employee>.Search(search, employees);
                foreach (Employee employee in employees)
                {
                    dataGridViewEmployeeManagers.Rows.Add(employee.FirstName, employee.LastName, employee.Email, employee.PhoneNumber);
                }
            }
        }



        /// <summary>
        /// Custom Functions
        /// </summary>

        public void LoadEmployees()
        {
            dataGridViewEmployeeManagers.Rows.Clear();

            employees = employeeManager.GetEmployeesManagers().Value.ToList();
            foreach(Employee employee in employees)
            {
                dataGridViewEmployeeManagers.Rows.Add(employee.FirstName, employee.LastName, employee.Email, employee.PhoneNumber);
            }
        }

        public void LoadEmploeeyInfo(Employee e)
        {
            tbxFirstName.Text = e.FirstName;
            tbxLastName.Text = e.LastName;
            tbxEmail.Text = e.Email;
            tbxStreetName.Text = e.PersonAddress.StreetName;
            tbxStreetNumber.Text = e.PersonAddress.StreetNumber;
            tbxZip.Text = e.PersonAddress.Zip;
            tbxCity.Text = e.PersonAddress.City;
            tbxCountry.Text = e.PersonAddress.Country;
            DTPDateOfBirth.Value = e.DateOfBirth.ToDateTime(TimeOnly.Parse("00:00"));
            tbxPhoneNumber.Text = e.PhoneNumber;
            tbxBsn.Text = e.Bsn.ToString();
        }

        public Employee CreateEmployee()
        {
            Employee employee = null;
            if (tbUserControl.SelectedTab == tbUpdateEmployeeInfo)
            {
                Address address = new Address
                {
                    StreetName = tbxStreetName.Text,
                    StreetNumber = tbxStreetNumber.Text,
                    Zip = tbxZip.Text,
                    City = tbxCity.Text,
                    Country = tbxCountry.Text
                };

                 employee = new ManagerEmployees(
                    employees[dataGridViewEmployeeManagers.CurrentCell.RowIndex].Id, tbxFirstName.Text,
                    tbxLastName.Text, tbxEmail.Text, address, DateOnly.FromDateTime(DTPDateOfBirth.Value),
                    tbxPhoneNumber.Text, Convert.ToInt32(tbxBsn.Text), true, tbxEmail.Text, null, null);
            }
            else if (tbUserControl.SelectedTab == tbAddEmployee)
            {
                Address address = new Address
                {
                    StreetName = tbxStreetNameAdd.Text,
                    StreetNumber = tbxStreetNumberAdd.Text,
                    Zip = tbxZipAdd.Text,
                    City = tbxCityAdd.Text,
                    Country = tbxCountryAdd.Text
                };

                employee = new ManagerEmployees(0, tbxFirstNameAdd.Text,
                   tbxLastNameAdd.Text, tbxEmailAdd.Text, address, DateOnly.FromDateTime(DTPDateOfBirthAdd.Value),
                   tbxPhoneNumberAdd.Text, Convert.ToInt32(tbxBsnAdd.Text), true, tbxEmailAdd.Text, null, null);
            }


            return employee;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}

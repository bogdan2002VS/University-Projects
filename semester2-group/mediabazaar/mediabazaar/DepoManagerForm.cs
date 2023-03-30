using Logic.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Logic.interfaces;
using Logic.ClassManagers;
using DataL;
using Logic.Validation;
using DataL.interfaces;

namespace mediabazaar
{
    public partial class DepoManagerForm : Form
    {
        IDepartment _departmentManager = new DepartmentManager();
        IEmployee _employeeManager;
        IManagerRepository _employeeManagerRepository;

        private Employee _employee;
        private Department _selectedDepartment;
        private List<Employee> employees;

        public DepoManagerForm(Employee employee)
        {
            _employee = employee;
            InitializeComponent();

            _employeeManagerRepository = new EmployeeRepository();
            _employeeManager = new EmployeeManager(_employeeManagerRepository, new CredentialsManager(new CredentialsRepository()), new EmployeeValidation());

            RefreshDeparmentsList();

            LoadEmployees();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (tbxDeptName.Text != "")
            {
                Department department = new Department(tbxDeptName.Text);
                if (_departmentManager.AddDepartment(department))
                {
                    RefreshDeparmentsList();
                    MessageBox.Show($"Succesfully created department {department.Name}");
                }

            }
            else
            {
                MessageBox.Show("Please enter the department name.");
            }
        }

        private void RefreshDeparmentsList()
        {
            lbxDepts.Items.Clear();

            Department[] departments = _departmentManager.GetDepartments();

            foreach (Department department in departments)
            {
                lbxDepts.Items.Add($"Id: {department.Id}  ||  Name: {department.Name}");
            }
        }

        private void btnSeeDepts_Click(object sender, EventArgs e)
        {
            RefreshDeparmentsList();
        }

        private void btnRemoveDept_Click(object sender, EventArgs e)
        {
            if (lbxDepts.SelectedItems.Count == 1)
            {
                string selectedDepartment = lbxDepts.SelectedItem.ToString();
                Department department = null;
                Department[] departments = _departmentManager.GetDepartments();

                foreach (Department dep in departments)
                {
                    if (($"Id: {dep.Id}  ||  Name: {dep.Name}") == selectedDepartment)
                    {
                        department = dep;
                    }
                }

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete department {department.Name}?", "Deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (_departmentManager.RemoveDepartment(department.Id) != true)
                    {
                        RefreshDeparmentsList();
                        MessageBox.Show("Succesfully removed");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Contact administrator and try again later.");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Deletion cancelled.");
                }
            }
            else
            {
                MessageBox.Show("Please select one department.");
            }
        }

        private void btnModifyDept_Click(object sender, EventArgs e)
        {
            if (lbxDepts.SelectedItems.Count == 1 && tbxDeptName.Text != string.Empty)
            {
                string selectedDepartment = lbxDepts.SelectedItem.ToString();
                Department department = null;
                Department[] departments = _departmentManager.GetDepartments();

                foreach (Department dep in departments)
                {
                    if (($"Id: {dep.Id}  ||  Name: {dep.Name}") == selectedDepartment)
                    {
                        department = dep;
                    }
                }

                _selectedDepartment = department;
                lblSelectedDept.Text = department.Name;
                lblSelectedDeptAssignTab.Text = department.Name;

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to update department {department.Name} to {tbxDeptName.Text}?", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    department.Name = tbxDeptName.Text;
                    if (_departmentManager.UpdateDepartment(department))
                    {
                        RefreshDeparmentsList();
                        MessageBox.Show("Succesfully updated.");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Contact administrator and try again later.");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Update cancelled.");
                }
            }
            else
            {
                MessageBox.Show("Please select one department and enter new name.");
            }
        }

        private void tbxUser_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadEmployees()
        {
            dtgvUsers.Rows.Clear();
            employees = _employeeManager.GetEmployeesOverview().Value.ToList();

            foreach (Employee e in employees)
            {
                dtgvUsers.Rows.Add(e.Id, e.FirstName, e.LastName, e.Email, e.PhoneNumber, e.GetType().Name);
            }
        }

        private void tbxUserSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxUserSearch.Text != string.Empty)
            {
                dtgvUsers.Rows.Clear();

                string[] search = tbxUserSearch.Text.ToLower().Split(" ");

                List<Employee> searchedEmployees = _employeeManager.SearchEmployee(search);

                employees = searchedEmployees;

                foreach (Employee employee in searchedEmployees)
                {
                    dtgvUsers.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.Email, employee.PhoneNumber, employee.GetType().Name);
                }
            }
            else
            {
                LoadEmployees();
            }
        }

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            if (_selectedDepartment != null)
            {
                try
                {
                    bool result = _employeeManager.AssignEmployeeToDepartment(_selectedDepartment.Id, employees[dtgvUsers.CurrentCell.RowIndex].Id);

                    if (result)
                    {
                        MessageBox.Show($"Assigned the employee to {_selectedDepartment.Name}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee and a department");
            }
        }

        private void btnSelectDept_Click(object sender, EventArgs e)
        {
            if (lbxDepts.SelectedItems.Count == 1)
            {
                string selectedDepartment = lbxDepts.SelectedItem.ToString();
                Department department = null;
                Department[] departments = _departmentManager.GetDepartments();

                foreach (Department dep in departments)
                {
                    if (($"Id: {dep.Id}  ||  Name: {dep.Name}") == selectedDepartment)
                    {
                        department = dep;
                    }
                }

                _selectedDepartment = department;
                lblSelectedDept.Text = department.Name;
                lblSelectedDeptAssignTab.Text = department.Name;
            }
            else
            {
                MessageBox.Show("Please select one department.");
            }
        }

        private void btnSeeDepartmentEmployees_Click(object sender, EventArgs e)
        {
            DepartmentEmployees departmentEmployees = new DepartmentEmployees(_selectedDepartment);
            departmentEmployees.Show();
        }

        private void tabDepartmentInfo_Click(object sender, EventArgs e)
        {

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

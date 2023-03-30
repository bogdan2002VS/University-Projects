using DataL;
using DataL.interfaces;
using Logic;
using Logic.ClassManagers;
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
    public partial class DepartmentEmployees : Form
    {
        IManagerRepository _employeeManagerRepository;
        IEmployee _employeeManager;

        Department _selectedDepartment;

        public DepartmentEmployees(Department selectedDepartment)
        {
            InitializeComponent();

            _employeeManagerRepository = new EmployeeRepository();
            _employeeManager = new EmployeeManager(_employeeManagerRepository, new CredentialsManager(new CredentialsRepository()), new EmployeeValidation());

            _selectedDepartment = selectedDepartment;

            LoadEmployees();
        }
        public void LoadEmployees()
        {
            dtgvUsers.Rows.Clear();



            //Result<Employee[]> searchedEmployees = _employeeManager.GetEmployees();

            //foreach (Employee employee in searchedEmployees)
            //{
            //    if (employee.Department.Id == _selectedDepartment.Id)
            //    {
            //        dtgvUsers.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.Email, employee.PhoneNumber, employee.GetType().Name);
            //    }
            //}

        }

        private void DepartmentEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}

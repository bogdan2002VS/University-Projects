using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataL;
using Logic;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.interfaces;

namespace mediabazaar
{
    public partial class EmployeeForm : Form
    {
        private Employee employee;

        private IAbsenceManager absenceManager;
        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            absenceManager = new AbsenceManager(new AbsenceRepository());

            lbEmployeeNameValue.Text = employee.FirstName;
        }
    }
}

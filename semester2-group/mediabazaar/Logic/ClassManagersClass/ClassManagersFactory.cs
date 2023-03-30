using DataL;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Logic.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Factory
{
    public class ClassManagers
    {
        public static IAbsenceManager AbsenceManager { get; } = new AbsenceManager(new AbsenceRepository());
        public static ICredentialsManager CredentialsManager { get; } = new CredentialsManager(new CredentialsRepository());
        public static IDepartment DepartmentManager { get; } = new DepartmentManager();
        public static IEmployee EmployeeManager { get; } = new EmployeeManager(new EmployeeRepository(), CredentialsManager, new EmployeeValidation());
        public static IProduct ProductManager { get; } = new ProductManager(new ProductRepository());
        public static IShiftManager ShiftManager { get; } = new ShiftManager(new ShiftRepository(), new EmployeeManager(new EmployeeRepository(), CredentialsManager, new EmployeeValidation()));

        public ClassManagers()
        {
            SetEvents();
        }

        public void SetEvents()
        {
            EmployeeManager.EmployeeAdded += new EmailSender().OnEmployeeAdded;
        }
    }
}

using DataL;
using DataL.DTO;
using DataL.interfaces;
using FluentValidation;
using Logic.CustomEventArgs;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Logic.Pool;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Logic.ClassManagers
{
    public class EmployeeManager : IEmployee, IHR, IShiftEmployeeManager
    {
        private readonly IManagerRepository managerRepository;
        private readonly ICredentialsManager credentialsManager;
        private readonly IValidator<Employee> employeeValidation;
        //private List<Employee> allEmployees;
        private static EmployeeManager instance;
        private List<RFIDControl> rFIDcontrols;

        public event EventHandler<EmployeeArgs> EmployeeAdded;

        public EmployeeManager(IManagerRepository imanagerRepository, ICredentialsManager credentialsManager, IValidator<Employee> employeeValidation)
        {
            managerRepository = imanagerRepository;
            this.credentialsManager = credentialsManager;
            this.employeeValidation = employeeValidation;
        }

        public static EmployeeManager GetInstance()
        {
            if (instance == null)
                instance = new EmployeeManager();
            return instance;
        }
        public EmployeeManager()
        {

            //allEmployees = GetEmployees().Value.ToList();
            rFIDcontrols = GetRFIDcontrols();

        }

        public Result<Employee[]> GetEmployees()
        {
            List<EmployeeDTO> employeeDTOs = managerRepository.GetEmployees();
            Employee[] employees = ConverterPool.GetConverter<Employee, EmployeeDTO>().Convert(employeeDTOs);

            return Result<Employee[]>.Ok(employees);
        }

        public Result<Employee[]> GetEmployeesOverview()
        {
            List<EmployeeDTO> employeeDTOs = managerRepository.GetEmployeesOverView();
            Employee[] employees = ConverterPool.GetConverter<Employee, EmployeeDTO>().Convert(employeeDTOs);

            return Result<Employee[]>.Ok(employees);
        }

        public Result<bool> AddEmployee(Employee e)
        {
            var validation =  employeeValidation.Validate(e, options => options.ThrowOnFailures());

            if (!validation.IsValid)
                return Result<bool>.Fail(new ArgumentException("Something went wrong while validating"));

            if (credentialsManager.CheckUsername(e.EmployeeCredentials.Username))
                return Result<bool>.Fail(new ArgumentException("That username already exists"));
                
            EmployeeDTO employeeDTO = ConverterPool.GetConverter<Employee, EmployeeDTO>().Convert(e);

            int employeeId = managerRepository.AddEmployee(employeeDTO);

            bool success = false;
            if (employeeId != 0)
            {
                e.Id = employeeId;
                OnEmployeeAdded(this, new EmployeeArgs { Employee = e });

                success = true;
            }

            return Result<bool>.Ok(success);
        }

        public Result<Employee> GetEmployee(int id)
        {
            EmployeeDTO employeeDTO = managerRepository.GetEmployee(id);

            Employee employee = ConverterPool.GetConverter<Employee, EmployeeDTO>().Convert(employeeDTO);

            return Result<Employee>.Ok(employee);
        }

        public Result<Employee[]> GetEmployeesManagers()
        {
            List<EmployeeDTO> employeeDTOs = managerRepository.GetEmployeesManagers();
            Employee[] employees = ConverterPool.GetConverter<Employee, EmployeeDTO>().Convert(employeeDTOs);

            return Result<Employee[]>.Ok(employees);
        }

        public Result<Absence[]> GetEmployeeAbsences(int id)
        {
            List<AbsenceDTO> absenceDTOs = managerRepository.GetEmployeeAbsences(id);
            Absence[] absences = ConverterPool.GetConverter<Absence, AbsenceDTO>().Convert(absenceDTOs);

            return Result<Absence[]>.Ok(absences);
        }

        public Result<Shift[]> GetEmployeeShifts(int id)
        {
            List<ShiftDTO> shiftDTOs = managerRepository.GetEmployeeShifts(id);
            Shift[] shifts = ConverterPool.GetConverter<Shift, ShiftDTO>().Convert(shiftDTOs);

            return Result<Shift[]>.Ok(shifts);
        }

        public Result<IEnumerable<Employee>> GetEmployeesShiftsAbsences()
        {
            IEnumerable<EmployeeDTO> employeeDTOs = managerRepository.GetEmployeesShiftsAbsences();
            List<Employee> employees = new List<Employee>();

            foreach (EmployeeDTO employeeDTO in employeeDTOs)
            {
                Shift[] shifts = ConverterPool.GetConverter<Shift, ShiftDTO>().Convert(employeeDTO.ShiftDTOs);
                Absence[] absences = ConverterPool.GetConverter<Absence, AbsenceDTO>().Convert(employeeDTO.AbsenceDTOs);

                Employee employee = ConverterPool.GetConverter<Employee, EmployeeDTO>().Convert(employeeDTO);

                employee.Shifts = shifts.ToList();
                employee.Absences = absences.ToList();

                employees.Add(employee);
            }

            return Result<IEnumerable<Employee>>.Ok(employees);
        }

        public Result<Warnings[]> GetEmployeeWarnings(int id)
        {
            List<WarningDTO> warningDTOs = managerRepository.GetEmployeeWarnings(id);
            Warnings[] warnings = ConverterPool.GetConverter<Warnings, WarningDTO>().Convert(warningDTOs);

            return Result<Warnings[]>.Ok(warnings);
        }

        public bool RemoveEmployee(int id, Type type)
        {
            string typeS = null;

            if (type == typeof(Employee))
            {
                typeS = "Employees";
            }
            else if (type == typeof(ManagerEmployees))
            {
                typeS = "Manager";
            }
            else if (type == typeof(StockManager))
            {
                typeS = "StockManager";
            }
            else if (type == typeof(DepoManager))
            {
                typeS = "DepoManager";
            }

            return managerRepository.RemoveEmployee(id, typeS);
        }

        public Result<bool> UpdateEmployee(Employee employee)
        {
            var validation = employeeValidation.Validate(employee, options => options.ThrowOnFailures());

            if (!validation.IsValid)
                return Result<bool>.Fail(new ArgumentException("Something went wrong while validating"));

            EmployeeDTO employeeDTO = ConverterPool.GetConverter<Employee, EmployeeDTO>().Convert(employee);
            //employeeDTO.Id = employee.Id;

            bool result = managerRepository.UpdateEmployee(employeeDTO);

            return Result<bool>.Ok(result);
        }

        public void AddRFID(RFIDControl rfid)
        {
            rFIDcontrols.Add(rfid);
        }

        public RFIDControl GetRFIDcontrolBySerial(string serial)
        {
            RFIDControl rfid = null;
            foreach (RFIDControl rFIDcontrol in rFIDcontrols)
            {
                if (rFIDcontrol.SerialNumber == serial)
                {
                    rfid = rFIDcontrol;
                }
            }
            return rfid;
        }

        public List<RFIDControl> GetRFIDcontrols()
        {
            return rFIDcontrols;
        }


        public List<Employee> SearchEmployee(string[] textSearch)
        {
            List<Employee> employees = SearchSystem<Employee>.Search(textSearch, GetEmployees().Value.ToList());

            return employees;
        }

        protected virtual void OnEmployeeAdded(object sender, EmployeeArgs employeeArgs)
        {
            if (EmployeeAdded != null)
                EmployeeAdded(sender, employeeArgs);
        }

        public bool AssignEmployeeToDepartment(int departmentId, int userId)
        {
            return managerRepository.AssignEmployeeToDepartment(departmentId, userId);
        }
    }
}
using DataL;
using DataL.DTO;
using DataL.interfaces;
using DataL.MockRepository;
using Logic;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestGetEmployeeDTO()
        //{
        //    DBHelperEmployee db = new DBHelperEmployee();

        //    EmployeeDTO employee = db.GetEmployee(2);

        //    Assert.AreEqual("teste", employee.Username);
        //}

        //[TestMethod]
        //public void TestGetEmployeesShifts()
        //{
        //    DBHelperEmployee db = new DBHelperEmployee();

        //    List<ShiftDTO> shifts = db.GetEmployeeShifts(2);

        //    Assert.AreEqual(2, shifts.Count);
        //}

        //[TestMethod]
        //public void TestGetEmployeesWarnings()
        //{
        //    DBHelperEmployee db = new DBHelperEmployee();

        //    List<WarningDTO> warnings = db.GetEmployeeWarnings(2);

        //    Assert.AreEqual(1, warnings.Count);
        //}

        //[TestMethod]
        //public void TestGetEmployeeAbsences()
        //{
        //    DBHelperEmployee db = new DBHelperEmployee();

        //    List<AbsenceDTO> absences = db.GetEmployeeAbsences(2);

        //    Assert.AreEqual(1, absences.Count);
        //}

        //[TestMethod]
        //public void TestGetEmployeeNOTDTO()
        //{
        //    IManagerRepository managerRepository = new EmployeeRepository();

        //    IEmployee employee = new EmployeeManager(managerRepository);

        //    Employee employee1 = employee.GetEmployee(2);

        //    Assert.AreEqual("teste", employee1.EmployeeCredentials.Username);
        //}

        //[TestMethod]
        //public void TestAssignShift()
        //{
        //    IManagerRepository managerRepository = new EmployeeRepository();

        //    IEmployee employee = new EmployeeManager(managerRepository);

        //    DateTime date = DateTime.Now;
        //    Shift shift = new Shift(date, date);

        //    bool shiftassigned = employee.AssignShift(2, shift);

        //    Assert.AreEqual(true, shiftassigned);
        //}

        //[TestMethod]
        //public void TestAddEmployee()
        //{
        //    IManagerRepository managerRepository = new EmployeeRepository();

        //    IEmployee employee = new EmployeeManager(managerRepository);

        //    DateTime date = DateTime.Now;
        //    Shift shift = new Shift(date, date);

        //    bool shiftassigned = employee.AssignShift(2, shift);

        //    Assert.AreEqual(true, shiftassigned);
        //}

        //[TestMethod]
        //public void TestAddProduct()
        //{
        //    IProductRepository productRepository = new ProductRepository();

        //    IProduct product = new ProductManager(productRepository);

        //    Product product1 = new Product(0, 22, 22, "asdasd", "asdasd", "asdasd", 22, 22, 22, "sdasda", 22, 22, (ProductState)1, "sasdasd", 22);

        //    bool test = product.AddProduct(product1);

        //    Assert.AreEqual(true, test);
        //}

        //[TestMethod]ms
        //public void TestGetEmployee()
        //{
        //    IManagerRepository managerRepository = new EmployeeRepository();

        //    IEmployee employee = new EmployeeManager(managerRepository);
        //    Employee selectedEmployee = employee.GetEmployee(10);


        //    Assert.AreEqual("tesfsdf", selectedEmployee.FirstName);
        //}

        //[TestMethod]
        //public void TestUpdatePassword()
        //{
        //    IPassword iPassword = new CredentialsRepository();

        //    Credentials c = new Credentials(iPassword);
        //    bool success = c.Ipassword.UpdatePassword(17, "password");


        //    Assert.AreEqual(true, success);
        //}

        //[TestMethod]
        //public void TestAddEmployeeManager()
        //{
        //    HRRepository hrrep = new HRRepository();

        //    EmployeeDTO employee = new EmployeeDTO("teste", "teste", "teste", "teste", "etestes", "dasdassd", "asdsda", "asdasd", DateOnly.Parse("2009-03-03"), "asdasd", 222, true, "teste4", "teste4", "asdasda", 4);

        //    bool success = hrrep.AddEmployeeManager(employee);

        //    Assert.AreEqual(true, success);
        //}

        //[TestMethod]
        //public void TestGetEmployeeManager()
        //{
        //    HRRepository hrrep = new HRRepository();

        //    EmployeeDTO employee = hrrep.GetEmployeeManager(48);

        //    Assert.AreEqual("teste", employee.Email);
        //}

        //[TestMethod]
        //public void TestGetEmployeeManagers()
        //{
        //    HRRepository hrrep = new HRRepository();

        //    List<EmployeeDTO> employee = hrrep.GetEmployeeManagers();

        //    Assert.AreEqual(1, employee.Count);
        //}

        //[TestMethod]
        //public void TestUpdateEmployee()
        //{
        //    HRRepository hrrep = new HRRepository();

        //    EmployeeDTO employee = new EmployeeDTO(48, "teste2", "teste", "teste", "teste", "etestes", "dasdassd", "asdsda", "asdasd", DateOnly.Parse("2009-03-03"), "asdasd", 222, true, "teste4", "teste4", "asdasda", 3232);

        //    bool success = hrrep.UpdateEmployeeManager(employee);

        //    Assert.AreEqual(true, success);
        //}

        //[TestMethod]
        //public void TestRemoveEmployee()
        //{
        //    HRRepository hrrep = new HRRepository();

        //    bool success = hrrep.RemoveEmployeeManager(48);

        //    Assert.AreEqual(true, success);
        //}

        //[TestMethod]
        //public void TestAutomaticSchedule()
        //{
        //    IEmployee employeemanager = new EmployeeManager(new AbsenceManagerMockRep());

        //    Shift s = new Shift
        //    {
        //        Id = 4,
        //        Start = DateTime.Now.AddDays(2),
        //        End = DateTime.Now.AddDays(3),
        //        MaxCashier = 2,
        //        MaxSecurity = 2
        //    };
        //    List<Employee> success = employeemanager.AutomaticShift(s);

        //    Assert.AreEqual(s.MaxSecurity + s.MaxCashier, success.Count);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void TestAutomaticScheduleDB()
        //{
        //    IEmployee employeemanager = new EmployeeManager(new EmployeeRepository());

        //    Shift s = new Shift
        //    {
        //        Id = 1003,
        //        Start = DateTime.Now.AddDays(2),
        //        End = DateTime.Now.AddDays(3),
        //        MaxCashier = 2,
        //        MaxSecurity = 3,
        //        MaxStockManager = 4,
        //        MaxDepoManager = 5,
        //        MaxEmployeeManager = 3,
        //        MaxHR = 1
        //    };
        //   // bool success = employeemanager.AutomaticShift(s);

        //    //Assert.AreEqual(true, success);
        //}
    }
}
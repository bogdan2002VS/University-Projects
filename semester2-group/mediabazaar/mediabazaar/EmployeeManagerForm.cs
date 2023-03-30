using DataL;
using DataL.interfaces;
using Logic;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.Factory;
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
    public partial class EmployeeManagerForm : Form
    {
        IManagerRepository employeeManagerRepository;
        IEmployee employeeManager;
        IShiftManager shiftManager;
        IAbsenceManager absenceManager;

        List<Employee> employees;
        List<Shift> shifts;
        private Employee employee;
        public EmployeeManagerForm(Employee employee)
        {
            InitializeComponent();
            employeeManagerRepository = new EmployeeRepository();
            employeeManager = new EmployeeManager(employeeManagerRepository, new CredentialsManager(new CredentialsRepository()), new EmployeeValidation());

            shiftManager = new ShiftManager(new ShiftRepository(), new EmployeeManager(employeeManagerRepository, new CredentialsManager(new CredentialsRepository()), new EmployeeValidation()));
            absenceManager = new AbsenceManager(new AbsenceRepository());

            this.employee = employee;
            employees = new List<Employee>();
            shifts = new List<Shift>();

            LoadEmployees();

            shiftManager.ShiftHandler += LoadShiftsEvent;
            absenceManager.AbsenceHandler += LoadAbsencesEvent;
            employeeManager.EmployeeAdded += new EmailSender().OnEmployeeAdded;
        }

        private void EmployeeManager_Load(object sender, EventArgs e)
        {

        }

        private void dataGVEmployee_Click(object sender, EventArgs e)
        {
            if (dataGVEmployee.CurrentCell.RowIndex != -1)
            {
                Employee selectedEmployee = employeeManager.GetEmployee(employees[dataGVEmployee.CurrentCell.RowIndex].Id).Value ?? new Employee();
                if (tbControlEmployeeManager.SelectedTab == tabEmployeeInfo)
                {
                    lbUserFirstName.Text = string.Empty;
                    lbUserLastName.Text = string.Empty;
                    lbEmail.Text = string.Empty;
                    lbUserStreetName.Text = string.Empty;
                    lbUserStreetNumber.Text = string.Empty;
                    lbUserZIP.Text = string.Empty;
                    lbUserCity.Text = string.Empty;
                    lbCountry.Text = string.Empty;
                    lbUserBirthday.Text = string.Empty;
                    lbPhoneNumber.Text = string.Empty;
                    lbUserBsn.Text = string.Empty;

                    lbUserFirstName.Text = "First Name: " + selectedEmployee.FirstName;
                    lbUserLastName.Text = "Last Name: " + selectedEmployee.LastName;
                    lbEmail.Text = "Email: " + selectedEmployee.Email;
                    lbUserStreetName.Text = "Street Name: " + selectedEmployee.PersonAddress.StreetName;
                    lbUserStreetNumber.Text = "Street Number: " + selectedEmployee.PersonAddress.StreetNumber;
                    lbUserZIP.Text = "Zip: " + selectedEmployee.PersonAddress.Zip;
                    lbUserCity.Text = "City: " + selectedEmployee.PersonAddress.City;
                    lbCountry.Text = "Country: " + selectedEmployee.PersonAddress.Country;
                    lbUserBirthday.Text = "Birthday: " + selectedEmployee.DateOfBirth;
                    lbPhoneNumber.Text = "Phone Number: " + selectedEmployee.PhoneNumber;
                    lbUserBsn.Text = "BSN: " + selectedEmployee.Bsn;
                }
                else if (tbControlEmployeeManager.SelectedTab == TabAddUpdateEmployee)
                {
                    tbxFirstName.Text = string.Empty;
                    tbxLastName.Text = string.Empty;
                    tbxEmail.Text = string.Empty;
                    tbxStreetName.Text = string.Empty;
                    tbxStreetNumber.Text = string.Empty;
                    tbxZip.Text = string.Empty;
                    tbxCity.Text = string.Empty;
                    tbxCountry.Text = string.Empty;
                    tbxBirthday.Text = string.Empty;
                    tbxPhoneNumber.Text = string.Empty;
                    tbxBSN.Text = string.Empty;

                    tbxFirstName.Text = selectedEmployee.FirstName;
                    tbxLastName.Text = selectedEmployee.LastName;
                    tbxEmail.Text = selectedEmployee.Email;
                    tbxStreetName.Text = selectedEmployee.PersonAddress.StreetName;
                    tbxStreetNumber.Text = selectedEmployee.PersonAddress.StreetNumber;
                    tbxZip.Text = selectedEmployee.PersonAddress.Zip;
                    tbxCity.Text = selectedEmployee.PersonAddress.City;
                    tbxCountry.Text = selectedEmployee.PersonAddress.Country;
                    tbxBirthday.Text = selectedEmployee.DateOfBirth.ToString();
                    tbxPhoneNumber.Text = selectedEmployee.PhoneNumber;
                    tbxBSN.Text = selectedEmployee.Bsn.ToString();
                    if (selectedEmployee.GetType() == typeof(Security))
                    {
                        cbEmployeeType.SelectedIndex = 0;
                    }
                    else if (selectedEmployee.GetType() == typeof(Cashier))
                    {
                        cbEmployeeType.SelectedIndex = 1;
                    }
                    else if (selectedEmployee.GetType() == typeof(StockManager))
                    {
                        cbEmployeeType.SelectedIndex = 2;
                    }
                    else if (selectedEmployee.GetType() == typeof(DepoManager))
                    {
                        cbEmployeeType.SelectedIndex = 3;
                    }

                }
            }
            else
            {
                MessageBox.Show("Select an Employee");
            }
        }

        private void btnAddShifts_Click(object sender, EventArgs e)
        {
            try
            {
                CreateShift createShiftForm = new CreateShift(shiftManager);
                createShiftForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lbxShift_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Gray);//Choose the color


            e.DrawBackground();

            Shift selectedItem = (Shift)lbxShift.Items[e.Index];

            SolidBrush solidBrush = new SolidBrush(Color.Red);

            if (selectedItem.IsFull)
            {
                solidBrush = new SolidBrush(Color.DarkOliveGreen);
            }

            e.Graphics.DrawString(lbxShift.Items[e.Index].ToString(), new Font("Segoe UI", 9, FontStyle.Bold), solidBrush, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        private void btnSeeShifts_Click(object sender, EventArgs e)
        {
            if (dataGVEmployee.CurrentCell.RowIndex != -1)
            {
                try
                {
                    Result<Shift[]> result = employeeManager.GetEmployeeShifts(employees[dataGVEmployee.CurrentCell.RowIndex].Id);
                    
                    lbxShifts.Items.Clear();
                    if (result.Value.Length != 0)
                    {
                        foreach (Shift s in result.Value)
                        {
                            lbxShifts.Items.Add(s.ToString());
                        }
                    }
                    else
                    {
                        lbxShifts.Items.Add("No shifts");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void lbxShifts_DoubleClick(object sender, EventArgs e)
        {
            Result<Shift[]> result = employeeManager.GetEmployeeShifts(employees[dataGVEmployee.CurrentCell.RowIndex].Id);
            shifts = result.Value.ToList();

            if (result.Value.Length != 0)
            {
                if (lbxShifts.SelectedIndex != -1)
                {
                    MessageBox.Show($"Start:{shifts[lbxShifts.SelectedIndex].Start}\nEnd:{shifts[lbxShifts.SelectedIndex].End}");
                }
                else
                {
                    MessageBox.Show("Select a Shift");
                }
            }        
        }

        private void btnSeeAbsences_Click(object sender, EventArgs e)
        {
            if (dataGVEmployee.CurrentCell.RowIndex != -1)
            {
                try
                {
                    Result<Absence[]> result = employeeManager.GetEmployeeAbsences(employees[dataGVEmployee.CurrentCell.RowIndex].Id);

                    lbxAbsences.Items.Clear();
                    if (result.Value.Length != 0)
                    {
                        foreach (Absence a in result.Value)
                        {
                            lbxAbsences.Items.Add(a.ToString());
                        }
                        Array.Clear(result.Value);
                    }
                    else
                    {
                        lbxAbsences.Items.Add("No absences");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select an Employee");
            }
        }

        private void lbxAbsences_DoubleClick(object sender, EventArgs e)
        {
            Result<Absence[]> result = employeeManager.GetEmployeeAbsences(employees[dataGVEmployee.CurrentCell.RowIndex].Id);
            if (result.Value.Length != 0)
            {
                if (lbxAbsences.SelectedIndex != -1)
                {
                    MessageBox.Show($"Employee Id: {result.Value[lbxAbsences.SelectedIndex].Employee.Id}\nDate: {result.Value[lbxAbsences.SelectedIndex].Date}\n" +
                    $"Absence Reason: {result.Value[lbxAbsences.SelectedIndex].AbsenceReason}\nAbsence Description {result.Value[lbxAbsences.SelectedIndex].AbsenceDescription}\n" +
                    $"Status: {result.Value[lbxAbsences.SelectedIndex].TicketStatus}");
                }
                else
                {
                    MessageBox.Show("Select an Absence");
                }
            }
        }

        private void btnWarnings_Click(object sender, EventArgs e)
        {
            if (dataGVEmployee.CurrentCell.RowIndex != -1)
            {
                try
                {
                    Result<Warnings[]> result = employeeManager.GetEmployeeWarnings(employees[dataGVEmployee.CurrentCell.RowIndex].Id);

                    lbxWarnings.Items.Clear();
                    if (result.Value.Length != 0)
                    {
                        foreach (Warnings w in result.Value)
                        {
                            lbxWarnings.Items.Add($"Reason: {w.Reson}");
                        }
                    }
                    else
                    {
                        lbxWarnings.Items.Add("No warnings");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void lbxWarnings_DoubleClick(object sender, EventArgs e)
        {
            Result<Warnings[]> result = employeeManager.GetEmployeeWarnings(employees[dataGVEmployee.CurrentCell.RowIndex].Id);
            if (result.Value.Length != 0)
            {
                if (lbxWarnings.SelectedIndex != -1)
                {
                    MessageBox.Show($"Reason: {result.Value[lbxWarnings.SelectedIndex].Reson}");
                }
                else
                {
                    MessageBox.Show("Select a Warning");
                }
            }
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
                    return;
                }

                if (success.Success == true)
                {
                    MessageBox.Show("Employee Added Correctly");
                    LoadEmployees();
                }
            }
            catch(FormatException fx)
            {
                MessageBox.Show("Some value has not been inserter correctly");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifyEmployeeInfo_Click_1(object sender, EventArgs e)
        {
            if (dataGVEmployee.CurrentCell.RowIndex != -1)
            {
                try
                {
                    Employee employee = CreateEmployee();

                    if (employee != null)
                    {
                        employee.Id = employees[dataGVEmployee.CurrentCell.RowIndex].Id;

                        Result<bool> result = employeeManager.UpdateEmployee(employee);

                        if (result.Success == true)
                        {
                            MessageBox.Show("Employee Information Updated Correctly");
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("Employee Information not Updated");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dataGVEmployee.CurrentCell.RowIndex != -1)
            {
                try
                {
                    bool success = employeeManager.RemoveEmployee(employees[dataGVEmployee.CurrentCell.RowIndex].Id, employees[dataGVEmployee.CurrentCell.RowIndex].GetType());

                    if (success == true)
                    {
                        MessageBox.Show("Employee Removed");
                        LoadEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Employee not Removed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pleasse select an employee");
            }
        }

        private void lbEmployees_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnAssignShiftToEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxShift.SelectedIndex != -1 && dataGVEmployee.CurrentCell.RowIndex != -1)
                {
                    var selectedRows = dataGVEmployee.SelectedRows;

                    if (selectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow row in selectedRows)
                        {
                            Result<bool> success = shiftManager.AssignShift((int)row.Cells[0].Value, (Shift)lbxShift.SelectedItem);

                            if (success.IsExceptionType<ArgumentException>())
                            {
                                MessageBox.Show(success.Exception.Message);
                                return;
                            }
                        }

                        MessageBox.Show("Shift Assigned");
                    }
                    else
                    {
                        MessageBox.Show("Please select an employee");
                    }
                }
                else
                {
                    MessageBox.Show("Select an employee and a shift");
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAutomaticSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbxShift.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Shift");
                }
                else
                {
                    Result<bool> success = shiftManager.AutomaticShift((Shift)lbxShift.SelectedItem);

                    if (success.IsExceptionType<ArgumentException>())
                    {
                        MessageBox.Show(success.Exception.Message);
                        return;
                    }

                    if (success.Success == true)
                    {
                        MessageBox.Show("Shifted automaticly assigned");
                    }
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong" + ex.Message);
            }
        }

        private void lbxShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxShift.SelectedIndex != -1)
                {
                    Shift currentShift = (Shift)lbxShift.SelectedItem;

                    lbxShiftEmployees.DataSource = shiftManager.GetShiftEmployees(currentShift).Value;

                }
                else
                {
                    MessageBox.Show("Select a shift");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbxShift_DoubleClick(object sender, EventArgs e)
        {
            Shift shift = (Shift)lbxShift.SelectedItem;

            MessageBox.Show($"Start: {shift.Start} \n " +
                $"End: {shift.End} \n" +
                $" \n" +
                $"-------Employees Settings------- \n" +
                $" \n" +
                $"Max Cashier: {shift.MaxCashier} \n" +
                $"Max Security: {shift.MaxSecurity} \n" +
                $"Max StockManager: {shift.MaxStockManager} \n" +
                $"Max Department Manager: {shift.MaxDepoManager} \n" +
                $"Max Employee Manager: {shift.MaxEmployeeManager} \n" +
                $"Max HR: {shift.MaxHR} \n");
        }

        private void tbxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchEmployee.Text != string.Empty)
            {
                dataGVEmployee.Rows.Clear();

                string[] search = tbxSearchEmployee.Text.ToLower().Split(" ");

                List<Employee> searchedEmployees = employeeManager.SearchEmployee(search);

                employees = searchedEmployees;

                foreach (Employee employee in searchedEmployees)
                {
                    dataGVEmployee.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.Email, employee.PhoneNumber, employee.GetType().Name);
                }
            }
            else
            {
                LoadEmployees();
            }
        }

        private void lbxEmployeeAbsences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxEmployeeAbsences.SelectedIndex != -1)
            {
                btnSeeAbsence.Visible = true;
            }
        }

        private void btnSeeAbsence_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxEmployeeAbsences.SelectedIndex != -1)
                {
                    Absence selectedAbsence = (Absence)lbxEmployeeAbsences.SelectedItem;

                    AbsenceDetails absenceDetails = new AbsenceDetails(selectedAbsence, absenceManager);
                    absenceDetails.Show();
                }
                else
                {
                    MessageBox.Show("You need to select an absence"); ;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Employee CreateEmployee()
        {
            Employee employee = null;

            Address employeeAddress = new Address()
            {
                StreetName = tbxStreetName.Text,
                StreetNumber = tbxStreetNumber.Text,
                Zip = tbxZip.Text,
                City = tbxCity.Text,
                Country = tbxCountry.Text
            };

            if (cbEmployeeType.SelectedIndex != -1)
            {
                if (cbEmployeeType.SelectedIndex == 0)
                {
                    employee = new Security(tbxFirstName.Text, tbxLastName.Text,
                        tbxEmail.Text, employeeAddress, DateOnly.Parse(tbxBirthday.Text),
                        tbxPhoneNumber.Text, Convert.ToInt32(tbxBSN.Text), true, tbxEmail.Text, string.Empty, string.Empty);
                }
                else if (cbEmployeeType.SelectedIndex == 1)
                {
                    employee = new Cashier(tbxFirstName.Text, tbxLastName.Text,
                        tbxEmail.Text, employeeAddress, DateOnly.Parse(tbxBirthday.Text),
                        tbxPhoneNumber.Text, Convert.ToInt32(tbxBSN.Text), true, tbxEmail.Text, string.Empty, string.Empty);
                }
                else if (cbEmployeeType.SelectedIndex == 2)
                {
                    employee = new StockManager(tbxFirstName.Text, tbxLastName.Text,
                        tbxEmail.Text, employeeAddress, DateOnly.Parse(tbxBirthday.Text),
                        tbxPhoneNumber.Text, Convert.ToInt32(tbxBSN.Text), true, tbxEmail.Text, string.Empty, string.Empty);
                }
                else if (cbEmployeeType.SelectedIndex == 3)
                {
                    employee = new DepoManager(tbxFirstName.Text, tbxLastName.Text,
                        tbxEmail.Text, employeeAddress, DateOnly.Parse(tbxBirthday.Text),
                        tbxPhoneNumber.Text, Convert.ToInt32(tbxBSN.Text), true, tbxEmail.Text, string.Empty, string.Empty);
                }

            }
            else
            {
                MessageBox.Show("Please choose an employee type");
                employee = null;
            }


            return employee;
        }

        //////////////////////////////////////////////////////////////
        /////////////////////SIDE BUTTONS/////////////////////////////
        //////////////////////////////////////////////////////////////
        private void btnEmployeeInfo_Click(object sender, EventArgs e)
        {
            tbControlEmployeeManager.SelectedTab = tabEmployeeInfo;
        }

        private void btnAddUpdateEmployee_Click(object sender, EventArgs e)
        {
            tbControlEmployeeManager.SelectedTab = TabAddUpdateEmployee;
            if (cbEmployeeType.Items.Count == 0)
            {
                LoadEnums();
            }
        }

        private void btnAddAbsence_Click(object sender, EventArgs e)
        {
            tbControlEmployeeManager.SelectedTab = tabAddAbsence;
            LoadAbsences();
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            tbControlEmployeeManager.SelectedTab = tabAddShift;
            if (lbxShift.Items.Count == 0)
            {
                LoadShifts();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        //////////////////////////////////////////////////////////////
        /////////////////////CustomEvents//////////////////////////////////
        //////////////////////////////////////////////////////////////
        ///

        public void LoadShiftsEvent(bool value)
        {
            if (value)
            {
                LoadShifts();
            }
        }

        public void LoadAbsencesEvent(bool success)
        {
            if (success)
            {
                LoadAbsences();
            }
        }

        //////////////////////////////////////////////////////////////
        /////////////////////LOADERS//////////////////////////////////
        //////////////////////////////////////////////////////////////
        ////
        public void LoadEmployees()
        {
            dataGVEmployee.Rows.Clear();
            employees = employeeManager.GetEmployeesOverview().Value.ToList();

            foreach(Employee e in employees)
            {
                dataGVEmployee.Rows.Add(e.Id, e.FirstName, e.LastName, e.Email, e.PhoneNumber, e.GetType().Name);
            }
        }

        public void LoadEnums()
        {
            cbEmployeeType.Items.Clear();

            for (int i = 0; i < Enum.GetValues(typeof(EmployeeType)).Length - 2; i++)
            {
                cbEmployeeType.Items.Add(Enum.GetValues(typeof(EmployeeType)).GetValue(i));
            }
        }

        public void LoadShifts()
        {
            lbxShift.Items.Clear();
            shifts = shiftManager.GetShifts().Value.ToList();

            foreach (Shift shifts in shifts)
            {
                lbxShift.Items.Add(shifts);
            }
        }

        public void LoadAbsences()
        {
            lbxEmployeeAbsences.DataSource = absenceManager.GetAbsences();
        }

        private void btnUploadSerialNumber_Click(object sender, EventArgs e)
        {
            bool isExisted = true;
            if (EmployeeManager.GetInstance().GetRFIDcontrols().Count == 0)
            {
                EmployeeManager.GetInstance().AddRFID(new RFIDControl(tbRFIDSerial.Text.Trim(), false));
                MessageBox.Show($"{tbRFIDSerial.Text.Trim()} is uploaded");
            }
            else
            {
                foreach (RFIDControl rFIDcontrol in EmployeeManager.GetInstance().GetRFIDcontrols())
                {
                    if (rFIDcontrol.ToString() == tbRFIDSerial.Text.Trim())
                    {
                        MessageBox.Show("This serial number is already existed!");
                        isExisted = true;
                        break;
                    }
                    else
                    {
                        isExisted = false;
                    }
                }

                if (!isExisted)
                {
                    EmployeeManager.GetInstance().AddRFID(new RFIDControl(tbRFIDSerial.Text.Trim(), false));
                    MessageBox.Show($"{tbRFIDSerial.Text.Trim()} is uploaded");
                }
            }
        }

        private void btnAssignRFID_Click(object sender, EventArgs e)
        {
            Employee emp = null;

            //foreach (Employee employee in EmployeeManager.GetInstance().GetEmployees())
            //{
            //    if (id == employee.Id)
            //    {
            //        emp = employee;
            //    }
            //}
            if (emp != null)
            {
                RFIDControl rfid = EmployeeManager.GetInstance().GetRFIDcontrolBySerial(tbRFIDSerial.Text);

                try
                {
                    if (!rfid.IsAssigned)
                    {
                        if (emp.Rfid != null)
                        {
                            emp.Rfid.IsAssigned = false; // previous rfid gets available again
                        }
                        emp.Rfid = rfid; // get new rfid number
                        rfid.IsAssigned = true; // make it unavailable
                        //EmployeeManager.GetInstance().dataHelperEmployee.UpdateEmployee(emp);
                        MessageBox.Show($"{tbRFIDSerial.Text} is assigned to {emp.FirstName + " " + emp.LastName}");
                    }
                    else
                    {
                        MessageBox.Show("This RFID is already assigned");

                    }
                }

                catch (System.NullReferenceException)
                {
                    MessageBox.Show("This RFID is not assigned to list");
                }
            }
        }
    }
}

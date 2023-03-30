namespace mediabazaar
{
    partial class EmployeeManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbControlEmployeeManager = new System.Windows.Forms.TabControl();
            this.tabEmployeeInfo = new System.Windows.Forms.TabPage();
            this.lbxWarnings = new System.Windows.Forms.ListBox();
            this.lbxAbsences = new System.Windows.Forms.ListBox();
            this.lbxShifts = new System.Windows.Forms.ListBox();
            this.btnWarnings = new System.Windows.Forms.Button();
            this.btnSeeAbsences = new System.Windows.Forms.Button();
            this.btnSeeShifts = new System.Windows.Forms.Button();
            this.lbUserBsn = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbUserBirthday = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbUserCity = new System.Windows.Forms.Label();
            this.lbUserZIP = new System.Windows.Forms.Label();
            this.lbUserStreetNumber = new System.Windows.Forms.Label();
            this.lbUserStreetName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUserLastName = new System.Windows.Forms.Label();
            this.lbUserFirstName = new System.Windows.Forms.Label();
            this.TabAddUpdateEmployee = new System.Windows.Forms.TabPage();
            this.lbType = new System.Windows.Forms.Label();
            this.cbEmployeeType = new System.Windows.Forms.ComboBox();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnModifyEmployeeInfo = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tbxBSN = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxBirthday = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.tbxStreetNumber = new System.Windows.Forms.TextBox();
            this.tbxStreetName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lbAddUpdateEmployeeBSN = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeePhoneNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeBirthday = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeCountry = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeCity = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeZip = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeStreetNumber = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeStreetName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeEmail = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeLastName = new System.Windows.Forms.Label();
            this.lbAddUpdateEmployeeFirstName = new System.Windows.Forms.Label();
            this.tabAddAbsence = new System.Windows.Forms.TabPage();
            this.btnSeeAbsence = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxEmployeeAbsences = new System.Windows.Forms.ListBox();
            this.tabAddShift = new System.Windows.Forms.TabPage();
            this.labShiftEmployees = new System.Windows.Forms.Label();
            this.lbShifts = new System.Windows.Forms.Label();
            this.buttonAutomaticSchedule = new System.Windows.Forms.Button();
            this.btnAssignShiftToEmployee = new System.Windows.Forms.Button();
            this.lbxShiftEmployees = new System.Windows.Forms.ListBox();
            this.lbxShift = new System.Windows.Forms.ListBox();
            this.btnAddShifts = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUploadSerialNumber = new System.Windows.Forms.Button();
            this.btnAssignRFID = new System.Windows.Forms.Button();
            this.lbAssigRfid = new System.Windows.Forms.Label();
            this.tbRFIDSerial = new System.Windows.Forms.TextBox();
            this.btnEmployeeInfo = new System.Windows.Forms.Button();
            this.btnAddUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddAbsence = new System.Windows.Forms.Button();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tbxSearchEmployee = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVEmployee = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbControlEmployeeManager.SuspendLayout();
            this.tabEmployeeInfo.SuspendLayout();
            this.TabAddUpdateEmployee.SuspendLayout();
            this.tabAddAbsence.SuspendLayout();
            this.tabAddShift.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlEmployeeManager
            // 
            this.tbControlEmployeeManager.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbControlEmployeeManager.Controls.Add(this.tabEmployeeInfo);
            this.tbControlEmployeeManager.Controls.Add(this.TabAddUpdateEmployee);
            this.tbControlEmployeeManager.Controls.Add(this.tabAddAbsence);
            this.tbControlEmployeeManager.Controls.Add(this.tabAddShift);
            this.tbControlEmployeeManager.Controls.Add(this.tabPage1);
            this.tbControlEmployeeManager.ItemSize = new System.Drawing.Size(0, 1);
            this.tbControlEmployeeManager.Location = new System.Drawing.Point(234, 2);
            this.tbControlEmployeeManager.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbControlEmployeeManager.Multiline = true;
            this.tbControlEmployeeManager.Name = "tbControlEmployeeManager";
            this.tbControlEmployeeManager.SelectedIndex = 0;
            this.tbControlEmployeeManager.Size = new System.Drawing.Size(608, 497);
            this.tbControlEmployeeManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbControlEmployeeManager.TabIndex = 0;
            // 
            // tabEmployeeInfo
            // 
            this.tabEmployeeInfo.Controls.Add(this.lbxWarnings);
            this.tabEmployeeInfo.Controls.Add(this.lbxAbsences);
            this.tabEmployeeInfo.Controls.Add(this.lbxShifts);
            this.tabEmployeeInfo.Controls.Add(this.btnWarnings);
            this.tabEmployeeInfo.Controls.Add(this.btnSeeAbsences);
            this.tabEmployeeInfo.Controls.Add(this.btnSeeShifts);
            this.tabEmployeeInfo.Controls.Add(this.lbUserBsn);
            this.tabEmployeeInfo.Controls.Add(this.lbPhoneNumber);
            this.tabEmployeeInfo.Controls.Add(this.lbUserBirthday);
            this.tabEmployeeInfo.Controls.Add(this.lbCountry);
            this.tabEmployeeInfo.Controls.Add(this.lbUserCity);
            this.tabEmployeeInfo.Controls.Add(this.lbUserZIP);
            this.tabEmployeeInfo.Controls.Add(this.lbUserStreetNumber);
            this.tabEmployeeInfo.Controls.Add(this.lbUserStreetName);
            this.tabEmployeeInfo.Controls.Add(this.lbEmail);
            this.tabEmployeeInfo.Controls.Add(this.lbUserLastName);
            this.tabEmployeeInfo.Controls.Add(this.lbUserFirstName);
            this.tabEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabEmployeeInfo.Location = new System.Drawing.Point(4, 5);
            this.tabEmployeeInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tabEmployeeInfo.Name = "tabEmployeeInfo";
            this.tabEmployeeInfo.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tabEmployeeInfo.Size = new System.Drawing.Size(600, 488);
            this.tabEmployeeInfo.TabIndex = 0;
            this.tabEmployeeInfo.Text = "tabEmployeeInfo";
            this.tabEmployeeInfo.UseVisualStyleBackColor = true;
            // 
            // lbxWarnings
            // 
            this.lbxWarnings.FormattingEnabled = true;
            this.lbxWarnings.ItemHeight = 17;
            this.lbxWarnings.Location = new System.Drawing.Point(403, 266);
            this.lbxWarnings.Name = "lbxWarnings";
            this.lbxWarnings.Size = new System.Drawing.Size(192, 157);
            this.lbxWarnings.TabIndex = 18;
            this.lbxWarnings.DoubleClick += new System.EventHandler(this.lbxWarnings_DoubleClick);
            // 
            // lbxAbsences
            // 
            this.lbxAbsences.FormattingEnabled = true;
            this.lbxAbsences.ItemHeight = 17;
            this.lbxAbsences.Location = new System.Drawing.Point(206, 266);
            this.lbxAbsences.Name = "lbxAbsences";
            this.lbxAbsences.Size = new System.Drawing.Size(192, 157);
            this.lbxAbsences.TabIndex = 17;
            this.lbxAbsences.DoubleClick += new System.EventHandler(this.lbxAbsences_DoubleClick);
            // 
            // lbxShifts
            // 
            this.lbxShifts.FormattingEnabled = true;
            this.lbxShifts.ItemHeight = 17;
            this.lbxShifts.Location = new System.Drawing.Point(8, 266);
            this.lbxShifts.Name = "lbxShifts";
            this.lbxShifts.Size = new System.Drawing.Size(192, 157);
            this.lbxShifts.TabIndex = 16;
            this.lbxShifts.DoubleClick += new System.EventHandler(this.lbxShifts_DoubleClick);
            // 
            // btnWarnings
            // 
            this.btnWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWarnings.Location = new System.Drawing.Point(403, 227);
            this.btnWarnings.Name = "btnWarnings";
            this.btnWarnings.Size = new System.Drawing.Size(190, 33);
            this.btnWarnings.TabIndex = 15;
            this.btnWarnings.Text = "Warnings";
            this.btnWarnings.UseVisualStyleBackColor = true;
            this.btnWarnings.Click += new System.EventHandler(this.btnWarnings_Click);
            // 
            // btnSeeAbsences
            // 
            this.btnSeeAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeeAbsences.Location = new System.Drawing.Point(206, 227);
            this.btnSeeAbsences.Name = "btnSeeAbsences";
            this.btnSeeAbsences.Size = new System.Drawing.Size(190, 33);
            this.btnSeeAbsences.TabIndex = 14;
            this.btnSeeAbsences.Text = "See Absences";
            this.btnSeeAbsences.UseVisualStyleBackColor = true;
            this.btnSeeAbsences.Click += new System.EventHandler(this.btnSeeAbsences_Click);
            // 
            // btnSeeShifts
            // 
            this.btnSeeShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeeShifts.Location = new System.Drawing.Point(8, 227);
            this.btnSeeShifts.Name = "btnSeeShifts";
            this.btnSeeShifts.Size = new System.Drawing.Size(190, 33);
            this.btnSeeShifts.TabIndex = 13;
            this.btnSeeShifts.Text = "See Shifts";
            this.btnSeeShifts.UseVisualStyleBackColor = true;
            this.btnSeeShifts.Click += new System.EventHandler(this.btnSeeShifts_Click);
            // 
            // lbUserBsn
            // 
            this.lbUserBsn.AutoSize = true;
            this.lbUserBsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserBsn.Location = new System.Drawing.Point(225, 167);
            this.lbUserBsn.Name = "lbUserBsn";
            this.lbUserBsn.Size = new System.Drawing.Size(46, 20);
            this.lbUserBsn.TabIndex = 10;
            this.lbUserBsn.Text = "BSN:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhoneNumber.Location = new System.Drawing.Point(8, 167);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lbPhoneNumber.TabIndex = 9;
            this.lbPhoneNumber.Text = "Phone Number:";
            // 
            // lbUserBirthday
            // 
            this.lbUserBirthday.AutoSize = true;
            this.lbUserBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserBirthday.Location = new System.Drawing.Point(416, 124);
            this.lbUserBirthday.Name = "lbUserBirthday";
            this.lbUserBirthday.Size = new System.Drawing.Size(75, 20);
            this.lbUserBirthday.TabIndex = 8;
            this.lbUserBirthday.Text = "Birthday: ";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(225, 124);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(68, 20);
            this.lbCountry.TabIndex = 7;
            this.lbCountry.Text = "Country:";
            // 
            // lbUserCity
            // 
            this.lbUserCity.AutoSize = true;
            this.lbUserCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserCity.Location = new System.Drawing.Point(36, 124);
            this.lbUserCity.Name = "lbUserCity";
            this.lbUserCity.Size = new System.Drawing.Size(39, 20);
            this.lbUserCity.TabIndex = 6;
            this.lbUserCity.Text = "City:";
            // 
            // lbUserZIP
            // 
            this.lbUserZIP.AutoSize = true;
            this.lbUserZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserZIP.Location = new System.Drawing.Point(416, 76);
            this.lbUserZIP.Name = "lbUserZIP";
            this.lbUserZIP.Size = new System.Drawing.Size(35, 20);
            this.lbUserZIP.TabIndex = 5;
            this.lbUserZIP.Text = "Zip:";
            // 
            // lbUserStreetNumber
            // 
            this.lbUserStreetNumber.AutoSize = true;
            this.lbUserStreetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserStreetNumber.Location = new System.Drawing.Point(225, 76);
            this.lbUserStreetNumber.Name = "lbUserStreetNumber";
            this.lbUserStreetNumber.Size = new System.Drawing.Size(117, 20);
            this.lbUserStreetNumber.TabIndex = 4;
            this.lbUserStreetNumber.Text = "Street Number:";
            // 
            // lbUserStreetName
            // 
            this.lbUserStreetName.AutoSize = true;
            this.lbUserStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserStreetName.Location = new System.Drawing.Point(8, 76);
            this.lbUserStreetName.Name = "lbUserStreetName";
            this.lbUserStreetName.Size = new System.Drawing.Size(103, 20);
            this.lbUserStreetName.TabIndex = 3;
            this.lbUserStreetName.Text = "Street Name:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(416, 21);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email:";
            // 
            // lbUserLastName
            // 
            this.lbUserLastName.AutoSize = true;
            this.lbUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserLastName.Location = new System.Drawing.Point(225, 21);
            this.lbUserLastName.Name = "lbUserLastName";
            this.lbUserLastName.Size = new System.Drawing.Size(86, 20);
            this.lbUserLastName.TabIndex = 1;
            this.lbUserLastName.Text = "Last Name";
            // 
            // lbUserFirstName
            // 
            this.lbUserFirstName.AutoSize = true;
            this.lbUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserFirstName.Location = new System.Drawing.Point(8, 21);
            this.lbUserFirstName.Name = "lbUserFirstName";
            this.lbUserFirstName.Size = new System.Drawing.Size(90, 20);
            this.lbUserFirstName.TabIndex = 0;
            this.lbUserFirstName.Text = "First Name:";
            // 
            // TabAddUpdateEmployee
            // 
            this.TabAddUpdateEmployee.Controls.Add(this.lbType);
            this.TabAddUpdateEmployee.Controls.Add(this.cbEmployeeType);
            this.TabAddUpdateEmployee.Controls.Add(this.btnRemoveEmployee);
            this.TabAddUpdateEmployee.Controls.Add(this.btnModifyEmployeeInfo);
            this.TabAddUpdateEmployee.Controls.Add(this.btnAddEmployee);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxBSN);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxPhoneNumber);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxBirthday);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxCountry);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxCity);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxZip);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxStreetNumber);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxStreetName);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxEmail);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxLastName);
            this.TabAddUpdateEmployee.Controls.Add(this.tbxFirstName);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeBSN);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeePhoneNumber);
            this.TabAddUpdateEmployee.Controls.Add(this.label3);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeBirthday);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeCountry);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeCity);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeZip);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeStreetNumber);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeStreetName);
            this.TabAddUpdateEmployee.Controls.Add(this.label2);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeEmail);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeLastName);
            this.TabAddUpdateEmployee.Controls.Add(this.lbAddUpdateEmployeeFirstName);
            this.TabAddUpdateEmployee.Location = new System.Drawing.Point(4, 5);
            this.TabAddUpdateEmployee.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TabAddUpdateEmployee.Name = "TabAddUpdateEmployee";
            this.TabAddUpdateEmployee.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TabAddUpdateEmployee.Size = new System.Drawing.Size(600, 488);
            this.TabAddUpdateEmployee.TabIndex = 1;
            this.TabAddUpdateEmployee.Text = "TabAddUpdateEmployee";
            this.TabAddUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbType.Location = new System.Drawing.Point(468, 214);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(47, 20);
            this.lbType.TabIndex = 42;
            this.lbType.Text = "Type:";
            // 
            // cbEmployeeType
            // 
            this.cbEmployeeType.FormattingEnabled = true;
            this.cbEmployeeType.Location = new System.Drawing.Point(437, 236);
            this.cbEmployeeType.Name = "cbEmployeeType";
            this.cbEmployeeType.Size = new System.Drawing.Size(110, 23);
            this.cbEmployeeType.TabIndex = 41;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEmployee.Location = new System.Drawing.Point(289, 418);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(257, 29);
            this.btnRemoveEmployee.TabIndex = 40;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnModifyEmployeeInfo
            // 
            this.btnModifyEmployeeInfo.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifyEmployeeInfo.Location = new System.Drawing.Point(34, 418);
            this.btnModifyEmployeeInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyEmployeeInfo.Name = "btnModifyEmployeeInfo";
            this.btnModifyEmployeeInfo.Size = new System.Drawing.Size(249, 29);
            this.btnModifyEmployeeInfo.TabIndex = 36;
            this.btnModifyEmployeeInfo.Text = "Modify Employee Information";
            this.btnModifyEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnModifyEmployeeInfo.Click += new System.EventHandler(this.btnModifyEmployeeInfo_Click_1);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.Location = new System.Drawing.Point(34, 377);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(512, 29);
            this.btnAddEmployee.TabIndex = 35;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tbxBSN
            // 
            this.tbxBSN.Location = new System.Drawing.Point(249, 236);
            this.tbxBSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBSN.Name = "tbxBSN";
            this.tbxBSN.Size = new System.Drawing.Size(110, 23);
            this.tbxBSN.TabIndex = 34;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(34, 236);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(110, 23);
            this.tbxPhoneNumber.TabIndex = 33;
            // 
            // tbxBirthday
            // 
            this.tbxBirthday.Location = new System.Drawing.Point(437, 175);
            this.tbxBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBirthday.Name = "tbxBirthday";
            this.tbxBirthday.Size = new System.Drawing.Size(110, 23);
            this.tbxBirthday.TabIndex = 32;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(249, 175);
            this.tbxCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(110, 23);
            this.tbxCountry.TabIndex = 31;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(32, 180);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(110, 23);
            this.tbxCity.TabIndex = 30;
            // 
            // tbxZip
            // 
            this.tbxZip.Location = new System.Drawing.Point(437, 124);
            this.tbxZip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(110, 23);
            this.tbxZip.TabIndex = 29;
            // 
            // tbxStreetNumber
            // 
            this.tbxStreetNumber.Location = new System.Drawing.Point(249, 124);
            this.tbxStreetNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStreetNumber.Name = "tbxStreetNumber";
            this.tbxStreetNumber.Size = new System.Drawing.Size(110, 23);
            this.tbxStreetNumber.TabIndex = 28;
            // 
            // tbxStreetName
            // 
            this.tbxStreetName.Location = new System.Drawing.Point(34, 124);
            this.tbxStreetName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStreetName.Name = "tbxStreetName";
            this.tbxStreetName.Size = new System.Drawing.Size(110, 23);
            this.tbxStreetName.TabIndex = 27;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(437, 56);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(110, 23);
            this.tbxEmail.TabIndex = 26;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(249, 56);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(110, 23);
            this.tbxLastName.TabIndex = 25;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(34, 56);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(110, 23);
            this.tbxFirstName.TabIndex = 24;
            // 
            // lbAddUpdateEmployeeBSN
            // 
            this.lbAddUpdateEmployeeBSN.AutoSize = true;
            this.lbAddUpdateEmployeeBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeBSN.Location = new System.Drawing.Point(280, 214);
            this.lbAddUpdateEmployeeBSN.Name = "lbAddUpdateEmployeeBSN";
            this.lbAddUpdateEmployeeBSN.Size = new System.Drawing.Size(46, 20);
            this.lbAddUpdateEmployeeBSN.TabIndex = 22;
            this.lbAddUpdateEmployeeBSN.Text = "BSN:";
            // 
            // lbAddUpdateEmployeePhoneNumber
            // 
            this.lbAddUpdateEmployeePhoneNumber.AutoSize = true;
            this.lbAddUpdateEmployeePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeePhoneNumber.Location = new System.Drawing.Point(26, 214);
            this.lbAddUpdateEmployeePhoneNumber.Name = "lbAddUpdateEmployeePhoneNumber";
            this.lbAddUpdateEmployeePhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lbAddUpdateEmployeePhoneNumber.TabIndex = 21;
            this.lbAddUpdateEmployeePhoneNumber.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(454, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Birthday: ";
            // 
            // lbAddUpdateEmployeeBirthday
            // 
            this.lbAddUpdateEmployeeBirthday.AutoSize = true;
            this.lbAddUpdateEmployeeBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeBirthday.Location = new System.Drawing.Point(463, 153);
            this.lbAddUpdateEmployeeBirthday.Name = "lbAddUpdateEmployeeBirthday";
            this.lbAddUpdateEmployeeBirthday.Size = new System.Drawing.Size(75, 20);
            this.lbAddUpdateEmployeeBirthday.TabIndex = 20;
            this.lbAddUpdateEmployeeBirthday.Text = "Birthday: ";
            // 
            // lbAddUpdateEmployeeCountry
            // 
            this.lbAddUpdateEmployeeCountry.AutoSize = true;
            this.lbAddUpdateEmployeeCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeCountry.Location = new System.Drawing.Point(267, 153);
            this.lbAddUpdateEmployeeCountry.Name = "lbAddUpdateEmployeeCountry";
            this.lbAddUpdateEmployeeCountry.Size = new System.Drawing.Size(68, 20);
            this.lbAddUpdateEmployeeCountry.TabIndex = 19;
            this.lbAddUpdateEmployeeCountry.Text = "Country:";
            // 
            // lbAddUpdateEmployeeCity
            // 
            this.lbAddUpdateEmployeeCity.AutoSize = true;
            this.lbAddUpdateEmployeeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeCity.Location = new System.Drawing.Point(62, 153);
            this.lbAddUpdateEmployeeCity.Name = "lbAddUpdateEmployeeCity";
            this.lbAddUpdateEmployeeCity.Size = new System.Drawing.Size(39, 20);
            this.lbAddUpdateEmployeeCity.TabIndex = 18;
            this.lbAddUpdateEmployeeCity.Text = "City:";
            // 
            // lbAddUpdateEmployeeZip
            // 
            this.lbAddUpdateEmployeeZip.AutoSize = true;
            this.lbAddUpdateEmployeeZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeZip.Location = new System.Drawing.Point(468, 102);
            this.lbAddUpdateEmployeeZip.Name = "lbAddUpdateEmployeeZip";
            this.lbAddUpdateEmployeeZip.Size = new System.Drawing.Size(35, 20);
            this.lbAddUpdateEmployeeZip.TabIndex = 17;
            this.lbAddUpdateEmployeeZip.Text = "Zip:";
            // 
            // lbAddUpdateEmployeeStreetNumber
            // 
            this.lbAddUpdateEmployeeStreetNumber.AutoSize = true;
            this.lbAddUpdateEmployeeStreetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeStreetNumber.Location = new System.Drawing.Point(249, 101);
            this.lbAddUpdateEmployeeStreetNumber.Name = "lbAddUpdateEmployeeStreetNumber";
            this.lbAddUpdateEmployeeStreetNumber.Size = new System.Drawing.Size(117, 20);
            this.lbAddUpdateEmployeeStreetNumber.TabIndex = 16;
            this.lbAddUpdateEmployeeStreetNumber.Text = "Street Number:";
            // 
            // lbAddUpdateEmployeeStreetName
            // 
            this.lbAddUpdateEmployeeStreetName.AutoSize = true;
            this.lbAddUpdateEmployeeStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeStreetName.Location = new System.Drawing.Point(34, 101);
            this.lbAddUpdateEmployeeStreetName.Name = "lbAddUpdateEmployeeStreetName";
            this.lbAddUpdateEmployeeStreetName.Size = new System.Drawing.Size(103, 20);
            this.lbAddUpdateEmployeeStreetName.TabIndex = 15;
            this.lbAddUpdateEmployeeStreetName.Text = "Street Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(463, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email:";
            // 
            // lbAddUpdateEmployeeEmail
            // 
            this.lbAddUpdateEmployeeEmail.AutoSize = true;
            this.lbAddUpdateEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeEmail.Location = new System.Drawing.Point(468, 34);
            this.lbAddUpdateEmployeeEmail.Name = "lbAddUpdateEmployeeEmail";
            this.lbAddUpdateEmployeeEmail.Size = new System.Drawing.Size(52, 20);
            this.lbAddUpdateEmployeeEmail.TabIndex = 14;
            this.lbAddUpdateEmployeeEmail.Text = "Email:";
            // 
            // lbAddUpdateEmployeeLastName
            // 
            this.lbAddUpdateEmployeeLastName.AutoSize = true;
            this.lbAddUpdateEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeLastName.Location = new System.Drawing.Point(267, 34);
            this.lbAddUpdateEmployeeLastName.Name = "lbAddUpdateEmployeeLastName";
            this.lbAddUpdateEmployeeLastName.Size = new System.Drawing.Size(86, 20);
            this.lbAddUpdateEmployeeLastName.TabIndex = 13;
            this.lbAddUpdateEmployeeLastName.Text = "Last Name";
            // 
            // lbAddUpdateEmployeeFirstName
            // 
            this.lbAddUpdateEmployeeFirstName.AutoSize = true;
            this.lbAddUpdateEmployeeFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddUpdateEmployeeFirstName.Location = new System.Drawing.Point(32, 34);
            this.lbAddUpdateEmployeeFirstName.Name = "lbAddUpdateEmployeeFirstName";
            this.lbAddUpdateEmployeeFirstName.Size = new System.Drawing.Size(90, 20);
            this.lbAddUpdateEmployeeFirstName.TabIndex = 12;
            this.lbAddUpdateEmployeeFirstName.Text = "First Name:";
            // 
            // tabAddAbsence
            // 
            this.tabAddAbsence.Controls.Add(this.btnSeeAbsence);
            this.tabAddAbsence.Controls.Add(this.label4);
            this.tabAddAbsence.Controls.Add(this.lbxEmployeeAbsences);
            this.tabAddAbsence.Location = new System.Drawing.Point(4, 5);
            this.tabAddAbsence.Name = "tabAddAbsence";
            this.tabAddAbsence.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAbsence.Size = new System.Drawing.Size(600, 488);
            this.tabAddAbsence.TabIndex = 2;
            this.tabAddAbsence.Text = "tabAddAbsence";
            this.tabAddAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSeeAbsence
            // 
            this.btnSeeAbsence.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeeAbsence.Location = new System.Drawing.Point(6, 258);
            this.btnSeeAbsence.Name = "btnSeeAbsence";
            this.btnSeeAbsence.Size = new System.Drawing.Size(588, 43);
            this.btnSeeAbsence.TabIndex = 2;
            this.btnSeeAbsence.Text = "See Absences";
            this.btnSeeAbsence.UseVisualStyleBackColor = true;
            this.btnSeeAbsence.Visible = false;
            this.btnSeeAbsence.Click += new System.EventHandler(this.btnSeeAbsence_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Employee Absences:";
            // 
            // lbxEmployeeAbsences
            // 
            this.lbxEmployeeAbsences.FormattingEnabled = true;
            this.lbxEmployeeAbsences.ItemHeight = 15;
            this.lbxEmployeeAbsences.Location = new System.Drawing.Point(6, 53);
            this.lbxEmployeeAbsences.Name = "lbxEmployeeAbsences";
            this.lbxEmployeeAbsences.Size = new System.Drawing.Size(588, 199);
            this.lbxEmployeeAbsences.TabIndex = 0;
            this.lbxEmployeeAbsences.SelectedIndexChanged += new System.EventHandler(this.lbxEmployeeAbsences_SelectedIndexChanged);
            // 
            // tabAddShift
            // 
            this.tabAddShift.Controls.Add(this.labShiftEmployees);
            this.tabAddShift.Controls.Add(this.lbShifts);
            this.tabAddShift.Controls.Add(this.buttonAutomaticSchedule);
            this.tabAddShift.Controls.Add(this.btnAssignShiftToEmployee);
            this.tabAddShift.Controls.Add(this.lbxShiftEmployees);
            this.tabAddShift.Controls.Add(this.lbxShift);
            this.tabAddShift.Controls.Add(this.btnAddShifts);
            this.tabAddShift.Location = new System.Drawing.Point(4, 5);
            this.tabAddShift.Name = "tabAddShift";
            this.tabAddShift.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddShift.Size = new System.Drawing.Size(600, 488);
            this.tabAddShift.TabIndex = 3;
            this.tabAddShift.Text = "tabAddShift";
            this.tabAddShift.UseVisualStyleBackColor = true;
            // 
            // labShiftEmployees
            // 
            this.labShiftEmployees.AutoSize = true;
            this.labShiftEmployees.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labShiftEmployees.Location = new System.Drawing.Point(6, 297);
            this.labShiftEmployees.Name = "labShiftEmployees";
            this.labShiftEmployees.Size = new System.Drawing.Size(130, 20);
            this.labShiftEmployees.TabIndex = 12;
            this.labShiftEmployees.Text = "Shift Employees:";
            // 
            // lbShifts
            // 
            this.lbShifts.AutoSize = true;
            this.lbShifts.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbShifts.Location = new System.Drawing.Point(6, 67);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(61, 22);
            this.lbShifts.TabIndex = 11;
            this.lbShifts.Text = "Shifts:";
            // 
            // buttonAutomaticSchedule
            // 
            this.buttonAutomaticSchedule.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAutomaticSchedule.Location = new System.Drawing.Point(6, 260);
            this.buttonAutomaticSchedule.Name = "buttonAutomaticSchedule";
            this.buttonAutomaticSchedule.Size = new System.Drawing.Size(276, 34);
            this.buttonAutomaticSchedule.TabIndex = 9;
            this.buttonAutomaticSchedule.Text = "Automatic Assign";
            this.buttonAutomaticSchedule.UseVisualStyleBackColor = true;
            this.buttonAutomaticSchedule.Click += new System.EventHandler(this.buttonAutomaticSchedule_Click);
            // 
            // btnAssignShiftToEmployee
            // 
            this.btnAssignShiftToEmployee.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssignShiftToEmployee.Location = new System.Drawing.Point(314, 260);
            this.btnAssignShiftToEmployee.Name = "btnAssignShiftToEmployee";
            this.btnAssignShiftToEmployee.Size = new System.Drawing.Size(280, 34);
            this.btnAssignShiftToEmployee.TabIndex = 6;
            this.btnAssignShiftToEmployee.Text = "Assign Shift";
            this.btnAssignShiftToEmployee.UseVisualStyleBackColor = true;
            this.btnAssignShiftToEmployee.Click += new System.EventHandler(this.btnAssignShiftToEmployee_Click);
            // 
            // lbxShiftEmployees
            // 
            this.lbxShiftEmployees.FormattingEnabled = true;
            this.lbxShiftEmployees.ItemHeight = 15;
            this.lbxShiftEmployees.Location = new System.Drawing.Point(6, 320);
            this.lbxShiftEmployees.Name = "lbxShiftEmployees";
            this.lbxShiftEmployees.Size = new System.Drawing.Size(588, 139);
            this.lbxShiftEmployees.TabIndex = 10;
            // 
            // lbxShift
            // 
            this.lbxShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbxShift.FormattingEnabled = true;
            this.lbxShift.ItemHeight = 15;
            this.lbxShift.Location = new System.Drawing.Point(6, 92);
            this.lbxShift.Name = "lbxShift";
            this.lbxShift.Size = new System.Drawing.Size(588, 124);
            this.lbxShift.TabIndex = 5;
            this.lbxShift.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxShift_DrawItem);
            this.lbxShift.SelectedIndexChanged += new System.EventHandler(this.lbxShift_SelectedIndexChanged);
            this.lbxShift.DoubleClick += new System.EventHandler(this.lbxShift_DoubleClick);
            // 
            // btnAddShifts
            // 
            this.btnAddShifts.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddShifts.Location = new System.Drawing.Point(6, 12);
            this.btnAddShifts.Name = "btnAddShifts";
            this.btnAddShifts.Size = new System.Drawing.Size(588, 40);
            this.btnAddShifts.TabIndex = 1;
            this.btnAddShifts.Text = "Create Shift";
            this.btnAddShifts.UseVisualStyleBackColor = true;
            this.btnAddShifts.Click += new System.EventHandler(this.btnAddShifts_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUploadSerialNumber);
            this.tabPage1.Controls.Add(this.btnAssignRFID);
            this.tabPage1.Controls.Add(this.lbAssigRfid);
            this.tabPage1.Controls.Add(this.tbRFIDSerial);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 488);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Assign RFID";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUploadSerialNumber
            // 
            this.btnUploadSerialNumber.Location = new System.Drawing.Point(190, 93);
            this.btnUploadSerialNumber.Name = "btnUploadSerialNumber";
            this.btnUploadSerialNumber.Size = new System.Drawing.Size(87, 27);
            this.btnUploadSerialNumber.TabIndex = 3;
            this.btnUploadSerialNumber.Text = "AssignRFID";
            this.btnUploadSerialNumber.UseVisualStyleBackColor = true;
            this.btnUploadSerialNumber.Click += new System.EventHandler(this.btnUploadSerialNumber_Click);
            // 
            // btnAssignRFID
            // 
            this.btnAssignRFID.Location = new System.Drawing.Point(45, 93);
            this.btnAssignRFID.Name = "btnAssignRFID";
            this.btnAssignRFID.Size = new System.Drawing.Size(87, 27);
            this.btnAssignRFID.TabIndex = 2;
            this.btnAssignRFID.Text = "AssignRFID";
            this.btnAssignRFID.UseVisualStyleBackColor = true;
            this.btnAssignRFID.Click += new System.EventHandler(this.btnAssignRFID_Click);
            // 
            // lbAssigRfid
            // 
            this.lbAssigRfid.AutoSize = true;
            this.lbAssigRfid.Location = new System.Drawing.Point(45, 43);
            this.lbAssigRfid.Name = "lbAssigRfid";
            this.lbAssigRfid.Size = new System.Drawing.Size(199, 15);
            this.lbAssigRfid.TabIndex = 1;
            this.lbAssigRfid.Text = "Serial number of attached RFID card:";
            // 
            // tbRFIDSerial
            // 
            this.tbRFIDSerial.Location = new System.Drawing.Point(270, 40);
            this.tbRFIDSerial.Name = "tbRFIDSerial";
            this.tbRFIDSerial.Size = new System.Drawing.Size(268, 23);
            this.tbRFIDSerial.TabIndex = 0;
            // 
            // btnEmployeeInfo
            // 
            this.btnEmployeeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnEmployeeInfo.FlatAppearance.BorderSize = 0;
            this.btnEmployeeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmployeeInfo.Location = new System.Drawing.Point(-4, 66);
            this.btnEmployeeInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEmployeeInfo.Name = "btnEmployeeInfo";
            this.btnEmployeeInfo.Size = new System.Drawing.Size(238, 99);
            this.btnEmployeeInfo.TabIndex = 0;
            this.btnEmployeeInfo.Text = "Employee Info";
            this.btnEmployeeInfo.UseVisualStyleBackColor = false;
            this.btnEmployeeInfo.Click += new System.EventHandler(this.btnEmployeeInfo_Click);
            // 
            // btnAddUpdateEmployee
            // 
            this.btnAddUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnAddUpdateEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUpdateEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddUpdateEmployee.Location = new System.Drawing.Point(-4, 160);
            this.btnAddUpdateEmployee.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddUpdateEmployee.Name = "btnAddUpdateEmployee";
            this.btnAddUpdateEmployee.Size = new System.Drawing.Size(238, 98);
            this.btnAddUpdateEmployee.TabIndex = 1;
            this.btnAddUpdateEmployee.Text = "Add/Update Employee Information";
            this.btnAddUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnAddUpdateEmployee.Click += new System.EventHandler(this.btnAddUpdateEmployee_Click);
            // 
            // btnAddAbsence
            // 
            this.btnAddAbsence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnAddAbsence.FlatAppearance.BorderSize = 0;
            this.btnAddAbsence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAbsence.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAbsence.Location = new System.Drawing.Point(-4, 253);
            this.btnAddAbsence.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddAbsence.Name = "btnAddAbsence";
            this.btnAddAbsence.Size = new System.Drawing.Size(238, 100);
            this.btnAddAbsence.TabIndex = 2;
            this.btnAddAbsence.Text = "See Absence";
            this.btnAddAbsence.UseVisualStyleBackColor = false;
            this.btnAddAbsence.Click += new System.EventHandler(this.btnAddAbsence_Click);
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnAddShift.FlatAppearance.BorderSize = 0;
            this.btnAddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddShift.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddShift.Location = new System.Drawing.Point(-4, 347);
            this.btnAddShift.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(238, 90);
            this.btnAddShift.TabIndex = 3;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(-4, 429);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(238, 70);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tbxSearchEmployee
            // 
            this.tbxSearchEmployee.Location = new System.Drawing.Point(1042, 10);
            this.tbxSearchEmployee.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbxSearchEmployee.Name = "tbxSearchEmployee";
            this.tbxSearchEmployee.Size = new System.Drawing.Size(200, 23);
            this.tbxSearchEmployee.TabIndex = 0;
            this.tbxSearchEmployee.TextChanged += new System.EventHandler(this.tbxSearchEmployee_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSearch.Location = new System.Drawing.Point(967, 13);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(71, 20);
            this.lbSearch.TabIndex = 5;
            this.lbSearch.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // dataGVEmployee
            // 
            this.dataGVEmployee.AllowUserToAddRows = false;
            this.dataGVEmployee.AllowUserToDeleteRows = false;
            this.dataGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber,
            this.Position});
            this.dataGVEmployee.Location = new System.Drawing.Point(842, 38);
            this.dataGVEmployee.Name = "dataGVEmployee";
            this.dataGVEmployee.ReadOnly = true;
            this.dataGVEmployee.RowTemplate.Height = 25;
            this.dataGVEmployee.Size = new System.Drawing.Size(648, 289);
            this.dataGVEmployee.TabIndex = 6;
            this.dataGVEmployee.Click += new System.EventHandler(this.dataGVEmployee_Click);
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 120;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 85;
            // 
            // EmployeeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1488, 497);
            this.Controls.Add(this.dataGVEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbxSearchEmployee);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.btnAddAbsence);
            this.Controls.Add(this.btnAddUpdateEmployee);
            this.Controls.Add(this.btnEmployeeInfo);
            this.Controls.Add(this.tbControlEmployeeManager);
            this.Name = "EmployeeManagerForm";
            this.Text = "EmployeeManager";
            this.Load += new System.EventHandler(this.EmployeeManager_Load);
            this.tbControlEmployeeManager.ResumeLayout(false);
            this.tabEmployeeInfo.ResumeLayout(false);
            this.tabEmployeeInfo.PerformLayout();
            this.TabAddUpdateEmployee.ResumeLayout(false);
            this.TabAddUpdateEmployee.PerformLayout();
            this.tabAddAbsence.ResumeLayout(false);
            this.tabAddAbsence.PerformLayout();
            this.tabAddShift.ResumeLayout(false);
            this.tabAddShift.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tbControlEmployeeManager;
        private TabPage tabEmployeeInfo;
        private TabPage TabAddUpdateEmployee;
        private Button btnEmployeeInfo;
        private Button btnAddUpdateEmployee;
        private Button btnAddAbsence;
        private Button btnAddShift;
        private Button btnLogOut;
        private TextBox tbxSearchEmployee;
        private Label lbSearch;
        private Label label1;
        private TabPage tabAddAbsence;
        private TabPage tabAddShift;
        private Label lbUserStreetName;
        private Label lbEmail;
        private Label lbUserLastName;
        private Label lbUserFirstName;
        private Label lbCountry;
        private Label lbUserCity;
        private Label lbUserZIP;
        private Label lbUserStreetNumber;
        private Label lbUserBsn;
        private Label lbPhoneNumber;
        private Label lbUserBirthday;
        private Button btnWarnings;
        private Button btnSeeAbsences;
        private Button btnSeeShifts;
        private ListBox lbxWarnings;
        private ListBox lbxAbsences;
        private ListBox lbxShifts;
        private Button btnAddShifts;
        private Button btnModifyEmployeeInfo;
        private Button btnAddEmployee;
        private TextBox tbxBSN;
        private TextBox tbxPhoneNumber;
        private TextBox tbxBirthday;
        private TextBox tbxCountry;
        private TextBox tbxCity;
        private TextBox tbxZip;
        private TextBox tbxStreetNumber;
        private TextBox tbxStreetName;
        private TextBox tbxEmail;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private Label lbAddUpdateEmployeeBSN;
        private Label lbAddUpdateEmployeePhoneNumber;
        private Label lbAddUpdateEmployeeBirthday;
        private Label lbAddUpdateEmployeeCountry;
        private Label lbAddUpdateEmployeeCity;
        private Label lbAddUpdateEmployeeZip;
        private Label lbAddUpdateEmployeeStreetNumber;
        private Label lbAddUpdateEmployeeStreetName;
        private Label lbAddUpdateEmployeeEmail;
        private Label lbAddUpdateEmployeeLastName;
        private Label lbAddUpdateEmployeeFirstName;
        private Button btnRemoveEmployee;
        private TabPage tabPage1;
        private Button btnUploadSerialNumber;
        private Button btnAssignRFID;
        private Label lbAssigRfid;
        private TextBox tbRFIDSerial;
        private Button btnAssignShiftToEmployee;
        private ListBox lbxShift;
        private DataGridView dataGVEmployee;
        private Label label3;
        private Label label2;
        private ComboBox cbEmployeeType;
        private Label lbType;
        private Button buttonAutomaticSchedule;
        private ListBox lbxShiftEmployees;
        private Label labShiftEmployees;
        private Label lbShifts;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Position;
        private ListBox lbxEmployeeAbsences;
        private Label label4;
        private Button btnSeeAbsence;
    }
}
namespace mediabazaar
{
    partial class FormHR
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
            this.dataGridViewEmployeeManagers = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeeInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbUserControl = new System.Windows.Forms.TabControl();
            this.tbDefault = new System.Windows.Forms.TabPage();
            this.tbUpdateEmployeeInfo = new System.Windows.Forms.TabPage();
            this.lbBSN = new System.Windows.Forms.Label();
            this.tbxBsn = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbZip = new System.Windows.Forms.Label();
            this.lbStreetNumber = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbStreetName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxStreetNumber = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.tbxStreetName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbAddEmployee = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBsnAdd = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.DTPDateOfBirthAdd = new System.Windows.Forms.DateTimePicker();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbEmailAdd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxCountryAdd = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumberAdd = new System.Windows.Forms.TextBox();
            this.tbxStreetNumberAdd = new System.Windows.Forms.TextBox();
            this.tbxCityAdd = new System.Windows.Forms.TextBox();
            this.tbxZipAdd = new System.Windows.Forms.TextBox();
            this.tbxStreetNameAdd = new System.Windows.Forms.TextBox();
            this.tbxEmailAdd = new System.Windows.Forms.TextBox();
            this.tbxLastNameAdd = new System.Windows.Forms.TextBox();
            this.tbxFirstNameAdd = new System.Windows.Forms.TextBox();
            this.btnAddEmployeeManager = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeManagers)).BeginInit();
            this.tbUserControl.SuspendLayout();
            this.tbUpdateEmployeeInfo.SuspendLayout();
            this.tbAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeManagers
            // 
            this.dataGridViewEmployeeManagers.AllowUserToAddRows = false;
            this.dataGridViewEmployeeManagers.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeManagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber,
            this.SeeInfo});
            this.dataGridViewEmployeeManagers.Location = new System.Drawing.Point(-9, 1);
            this.dataGridViewEmployeeManagers.Name = "dataGridViewEmployeeManagers";
            this.dataGridViewEmployeeManagers.ReadOnly = true;
            this.dataGridViewEmployeeManagers.RowTemplate.Height = 25;
            this.dataGridViewEmployeeManagers.Size = new System.Drawing.Size(555, 446);
            this.dataGridViewEmployeeManagers.TabIndex = 0;
            this.dataGridViewEmployeeManagers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeeManagers_CellContentClick);
            this.dataGridViewEmployeeManagers.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewEmployeeManagers_DefaultValuesNeeded);
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
            // SeeInfo
            // 
            this.SeeInfo.HeaderText = "See Info";
            this.SeeInfo.Name = "SeeInfo";
            this.SeeInfo.ReadOnly = true;
            this.SeeInfo.Text = "See Info";
            this.SeeInfo.UseColumnTextForButtonValue = true;
            this.SeeInfo.Width = 110;
            // 
            // tbUserControl
            // 
            this.tbUserControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbUserControl.Controls.Add(this.tbDefault);
            this.tbUserControl.Controls.Add(this.tbUpdateEmployeeInfo);
            this.tbUserControl.Controls.Add(this.tbAddEmployee);
            this.tbUserControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tbUserControl.Location = new System.Drawing.Point(548, 1);
            this.tbUserControl.Multiline = true;
            this.tbUserControl.Name = "tbUserControl";
            this.tbUserControl.SelectedIndex = 0;
            this.tbUserControl.Size = new System.Drawing.Size(835, 580);
            this.tbUserControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbUserControl.TabIndex = 1;
            // 
            // tbDefault
            // 
            this.tbDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.tbDefault.Location = new System.Drawing.Point(4, 5);
            this.tbDefault.Name = "tbDefault";
            this.tbDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tbDefault.Size = new System.Drawing.Size(827, 571);
            this.tbDefault.TabIndex = 2;
            this.tbDefault.Text = "tbDefault";
            // 
            // tbUpdateEmployeeInfo
            // 
            this.tbUpdateEmployeeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbBSN);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxBsn);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel9);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel8);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel7);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel6);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel5);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel4);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel2);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel3);
            this.tbUpdateEmployeeInfo.Controls.Add(this.panel1);
            this.tbUpdateEmployeeInfo.Controls.Add(this.DTPDateOfBirth);
            this.tbUpdateEmployeeInfo.Controls.Add(this.btnUpdateUser);
            this.tbUpdateEmployeeInfo.Controls.Add(this.btnEditInfo);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbPhoneNumber);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbDateOfBirth);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbCountry);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbCity);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbZip);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbStreetNumber);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbEmail);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbStreetName);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbLastName);
            this.tbUpdateEmployeeInfo.Controls.Add(this.lbFirstName);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxCountry);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxPhoneNumber);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxStreetNumber);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxCity);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxZip);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxStreetName);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxEmail);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxLastName);
            this.tbUpdateEmployeeInfo.Controls.Add(this.tbxFirstName);
            this.tbUpdateEmployeeInfo.Location = new System.Drawing.Point(4, 5);
            this.tbUpdateEmployeeInfo.Name = "tbUpdateEmployeeInfo";
            this.tbUpdateEmployeeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbUpdateEmployeeInfo.Size = new System.Drawing.Size(827, 571);
            this.tbUpdateEmployeeInfo.TabIndex = 0;
            this.tbUpdateEmployeeInfo.Text = "tbUpdateEmployeeInfo";
            // 
            // lbBSN
            // 
            this.lbBSN.AutoSize = true;
            this.lbBSN.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBSN.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBSN.Location = new System.Drawing.Point(629, 24);
            this.lbBSN.Name = "lbBSN";
            this.lbBSN.Size = new System.Drawing.Size(64, 29);
            this.lbBSN.TabIndex = 63;
            this.lbBSN.Text = "BSN:";
            // 
            // tbxBsn
            // 
            this.tbxBsn.Enabled = false;
            this.tbxBsn.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxBsn.Location = new System.Drawing.Point(594, 56);
            this.tbxBsn.Name = "tbxBsn";
            this.tbxBsn.Size = new System.Drawing.Size(124, 27);
            this.tbxBsn.TabIndex = 62;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel9.Location = new System.Drawing.Point(373, 373);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(124, 5);
            this.panel9.TabIndex = 61;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel8.Location = new System.Drawing.Point(373, 233);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(124, 5);
            this.panel8.TabIndex = 60;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel7.Location = new System.Drawing.Point(373, 158);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(124, 5);
            this.panel7.TabIndex = 59;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel6.Location = new System.Drawing.Point(373, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(124, 5);
            this.panel6.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel5.Location = new System.Drawing.Point(99, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(124, 5);
            this.panel5.TabIndex = 58;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel4.Location = new System.Drawing.Point(99, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 5);
            this.panel4.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(99, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 5);
            this.panel2.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel3.Location = new System.Drawing.Point(99, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 5);
            this.panel3.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(99, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 5);
            this.panel1.TabIndex = 53;
            // 
            // DTPDateOfBirth
            // 
            this.DTPDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDateOfBirth.Location = new System.Drawing.Point(343, 271);
            this.DTPDateOfBirth.Name = "DTPDateOfBirth";
            this.DTPDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.DTPDateOfBirth.TabIndex = 52;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateUser.Location = new System.Drawing.Point(81, 446);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(652, 39);
            this.btnUpdateUser.TabIndex = 51;
            this.btnUpdateUser.Text = "Update Information ";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnEditInfo.FlatAppearance.BorderSize = 0;
            this.btnEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInfo.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditInfo.Location = new System.Drawing.Point(279, 407);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(264, 33);
            this.btnEditInfo.TabIndex = 50;
            this.btnEditInfo.Text = "Edit";
            this.btnEditInfo.UseVisualStyleBackColor = false;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPhoneNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPhoneNumber.Location = new System.Drawing.Point(354, 313);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(174, 29);
            this.lbPhoneNumber.TabIndex = 49;
            this.lbPhoneNumber.Text = "Phonenumber:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDateOfBirth.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDateOfBirth.Location = new System.Drawing.Point(365, 239);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(156, 29);
            this.lbDateOfBirth.TabIndex = 48;
            this.lbDateOfBirth.Text = "Date of birth:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCountry.Location = new System.Drawing.Point(387, 171);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(104, 29);
            this.lbCountry.TabIndex = 47;
            this.lbCountry.Text = "Country:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCity.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCity.Location = new System.Drawing.Point(408, 97);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(60, 29);
            this.lbCity.TabIndex = 46;
            this.lbCity.Text = "City:";
            // 
            // lbZip
            // 
            this.lbZip.AutoSize = true;
            this.lbZip.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbZip.ForeColor = System.Drawing.SystemColors.Control;
            this.lbZip.Location = new System.Drawing.Point(408, 24);
            this.lbZip.Name = "lbZip";
            this.lbZip.Size = new System.Drawing.Size(52, 29);
            this.lbZip.TabIndex = 45;
            this.lbZip.Text = "Zip:";
            // 
            // lbStreetNumber
            // 
            this.lbStreetNumber.AutoSize = true;
            this.lbStreetNumber.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStreetNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStreetNumber.Location = new System.Drawing.Point(81, 313);
            this.lbStreetNumber.Name = "lbStreetNumber";
            this.lbStreetNumber.Size = new System.Drawing.Size(179, 29);
            this.lbStreetNumber.TabIndex = 44;
            this.lbStreetNumber.Text = "Street Number:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEmail.Location = new System.Drawing.Point(123, 171);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(79, 29);
            this.lbEmail.TabIndex = 43;
            this.lbEmail.Text = "Email:";
            // 
            // lbStreetName
            // 
            this.lbStreetName.AutoSize = true;
            this.lbStreetName.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStreetName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStreetName.Location = new System.Drawing.Point(90, 239);
            this.lbStreetName.Name = "lbStreetName";
            this.lbStreetName.Size = new System.Drawing.Size(155, 29);
            this.lbStreetName.TabIndex = 42;
            this.lbStreetName.Text = "Street Name:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLastName.Location = new System.Drawing.Point(99, 97);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(135, 29);
            this.lbLastName.TabIndex = 41;
            this.lbLastName.Text = "Last Name:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbFirstName.Location = new System.Drawing.Point(90, 24);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(137, 29);
            this.lbFirstName.TabIndex = 40;
            this.lbFirstName.Text = "First Name:";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Enabled = false;
            this.tbxCountry.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCountry.Location = new System.Drawing.Point(373, 203);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(124, 27);
            this.tbxCountry.TabIndex = 39;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Enabled = false;
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPhoneNumber.Location = new System.Drawing.Point(373, 345);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(124, 27);
            this.tbxPhoneNumber.TabIndex = 38;
            // 
            // tbxStreetNumber
            // 
            this.tbxStreetNumber.Enabled = false;
            this.tbxStreetNumber.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxStreetNumber.Location = new System.Drawing.Point(99, 345);
            this.tbxStreetNumber.Name = "tbxStreetNumber";
            this.tbxStreetNumber.Size = new System.Drawing.Size(124, 27);
            this.tbxStreetNumber.TabIndex = 37;
            // 
            // tbxCity
            // 
            this.tbxCity.Enabled = false;
            this.tbxCity.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCity.Location = new System.Drawing.Point(373, 129);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(124, 27);
            this.tbxCity.TabIndex = 36;
            // 
            // tbxZip
            // 
            this.tbxZip.Enabled = false;
            this.tbxZip.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxZip.Location = new System.Drawing.Point(373, 56);
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(124, 27);
            this.tbxZip.TabIndex = 35;
            // 
            // tbxStreetName
            // 
            this.tbxStreetName.Enabled = false;
            this.tbxStreetName.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxStreetName.Location = new System.Drawing.Point(99, 271);
            this.tbxStreetName.Name = "tbxStreetName";
            this.tbxStreetName.Size = new System.Drawing.Size(124, 27);
            this.tbxStreetName.TabIndex = 34;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxEmail.Location = new System.Drawing.Point(99, 203);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(124, 27);
            this.tbxEmail.TabIndex = 33;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Enabled = false;
            this.tbxLastName.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxLastName.Location = new System.Drawing.Point(99, 129);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(124, 27);
            this.tbxLastName.TabIndex = 32;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Enabled = false;
            this.tbxFirstName.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFirstName.Location = new System.Drawing.Point(99, 56);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(124, 27);
            this.tbxFirstName.TabIndex = 31;
            // 
            // tbAddEmployee
            // 
            this.tbAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.tbAddEmployee.Controls.Add(this.panel19);
            this.tbAddEmployee.Controls.Add(this.label1);
            this.tbAddEmployee.Controls.Add(this.tbxBsnAdd);
            this.tbAddEmployee.Controls.Add(this.panel10);
            this.tbAddEmployee.Controls.Add(this.panel11);
            this.tbAddEmployee.Controls.Add(this.panel12);
            this.tbAddEmployee.Controls.Add(this.panel13);
            this.tbAddEmployee.Controls.Add(this.panel14);
            this.tbAddEmployee.Controls.Add(this.panel15);
            this.tbAddEmployee.Controls.Add(this.panel16);
            this.tbAddEmployee.Controls.Add(this.panel17);
            this.tbAddEmployee.Controls.Add(this.panel18);
            this.tbAddEmployee.Controls.Add(this.DTPDateOfBirthAdd);
            this.tbAddEmployee.Controls.Add(this.btnAddEmployee);
            this.tbAddEmployee.Controls.Add(this.label2);
            this.tbAddEmployee.Controls.Add(this.label3);
            this.tbAddEmployee.Controls.Add(this.label4);
            this.tbAddEmployee.Controls.Add(this.label5);
            this.tbAddEmployee.Controls.Add(this.label6);
            this.tbAddEmployee.Controls.Add(this.label7);
            this.tbAddEmployee.Controls.Add(this.lbEmailAdd);
            this.tbAddEmployee.Controls.Add(this.label9);
            this.tbAddEmployee.Controls.Add(this.label10);
            this.tbAddEmployee.Controls.Add(this.label11);
            this.tbAddEmployee.Controls.Add(this.tbxCountryAdd);
            this.tbAddEmployee.Controls.Add(this.tbxPhoneNumberAdd);
            this.tbAddEmployee.Controls.Add(this.tbxStreetNumberAdd);
            this.tbAddEmployee.Controls.Add(this.tbxCityAdd);
            this.tbAddEmployee.Controls.Add(this.tbxZipAdd);
            this.tbAddEmployee.Controls.Add(this.tbxStreetNameAdd);
            this.tbAddEmployee.Controls.Add(this.tbxEmailAdd);
            this.tbAddEmployee.Controls.Add(this.tbxLastNameAdd);
            this.tbAddEmployee.Controls.Add(this.tbxFirstNameAdd);
            this.tbAddEmployee.Location = new System.Drawing.Point(4, 5);
            this.tbAddEmployee.Name = "tbAddEmployee";
            this.tbAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddEmployee.Size = new System.Drawing.Size(827, 571);
            this.tbAddEmployee.TabIndex = 1;
            this.tbAddEmployee.Text = "tbAddEmployee";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel19.Location = new System.Drawing.Point(600, 86);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(124, 5);
            this.panel19.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(635, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 96;
            this.label1.Text = "BSN:";
            // 
            // tbxBsnAdd
            // 
            this.tbxBsnAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxBsnAdd.Location = new System.Drawing.Point(600, 58);
            this.tbxBsnAdd.Name = "tbxBsnAdd";
            this.tbxBsnAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxBsnAdd.TabIndex = 95;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel10.Location = new System.Drawing.Point(379, 375);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(124, 5);
            this.panel10.TabIndex = 94;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel11.Location = new System.Drawing.Point(379, 235);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(124, 5);
            this.panel11.TabIndex = 93;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel12.Location = new System.Drawing.Point(379, 160);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(124, 5);
            this.panel12.TabIndex = 92;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel13.Location = new System.Drawing.Point(379, 86);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(124, 5);
            this.panel13.TabIndex = 90;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel14.Location = new System.Drawing.Point(105, 375);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(124, 5);
            this.panel14.TabIndex = 91;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel15.Location = new System.Drawing.Point(105, 302);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(124, 5);
            this.panel15.TabIndex = 89;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel16.Location = new System.Drawing.Point(105, 160);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(124, 5);
            this.panel16.TabIndex = 87;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel17.Location = new System.Drawing.Point(105, 235);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(124, 5);
            this.panel17.TabIndex = 88;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.panel18.Location = new System.Drawing.Point(105, 86);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(124, 5);
            this.panel18.TabIndex = 86;
            // 
            // DTPDateOfBirthAdd
            // 
            this.DTPDateOfBirthAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDateOfBirthAdd.Location = new System.Drawing.Point(349, 273);
            this.DTPDateOfBirthAdd.Name = "DTPDateOfBirthAdd";
            this.DTPDateOfBirthAdd.Size = new System.Drawing.Size(200, 23);
            this.DTPDateOfBirthAdd.TabIndex = 85;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddEmployee.Location = new System.Drawing.Point(87, 444);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(652, 39);
            this.btnAddEmployee.TabIndex = 84;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(360, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Phonenumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(371, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 81;
            this.label3.Text = "Date of birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(393, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 80;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(414, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 79;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(414, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 29);
            this.label6.TabIndex = 78;
            this.label6.Text = "Zip:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(87, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 29);
            this.label7.TabIndex = 77;
            this.label7.Text = "Street Number:";
            // 
            // lbEmailAdd
            // 
            this.lbEmailAdd.AutoSize = true;
            this.lbEmailAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmailAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEmailAdd.Location = new System.Drawing.Point(129, 173);
            this.lbEmailAdd.Name = "lbEmailAdd";
            this.lbEmailAdd.Size = new System.Drawing.Size(79, 29);
            this.lbEmailAdd.TabIndex = 76;
            this.lbEmailAdd.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(96, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 29);
            this.label9.TabIndex = 75;
            this.label9.Text = "Street Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(105, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 29);
            this.label10.TabIndex = 74;
            this.label10.Text = "Last Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(96, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 29);
            this.label11.TabIndex = 73;
            this.label11.Text = "First Name:";
            // 
            // tbxCountryAdd
            // 
            this.tbxCountryAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCountryAdd.Location = new System.Drawing.Point(379, 205);
            this.tbxCountryAdd.Name = "tbxCountryAdd";
            this.tbxCountryAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxCountryAdd.TabIndex = 72;
            // 
            // tbxPhoneNumberAdd
            // 
            this.tbxPhoneNumberAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPhoneNumberAdd.Location = new System.Drawing.Point(379, 347);
            this.tbxPhoneNumberAdd.Name = "tbxPhoneNumberAdd";
            this.tbxPhoneNumberAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxPhoneNumberAdd.TabIndex = 71;
            // 
            // tbxStreetNumberAdd
            // 
            this.tbxStreetNumberAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxStreetNumberAdd.Location = new System.Drawing.Point(105, 347);
            this.tbxStreetNumberAdd.Name = "tbxStreetNumberAdd";
            this.tbxStreetNumberAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxStreetNumberAdd.TabIndex = 70;
            // 
            // tbxCityAdd
            // 
            this.tbxCityAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCityAdd.Location = new System.Drawing.Point(379, 131);
            this.tbxCityAdd.Name = "tbxCityAdd";
            this.tbxCityAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxCityAdd.TabIndex = 69;
            // 
            // tbxZipAdd
            // 
            this.tbxZipAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxZipAdd.Location = new System.Drawing.Point(379, 58);
            this.tbxZipAdd.Name = "tbxZipAdd";
            this.tbxZipAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxZipAdd.TabIndex = 68;
            // 
            // tbxStreetNameAdd
            // 
            this.tbxStreetNameAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxStreetNameAdd.Location = new System.Drawing.Point(105, 273);
            this.tbxStreetNameAdd.Name = "tbxStreetNameAdd";
            this.tbxStreetNameAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxStreetNameAdd.TabIndex = 67;
            // 
            // tbxEmailAdd
            // 
            this.tbxEmailAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxEmailAdd.Location = new System.Drawing.Point(105, 205);
            this.tbxEmailAdd.Name = "tbxEmailAdd";
            this.tbxEmailAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxEmailAdd.TabIndex = 66;
            // 
            // tbxLastNameAdd
            // 
            this.tbxLastNameAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxLastNameAdd.Location = new System.Drawing.Point(105, 131);
            this.tbxLastNameAdd.Name = "tbxLastNameAdd";
            this.tbxLastNameAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxLastNameAdd.TabIndex = 65;
            // 
            // tbxFirstNameAdd
            // 
            this.tbxFirstNameAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFirstNameAdd.Location = new System.Drawing.Point(105, 58);
            this.tbxFirstNameAdd.Name = "tbxFirstNameAdd";
            this.tbxFirstNameAdd.Size = new System.Drawing.Size(124, 27);
            this.tbxFirstNameAdd.TabIndex = 64;
            // 
            // btnAddEmployeeManager
            // 
            this.btnAddEmployeeManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnAddEmployeeManager.FlatAppearance.BorderSize = 0;
            this.btnAddEmployeeManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployeeManager.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployeeManager.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployeeManager.Location = new System.Drawing.Point(12, 495);
            this.btnAddEmployeeManager.Name = "btnAddEmployeeManager";
            this.btnAddEmployeeManager.Size = new System.Drawing.Size(324, 35);
            this.btnAddEmployeeManager.TabIndex = 2;
            this.btnAddEmployeeManager.Text = "Add Employee";
            this.btnAddEmployeeManager.UseVisualStyleBackColor = false;
            this.btnAddEmployeeManager.Click += new System.EventHandler(this.btnAddEmployeeManager_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnRemoveEmployee.FlatAppearance.BorderSize = 0;
            this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEmployee.ForeColor = System.Drawing.Color.White;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(342, 495);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(200, 35);
            this.btnRemoveEmployee.TabIndex = 3;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxSearch.Location = new System.Drawing.Point(103, 453);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(439, 31);
            this.tbxSearch.TabIndex = 4;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.Location = new System.Drawing.Point(12, 456);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(85, 26);
            this.lbSearch.TabIndex = 5;
            this.lbSearch.Text = "Search:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(12, 536);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(530, 35);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FormHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1382, 579);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnAddEmployeeManager);
            this.Controls.Add(this.tbUserControl);
            this.Controls.Add(this.dataGridViewEmployeeManagers);
            this.Name = "FormHR";
            this.Text = "FormHR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeManagers)).EndInit();
            this.tbUserControl.ResumeLayout(false);
            this.tbUpdateEmployeeInfo.ResumeLayout(false);
            this.tbUpdateEmployeeInfo.PerformLayout();
            this.tbAddEmployee.ResumeLayout(false);
            this.tbAddEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewEmployeeManagers;
        private TabControl tbUserControl;
        private TabPage tbUpdateEmployeeInfo;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private DateTimePicker DTPDateOfBirth;
        private Button btnUpdateUser;
        private Button btnEditInfo;
        private Label lbPhoneNumber;
        private Label lbDateOfBirth;
        private Label lbCountry;
        private Label lbCity;
        private Label lbZip;
        private Label lbStreetNumber;
        private Label lbEmail;
        private Label lbStreetName;
        private Label lbLastName;
        private Label lbFirstName;
        private TextBox tbxCountry;
        private TextBox tbxPhoneNumber;
        private TextBox tbxStreetNumber;
        private TextBox tbxCity;
        private TextBox tbxZip;
        private TextBox tbxStreetName;
        private TextBox tbxEmail;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private TabPage tbAddEmployee;
        private Button btnAddEmployeeManager;
        private Button btnRemoveEmployee;
        private TabPage tabPage1;
        private TextBox tbxSearch;
        private Label lbSearch;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewButtonColumn SeeInfo;
        private TabPage tbDefault;
        private Label lbBSN;
        private TextBox tbxBsn;
        private Label label1;
        private TextBox tbxBsnAdd;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private DateTimePicker DTPDateOfBirthAdd;
        private Button btnAddEmployee;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbEmailAdd;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbxCountryAdd;
        private TextBox tbxPhoneNumberAdd;
        private TextBox tbxStreetNumberAdd;
        private TextBox tbxCityAdd;
        private TextBox tbxZipAdd;
        private TextBox tbxStreetNameAdd;
        private TextBox tbxEmailAdd;
        private TextBox tbxLastNameAdd;
        private TextBox tbxFirstNameAdd;
        private Panel panel19;
        private Button btnLogOut;
    }
}
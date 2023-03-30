namespace mediabazaar
{
    partial class DepoManagerForm
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepartmentInfo = new System.Windows.Forms.Button();
            this.tbControlEmployeeManager = new System.Windows.Forms.TabControl();
            this.tabDepartmentInfo = new System.Windows.Forms.TabPage();
            this.btnSelectDept = new System.Windows.Forms.Button();
            this.lblSelectedDept = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeeDepts = new System.Windows.Forms.Button();
            this.btnRemoveDept = new System.Windows.Forms.Button();
            this.btnModifyDept = new System.Windows.Forms.Button();
            this.lbxDepts = new System.Windows.Forms.ListBox();
            this.tbxDeptName = new System.Windows.Forms.TextBox();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.lbDepName = new System.Windows.Forms.Label();
            this.tabAssignEmployees = new System.Windows.Forms.TabPage();
            this.dtgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectedDeptAssignTab = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUserSearch = new System.Windows.Forms.TextBox();
            this.btnAssignEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbControlEmployeeManager.SuspendLayout();
            this.tabDepartmentInfo.SuspendLayout();
            this.tabAssignEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(8, 455);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(238, 33);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome";
            // 
            // btnDepartmentInfo
            // 
            this.btnDepartmentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnDepartmentInfo.FlatAppearance.BorderSize = 0;
            this.btnDepartmentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepartmentInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartmentInfo.Location = new System.Drawing.Point(8, 47);
            this.btnDepartmentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepartmentInfo.Name = "btnDepartmentInfo";
            this.btnDepartmentInfo.Size = new System.Drawing.Size(238, 99);
            this.btnDepartmentInfo.TabIndex = 7;
            this.btnDepartmentInfo.Text = "Department Info";
            this.btnDepartmentInfo.UseVisualStyleBackColor = false;
            // 
            // tbControlEmployeeManager
            // 
            this.tbControlEmployeeManager.Controls.Add(this.tabDepartmentInfo);
            this.tbControlEmployeeManager.Controls.Add(this.tabAssignEmployees);
            this.tbControlEmployeeManager.Location = new System.Drawing.Point(262, 2);
            this.tbControlEmployeeManager.Margin = new System.Windows.Forms.Padding(2);
            this.tbControlEmployeeManager.Name = "tbControlEmployeeManager";
            this.tbControlEmployeeManager.SelectedIndex = 0;
            this.tbControlEmployeeManager.Size = new System.Drawing.Size(620, 488);
            this.tbControlEmployeeManager.TabIndex = 11;
            // 
            // tabDepartmentInfo
            // 
            this.tabDepartmentInfo.Controls.Add(this.btnSelectDept);
            this.tabDepartmentInfo.Controls.Add(this.lblSelectedDept);
            this.tabDepartmentInfo.Controls.Add(this.label5);
            this.tabDepartmentInfo.Controls.Add(this.btnSeeDepts);
            this.tabDepartmentInfo.Controls.Add(this.btnRemoveDept);
            this.tabDepartmentInfo.Controls.Add(this.btnModifyDept);
            this.tabDepartmentInfo.Controls.Add(this.lbxDepts);
            this.tabDepartmentInfo.Controls.Add(this.tbxDeptName);
            this.tabDepartmentInfo.Controls.Add(this.btnAddDept);
            this.tabDepartmentInfo.Controls.Add(this.lbDepName);
            this.tabDepartmentInfo.Location = new System.Drawing.Point(4, 24);
            this.tabDepartmentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabDepartmentInfo.Name = "tabDepartmentInfo";
            this.tabDepartmentInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabDepartmentInfo.Size = new System.Drawing.Size(612, 460);
            this.tabDepartmentInfo.TabIndex = 0;
            this.tabDepartmentInfo.Text = "tabDepartmentInfo";
            this.tabDepartmentInfo.UseVisualStyleBackColor = true;
            this.tabDepartmentInfo.Click += new System.EventHandler(this.tabDepartmentInfo_Click);
            // 
            // btnSelectDept
            // 
            this.btnSelectDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectDept.Location = new System.Drawing.Point(465, 146);
            this.btnSelectDept.Name = "btnSelectDept";
            this.btnSelectDept.Size = new System.Drawing.Size(145, 41);
            this.btnSelectDept.TabIndex = 43;
            this.btnSelectDept.Text = "Select Dept.";
            this.btnSelectDept.UseVisualStyleBackColor = true;
            this.btnSelectDept.Click += new System.EventHandler(this.btnSelectDept_Click);
            // 
            // lblSelectedDept
            // 
            this.lblSelectedDept.AutoSize = true;
            this.lblSelectedDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedDept.Location = new System.Drawing.Point(491, 14);
            this.lblSelectedDept.Name = "lblSelectedDept";
            this.lblSelectedDept.Size = new System.Drawing.Size(98, 20);
            this.lblSelectedDept.TabIndex = 42;
            this.lblSelectedDept.Text = "Not selected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(312, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Selected department:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeeDepts
            // 
            this.btnSeeDepts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeeDepts.Location = new System.Drawing.Point(464, 194);
            this.btnSeeDepts.Name = "btnSeeDepts";
            this.btnSeeDepts.Size = new System.Drawing.Size(145, 33);
            this.btnSeeDepts.TabIndex = 37;
            this.btnSeeDepts.Text = " See Depts.";
            this.btnSeeDepts.UseVisualStyleBackColor = true;
            this.btnSeeDepts.Click += new System.EventHandler(this.btnSeeDepts_Click);
            // 
            // btnRemoveDept
            // 
            this.btnRemoveDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveDept.Location = new System.Drawing.Point(312, 194);
            this.btnRemoveDept.Name = "btnRemoveDept";
            this.btnRemoveDept.Size = new System.Drawing.Size(145, 33);
            this.btnRemoveDept.TabIndex = 36;
            this.btnRemoveDept.Text = "Remove Dept.";
            this.btnRemoveDept.UseVisualStyleBackColor = true;
            this.btnRemoveDept.Click += new System.EventHandler(this.btnRemoveDept_Click);
            // 
            // btnModifyDept
            // 
            this.btnModifyDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifyDept.Location = new System.Drawing.Point(161, 194);
            this.btnModifyDept.Name = "btnModifyDept";
            this.btnModifyDept.Size = new System.Drawing.Size(145, 33);
            this.btnModifyDept.TabIndex = 35;
            this.btnModifyDept.Text = "Modify Dept.";
            this.btnModifyDept.UseVisualStyleBackColor = true;
            this.btnModifyDept.Click += new System.EventHandler(this.btnModifyDept_Click);
            // 
            // lbxDepts
            // 
            this.lbxDepts.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxDepts.FormattingEnabled = true;
            this.lbxDepts.ItemHeight = 25;
            this.lbxDepts.Location = new System.Drawing.Point(10, 232);
            this.lbxDepts.Name = "lbxDepts";
            this.lbxDepts.Size = new System.Drawing.Size(601, 204);
            this.lbxDepts.TabIndex = 19;
            // 
            // tbxDeptName
            // 
            this.tbxDeptName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDeptName.Location = new System.Drawing.Point(11, 37);
            this.tbxDeptName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDeptName.Name = "tbxDeptName";
            this.tbxDeptName.Size = new System.Drawing.Size(149, 26);
            this.tbxDeptName.TabIndex = 21;
            // 
            // btnAddDept
            // 
            this.btnAddDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDept.Location = new System.Drawing.Point(10, 194);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(145, 33);
            this.btnAddDept.TabIndex = 15;
            this.btnAddDept.Text = "Add Dept.";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lbDepName
            // 
            this.lbDepName.AutoSize = true;
            this.lbDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDepName.Location = new System.Drawing.Point(11, 10);
            this.lbDepName.Name = "lbDepName";
            this.lbDepName.Size = new System.Drawing.Size(142, 20);
            this.lbDepName.TabIndex = 0;
            this.lbDepName.Text = "Department name:";
            // 
            // tabAssignEmployees
            // 
            this.tabAssignEmployees.Controls.Add(this.dtgvUsers);
            this.tabAssignEmployees.Controls.Add(this.lblSelectedDeptAssignTab);
            this.tabAssignEmployees.Controls.Add(this.label7);
            this.tabAssignEmployees.Controls.Add(this.label4);
            this.tabAssignEmployees.Controls.Add(this.tbxUserSearch);
            this.tabAssignEmployees.Controls.Add(this.btnAssignEmployee);
            this.tabAssignEmployees.Controls.Add(this.label2);
            this.tabAssignEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabAssignEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.tabAssignEmployees.Name = "tabAssignEmployees";
            this.tabAssignEmployees.Padding = new System.Windows.Forms.Padding(2);
            this.tabAssignEmployees.Size = new System.Drawing.Size(612, 460);
            this.tabAssignEmployees.TabIndex = 2;
            this.tabAssignEmployees.Text = "tabAssignEmployees";
            this.tabAssignEmployees.UseVisualStyleBackColor = true;
            // 
            // dtgvUsers
            // 
            this.dtgvUsers.AllowUserToAddRows = false;
            this.dtgvUsers.AllowUserToDeleteRows = false;
            this.dtgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber,
            this.Position});
            this.dtgvUsers.Location = new System.Drawing.Point(4, 122);
            this.dtgvUsers.Name = "dtgvUsers";
            this.dtgvUsers.ReadOnly = true;
            this.dtgvUsers.RowHeadersWidth = 51;
            this.dtgvUsers.RowTemplate.Height = 25;
            this.dtgvUsers.Size = new System.Drawing.Size(604, 336);
            this.dtgvUsers.TabIndex = 48;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 120;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 85;
            // 
            // lblSelectedDeptAssignTab
            // 
            this.lblSelectedDeptAssignTab.AutoSize = true;
            this.lblSelectedDeptAssignTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedDeptAssignTab.Location = new System.Drawing.Point(345, 52);
            this.lblSelectedDeptAssignTab.Name = "lblSelectedDeptAssignTab";
            this.lblSelectedDeptAssignTab.Size = new System.Drawing.Size(98, 20);
            this.lblSelectedDeptAssignTab.TabIndex = 47;
            this.lblSelectedDeptAssignTab.Text = "Not selected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(166, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Selected department:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Search:";
            // 
            // tbxUserSearch
            // 
            this.tbxUserSearch.Location = new System.Drawing.Point(73, 87);
            this.tbxUserSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUserSearch.Name = "tbxUserSearch";
            this.tbxUserSearch.Size = new System.Drawing.Size(153, 23);
            this.tbxUserSearch.TabIndex = 44;
            this.tbxUserSearch.TextChanged += new System.EventHandler(this.tbxUserSearch_TextChanged);
            // 
            // btnAssignEmployee
            // 
            this.btnAssignEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssignEmployee.Location = new System.Drawing.Point(256, 87);
            this.btnAssignEmployee.Name = "btnAssignEmployee";
            this.btnAssignEmployee.Size = new System.Drawing.Size(169, 29);
            this.btnAssignEmployee.TabIndex = 43;
            this.btnAssignEmployee.Text = "Assign employee";
            this.btnAssignEmployee.UseVisualStyleBackColor = true;
            this.btnAssignEmployee.Click += new System.EventHandler(this.btnAssignEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(187, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Add employees to department";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DepoManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1129, 497);
            this.Controls.Add(this.tbControlEmployeeManager);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepartmentInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DepoManagerForm";
            this.Text = "DepoManagerForm";
            this.tbControlEmployeeManager.ResumeLayout(false);
            this.tabDepartmentInfo.ResumeLayout(false);
            this.tabDepartmentInfo.PerformLayout();
            this.tabAssignEmployees.ResumeLayout(false);
            this.tabAssignEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogOut;
        private Label label1;
        private Button btnDepartmentInfo;
        private TabControl tbControlEmployeeManager;
        private TabPage tabDepartmentInfo;
        private Button btnSeeDepts;
        private Button btnRemoveDept;
        private Button btnModifyDept;
        private ListBox lbxDepts;
        private TextBox tbxDeptName;
        private Button btnAddDept;
        private Label lbDepName;
        private TabPage tabAssignEmployees;
        private Label label4;
        private TextBox tbxUserSearch;
        private Button btnAssignEmployee;
        private Label label2;
        private Label lblSelectedDept;
        private Label label5;
        private Label lblSelectedDeptAssignTab;
        private Label label7;
        private Button btnSelectDept;
        private DataGridView dtgvUsers;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Position;
    }
}
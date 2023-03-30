namespace mediabazaar
{
    partial class DepartmentEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dtgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartment.Location = new System.Drawing.Point(189, 9);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(111, 38);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "<dept>";
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
            this.dtgvUsers.Location = new System.Drawing.Point(12, 60);
            this.dtgvUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvUsers.Name = "dtgvUsers";
            this.dtgvUsers.ReadOnly = true;
            this.dtgvUsers.RowHeadersWidth = 51;
            this.dtgvUsers.RowTemplate.Height = 25;
            this.dtgvUsers.Size = new System.Drawing.Size(776, 377);
            this.dtgvUsers.TabIndex = 49;
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
            // DepartmentEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvUsers);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentEmployees";
            this.Text = "DepartmentEmployees";
            this.Load += new System.EventHandler(this.DepartmentEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblDepartment;
        private DataGridView dtgvUsers;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Position;
    }
}
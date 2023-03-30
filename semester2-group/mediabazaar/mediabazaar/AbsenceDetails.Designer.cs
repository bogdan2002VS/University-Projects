namespace mediabazaar
{
    partial class AbsenceDetails
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
            this.dtpAbsence = new System.Windows.Forms.DateTimePicker();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.cbTicketStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateAbsence = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbAbsenceReason = new System.Windows.Forms.Label();
            this.lbAbsenceDescription = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpAbsence
            // 
            this.dtpAbsence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAbsence.Location = new System.Drawing.Point(34, 102);
            this.dtpAbsence.Name = "dtpAbsence";
            this.dtpAbsence.Size = new System.Drawing.Size(121, 23);
            this.dtpAbsence.TabIndex = 0;
            // 
            // rtbReason
            // 
            this.rtbReason.Location = new System.Drawing.Point(273, 102);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.Size = new System.Drawing.Size(250, 74);
            this.rtbReason.TabIndex = 1;
            this.rtbReason.Text = "";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(273, 223);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(250, 153);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // cbTicketStatus
            // 
            this.cbTicketStatus.FormattingEnabled = true;
            this.cbTicketStatus.Location = new System.Drawing.Point(34, 223);
            this.cbTicketStatus.Name = "cbTicketStatus";
            this.cbTicketStatus.Size = new System.Drawing.Size(121, 23);
            this.cbTicketStatus.TabIndex = 3;
            // 
            // btnUpdateAbsence
            // 
            this.btnUpdateAbsence.Location = new System.Drawing.Point(34, 391);
            this.btnUpdateAbsence.Name = "btnUpdateAbsence";
            this.btnUpdateAbsence.Size = new System.Drawing.Size(489, 42);
            this.btnUpdateAbsence.TabIndex = 4;
            this.btnUpdateAbsence.Text = "Confirm Absence";
            this.btnUpdateAbsence.UseVisualStyleBackColor = true;
            this.btnUpdateAbsence.Click += new System.EventHandler(this.btnUpdateAbsence_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(34, 84);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(34, 15);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Date:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(34, 205);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(42, 15);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status:";
            // 
            // lbAbsenceReason
            // 
            this.lbAbsenceReason.AutoSize = true;
            this.lbAbsenceReason.Location = new System.Drawing.Point(273, 84);
            this.lbAbsenceReason.Name = "lbAbsenceReason";
            this.lbAbsenceReason.Size = new System.Drawing.Size(96, 15);
            this.lbAbsenceReason.TabIndex = 7;
            this.lbAbsenceReason.Text = "Absence Reason:";
            // 
            // lbAbsenceDescription
            // 
            this.lbAbsenceDescription.AutoSize = true;
            this.lbAbsenceDescription.Location = new System.Drawing.Point(273, 205);
            this.lbAbsenceDescription.Name = "lbAbsenceDescription";
            this.lbAbsenceDescription.Size = new System.Drawing.Size(118, 15);
            this.lbAbsenceDescription.TabIndex = 8;
            this.lbAbsenceDescription.Text = "Absence Description:";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FirstName,
            this.LastName,
            this.Email,
            this.PhoneNumber});
            this.dgvEmployee.Location = new System.Drawing.Point(0, 1);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(563, 51);
            this.dgvEmployee.TabIndex = 9;
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
            // AbsenceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 442);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.lbAbsenceDescription);
            this.Controls.Add(this.lbAbsenceReason);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnUpdateAbsence);
            this.Controls.Add(this.cbTicketStatus);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.rtbReason);
            this.Controls.Add(this.dtpAbsence);
            this.Name = "AbsenceDetails";
            this.Text = "AbsenceDetails";
            this.Load += new System.EventHandler(this.AbsenceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpAbsence;
        private RichTextBox rtbReason;
        private RichTextBox rtbDescription;
        private ComboBox cbTicketStatus;
        private Button btnUpdateAbsence;
        private Label lbDate;
        private Label lbStatus;
        private Label lbAbsenceReason;
        private Label lbAbsenceDescription;
        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
    }
}
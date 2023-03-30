namespace mediabazaar
{
    partial class EmployeeForm
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
            this.btnCreateAbsence = new System.Windows.Forms.Button();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeeNameValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateAbsence
            // 
            this.btnCreateAbsence.Location = new System.Drawing.Point(0, 78);
            this.btnCreateAbsence.Name = "btnCreateAbsence";
            this.btnCreateAbsence.Size = new System.Drawing.Size(146, 58);
            this.btnCreateAbsence.TabIndex = 0;
            this.btnCreateAbsence.Text = "See Absences";
            this.btnCreateAbsence.UseVisualStyleBackColor = true;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(12, 9);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(60, 15);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "Welcome:";
            // 
            // lbEmployeeNameValue
            // 
            this.lbEmployeeNameValue.AutoSize = true;
            this.lbEmployeeNameValue.Location = new System.Drawing.Point(78, 9);
            this.lbEmployeeNameValue.Name = "lbEmployeeNameValue";
            this.lbEmployeeNameValue.Size = new System.Drawing.Size(0, 15);
            this.lbEmployeeNameValue.TabIndex = 2;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEmployeeNameValue);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.btnCreateAbsence);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCreateAbsence;
        private Label lbEmployeeName;
        private Label lbEmployeeNameValue;
    }
}
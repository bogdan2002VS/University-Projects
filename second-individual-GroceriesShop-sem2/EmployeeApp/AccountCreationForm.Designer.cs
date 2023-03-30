namespace EmployeeApp
{
    partial class AccountCreationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_createAcc = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label_fullName = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label_acctype = new System.Windows.Forms.Label();
            this.label_subtitle = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_createAcc
            // 
            this.button_createAcc.BackColor = System.Drawing.Color.Gold;
            this.button_createAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_createAcc.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.button_createAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_createAcc.Font = new System.Drawing.Font("SF Pro Display", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_createAcc.Location = new System.Drawing.Point(303, 350);
            this.button_createAcc.Name = "button_createAcc";
            this.button_createAcc.Size = new System.Drawing.Size(142, 63);
            this.button_createAcc.TabIndex = 24;
            this.button_createAcc.Text = "Create Account";
            this.button_createAcc.UseVisualStyleBackColor = false;
            this.button_createAcc.Click += new System.EventHandler(this.button_createAcc_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("SF Pro Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_password.Location = new System.Drawing.Point(16, 350);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(104, 23);
            this.label_password.TabIndex = 23;
            this.label_password.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(16, 378);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(226, 33);
            this.tbPassword.TabIndex = 22;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("SF Pro Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_email.Location = new System.Drawing.Point(16, 276);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(71, 23);
            this.label_email.TabIndex = 21;
            this.label_email.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(16, 304);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(226, 33);
            this.tbEmail.TabIndex = 20;
            // 
            // label_fullName
            // 
            this.label_fullName.AutoSize = true;
            this.label_fullName.Font = new System.Drawing.Font("SF Pro Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_fullName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_fullName.Location = new System.Drawing.Point(16, 206);
            this.label_fullName.Name = "label_fullName";
            this.label_fullName.Size = new System.Drawing.Size(105, 23);
            this.label_fullName.TabIndex = 19;
            this.label_fullName.Text = "Full Name";
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFullName.Location = new System.Drawing.Point(16, 234);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(226, 33);
            this.tbFullName.TabIndex = 18;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("SF Pro Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_username.Location = new System.Drawing.Point(16, 140);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(107, 23);
            this.label_username.TabIndex = 17;
            this.label_username.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(16, 168);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(226, 33);
            this.tbUsername.TabIndex = 16;
            // 
            // label_acctype
            // 
            this.label_acctype.AutoSize = true;
            this.label_acctype.Font = new System.Drawing.Font("SF Pro Display", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_acctype.ForeColor = System.Drawing.Color.Gold;
            this.label_acctype.Location = new System.Drawing.Point(265, 67);
            this.label_acctype.Name = "label_acctype";
            this.label_acctype.Size = new System.Drawing.Size(177, 35);
            this.label_acctype.TabIndex = 15;
            this.label_acctype.Text = "Type: STAFF";
            // 
            // label_subtitle
            // 
            this.label_subtitle.AutoSize = true;
            this.label_subtitle.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_subtitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_subtitle.Location = new System.Drawing.Point(12, 72);
            this.label_subtitle.Name = "label_subtitle";
            this.label_subtitle.Size = new System.Drawing.Size(251, 29);
            this.label_subtitle.TabIndex = 14;
            this.label_subtitle.Text = "Please fill entire form.";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("SF Pro Display", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_title.Location = new System.Drawing.Point(12, 25);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(368, 42);
            this.label_title.TabIndex = 13;
            this.label_title.Text = "Creating new Account";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // AccountCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(455, 453);
            this.Controls.Add(this.button_createAcc);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label_fullName);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label_acctype);
            this.Controls.Add(this.label_subtitle);
            this.Controls.Add(this.label_title);
            this.Name = "AccountCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_createAcc;
        private Label label_password;
        private TextBox tbPassword;
        private Label label_email;
        private TextBox tbEmail;
        private Label label_fullName;
        private TextBox tbFullName;
        private Label label_username;
        private TextBox tbUsername;
        private Label label_acctype;
        private Label label_subtitle;
        private Label label_title;
    }
}
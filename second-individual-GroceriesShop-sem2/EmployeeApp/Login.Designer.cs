namespace EmployeeApp
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbUsername.Location = new System.Drawing.Point(32, 99);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(246, 28);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPassword.Location = new System.Drawing.Point(32, 152);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(246, 28);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(39, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowPassword.Location = new System.Drawing.Point(159, 186);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(126, 20);
            this.cbShowPassword.TabIndex = 7;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Gold;
            this.button_login.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(32, 212);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(259, 54);
            this.button_login.TabIndex = 8;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(317, 296);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label3;
        private CheckBox cbShowPassword;
        private Button button_login;
    }
}
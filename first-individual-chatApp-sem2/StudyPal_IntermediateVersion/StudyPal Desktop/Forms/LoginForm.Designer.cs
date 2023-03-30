namespace StudyPalDesktop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblDhaa = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Teal;
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.lblCreateAccount);
            this.pnlLogin.Controls.Add(this.lblDhaa);
            this.pnlLogin.Controls.Add(this.tbPassword);
            this.pnlLogin.Controls.Add(this.tbUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.pnlPassword);
            this.pnlLogin.Controls.Add(this.pnlUsername);
            this.pnlLogin.Controls.Add(this.pbLogo);
            this.pnlLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLogin.Location = new System.Drawing.Point(369, 91);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(432, 394);
            this.pnlLogin.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(64, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 14);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(64, 157);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 14);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateAccount.ForeColor = System.Drawing.Color.White;
            this.lblCreateAccount.Location = new System.Drawing.Point(251, 348);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(120, 19);
            this.lblCreateAccount.TabIndex = 10;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // lblDhaa
            // 
            this.lblDhaa.AutoSize = true;
            this.lblDhaa.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDhaa.ForeColor = System.Drawing.Color.White;
            this.lblDhaa.Location = new System.Drawing.Point(57, 348);
            this.lblDhaa.Name = "lblDhaa";
            this.lblDhaa.Size = new System.Drawing.Size(175, 19);
            this.lblDhaa.TabIndex = 9;
            this.lblDhaa.Text = "Don\'t have an account?";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(64, 224);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(291, 23);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.Location = new System.Drawing.Point(64, 172);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(291, 23);
            this.tbUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gray;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(157, 275);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 33);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Location = new System.Drawing.Point(64, 248);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(291, 1);
            this.pnlPassword.TabIndex = 5;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.White;
            this.pnlUsername.Location = new System.Drawing.Point(64, 196);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(291, 1);
            this.pnlUsername.TabIndex = 4;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(157, 30);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(119, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.pnlLogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblDhaa;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

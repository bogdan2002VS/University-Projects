namespace StudyPalDesktop.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.Teal;
            this.pnlRegister.Controls.Add(this.tbName);
            this.pnlRegister.Controls.Add(this.lblName);
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.lblPassword);
            this.pnlRegister.Controls.Add(this.lblUsername);
            this.pnlRegister.Controls.Add(this.tbPassword);
            this.pnlRegister.Controls.Add(this.tbUsername);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.pnlPassword);
            this.pnlRegister.Controls.Add(this.pnlUsername);
            this.pnlRegister.Controls.Add(this.pbLogo);
            this.pnlRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRegister.Location = new System.Drawing.Point(383, 84);
            this.pnlRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(432, 394);
            this.pnlRegister.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(64, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 14);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 22;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(64, 255);
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
            this.lblUsername.Location = new System.Drawing.Point(64, 208);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 14);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(64, 271);
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
            this.tbUsername.Location = new System.Drawing.Point(64, 226);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(291, 23);
            this.tbUsername.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Gray;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(157, 322);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 33);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(64, 174);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(291, 23);
            this.tbName.TabIndex = 24;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.pnlRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyPalDesktop";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
    }
}
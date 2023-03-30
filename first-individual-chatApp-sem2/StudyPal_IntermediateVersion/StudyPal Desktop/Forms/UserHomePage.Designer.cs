namespace StudyPalDesktop.Presentation
{
    partial class UserHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomePage));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnUpdateMyAccount = new System.Windows.Forms.Button();
            this.btnDeleteMyAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnEnterRooms = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblDayMessage = new System.Windows.Forms.Label();
            this.pnlSide.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlSide.Controls.Add(this.pnlMenu);
            this.pnlSide.Controls.Add(this.btnLogOut);
            this.pnlSide.Controls.Add(this.pnlAccount);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(260, 565);
            this.pnlSide.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlMenu.Controls.Add(this.btnUpdateMyAccount);
            this.pnlMenu.Controls.Add(this.btnDeleteMyAccount);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 204);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(260, 304);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnUpdateMyAccount
            // 
            this.btnUpdateMyAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateMyAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateMyAccount.FlatAppearance.BorderSize = 0;
            this.btnUpdateMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMyAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateMyAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMyAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMyAccount.Image")));
            this.btnUpdateMyAccount.Location = new System.Drawing.Point(0, 50);
            this.btnUpdateMyAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateMyAccount.Name = "btnUpdateMyAccount";
            this.btnUpdateMyAccount.Size = new System.Drawing.Size(260, 50);
            this.btnUpdateMyAccount.TabIndex = 8;
            this.btnUpdateMyAccount.Text = "    Update My Account         ";
            this.btnUpdateMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMyAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateMyAccount.UseVisualStyleBackColor = false;
            this.btnUpdateMyAccount.Click += new System.EventHandler(this.btnUpdateMyAccount_Click);
            // 
            // btnDeleteMyAccount
            // 
            this.btnDeleteMyAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteMyAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteMyAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMyAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteMyAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMyAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMyAccount.Image")));
            this.btnDeleteMyAccount.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteMyAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMyAccount.Name = "btnDeleteMyAccount";
            this.btnDeleteMyAccount.Size = new System.Drawing.Size(260, 50);
            this.btnDeleteMyAccount.TabIndex = 7;
            this.btnDeleteMyAccount.Text = "     Delete My Account         ";
            this.btnDeleteMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMyAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteMyAccount.UseVisualStyleBackColor = false;
            this.btnDeleteMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(0, 515);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(260, 50);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlAccount
            // 
            this.pnlAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlAccount.Controls.Add(this.lblUser);
            this.pnlAccount.Controls.Add(this.pictureBox1);
            this.pnlAccount.Controls.Add(this.btnHome);
            this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(260, 204);
            this.pnlAccount.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(10, 124);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(113, 27);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 154);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(260, 50);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "     Home                              ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.Controls.Add(this.tbDescription);
            this.pnlContent.Controls.Add(this.tbSubjectName);
            this.pnlContent.Controls.Add(this.lblEnter);
            this.pnlContent.Controls.Add(this.btnEnterRooms);
            this.pnlContent.Controls.Add(this.comboBox1);
            this.pnlContent.Controls.Add(this.pnlHome);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(967, 565);
            this.pnlContent.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(281, 322);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(166, 23);
            this.tbDescription.TabIndex = 5;
            this.tbDescription.Text = "Type the Description";
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.Location = new System.Drawing.Point(281, 280);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(166, 23);
            this.tbSubjectName.TabIndex = 4;
            this.tbSubjectName.Text = "Type the Name";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnter.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnter.ForeColor = System.Drawing.Color.Transparent;
            this.lblEnter.Location = new System.Drawing.Point(280, 252);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(313, 18);
            this.lblEnter.TabIndex = 3;
            this.lblEnter.Text = "Select the subject and enter in the chat rooms";
            // 
            // btnEnterRooms
            // 
            this.btnEnterRooms.Location = new System.Drawing.Point(471, 299);
            this.btnEnterRooms.Name = "btnEnterRooms";
            this.btnEnterRooms.Size = new System.Drawing.Size(75, 23);
            this.btnEnterRooms.TabIndex = 2;
            this.btnEnterRooms.Text = "Enter";
            this.btnEnterRooms.UseVisualStyleBackColor = true;
            this.btnEnterRooms.Click += new System.EventHandler(this.btnEnterRooms_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.lblDayMessage);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(967, 231);
            this.pnlHome.TabIndex = 0;
            this.pnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHome_Paint);
            // 
            // lblDayMessage
            // 
            this.lblDayMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDayMessage.AutoSize = true;
            this.lblDayMessage.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDayMessage.ForeColor = System.Drawing.Color.White;
            this.lblDayMessage.Location = new System.Drawing.Point(408, 30);
            this.lblDayMessage.Name = "lblDayMessage";
            this.lblDayMessage.Size = new System.Drawing.Size(167, 29);
            this.lblDayMessage.TabIndex = 13;
            this.lblDayMessage.Text = "Good Morning!";
            this.lblDayMessage.Click += new System.EventHandler(this.lblDayMessage_Click);
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1227, 565);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1184, 602);
            this.Name = "UserHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.pnlSide.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Button btnDeleteMyAccount;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblDayMessage;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnEnterRooms;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbSubjectName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnUpdateMyAccount;
    }
}
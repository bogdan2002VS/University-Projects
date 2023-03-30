namespace EmployeeApp
{
    partial class UpdateStatusForm
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
            this.label_name = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label_subtitle = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.DelivceryAdressID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderStatus = new System.Windows.Forms.ComboBox();
            this.tbCreation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_name.Location = new System.Drawing.Point(24, 149);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(108, 29);
            this.label_name.TabIndex = 56;
            this.label_name.Text = "OrderID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbID.Location = new System.Drawing.Point(25, 184);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(66, 36);
            this.tbID.TabIndex = 55;
            // 
            // label_subtitle
            // 
            this.label_subtitle.AutoSize = true;
            this.label_subtitle.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_subtitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_subtitle.Location = new System.Drawing.Point(24, 88);
            this.label_subtitle.Name = "label_subtitle";
            this.label_subtitle.Size = new System.Drawing.Size(670, 48);
            this.label_subtitle.TabIndex = 54;
            this.label_subtitle.Text = "Here you can update only the status";
            this.label_subtitle.Click += new System.EventHandler(this.label_subtitle_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("SF Pro Display", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_title.Location = new System.Drawing.Point(14, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(582, 72);
            this.label_title.TabIndex = 53;
            this.label_title.Text = "Change orderStatus";
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbAdress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbAdress.Location = new System.Drawing.Point(25, 263);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.ReadOnly = true;
            this.tbAdress.Size = new System.Drawing.Size(255, 36);
            this.tbAdress.TabIndex = 74;
            // 
            // DelivceryAdressID
            // 
            this.DelivceryAdressID.AutoSize = true;
            this.DelivceryAdressID.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelivceryAdressID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelivceryAdressID.Location = new System.Drawing.Point(24, 228);
            this.DelivceryAdressID.Name = "DelivceryAdressID";
            this.DelivceryAdressID.Size = new System.Drawing.Size(98, 29);
            this.DelivceryAdressID.TabIndex = 73;
            this.DelivceryAdressID.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(25, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 72;
            this.label3.Text = "Customer";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbCustomer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbCustomer.Location = new System.Drawing.Point(25, 341);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.ReadOnly = true;
            this.tbCustomer.Size = new System.Drawing.Size(255, 36);
            this.tbCustomer.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(25, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 77;
            this.label2.Text = "Order Status";
            // 
            // tbOrderStatus
            // 
            this.tbOrderStatus.FormattingEnabled = true;
            this.tbOrderStatus.Items.AddRange(new object[] {
            "AWAITING SHIPMENT",
            "SHIPPED",
            "COMPLETED"});
            this.tbOrderStatus.Location = new System.Drawing.Point(25, 424);
            this.tbOrderStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOrderStatus.Name = "tbOrderStatus";
            this.tbOrderStatus.Size = new System.Drawing.Size(171, 28);
            this.tbOrderStatus.TabIndex = 76;
            // 
            // tbCreation
            // 
            this.tbCreation.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbCreation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbCreation.Location = new System.Drawing.Point(24, 493);
            this.tbCreation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCreation.Name = "tbCreation";
            this.tbCreation.ReadOnly = true;
            this.tbCreation.Size = new System.Drawing.Size(172, 36);
            this.tbCreation.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 78;
            this.label4.Text = "Created At";
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateOrder.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrder.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOrder.Location = new System.Drawing.Point(56, 559);
            this.btnUpdateOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(171, 99);
            this.btnUpdateOrder.TabIndex = 80;
            this.btnUpdateOrder.Text = "Update Order Status";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // UpdateStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(626, 711);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.tbCreation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOrderStatus);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.DelivceryAdressID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label_subtitle);
            this.Controls.Add(this.label_title);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateStatusForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_name;
        private TextBox tbID;
        private Label label_subtitle;
        private Label label_title;
        private TextBox tbAdress;
        private Label DelivceryAdressID;
        private Label label3;
        private TextBox tbCustomer;
        private Label label2;
        private ComboBox tbOrderStatus;
        private TextBox tbCreation;
        private Label label4;
        private Button btnUpdateOrder;
    }
}
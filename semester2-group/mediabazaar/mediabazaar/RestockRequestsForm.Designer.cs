namespace mediabazaar
{
    partial class RestockRequestsForm
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
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.btnAcceptRequest = new System.Windows.Forms.Button();
            this.lvRestockRequests = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colDateCreated = new System.Windows.Forms.ColumnHeader();
            this.colDateProcessed = new System.Windows.Forms.ColumnHeader();
            this.colProductID = new System.Windows.Forms.ColumnHeader();
            this.colProductName = new System.Windows.Forms.ColumnHeader();
            this.colCurrentStock = new System.Windows.Forms.ColumnHeader();
            this.colMinStock = new System.Windows.Forms.ColumnHeader();
            this.colRequestAmount = new System.Windows.Forms.ColumnHeader();
            this.columnStatus = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDenyRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDenyRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenyRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDenyRequest.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDenyRequest.Location = new System.Drawing.Point(258, 270);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(262, 52);
            this.btnDenyRequest.TabIndex = 8;
            this.btnDenyRequest.Text = "Deny Request";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            // 
            // btnAcceptRequest
            // 
            this.btnAcceptRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAcceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcceptRequest.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAcceptRequest.Location = new System.Drawing.Point(526, 270);
            this.btnAcceptRequest.Name = "btnAcceptRequest";
            this.btnAcceptRequest.Size = new System.Drawing.Size(262, 52);
            this.btnAcceptRequest.TabIndex = 7;
            this.btnAcceptRequest.Text = "Accept Request";
            this.btnAcceptRequest.UseVisualStyleBackColor = true;
            this.btnAcceptRequest.Click += new System.EventHandler(this.btnAcceptRequest_Click);
            // 
            // lvRestockRequests
            // 
            this.lvRestockRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDateCreated,
            this.colDateProcessed,
            this.colProductID,
            this.colProductName,
            this.colCurrentStock,
            this.colMinStock,
            this.colRequestAmount,
            this.columnStatus});
            this.lvRestockRequests.FullRowSelect = true;
            this.lvRestockRequests.GridLines = true;
            this.lvRestockRequests.Location = new System.Drawing.Point(12, 11);
            this.lvRestockRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvRestockRequests.MultiSelect = false;
            this.lvRestockRequests.Name = "lvRestockRequests";
            this.lvRestockRequests.Size = new System.Drawing.Size(995, 245);
            this.lvRestockRequests.TabIndex = 6;
            this.lvRestockRequests.UseCompatibleStateImageBehavior = false;
            this.lvRestockRequests.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date created";
            this.colDateCreated.Width = 150;
            // 
            // colDateProcessed
            // 
            this.colDateProcessed.Text = "Date processed";
            this.colDateProcessed.Width = 150;
            // 
            // colProductID
            // 
            this.colProductID.Text = "Product ID";
            this.colProductID.Width = 120;
            // 
            // colProductName
            // 
            this.colProductName.Text = "Product name";
            this.colProductName.Width = 180;
            // 
            // colCurrentStock
            // 
            this.colCurrentStock.Text = "Current stock";
            this.colCurrentStock.Width = 100;
            // 
            // colMinStock
            // 
            this.colMinStock.Text = "Min. Stock";
            this.colMinStock.Width = 80;
            // 
            // colRequestAmount
            // 
            this.colRequestAmount.Text = "Requested amount";
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 100;
            // 
            // RestockRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 354);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnAcceptRequest);
            this.Controls.Add(this.lvRestockRequests);
            this.Name = "RestockRequestsForm";
            this.Text = "RestockRequestsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDenyRequest;
        private Button btnAcceptRequest;
        private ListView lvRestockRequests;
        private ColumnHeader colID;
        private ColumnHeader colDateCreated;
        private ColumnHeader colDateProcessed;
        private ColumnHeader colProductID;
        private ColumnHeader colProductName;
        private ColumnHeader colCurrentStock;
        private ColumnHeader colMinStock;
        private ColumnHeader colRequestAmount;
        private ColumnHeader columnStatus;
    }
}
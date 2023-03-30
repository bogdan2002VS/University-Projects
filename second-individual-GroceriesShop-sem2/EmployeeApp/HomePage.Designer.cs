namespace EmployeeApp
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lbOrderStatus = new System.Windows.Forms.Label();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(446, -51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 751);
            this.panel1.TabIndex = 50;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProduct.Location = new System.Drawing.Point(607, 12);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(240, 29);
            this.lbProduct.TabIndex = 55;
            this.lbProduct.Text = "Product Information";
            // 
            // lbxProducts
            // 
            this.lbxProducts.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbxProducts.ForeColor = System.Drawing.Color.White;
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 25;
            this.lbxProducts.Location = new System.Drawing.Point(493, 101);
            this.lbxProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(408, 400);
            this.lbxProducts.TabIndex = 56;
            this.lbxProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            this.lbxProducts.DoubleClick += new System.EventHandler(this.lbProducts_DoubleClick);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.Gold;
            this.btnCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProduct.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProduct.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProduct.Location = new System.Drawing.Point(517, 549);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(145, 75);
            this.btnCreateProduct.TabIndex = 57;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // lbOrderStatus
            // 
            this.lbOrderStatus.AutoSize = true;
            this.lbOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderStatus.Location = new System.Drawing.Point(85, 12);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(160, 29);
            this.lbOrderStatus.TabIndex = 58;
            this.lbOrderStatus.Text = "Order Status";
            // 
            // lbxOrders
            // 
            this.lbxOrders.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbxOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbxOrders.ForeColor = System.Drawing.Color.White;
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.ItemHeight = 25;
            this.lbxOrders.Location = new System.Drawing.Point(14, 101);
            this.lbxOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(408, 400);
            this.lbxOrders.TabIndex = 59;
            this.lbxOrders.SelectedIndexChanged += new System.EventHandler(this.lbxProducts_SelectedIndexChanged);
            this.lbxOrders.DoubleClick += new System.EventHandler(this.lbOrders_DoubleClick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(982, 700);
            this.Controls.Add(this.lbxOrders);
            this.Controls.Add(this.lbOrderStatus);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.lbxProducts);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lbProduct;
        private ListBox lbxProducts;
        private Button btnCreateProduct;
        private Label lbOrderStatus;
        private ListBox lbxOrders;
    }
}
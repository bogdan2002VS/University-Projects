namespace mediabazaar
{
    partial class ProductManagerForm
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
            this.btnProductInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductStats = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tbControlEmployeeManager = new System.Windows.Forms.TabControl();
            this.tabEmployeeInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxProductStatus = new System.Windows.Forms.ComboBox();
            this.btnSeeProducts = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.tbxMinStock = new System.Windows.Forms.TextBox();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lbMinStock = new System.Windows.Forms.Label();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbControlEmployeeManager.SuspendLayout();
            this.tabEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductInfo
            // 
            this.btnProductInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnProductInfo.FlatAppearance.BorderSize = 0;
            this.btnProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductInfo.Location = new System.Drawing.Point(0, 49);
            this.btnProductInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnProductInfo.Name = "btnProductInfo";
            this.btnProductInfo.Size = new System.Drawing.Size(262, 99);
            this.btnProductInfo.TabIndex = 1;
            this.btnProductInfo.Text = "Product Info";
            this.btnProductInfo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // btnProductStats
            // 
            this.btnProductStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.btnProductStats.FlatAppearance.BorderSize = 0;
            this.btnProductStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductStats.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductStats.Location = new System.Drawing.Point(0, 167);
            this.btnProductStats.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnProductStats.Name = "btnProductStats";
            this.btnProductStats.Size = new System.Drawing.Size(262, 100);
            this.btnProductStats.TabIndex = 3;
            this.btnProductStats.Text = "Product Stats";
            this.btnProductStats.UseVisualStyleBackColor = false;
            this.btnProductStats.Click += new System.EventHandler(this.btnProductStats_Click_1);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(8, 455);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(238, 34);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tbControlEmployeeManager
            // 
            this.tbControlEmployeeManager.Controls.Add(this.tabEmployeeInfo);
            this.tbControlEmployeeManager.Location = new System.Drawing.Point(260, 0);
            this.tbControlEmployeeManager.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbControlEmployeeManager.Name = "tbControlEmployeeManager";
            this.tbControlEmployeeManager.SelectedIndex = 0;
            this.tbControlEmployeeManager.Size = new System.Drawing.Size(616, 514);
            this.tbControlEmployeeManager.TabIndex = 7;
            // 
            // tabEmployeeInfo
            // 
            this.tabEmployeeInfo.Controls.Add(this.button1);
            this.tabEmployeeInfo.Controls.Add(this.tbxPrice);
            this.tabEmployeeInfo.Controls.Add(this.label2);
            this.tabEmployeeInfo.Controls.Add(this.cbxDepartment);
            this.tabEmployeeInfo.Controls.Add(this.lbDepartment);
            this.tabEmployeeInfo.Controls.Add(this.btnSearch);
            this.tabEmployeeInfo.Controls.Add(this.cbxProductStatus);
            this.tabEmployeeInfo.Controls.Add(this.btnSeeProducts);
            this.tabEmployeeInfo.Controls.Add(this.tbxSearch);
            this.tabEmployeeInfo.Controls.Add(this.btnRemoveProduct);
            this.tabEmployeeInfo.Controls.Add(this.btnModifyProduct);
            this.tabEmployeeInfo.Controls.Add(this.lbxProducts);
            this.tabEmployeeInfo.Controls.Add(this.tbxMinStock);
            this.tabEmployeeInfo.Controls.Add(this.tbxBarcode);
            this.tabEmployeeInfo.Controls.Add(this.tbxAmount);
            this.tabEmployeeInfo.Controls.Add(this.tbxProductName);
            this.tabEmployeeInfo.Controls.Add(this.lbMinStock);
            this.tabEmployeeInfo.Controls.Add(this.lbBarcode);
            this.tabEmployeeInfo.Controls.Add(this.btnAddProduct);
            this.tabEmployeeInfo.Controls.Add(this.lbPrice);
            this.tabEmployeeInfo.Controls.Add(this.lbAmount);
            this.tabEmployeeInfo.Controls.Add(this.lbProductName);
            this.tabEmployeeInfo.Location = new System.Drawing.Point(4, 24);
            this.tabEmployeeInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tabEmployeeInfo.Name = "tabEmployeeInfo";
            this.tabEmployeeInfo.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tabEmployeeInfo.Size = new System.Drawing.Size(608, 486);
            this.tabEmployeeInfo.TabIndex = 0;
            this.tabEmployeeInfo.Text = "tabProductInfo";
            this.tabEmployeeInfo.UseVisualStyleBackColor = true;
            this.tabEmployeeInfo.Click += new System.EventHandler(this.tabEmployeeInfo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(149, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 48);
            this.button1.TabIndex = 46;
            this.button1.Text = "generate barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.DecimalPlaces = 2;
            this.tbxPrice.Location = new System.Drawing.Point(247, 76);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(120, 23);
            this.tbxPrice.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(406, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Product State :";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(10, 133);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(134, 23);
            this.cbxDepartment.TabIndex = 43;
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDepartment.Location = new System.Drawing.Point(10, 110);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(102, 20);
            this.lbDepartment.TabIndex = 41;
            this.lbDepartment.Text = "Department :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(531, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "🔍Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // cbxProductStatus
            // 
            this.cbxProductStatus.FormattingEnabled = true;
            this.cbxProductStatus.Location = new System.Drawing.Point(406, 101);
            this.cbxProductStatus.Name = "cbxProductStatus";
            this.cbxProductStatus.Size = new System.Drawing.Size(134, 23);
            this.cbxProductStatus.TabIndex = 39;
            // 
            // btnSeeProducts
            // 
            this.btnSeeProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeeProducts.Location = new System.Drawing.Point(463, 240);
            this.btnSeeProducts.Name = "btnSeeProducts";
            this.btnSeeProducts.Size = new System.Drawing.Size(146, 33);
            this.btnSeeProducts.TabIndex = 37;
            this.btnSeeProducts.Text = " See Products";
            this.btnSeeProducts.UseVisualStyleBackColor = true;
            this.btnSeeProducts.Click += new System.EventHandler(this.btnSeeProducts_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(393, 28);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(134, 23);
            this.tbxSearch.TabIndex = 8;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveProduct.Location = new System.Drawing.Point(312, 240);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(146, 33);
            this.btnRemoveProduct.TabIndex = 36;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifyProduct.Location = new System.Drawing.Point(161, 240);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(146, 33);
            this.btnModifyProduct.TabIndex = 35;
            this.btnModifyProduct.Text = "Modify Product";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // lbxProducts
            // 
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 15;
            this.lbxProducts.Location = new System.Drawing.Point(10, 279);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(599, 184);
            this.lbxProducts.TabIndex = 19;
            this.lbxProducts.SelectedIndexChanged += new System.EventHandler(this.lbxProducts_SelectedIndexChanged);
            this.lbxProducts.DoubleClick += new System.EventHandler(this.lbxProducts_DoubleClick);
            // 
            // tbxMinStock
            // 
            this.tbxMinStock.Location = new System.Drawing.Point(246, 125);
            this.tbxMinStock.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMinStock.Name = "tbxMinStock";
            this.tbxMinStock.Size = new System.Drawing.Size(134, 23);
            this.tbxMinStock.TabIndex = 34;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(10, 85);
            this.tbxBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(134, 23);
            this.tbxBarcode.TabIndex = 33;
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(246, 28);
            this.tbxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(134, 23);
            this.tbxAmount.TabIndex = 22;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(10, 28);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(134, 23);
            this.tbxProductName.TabIndex = 21;
            // 
            // lbMinStock
            // 
            this.lbMinStock.AutoSize = true;
            this.lbMinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMinStock.Location = new System.Drawing.Point(246, 105);
            this.lbMinStock.Name = "lbMinStock";
            this.lbMinStock.Size = new System.Drawing.Size(121, 20);
            this.lbMinStock.TabIndex = 20;
            this.lbMinStock.Text = "Minimum Stock:";
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBarcode.Location = new System.Drawing.Point(10, 65);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(73, 20);
            this.lbBarcode.TabIndex = 19;
            this.lbBarcode.Text = "Barcode:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(10, 240);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(146, 33);
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(246, 53);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 20);
            this.lbPrice.TabIndex = 10;
            this.lbPrice.Text = "Price:";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAmount.Location = new System.Drawing.Point(246, 8);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(69, 20);
            this.lbAmount.TabIndex = 1;
            this.lbAmount.Text = "Amount:";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(10, 8);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(118, 20);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name :";
            this.lbProductName.Click += new System.EventHandler(this.lbBoughtFor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 100);
            this.button2.TabIndex = 8;
            this.button2.Text = "Restock Request";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1128, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbControlEmployeeManager);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnProductStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductManagerForm";
            this.Text = "ProductManagerForm";
            this.tbControlEmployeeManager.ResumeLayout(false);
            this.tabEmployeeInfo.ResumeLayout(false);
            this.tabEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnProductInfo;
        private Label label1;
        private Button btnProductStats;
        private Button btnLogOut;
        private TabControl tbControlEmployeeManager;
        private TabPage tabEmployeeInfo;
        private Button btnAddProduct;
        private Label lbMinStock;
        private Label lbBarcode;
        private TextBox tbxSearch;
        private ListBox lbxProducts;
        private TextBox tbxMinStock;
        private TextBox tbxBarcode;
        private Button btnSeeProducts;
        private Button btnRemoveProduct;
        private Button btnModifyProduct;
        private Button btnSearch;
        private TextBox tbxAmount;
        private TextBox tbxProductName;
        private Label lbAmount;
        private Label lbProductName;
        private Label lbPrice;
        private ComboBox cbxProductStatus;
        private Label label2;
        private ComboBox cbxDepartment;
        private Label lbDepartment;
        private NumericUpDown tbxPrice;
        private Button button1;
        private Button button2;
    }
}
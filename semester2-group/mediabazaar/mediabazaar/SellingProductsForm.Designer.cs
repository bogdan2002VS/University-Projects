namespace mediabazaar
{
    partial class SellingProductsForm
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
            this.components = new System.ComponentModel.Container();
            this.lvAllItems = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colEan = new System.Windows.Forms.ColumnHeader();
            this.colDeptName = new System.Windows.Forms.ColumnHeader();
            this.colStock = new System.Windows.Forms.ColumnHeader();
            this.colMinStock = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.colProductStatus = new System.Windows.Forms.ColumnHeader();
            this.lvCart = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnAmount = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.btnSellCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chbxAutoAdd = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSeatch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.btnResetCart = new System.Windows.Forms.Button();
            this.autoAddToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nmrAddAmountToCart = new System.Windows.Forms.NumericUpDown();
            this.btnAddAmountToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAddAmountToCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAllItems
            // 
            this.lvAllItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colEan,
            this.colDeptName,
            this.colStock,
            this.colMinStock,
            this.colPrice,
            this.colProductStatus});
            this.lvAllItems.FullRowSelect = true;
            this.lvAllItems.GridLines = true;
            this.lvAllItems.Location = new System.Drawing.Point(12, 74);
            this.lvAllItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAllItems.MultiSelect = false;
            this.lvAllItems.Name = "lvAllItems";
            this.lvAllItems.Size = new System.Drawing.Size(864, 139);
            this.lvAllItems.TabIndex = 4;
            this.lvAllItems.UseCompatibleStateImageBehavior = false;
            this.lvAllItems.View = System.Windows.Forms.View.Details;
            this.lvAllItems.SelectedIndexChanged += new System.EventHandler(this.lvAllItems_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 30;
            // 
            // colName
            // 
            this.colName.Text = "Product name";
            this.colName.Width = 200;
            // 
            // colEan
            // 
            this.colEan.Text = "Barcode";
            this.colEan.Width = 150;
            // 
            // colDeptName
            // 
            this.colDeptName.Text = "Department";
            this.colDeptName.Width = 120;
            // 
            // colStock
            // 
            this.colStock.Text = "In stock";
            this.colStock.Width = 80;
            // 
            // colMinStock
            // 
            this.colMinStock.Text = "Min. Stock";
            this.colMinStock.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 100;
            // 
            // colProductStatus
            // 
            this.colProductStatus.Text = "ProductStatus";
            this.colProductStatus.Width = 100;
            // 
            // lvCart
            // 
            this.lvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnAmount,
            this.columnPrice});
            this.lvCart.FullRowSelect = true;
            this.lvCart.GridLines = true;
            this.lvCart.Location = new System.Drawing.Point(2, 249);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(497, 169);
            this.lvCart.TabIndex = 16;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "Product name";
            this.columnName.Width = 300;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(647, 345);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(99, 23);
            this.tbxTotal.TabIndex = 21;
            // 
            // btnSellCart
            // 
            this.btnSellCart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSellCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSellCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSellCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSellCart.ForeColor = System.Drawing.Color.White;
            this.btnSellCart.Location = new System.Drawing.Point(536, 372);
            this.btnSellCart.Name = "btnSellCart";
            this.btnSellCart.Size = new System.Drawing.Size(254, 38);
            this.btnSellCart.TabIndex = 20;
            this.btnSellCart.Text = "Sell Cart";
            this.btnSellCart.UseVisualStyleBackColor = false;
            this.btnSellCart.Click += new System.EventHandler(this.btnSellCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(558, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "TOTAL:";
            // 
            // chbxAutoAdd
            // 
            this.chbxAutoAdd.AutoSize = true;
            this.chbxAutoAdd.Location = new System.Drawing.Point(292, 15);
            this.chbxAutoAdd.Name = "chbxAutoAdd";
            this.chbxAutoAdd.Size = new System.Drawing.Size(77, 19);
            this.chbxAutoAdd.TabIndex = 23;
            this.chbxAutoAdd.Text = "Auto-add";
            this.chbxAutoAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(188, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "🔍Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSeatch
            // 
            this.lblSeatch.AutoSize = true;
            this.lblSeatch.Location = new System.Drawing.Point(11, 16);
            this.lblSeatch.Name = "lblSeatch";
            this.lblSeatch.Size = new System.Drawing.Size(42, 15);
            this.lblSeatch.TabIndex = 25;
            this.lblSeatch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(59, 13);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(123, 23);
            this.tbSearch.TabIndex = 24;
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoveEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveEntry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEntry.ForeColor = System.Drawing.Color.White;
            this.btnRemoveEntry.Location = new System.Drawing.Point(342, 434);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(153, 24);
            this.btnRemoveEntry.TabIndex = 28;
            this.btnRemoveEntry.Text = "Remove selected entry";
            this.btnRemoveEntry.UseVisualStyleBackColor = false;
            // 
            // btnResetCart
            // 
            this.btnResetCart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnResetCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetCart.ForeColor = System.Drawing.Color.White;
            this.btnResetCart.Location = new System.Drawing.Point(11, 433);
            this.btnResetCart.Name = "btnResetCart";
            this.btnResetCart.Size = new System.Drawing.Size(153, 25);
            this.btnResetCart.TabIndex = 27;
            this.btnResetCart.Text = "Reset Cart";
            this.btnResetCart.UseVisualStyleBackColor = false;
            this.btnResetCart.Click += new System.EventHandler(this.btnResetCart_Click);
            // 
            // nmrAddAmountToCart
            // 
            this.nmrAddAmountToCart.Location = new System.Drawing.Point(690, 249);
            this.nmrAddAmountToCart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrAddAmountToCart.Name = "nmrAddAmountToCart";
            this.nmrAddAmountToCart.Size = new System.Drawing.Size(66, 23);
            this.nmrAddAmountToCart.TabIndex = 19;
            this.nmrAddAmountToCart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddAmountToCart
            // 
            this.btnAddAmountToCart.BackColor = System.Drawing.Color.Silver;
            this.btnAddAmountToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAmountToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAmountToCart.Location = new System.Drawing.Point(647, 275);
            this.btnAddAmountToCart.Name = "btnAddAmountToCart";
            this.btnAddAmountToCart.Size = new System.Drawing.Size(153, 32);
            this.btnAddAmountToCart.TabIndex = 18;
            this.btnAddAmountToCart.Text = "Add amount to cart";
            this.btnAddAmountToCart.UseVisualStyleBackColor = false;
            // 
            // SellingProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 480);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnResetCart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSeatch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.chbxAutoAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.btnSellCart);
            this.Controls.Add(this.btnAddAmountToCart);
            this.Controls.Add(this.nmrAddAmountToCart);
            this.Controls.Add(this.lvCart);
            this.Controls.Add(this.lvAllItems);
            this.Name = "SellingProductsForm";
            this.Text = "SellingProductsForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SellingProductsForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAddAmountToCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvAllItems;
        private ColumnHeader colID;
        private ColumnHeader colName;
        private ColumnHeader colEan;
        private ColumnHeader colDeptName;
        private ColumnHeader colStock;
        private ColumnHeader colMinStock;
        private ColumnHeader colPrice;
        private ColumnHeader colProductStatus;
        private ListView lvCart;
        private ColumnHeader columnID;
        private ColumnHeader columnName;
        private ColumnHeader columnAmount;
        private ColumnHeader columnPrice;
        private TextBox tbxTotal;
        private Button btnSellCart;
        private Label label1;
        private CheckBox chbxAutoAdd;
        private Button btnSearch;
        private Label lblSeatch;
        private TextBox tbSearch;
        private Button btnRemoveEntry;
        private Button btnResetCart;
        private ToolTip autoAddToolTip;
        private NumericUpDown nmrAddAmountToCart;
        private Button btnAddAmountToCart;
    }
}
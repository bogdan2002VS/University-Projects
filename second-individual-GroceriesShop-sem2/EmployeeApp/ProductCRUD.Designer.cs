namespace EmployeeApp
{
    partial class ProductCRUD
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_subtitle = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.Price = new System.Windows.Forms.Label();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSCategory = new System.Windows.Forms.ComboBox();
            this.label_sport = new System.Windows.Forms.Label();
            this.textbox_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.lbUnitUpdate = new System.Windows.Forms.TextBox();
            this.lbUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("SF Pro Display", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_title.Location = new System.Drawing.Point(12, 22);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(526, 57);
            this.label_title.TabIndex = 33;
            this.label_title.Text = "Add item to the catalog";
            // 
            // label_subtitle
            // 
            this.label_subtitle.AutoSize = true;
            this.label_subtitle.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_subtitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_subtitle.Location = new System.Drawing.Point(21, 79);
            this.label_subtitle.Name = "label_subtitle";
            this.label_subtitle.Size = new System.Drawing.Size(487, 38);
            this.label_subtitle.TabIndex = 34;
            this.label_subtitle.Text = "Here you can update the product";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_name.Location = new System.Drawing.Point(21, 117);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(65, 23);
            this.label_name.TabIndex = 36;
            this.label_name.Text = "Name";
            // 
            // textbox_name
            // 
            this.textbox_name.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textbox_name.Location = new System.Drawing.Point(21, 145);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(269, 30);
            this.textbox_name.TabIndex = 35;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(21, 548);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 23);
            this.nudPrice.TabIndex = 45;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Price.Location = new System.Drawing.Point(21, 522);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(58, 23);
            this.Price.TabIndex = 44;
            this.Price.Text = "Price";
            // 
            // combobox1
            // 
            this.combobox1.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(21, 434);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(183, 22);
            this.combobox1.TabIndex = 43;
            this.combobox1.SelectedIndexChanged += new System.EventHandler(this.combobox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sub-Category";
            // 
            // cbSCategory
            // 
            this.cbSCategory.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSCategory.FormattingEnabled = true;
            this.cbSCategory.Location = new System.Drawing.Point(21, 488);
            this.cbSCategory.Name = "cbSCategory";
            this.cbSCategory.Size = new System.Drawing.Size(183, 31);
            this.cbSCategory.TabIndex = 41;
            // 
            // label_sport
            // 
            this.label_sport.AutoSize = true;
            this.label_sport.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_sport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_sport.Location = new System.Drawing.Point(21, 396);
            this.label_sport.Name = "label_sport";
            this.label_sport.Size = new System.Drawing.Size(97, 23);
            this.label_sport.TabIndex = 40;
            this.label_sport.Text = "Category";
            // 
            // textbox_description
            // 
            this.textbox_description.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textbox_description.Location = new System.Drawing.Point(21, 209);
            this.textbox_description.Multiline = true;
            this.textbox_description.Name = "textbox_description";
            this.textbox_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_description.Size = new System.Drawing.Size(269, 184);
            this.textbox_description.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Description";
            // 
            // pbItemImage
            // 
            this.pbItemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItemImage.Location = new System.Drawing.Point(323, 145);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(215, 248);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItemImage.TabIndex = 47;
            this.pbItemImage.TabStop = false;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProduct.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProduct.Location = new System.Drawing.Point(430, 445);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(101, 74);
            this.btnUpdateProduct.TabIndex = 46;
            this.btnUpdateProduct.Text = "Update product";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Gold;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.Location = new System.Drawing.Point(323, 445);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(101, 74);
            this.btnDeleteProduct.TabIndex = 49;
            this.btnDeleteProduct.Text = "Delete product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.Gold;
            this.btnUploadImage.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUploadImage.Location = new System.Drawing.Point(374, 394);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(115, 45);
            this.btnUploadImage.TabIndex = 50;
            this.btnUploadImage.Text = "Upload image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // lbUnitUpdate
            // 
            this.lbUnitUpdate.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnitUpdate.Location = new System.Drawing.Point(22, 608);
            this.lbUnitUpdate.Name = "lbUnitUpdate";
            this.lbUnitUpdate.Size = new System.Drawing.Size(182, 30);
            this.lbUnitUpdate.TabIndex = 51;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUnit.Location = new System.Drawing.Point(22, 582);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(50, 23);
            this.lbUnit.TabIndex = 52;
            this.lbUnit.Text = "Unit";
            // 
            // ProductCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(602, 686);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.lbUnitUpdate);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.combobox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSCategory);
            this.Controls.Add(this.label_sport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_description);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label_subtitle);
            this.Controls.Add(this.label_title);
            this.Name = "ProductCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_title;
        private Label label_subtitle;
        private Label label_name;
        private TextBox textbox_name;
        private NumericUpDown nudPrice;
        private Label Price;
        private ComboBox combobox1;
        private Label label1;
        private ComboBox cbSCategory;
        private Label label_sport;
        private TextBox textbox_description;
        private Label label2;
        private PictureBox pbItemImage;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Button btnUploadImage;
        private TextBox lbUnitUpdate;
        private Label lbUnit;
    }
}
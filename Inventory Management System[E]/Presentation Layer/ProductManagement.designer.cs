namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadProductListGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.searchProductNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addQuantityProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addProductQuantityButton = new System.Windows.Forms.Button();
            this.addProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchByQuantityNumberTextBox = new System.Windows.Forms.TextBox();
            this.loadInsufficientQuantityProductsListGridView = new System.Windows.Forms.DataGridView();
            this.backToHomeBuktton1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadProductListGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadInsufficientQuantityProductsListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteProductButton);
            this.groupBox1.Controls.Add(this.UpdateProductButton);
            this.groupBox1.Controls.Add(this.productCategoryComboBox);
            this.groupBox1.Controls.Add(this.productQuantityTextBox);
            this.groupBox1.Controls.Add(this.productPriceTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(700, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Add/Update/Delete";
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteProductButton.Location = new System.Drawing.Point(334, 263);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(111, 30);
            this.DeleteProductButton.TabIndex = 10;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.BackColor = System.Drawing.Color.DarkGray;
            this.UpdateProductButton.Location = new System.Drawing.Point(202, 263);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(111, 30);
            this.UpdateProductButton.TabIndex = 9;
            this.UpdateProductButton.Text = "Update";
            this.UpdateProductButton.UseVisualStyleBackColor = false;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.BackColor = System.Drawing.Color.Silver;
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Location = new System.Drawing.Point(167, 181);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(195, 27);
            this.productCategoryComboBox.TabIndex = 8;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.BackColor = System.Drawing.Color.Silver;
            this.productQuantityTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantityTextBox.Location = new System.Drawing.Point(167, 135);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(195, 26);
            this.productQuantityTextBox.TabIndex = 7;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.BackColor = System.Drawing.Color.Silver;
            this.productPriceTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceTextBox.Location = new System.Drawing.Point(167, 94);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(195, 26);
            this.productPriceTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.DarkGray;
            this.addProductButton.Location = new System.Drawing.Point(62, 263);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(117, 30);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.productNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(167, 53);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(195, 26);
            this.productNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // loadProductListGridView
            // 
            this.loadProductListGridView.AllowUserToAddRows = false;
            this.loadProductListGridView.AllowUserToDeleteRows = false;
            this.loadProductListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadProductListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadProductListGridView.Location = new System.Drawing.Point(0, 89);
            this.loadProductListGridView.Name = "loadProductListGridView";
            this.loadProductListGridView.ReadOnly = true;
            this.loadProductListGridView.Size = new System.Drawing.Size(669, 204);
            this.loadProductListGridView.TabIndex = 1;
            this.loadProductListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadProductListGridView_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Search by Product Name";
            // 
            // searchProductNameTextBox
            // 
            this.searchProductNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.searchProductNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductNameTextBox.Location = new System.Drawing.Point(266, 45);
            this.searchProductNameTextBox.Name = "searchProductNameTextBox";
            this.searchProductNameTextBox.Size = new System.Drawing.Size(172, 26);
            this.searchProductNameTextBox.TabIndex = 10;
            this.searchProductNameTextBox.TextChanged += new System.EventHandler(this.searchProductNameTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadProductListGridView);
            this.groupBox2.Controls.Add(this.searchProductNameTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 293);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Products";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addQuantityProductNameTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.addProductQuantityButton);
            this.groupBox3.Controls.Add(this.addProductQuantityTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(700, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 224);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Quantity of Products";
            // 
            // addQuantityProductNameTextBox
            // 
            this.addQuantityProductNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.addQuantityProductNameTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantityProductNameTextBox.Location = new System.Drawing.Point(209, 61);
            this.addQuantityProductNameTextBox.Name = "addQuantityProductNameTextBox";
            this.addQuantityProductNameTextBox.Size = new System.Drawing.Size(195, 26);
            this.addQuantityProductNameTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Product Name";
            // 
            // addProductQuantityButton
            // 
            this.addProductQuantityButton.BackColor = System.Drawing.Color.DarkGray;
            this.addProductQuantityButton.Location = new System.Drawing.Point(226, 158);
            this.addProductQuantityButton.Name = "addProductQuantityButton";
            this.addProductQuantityButton.Size = new System.Drawing.Size(153, 30);
            this.addProductQuantityButton.TabIndex = 11;
            this.addProductQuantityButton.Text = "Add Quantity";
            this.addProductQuantityButton.UseVisualStyleBackColor = false;
            this.addProductQuantityButton.Click += new System.EventHandler(this.addProductQuantityButton_Click);
            // 
            // addProductQuantityTextBox
            // 
            this.addProductQuantityTextBox.BackColor = System.Drawing.Color.Silver;
            this.addProductQuantityTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductQuantityTextBox.Location = new System.Drawing.Point(209, 112);
            this.addProductQuantityTextBox.Name = "addProductQuantityTextBox";
            this.addProductQuantityTextBox.Size = new System.Drawing.Size(195, 26);
            this.addProductQuantityTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.searchByQuantityNumberTextBox);
            this.groupBox4.Controls.Add(this.loadInsufficientQuantityProductsListGridView);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(669, 267);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insufficient Quantity of Products";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(521, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "(Default value 10)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Products which have Quantity less than or equal";
            // 
            // searchByQuantityNumberTextBox
            // 
            this.searchByQuantityNumberTextBox.BackColor = System.Drawing.Color.Silver;
            this.searchByQuantityNumberTextBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByQuantityNumberTextBox.Location = new System.Drawing.Point(417, 39);
            this.searchByQuantityNumberTextBox.Name = "searchByQuantityNumberTextBox";
            this.searchByQuantityNumberTextBox.Size = new System.Drawing.Size(98, 25);
            this.searchByQuantityNumberTextBox.TabIndex = 12;
            this.searchByQuantityNumberTextBox.Text = "10";
            this.searchByQuantityNumberTextBox.TextChanged += new System.EventHandler(this.searchByQuantityNumberTextBox_TextChanged);
            // 
            // loadInsufficientQuantityProductsListGridView
            // 
            this.loadInsufficientQuantityProductsListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadInsufficientQuantityProductsListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadInsufficientQuantityProductsListGridView.Location = new System.Drawing.Point(0, 89);
            this.loadInsufficientQuantityProductsListGridView.Name = "loadInsufficientQuantityProductsListGridView";
            this.loadInsufficientQuantityProductsListGridView.Size = new System.Drawing.Size(669, 178);
            this.loadInsufficientQuantityProductsListGridView.TabIndex = 0;
            this.loadInsufficientQuantityProductsListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadInsufficientQuantityProductsListGridView_CellClick);
            // 
            // backToHomeBuktton1
            // 
            this.backToHomeBuktton1.FlatAppearance.BorderSize = 0;
            this.backToHomeBuktton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToHomeBuktton1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHomeBuktton1.Image = ((System.Drawing.Image)(resources.GetObject("backToHomeBuktton1.Image")));
            this.backToHomeBuktton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backToHomeBuktton1.Location = new System.Drawing.Point(12, 12);
            this.backToHomeBuktton1.Name = "backToHomeBuktton1";
            this.backToHomeBuktton1.Size = new System.Drawing.Size(98, 41);
            this.backToHomeBuktton1.TabIndex = 24;
            this.backToHomeBuktton1.Text = "Home";
            this.backToHomeBuktton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToHomeBuktton1.UseVisualStyleBackColor = true;
            this.backToHomeBuktton1.Click += new System.EventHandler(this.backToHomeBuktton1_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1241, 745);
            this.Controls.Add(this.backToHomeBuktton1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManagement_FormClosing);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadProductListGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadInsufficientQuantityProductsListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox productCategoryComboBox;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loadProductListGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchProductNameTextBox;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addProductQuantityButton;
        private System.Windows.Forms.TextBox addProductQuantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView loadInsufficientQuantityProductsListGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchByQuantityNumberTextBox;
        private System.Windows.Forms.TextBox addQuantityProductNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backToHomeBuktton1;
        private System.Windows.Forms.Label label9;
    }
}
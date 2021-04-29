namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    partial class CategoryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.updateCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryWiseProductDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.categoryWiseProductcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backToHomeBuktton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteCategoryButton);
            this.groupBox1.Controls.Add(this.updateCategoryButton);
            this.groupBox1.Controls.Add(this.addCategoryButton);
            this.groupBox1.Controls.Add(this.categoryNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Add/Update/Delete";
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(402, 95);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(134, 40);
            this.deleteCategoryButton.TabIndex = 2;
            this.deleteCategoryButton.Text = "Delete Category";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.Location = new System.Drawing.Point(251, 95);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(135, 40);
            this.updateCategoryButton.TabIndex = 2;
            this.updateCategoryButton.Text = "Update Category";
            this.updateCategoryButton.UseVisualStyleBackColor = true;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(106, 95);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(124, 40);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(203, 40);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(183, 26);
            this.categoryNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // loadCategoryDataGridView
            // 
            this.loadCategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadCategoryDataGridView.Location = new System.Drawing.Point(689, 217);
            this.loadCategoryDataGridView.Name = "loadCategoryDataGridView";
            this.loadCategoryDataGridView.Size = new System.Drawing.Size(333, 273);
            this.loadCategoryDataGridView.TabIndex = 5;
            this.loadCategoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadCategoryDataGridView_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category List";
            // 
            // categoryWiseProductDataGridView
            // 
            this.categoryWiseProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryWiseProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryWiseProductDataGridView.Location = new System.Drawing.Point(0, 103);
            this.categoryWiseProductDataGridView.Name = "categoryWiseProductDataGridView";
            this.categoryWiseProductDataGridView.Size = new System.Drawing.Size(638, 307);
            this.categoryWiseProductDataGridView.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refreshButton);
            this.groupBox2.Controls.Add(this.categoryWiseProductcomboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.categoryWiseProductDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 410);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Product List by Category";
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(487, 47);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(104, 29);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // categoryWiseProductcomboBox
            // 
            this.categoryWiseProductcomboBox.FormattingEnabled = true;
            this.categoryWiseProductcomboBox.Location = new System.Drawing.Point(195, 49);
            this.categoryWiseProductcomboBox.Name = "categoryWiseProductcomboBox";
            this.categoryWiseProductcomboBox.Size = new System.Drawing.Size(165, 27);
            this.categoryWiseProductcomboBox.TabIndex = 7;
            this.categoryWiseProductcomboBox.SelectedIndexChanged += new System.EventHandler(this.categoryWiseProductcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Name";
            // 
            // backToHomeBuktton
            // 
            this.backToHomeBuktton.FlatAppearance.BorderSize = 0;
            this.backToHomeBuktton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToHomeBuktton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHomeBuktton.Image = ((System.Drawing.Image)(resources.GetObject("backToHomeBuktton.Image")));
            this.backToHomeBuktton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backToHomeBuktton.Location = new System.Drawing.Point(12, 12);
            this.backToHomeBuktton.Name = "backToHomeBuktton";
            this.backToHomeBuktton.Size = new System.Drawing.Size(98, 41);
            this.backToHomeBuktton.TabIndex = 8;
            this.backToHomeBuktton.Text = "Home";
            this.backToHomeBuktton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToHomeBuktton.UseVisualStyleBackColor = true;
            this.backToHomeBuktton.Click += new System.EventHandler(this.backToHomeButton_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 692);
            this.Controls.Add(this.backToHomeBuktton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadCategoryDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryManagement_FormClosing);
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateCategoryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.DataGridView loadCategoryDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView categoryWiseProductDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox categoryWiseProductcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button backToHomeBuktton;
    }
}
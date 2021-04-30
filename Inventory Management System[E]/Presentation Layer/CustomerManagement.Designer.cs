
namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    partial class CustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            this.customerSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerLoadDataGridView = new System.Windows.Forms.DataGridView();
            this.ordersLoadGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastOrderedLebel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.orderCount = new System.Windows.Forms.Label();
            this.totalOrderedAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.IncertCustomerButton = new System.Windows.Forms.Button();
            this.removeCustomerbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalDaysLabel = new System.Windows.Forms.Label();
            this.OrdersByDateButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tillDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.RemoveOrderButton = new System.Windows.Forms.Button();
            this.RemoveTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackToHomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerLoadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersLoadGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerSearchTextBox
            // 
            this.customerSearchTextBox.BackColor = System.Drawing.Color.Silver;
            this.customerSearchTextBox.Location = new System.Drawing.Point(585, 25);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.Size = new System.Drawing.Size(174, 26);
            this.customerSearchTextBox.TabIndex = 1;
            this.customerSearchTextBox.TextChanged += new System.EventHandler(this.customerSearchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // customerLoadDataGridView
            // 
            this.customerLoadDataGridView.AllowUserToAddRows = false;
            this.customerLoadDataGridView.AllowUserToDeleteRows = false;
            this.customerLoadDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerLoadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerLoadDataGridView.Location = new System.Drawing.Point(16, 23);
            this.customerLoadDataGridView.Name = "customerLoadDataGridView";
            this.customerLoadDataGridView.ReadOnly = true;
            this.customerLoadDataGridView.Size = new System.Drawing.Size(484, 289);
            this.customerLoadDataGridView.TabIndex = 3;
            this.customerLoadDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerLoadDataGridView_CellClick);
            // 
            // ordersLoadGridView
            // 
            this.ordersLoadGridView.AllowUserToAddRows = false;
            this.ordersLoadGridView.AllowUserToDeleteRows = false;
            this.ordersLoadGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersLoadGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersLoadGridView.Location = new System.Drawing.Point(0, 100);
            this.ordersLoadGridView.Name = "ordersLoadGridView";
            this.ordersLoadGridView.ReadOnly = true;
            this.ordersLoadGridView.Size = new System.Drawing.Size(1285, 196);
            this.ordersLoadGridView.TabIndex = 4;
            this.ordersLoadGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersLoadGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.customerLoadDataGridView);
            this.groupBox1.Controls.Add(this.lastOrderedLebel);
            this.groupBox1.Controls.Add(this.customerNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerSearchTextBox);
            this.groupBox1.Controls.Add(this.orderCount);
            this.groupBox1.Controls.Add(this.totalOrderedAmount);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 327);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // lastOrderedLebel
            // 
            this.lastOrderedLebel.AutoSize = true;
            this.lastOrderedLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOrderedLebel.ForeColor = System.Drawing.Color.Indigo;
            this.lastOrderedLebel.Location = new System.Drawing.Point(617, 296);
            this.lastOrderedLebel.Name = "lastOrderedLebel";
            this.lastOrderedLebel.Size = new System.Drawing.Size(0, 16);
            this.lastOrderedLebel.TabIndex = 36;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.Color.Indigo;
            this.customerNameLabel.Location = new System.Drawing.Point(569, 86);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(0, 20);
            this.customerNameLabel.TabIndex = 38;
            // 
            // orderCount
            // 
            this.orderCount.AutoSize = true;
            this.orderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCount.ForeColor = System.Drawing.Color.Indigo;
            this.orderCount.Location = new System.Drawing.Point(608, 157);
            this.orderCount.Name = "orderCount";
            this.orderCount.Size = new System.Drawing.Size(0, 20);
            this.orderCount.TabIndex = 28;
            // 
            // totalOrderedAmount
            // 
            this.totalOrderedAmount.AutoSize = true;
            this.totalOrderedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrderedAmount.ForeColor = System.Drawing.Color.Indigo;
            this.totalOrderedAmount.Location = new System.Drawing.Point(616, 224);
            this.totalOrderedAmount.Name = "totalOrderedAmount";
            this.totalOrderedAmount.Size = new System.Drawing.Size(0, 20);
            this.totalOrderedAmount.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(532, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Order count :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Total amount :";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.customerNameTextBox.Location = new System.Drawing.Point(168, 51);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(247, 26);
            this.customerNameTextBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateCustomerButton);
            this.groupBox2.Controls.Add(this.IncertCustomerButton);
            this.groupBox2.Controls.Add(this.removeCustomerbutton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.phoneNoTextBox);
            this.groupBox2.Controls.Add(this.customerNameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(856, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 327);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer operation";
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.BackColor = System.Drawing.Color.Silver;
            this.updateCustomerButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.updateCustomerButton.Location = new System.Drawing.Point(251, 157);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(151, 47);
            this.updateCustomerButton.TabIndex = 36;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.UseVisualStyleBackColor = false;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // IncertCustomerButton
            // 
            this.IncertCustomerButton.BackColor = System.Drawing.Color.Silver;
            this.IncertCustomerButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncertCustomerButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.IncertCustomerButton.Location = new System.Drawing.Point(72, 157);
            this.IncertCustomerButton.Name = "IncertCustomerButton";
            this.IncertCustomerButton.Size = new System.Drawing.Size(157, 47);
            this.IncertCustomerButton.TabIndex = 34;
            this.IncertCustomerButton.Text = "Insert";
            this.IncertCustomerButton.UseVisualStyleBackColor = false;
            this.IncertCustomerButton.Click += new System.EventHandler(this.IncertCustomerButton_Click);
            // 
            // removeCustomerbutton
            // 
            this.removeCustomerbutton.BackColor = System.Drawing.Color.Silver;
            this.removeCustomerbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCustomerbutton.ForeColor = System.Drawing.Color.Red;
            this.removeCustomerbutton.Location = new System.Drawing.Point(142, 224);
            this.removeCustomerbutton.Name = "removeCustomerbutton";
            this.removeCustomerbutton.Size = new System.Drawing.Size(191, 47);
            this.removeCustomerbutton.TabIndex = 35;
            this.removeCustomerbutton.Text = "Remove";
            this.removeCustomerbutton.UseVisualStyleBackColor = false;
            this.removeCustomerbutton.Click += new System.EventHandler(this.removeCustomerbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Phone No";
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.BackColor = System.Drawing.Color.Silver;
            this.phoneNoTextBox.Location = new System.Drawing.Point(168, 98);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(247, 26);
            this.phoneNoTextBox.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.RemoveOrderButton);
            this.groupBox3.Controls.Add(this.RemoveTextBox);
            this.groupBox3.Controls.Add(this.ordersLoadGridView);
            this.groupBox3.Location = new System.Drawing.Point(26, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1285, 299);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.totalDaysLabel);
            this.groupBox4.Controls.Add(this.OrdersByDateButton);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tillDateTimePicker);
            this.groupBox4.Controls.Add(this.fromDateTimePicker);
            this.groupBox4.Location = new System.Drawing.Point(51, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 78);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customers Orders By date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(777, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Total Days";
            // 
            // totalDaysLabel
            // 
            this.totalDaysLabel.AutoSize = true;
            this.totalDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDaysLabel.ForeColor = System.Drawing.Color.Indigo;
            this.totalDaysLabel.Location = new System.Drawing.Point(808, 42);
            this.totalDaysLabel.Name = "totalDaysLabel";
            this.totalDaysLabel.Size = new System.Drawing.Size(0, 25);
            this.totalDaysLabel.TabIndex = 42;
            // 
            // OrdersByDateButton
            // 
            this.OrdersByDateButton.BackColor = System.Drawing.Color.Silver;
            this.OrdersByDateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersByDateButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.OrdersByDateButton.Location = new System.Drawing.Point(593, 19);
            this.OrdersByDateButton.Name = "OrdersByDateButton";
            this.OrdersByDateButton.Size = new System.Drawing.Size(157, 44);
            this.OrdersByDateButton.TabIndex = 37;
            this.OrdersByDateButton.Text = "Find";
            this.OrdersByDateButton.UseVisualStyleBackColor = false;
            this.OrdersByDateButton.Click += new System.EventHandler(this.OrdersByDateButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Till :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "From :";
            // 
            // tillDateTimePicker
            // 
            this.tillDateTimePicker.Location = new System.Drawing.Point(364, 29);
            this.tillDateTimePicker.Name = "tillDateTimePicker";
            this.tillDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tillDateTimePicker.TabIndex = 1;
            this.tillDateTimePicker.CloseUp += new System.EventHandler(this.tillDateTimePicker_CloseUp);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(77, 29);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 0;
            this.fromDateTimePicker.CloseUp += new System.EventHandler(this.fromDateTimePicker_CloseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(982, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Product Name";
            // 
            // RemoveOrderButton
            // 
            this.RemoveOrderButton.BackColor = System.Drawing.Color.Silver;
            this.RemoveOrderButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveOrderButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveOrderButton.Location = new System.Drawing.Point(1109, 47);
            this.RemoveOrderButton.Name = "RemoveOrderButton";
            this.RemoveOrderButton.Size = new System.Drawing.Size(166, 36);
            this.RemoveOrderButton.TabIndex = 29;
            this.RemoveOrderButton.Text = "Remove";
            this.RemoveOrderButton.UseVisualStyleBackColor = false;
            this.RemoveOrderButton.Click += new System.EventHandler(this.RemoveOrderButton_Click);
            // 
            // RemoveTextBox
            // 
            this.RemoveTextBox.BackColor = System.Drawing.Color.Silver;
            this.RemoveTextBox.Location = new System.Drawing.Point(1094, 16);
            this.RemoveTextBox.Name = "RemoveTextBox";
            this.RemoveTextBox.Size = new System.Drawing.Size(181, 20);
            this.RemoveTextBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Last Ordered :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Name :";
            // 
            // BackToHomeButton
            // 
            this.BackToHomeButton.FlatAppearance.BorderSize = 0;
            this.BackToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("BackToHomeButton.Image")));
            this.BackToHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackToHomeButton.Location = new System.Drawing.Point(13, 5);
            this.BackToHomeButton.Name = "BackToHomeButton";
            this.BackToHomeButton.Size = new System.Drawing.Size(93, 39);
            this.BackToHomeButton.TabIndex = 40;
            this.BackToHomeButton.Text = "Home";
            this.BackToHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackToHomeButton.UseVisualStyleBackColor = true;
            this.BackToHomeButton.Click += new System.EventHandler(this.BackToHomeButton_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1323, 706);
            this.Controls.Add(this.BackToHomeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerManagement_FormClosing);
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerLoadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersLoadGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox customerSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customerLoadDataGridView;
        private System.Windows.Forms.DataGridView ordersLoadGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label orderCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalOrderedAmount;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.Button IncertCustomerButton;
        private System.Windows.Forms.Button removeCustomerbutton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lastOrderedLebel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RemoveOrderButton;
        private System.Windows.Forms.TextBox RemoveTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker tillDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Button OrdersByDateButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalDaysLabel;
        private System.Windows.Forms.Button BackToHomeButton;
    }
}
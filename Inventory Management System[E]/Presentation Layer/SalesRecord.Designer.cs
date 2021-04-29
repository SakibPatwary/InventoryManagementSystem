
namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    partial class SalesRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRecord));
            this.loadSalesGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalDaysLabel = new System.Windows.Forms.Label();
            this.salesByDateButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tillDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.totalOrderedAmount = new System.Windows.Forms.Label();
            this.lastOrderedLebel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orderCount = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadSalesGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadSalesGridView
            // 
            this.loadSalesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadSalesGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadSalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadSalesGridView.Location = new System.Drawing.Point(12, 267);
            this.loadSalesGridView.Name = "loadSalesGridView";
            this.loadSalesGridView.Size = new System.Drawing.Size(1258, 467);
            this.loadSalesGridView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.totalDaysLabel);
            this.groupBox4.Controls.Add(this.salesByDateButton);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tillDateTimePicker);
            this.groupBox4.Controls.Add(this.fromDateTimePicker);
            this.groupBox4.Location = new System.Drawing.Point(12, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 179);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "All Sales By date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(305, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Total Days";
            // 
            // totalDaysLabel
            // 
            this.totalDaysLabel.AutoSize = true;
            this.totalDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDaysLabel.ForeColor = System.Drawing.Color.Indigo;
            this.totalDaysLabel.Location = new System.Drawing.Point(338, 66);
            this.totalDaysLabel.Name = "totalDaysLabel";
            this.totalDaysLabel.Size = new System.Drawing.Size(0, 29);
            this.totalDaysLabel.TabIndex = 42;
            // 
            // salesByDateButton
            // 
            this.salesByDateButton.BackColor = System.Drawing.Color.Transparent;
            this.salesByDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesByDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesByDateButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.salesByDateButton.Image = ((System.Drawing.Image)(resources.GetObject("salesByDateButton.Image")));
            this.salesByDateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesByDateButton.Location = new System.Drawing.Point(129, 121);
            this.salesByDateButton.Name = "salesByDateButton";
            this.salesByDateButton.Size = new System.Drawing.Size(86, 37);
            this.salesByDateButton.TabIndex = 37;
            this.salesByDateButton.Text = "Find";
            this.salesByDateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salesByDateButton.UseVisualStyleBackColor = false;
            this.salesByDateButton.Click += new System.EventHandler(this.salesByDateButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 86);
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
            this.tillDateTimePicker.Location = new System.Drawing.Point(77, 86);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(677, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Total Sales Amount ";
            // 
            // totalOrderedAmount
            // 
            this.totalOrderedAmount.AutoSize = true;
            this.totalOrderedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrderedAmount.ForeColor = System.Drawing.Color.Indigo;
            this.totalOrderedAmount.Location = new System.Drawing.Point(716, 141);
            this.totalOrderedAmount.Name = "totalOrderedAmount";
            this.totalOrderedAmount.Size = new System.Drawing.Size(0, 24);
            this.totalOrderedAmount.TabIndex = 32;
            // 
            // lastOrderedLebel
            // 
            this.lastOrderedLebel.AutoSize = true;
            this.lastOrderedLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOrderedLebel.ForeColor = System.Drawing.Color.Indigo;
            this.lastOrderedLebel.Location = new System.Drawing.Point(945, 141);
            this.lastOrderedLebel.Name = "lastOrderedLebel";
            this.lastOrderedLebel.Size = new System.Drawing.Size(0, 20);
            this.lastOrderedLebel.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Total Sales ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(970, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Last Sales Date";
            // 
            // orderCount
            // 
            this.orderCount.AutoSize = true;
            this.orderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCount.ForeColor = System.Drawing.Color.Indigo;
            this.orderCount.Location = new System.Drawing.Point(532, 137);
            this.orderCount.Name = "orderCount";
            this.orderCount.Size = new System.Drawing.Size(0, 29);
            this.orderCount.TabIndex = 37;
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshButton.Location = new System.Drawing.Point(1163, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(102, 39);
            this.refreshButton.TabIndex = 38;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(93, 39);
            this.HomeButton.TabIndex = 39;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1277, 746);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalOrderedAmount);
            this.Controls.Add(this.lastOrderedLebel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderCount);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.loadSalesGridView);
            this.Name = "SalesRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesRecord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesRecord_FormClosing);
            this.Load += new System.EventHandler(this.SalesRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadSalesGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadSalesGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalDaysLabel;
        private System.Windows.Forms.Button salesByDateButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tillDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalOrderedAmount;
        private System.Windows.Forms.Label lastOrderedLebel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label orderCount;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button HomeButton;
    }
}
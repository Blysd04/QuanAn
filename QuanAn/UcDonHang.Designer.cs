namespace QuanAn
{
    partial class UcDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderDisplayPanel = new System.Windows.Forms.Panel();
            this.OrderLv = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.MenuOrderDisplayPanel = new System.Windows.Forms.Panel();
            this.NoteTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddFoodButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AmountOfFoodNud = new System.Windows.Forms.NumericUpDown();
            this.FoodNameTb = new System.Windows.Forms.TextBox();
            this.AmountOfFoodLb = new System.Windows.Forms.Label();
            this.FoodNameLb = new System.Windows.Forms.Label();
            this.OrderFunctionPanel = new System.Windows.Forms.Panel();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.ChangeTb = new System.Windows.Forms.TextBox();
            this.MoneyGivingByCustomerTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalMoneyTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuOrderPanel = new System.Windows.Forms.Panel();
            this.MenuLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDisplayPanel.SuspendLayout();
            this.MenuOrderDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfFoodNud)).BeginInit();
            this.OrderFunctionPanel.SuspendLayout();
            this.MenuOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDisplayPanel
            // 
            this.OrderDisplayPanel.Controls.Add(this.OrderLv);
            this.OrderDisplayPanel.Location = new System.Drawing.Point(403, 214);
            this.OrderDisplayPanel.Name = "OrderDisplayPanel";
            this.OrderDisplayPanel.Size = new System.Drawing.Size(494, 307);
            this.OrderDisplayPanel.TabIndex = 3;
            // 
            // OrderLv
            // 
            this.OrderLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.OrderLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLv.FullRowSelect = true;
            this.OrderLv.GridLines = true;
            this.OrderLv.HideSelection = false;
            this.OrderLv.Location = new System.Drawing.Point(0, 0);
            this.OrderLv.Name = "OrderLv";
            this.OrderLv.Size = new System.Drawing.Size(494, 307);
            this.OrderLv.TabIndex = 0;
            this.OrderLv.UseCompatibleStateImageBehavior = false;
            this.OrderLv.View = System.Windows.Forms.View.Details;
            this.OrderLv.SelectedIndexChanged += new System.EventHandler(this.OrderLv_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên món";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi chú";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thành tiền";
            this.columnHeader7.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thực đơn:";
            // 
            // MenuOrderDisplayPanel
            // 
            this.MenuOrderDisplayPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuOrderDisplayPanel.Controls.Add(this.NoteTb);
            this.MenuOrderDisplayPanel.Controls.Add(this.label6);
            this.MenuOrderDisplayPanel.Controls.Add(this.AddFoodButton);
            this.MenuOrderDisplayPanel.Controls.Add(this.DeleteButton);
            this.MenuOrderDisplayPanel.Controls.Add(this.AmountOfFoodNud);
            this.MenuOrderDisplayPanel.Controls.Add(this.FoodNameTb);
            this.MenuOrderDisplayPanel.Controls.Add(this.AmountOfFoodLb);
            this.MenuOrderDisplayPanel.Controls.Add(this.FoodNameLb);
            this.MenuOrderDisplayPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOrderDisplayPanel.Location = new System.Drawing.Point(403, 30);
            this.MenuOrderDisplayPanel.Name = "MenuOrderDisplayPanel";
            this.MenuOrderDisplayPanel.Size = new System.Drawing.Size(494, 153);
            this.MenuOrderDisplayPanel.TabIndex = 5;
            // 
            // NoteTb
            // 
            this.NoteTb.Location = new System.Drawing.Point(88, 68);
            this.NoteTb.Multiline = true;
            this.NoteTb.Name = "NoteTb";
            this.NoteTb.Size = new System.Drawing.Size(399, 78);
            this.NoteTb.TabIndex = 8;
            this.NoteTb.Text = "Không có ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ghi Chú:";
            // 
            // AddFoodButton
            // 
            this.AddFoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodButton.Location = new System.Drawing.Point(335, 7);
            this.AddFoodButton.Name = "AddFoodButton";
            this.AddFoodButton.Size = new System.Drawing.Size(75, 53);
            this.AddFoodButton.TabIndex = 4;
            this.AddFoodButton.Text = "Thêm món";
            this.AddFoodButton.UseVisualStyleBackColor = true;
            this.AddFoodButton.Click += new System.EventHandler(this.AddFoodButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(416, 6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 54);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = " Xóa  món";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AmountOfFoodNud
            // 
            this.AmountOfFoodNud.Location = new System.Drawing.Point(88, 38);
            this.AmountOfFoodNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AmountOfFoodNud.Name = "AmountOfFoodNud";
            this.AmountOfFoodNud.Size = new System.Drawing.Size(239, 24);
            this.AmountOfFoodNud.TabIndex = 3;
            this.AmountOfFoodNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountOfFoodNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FoodNameTb
            // 
            this.FoodNameTb.Location = new System.Drawing.Point(88, 7);
            this.FoodNameTb.Name = "FoodNameTb";
            this.FoodNameTb.ReadOnly = true;
            this.FoodNameTb.Size = new System.Drawing.Size(240, 24);
            this.FoodNameTb.TabIndex = 2;
            // 
            // AmountOfFoodLb
            // 
            this.AmountOfFoodLb.AutoSize = true;
            this.AmountOfFoodLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOfFoodLb.Location = new System.Drawing.Point(3, 40);
            this.AmountOfFoodLb.Name = "AmountOfFoodLb";
            this.AmountOfFoodLb.Size = new System.Drawing.Size(80, 18);
            this.AmountOfFoodLb.TabIndex = 1;
            this.AmountOfFoodLb.Text = "Số lượng:";
            // 
            // FoodNameLb
            // 
            this.FoodNameLb.AutoSize = true;
            this.FoodNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodNameLb.Location = new System.Drawing.Point(3, 13);
            this.FoodNameLb.Name = "FoodNameLb";
            this.FoodNameLb.Size = new System.Drawing.Size(79, 18);
            this.FoodNameLb.TabIndex = 0;
            this.FoodNameLb.Text = "Tên món:";
            // 
            // OrderFunctionPanel
            // 
            this.OrderFunctionPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrderFunctionPanel.Controls.Add(this.CheckoutButton);
            this.OrderFunctionPanel.Controls.Add(this.ChangeTb);
            this.OrderFunctionPanel.Controls.Add(this.MoneyGivingByCustomerTb);
            this.OrderFunctionPanel.Controls.Add(this.label5);
            this.OrderFunctionPanel.Controls.Add(this.label4);
            this.OrderFunctionPanel.Controls.Add(this.TotalMoneyTb);
            this.OrderFunctionPanel.Controls.Add(this.label3);
            this.OrderFunctionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFunctionPanel.Location = new System.Drawing.Point(403, 527);
            this.OrderFunctionPanel.Name = "OrderFunctionPanel";
            this.OrderFunctionPanel.Size = new System.Drawing.Size(494, 113);
            this.OrderFunctionPanel.TabIndex = 6;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.Location = new System.Drawing.Point(359, 22);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(128, 61);
            this.CheckoutButton.TabIndex = 13;
            this.CheckoutButton.Text = "Chốt đơn";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // ChangeTb
            // 
            this.ChangeTb.Location = new System.Drawing.Point(107, 70);
            this.ChangeTb.Name = "ChangeTb";
            this.ChangeTb.ReadOnly = true;
            this.ChangeTb.Size = new System.Drawing.Size(237, 24);
            this.ChangeTb.TabIndex = 11;
            this.ChangeTb.Text = "0";
            this.ChangeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MoneyGivingByCustomerTb
            // 
            this.MoneyGivingByCustomerTb.Location = new System.Drawing.Point(107, 40);
            this.MoneyGivingByCustomerTb.Name = "MoneyGivingByCustomerTb";
            this.MoneyGivingByCustomerTb.Size = new System.Drawing.Size(237, 24);
            this.MoneyGivingByCustomerTb.TabIndex = 10;
            this.MoneyGivingByCustomerTb.Text = "0";
            this.MoneyGivingByCustomerTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MoneyGivingByCustomerTb.TextChanged += new System.EventHandler(this.MoneyGivingByCustomerTb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiền thừa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khách đưa:";
            // 
            // TotalMoneyTb
            // 
            this.TotalMoneyTb.Location = new System.Drawing.Point(107, 10);
            this.TotalMoneyTb.Name = "TotalMoneyTb";
            this.TotalMoneyTb.ReadOnly = true;
            this.TotalMoneyTb.Size = new System.Drawing.Size(237, 24);
            this.TotalMoneyTb.TabIndex = 7;
            this.TotalMoneyTb.Text = "0";
            this.TotalMoneyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đơn hàng:";
            // 
            // MenuOrderPanel
            // 
            this.MenuOrderPanel.Controls.Add(this.MenuLv);
            this.MenuOrderPanel.Location = new System.Drawing.Point(8, 30);
            this.MenuOrderPanel.Name = "MenuOrderPanel";
            this.MenuOrderPanel.Size = new System.Drawing.Size(389, 610);
            this.MenuOrderPanel.TabIndex = 9;
            // 
            // MenuLv
            // 
            this.MenuLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.MenuLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuLv.FullRowSelect = true;
            this.MenuLv.GridLines = true;
            this.MenuLv.HideSelection = false;
            this.MenuLv.Location = new System.Drawing.Point(0, 0);
            this.MenuLv.Name = "MenuLv";
            this.MenuLv.Size = new System.Drawing.Size(389, 610);
            this.MenuLv.TabIndex = 0;
            this.MenuLv.UseCompatibleStateImageBehavior = false;
            this.MenuLv.View = System.Windows.Forms.View.Details;
            this.MenuLv.SelectedIndexChanged += new System.EventHandler(this.MenuLv_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "MaCTHD";
            // 
            // UcDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuOrderPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderFunctionPanel);
            this.Controls.Add(this.MenuOrderDisplayPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderDisplayPanel);
            this.Name = "UcDonHang";
            this.Size = new System.Drawing.Size(900, 643);
            this.OrderDisplayPanel.ResumeLayout(false);
            this.MenuOrderDisplayPanel.ResumeLayout(false);
            this.MenuOrderDisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfFoodNud)).EndInit();
            this.OrderFunctionPanel.ResumeLayout(false);
            this.OrderFunctionPanel.PerformLayout();
            this.MenuOrderPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel OrderDisplayPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MenuOrderDisplayPanel;
        private System.Windows.Forms.Label AmountOfFoodLb;
        private System.Windows.Forms.Label FoodNameLb;
        private System.Windows.Forms.Panel OrderFunctionPanel;
        private System.Windows.Forms.NumericUpDown AmountOfFoodNud;
        private System.Windows.Forms.TextBox FoodNameTb;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddFoodButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView OrderLv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChangeTb;
        private System.Windows.Forms.TextBox MoneyGivingByCustomerTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalMoneyTb;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.TextBox NoteTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel MenuOrderPanel;
        private System.Windows.Forms.ListView MenuLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

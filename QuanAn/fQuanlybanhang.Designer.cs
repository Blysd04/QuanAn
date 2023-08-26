using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanAn
{
    partial class fQuanlyBanHang
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
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.LoadUcDoanhThuButton = new System.Windows.Forms.Button();
            this.LoadUcThucDonButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.LoadUcQuanLyButton = new System.Windows.Forms.Button();
            this.LoadDonHangButton = new System.Windows.Forms.Button();
            this.LoadUcLoginButton = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.StaffPanel = new System.Windows.Forms.Panel();
            this.AccountLb = new System.Windows.Forms.Label();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolPanel.Controls.Add(this.AccountLb);
            this.ToolPanel.Controls.Add(this.LoadUcDoanhThuButton);
            this.ToolPanel.Controls.Add(this.LoadUcThucDonButton);
            this.ToolPanel.Controls.Add(this.LogOutButton);
            this.ToolPanel.Controls.Add(this.LoadUcQuanLyButton);
            this.ToolPanel.Controls.Add(this.LoadDonHangButton);
            this.ToolPanel.Controls.Add(this.LoadUcLoginButton);
            this.ToolPanel.Location = new System.Drawing.Point(3, 5);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(169, 645);
            this.ToolPanel.TabIndex = 0;
            // 
            // LoadUcDoanhThuButton
            // 
            this.LoadUcDoanhThuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadUcDoanhThuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadUcDoanhThuButton.Location = new System.Drawing.Point(3, 340);
            this.LoadUcDoanhThuButton.Name = "LoadUcDoanhThuButton";
            this.LoadUcDoanhThuButton.Size = new System.Drawing.Size(163, 63);
            this.LoadUcDoanhThuButton.TabIndex = 7;
            this.LoadUcDoanhThuButton.Text = "Doanh thu";
            this.LoadUcDoanhThuButton.UseVisualStyleBackColor = true;
            this.LoadUcDoanhThuButton.Click += new System.EventHandler(this.LoadUcDoanhThuButton_Click);
            // 
            // LoadUcThucDonButton
            // 
            this.LoadUcThucDonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadUcThucDonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadUcThucDonButton.Location = new System.Drawing.Point(3, 265);
            this.LoadUcThucDonButton.Name = "LoadUcThucDonButton";
            this.LoadUcThucDonButton.Size = new System.Drawing.Size(163, 63);
            this.LoadUcThucDonButton.TabIndex = 6;
            this.LoadUcThucDonButton.Text = "Thực đơn";
            this.LoadUcThucDonButton.UseVisualStyleBackColor = true;
            this.LoadUcThucDonButton.Click += new System.EventHandler(this.LoadUcThucDonButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(3, 600);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(163, 39);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Đăng xuất";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // LoadUcQuanLyButton
            // 
            this.LoadUcQuanLyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadUcQuanLyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadUcQuanLyButton.Location = new System.Drawing.Point(3, 190);
            this.LoadUcQuanLyButton.Name = "LoadUcQuanLyButton";
            this.LoadUcQuanLyButton.Size = new System.Drawing.Size(163, 63);
            this.LoadUcQuanLyButton.TabIndex = 2;
            this.LoadUcQuanLyButton.Text = "Quản lý nhân viên";
            this.LoadUcQuanLyButton.UseVisualStyleBackColor = true;
            this.LoadUcQuanLyButton.Click += new System.EventHandler(this.LoadUcQuanLyButton_Click);
            // 
            // LoadDonHangButton
            // 
            this.LoadDonHangButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadDonHangButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDonHangButton.Location = new System.Drawing.Point(3, 115);
            this.LoadDonHangButton.Name = "LoadDonHangButton";
            this.LoadDonHangButton.Size = new System.Drawing.Size(163, 63);
            this.LoadDonHangButton.TabIndex = 1;
            this.LoadDonHangButton.Text = "Đơn hàng";
            this.LoadDonHangButton.UseVisualStyleBackColor = true;
            this.LoadDonHangButton.Click += new System.EventHandler(this.LoadDonHangButton_Click);
            // 
            // LoadUcLoginButton
            // 
            this.LoadUcLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadUcLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadUcLoginButton.Location = new System.Drawing.Point(3, 550);
            this.LoadUcLoginButton.Name = "LoadUcLoginButton";
            this.LoadUcLoginButton.Size = new System.Drawing.Size(163, 39);
            this.LoadUcLoginButton.TabIndex = 0;
            this.LoadUcLoginButton.Text = "Đăng nhập";
            this.LoadUcLoginButton.UseVisualStyleBackColor = true;
            this.LoadUcLoginButton.Click += new System.EventHandler(this.LoadUcLoginButton_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Location = new System.Drawing.Point(178, 5);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(902, 645);
            this.UserPanel.TabIndex = 1;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Location = new System.Drawing.Point(178, 5);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(902, 645);
            this.LoginPanel.TabIndex = 2;
            // 
            // StaffPanel
            // 
            this.StaffPanel.Location = new System.Drawing.Point(178, 5);
            this.StaffPanel.Name = "StaffPanel";
            this.StaffPanel.Size = new System.Drawing.Size(902, 645);
            this.StaffPanel.TabIndex = 3;
            // 
            // AccountLb
            // 
            this.AccountLb.AutoSize = true;
            this.AccountLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLb.Location = new System.Drawing.Point(3, 4);
            this.AccountLb.Name = "AccountLb";
            this.AccountLb.Size = new System.Drawing.Size(0, 18);
            this.AccountLb.TabIndex = 8;
            // 
            // fQuanlyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.StaffPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.ToolPanel);
            this.Name = "fQuanlyBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán ăn";
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Button LoadUcLoginButton;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button LoadDonHangButton;
        private System.Windows.Forms.Button LoadUcQuanLyButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button LoadUcThucDonButton;
        private System.Windows.Forms.Button LoadUcDoanhThuButton;
        private Panel LoginPanel;
        private Panel StaffPanel;
        private Label AccountLb;
    }
}
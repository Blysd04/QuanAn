using QuanAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanAn
{
    public partial class UcLogin : UserControl
    {
        public static UcLogin instance;

        public bool LoginStatus = false;

        public System.Windows.Forms.TextBox userNameTb, passWordTb;

        public Label statusLb;

        public UcLogin()
        {
            InitializeComponent();
            instance = this;
            statusLb = StatusLb;
            userNameTb = UserNameTb;
            passWordTb = PasswordTb;
        }

        bool Login(string username, string password)
        {
            return LoginDAO.Instance.Login(username, password);
        }
        
        int Decentralization_Login(string username, string password)
        {
            return LoginDAO.Instance.Decentralization_Login(username, password);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCb.Checked)
            {
                PasswordTb.PasswordChar = '\0';
            }
            else
            {
                PasswordTb.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //fQuanlyBanHang.instance.p1.Enabled = true;
            string username = UserNameTb.Text;
            string password = PasswordTb.Text;
            
            if (Decentralization_Login(username, password) == 1)
            {
                LoginStatus = true;
                StatusLb.Text = "Đã đăng nhập thành công, tài khoản " + username;
                StatusLb.ForeColor = Color.FromArgb(0, 0, 255);
                fQuanlyBanHang.instance.accountLb.Text = "Tài khoản: " + username;
                fQuanlyBanHang.instance.accountLb.ForeColor = Color.FromArgb(0, 0, 0);
                fQuanlyBanHang.instance.StaffPanel1.Enabled = true;
                fQuanlyBanHang.instance.UserPanel1.Enabled = true;
            }
            else if (Decentralization_Login(username, password) == 2)
            {
                LoginStatus = true;
                StatusLb.Text = "Đã đăng nhập thành công, tài khoản " + username;
                StatusLb.ForeColor = Color.FromArgb(0, 0, 255);
                fQuanlyBanHang.instance.accountLb.Text = "Tài khoản: " + username;
                fQuanlyBanHang.instance.accountLb.ForeColor = Color.FromArgb(0, 0, 0);
                fQuanlyBanHang.instance.StaffPanel1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }

            /*
            if (Login(username, password))
            {
                LoginStatus = true;
                StatusLb.Text = "Đã đăng nhập thành công, tài khoản " + username;
                fQuanlyBanHang.instance.accountTb.Text = "Tài khoản: " + username;
                fQuanlyBanHang.instance.StaffPanel1.Enabled = true;
                fQuanlyBanHang.instance.UserPanel1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
            */
        }
    }
}

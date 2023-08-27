using QuanAn.DAO;
using QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanAn
{
    public partial class UcQuanLy : UserControl
    {
        public static UcQuanLy instance;
        public UcQuanLy()
        {
            InitializeComponent();
            instance = this;
            LoadStaff();
        }

        void LoadStaff()
        {
            List<Staff> staffList = StaffDAO.Instance.LoadStaffList();
            StaffDataGridView.DataSource = staffList;
            CalendarDataGridView.DataSource = staffList;
            SalaryDataGridView.DataSource = staffList;
        }
    }
}


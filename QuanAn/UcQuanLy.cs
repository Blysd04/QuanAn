using QuanAn.DAO;
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
        public Panel p1, p2, p3, p4, p5, p6;
        public NumericUpDown w1;
        public UcQuanLy()
        {
            InitializeComponent();
            instance = this;
            p1 = StaffCalendarPanel;
            p2 = StaffCalendarDisplayPanel;
            p3 = StaffPanel;
            p4 = StaffDisplayPanel;
            p5 = StaffSalaryPanel;
            p6 = StaffSalaryDisplayPanel;
            w1 = WorkingHoursNud;
        }   
    }
}


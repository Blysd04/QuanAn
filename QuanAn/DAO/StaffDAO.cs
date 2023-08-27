using QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanAn.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set => instance = value;
        }

        private StaffDAO() { }

        public List<Staff> LoadStaffList()
        {
            List<Staff> staffList = new List<Staff>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetStaff");

            foreach (DataRow row in data.Rows)
            {
                Staff staff = new Staff(row);
                staffList.Add(staff);
            }

            return staffList;
        }
    }
}

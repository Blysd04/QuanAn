using QuanAn.DAO;
using QuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanAn
{
    public partial class UcDoanhThu : UserControl
    {
        public UcDoanhThu()
        {
            InitializeComponent();
        }

        public void LoadOrderByDay(string day)
        {
            List<Order> orders = RevenueDAO.Instance.GetOrderListByDay(day);
            OrderDataGridView.DataSource = orders;
        }

        public void LoadOrderByMonth(string month)
        {
            List<Order> orders = RevenueDAO.Instance.GetOrderListByMonth(month);
            OrderDataGridView.DataSource = orders;
        }

        private void CalculateRevenueByDayButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = RevenueDtp.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            //MessageBox.Show(formattedDate);
            LoadOrderByDay(formattedDate);
            float revenue = RevenueDAO.Instance.GetTotalRevenueOnDay(formattedDate);
            int countOfOrder = RevenueDAO.Instance.GetCountOfOrderOnDay(formattedDate);
            NumberOfOrdersTb.Text = countOfOrder.ToString();
            
            if(revenue == -1)
                MessageBox.Show("Ngày không có doanh thu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                RevenueTb.Text = revenue.ToString();
        }

        private void CalculateRevenueByMonthButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = RevenueDtp.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");           
            LoadOrderByMonth(formattedDate);
            float revenue = RevenueDAO.Instance.GetTotalRevenueOnMonth(formattedDate);
            int countOfOrder = RevenueDAO.Instance.GetCountOfOrderOnDay(formattedDate);
            NumberOfOrdersTb.Text = countOfOrder.ToString();           
            if (revenue == -1)
                MessageBox.Show("Tháng không có doanh thu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                RevenueTb.Text = revenue.ToString();
        }

        private void OrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                string maDH = selectedRow.Cells[0].Value.ToString();
                string tong_tien = selectedRow.Cells[1].Value.ToString();   
                string khach_dua = selectedRow.Cells[2].Value.ToString();
                string tien_thua = selectedRow.Cells[3].Value.ToString();

                OrderTb.Text = maDH;
                TotalMoneyTb.Text = tong_tien;
                MoneyGivingByCustomerTb.Text = khach_dua;
                ChangeTb.Text = tien_thua;
                DataTable foods = FoodDAO.Instance.GetFoodListByMaDH(Convert.ToInt32(maDH));
                FoodListLv.Items.Clear();
                foreach(DataRow row in foods.Rows )
                {
                    //MessageBox.Show(row["ten_mon"].ToString());
                    ListViewItem ten_mon = new ListViewItem(row["ten_mon"].ToString());
                    ten_mon.SubItems.Add(row["MaMN"].ToString());
                    FoodListLv.Items.Add(ten_mon);
                }
             }
        }
    }
}

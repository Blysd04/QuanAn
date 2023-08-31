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
    public partial class UcDonHang : UserControl
    {
        public UcDonHang()
        {
            InitializeComponent();
            LoadFood();

            LoadOrderFood();
        }

        #region Method
        void LoadOrderFood()
        {
            OrderLv.Items.Clear();
            Order order = OrderDAO.Instance.GetOrderWithIDMax();
            List<Food> FoodList = FoodDAO.Instance.LoadFoodListByMaDH(order.MaDH);
            float tong_tien = 0; 
            foreach (Food food in FoodList)
            {
                ListViewItem item = new ListViewItem(food.Ten_mon.ToString());
                item.SubItems.Add(food.Don_gia.ToString());
                item.SubItems.Add(food.So_luong.ToString());
                item.SubItems.Add(food.Ghi_chu.ToString());
                item.SubItems.Add(food.Thanh_tien.ToString());
                item.SubItems.Add(food.MaCTDH.ToString());
                tong_tien += food.Thanh_tien;
                OrderLv.Items.Add(item);
            }
            TotalMoneyTb.Text = tong_tien.ToString();
        }

        void LoadFood()
        {
            List<Food> FoodList = FoodDAO.Instance.LoadFoodWithFixedExtras();

            foreach (Food food in FoodList)
            {
                ListViewItem listViewitem = new ListViewItem(food.Ten_mon.ToString());
                listViewitem.SubItems.Add(food.Don_gia.ToString());

                MenuLv.Items.Add(listViewitem);
            }
        }

        int GetMaMN()
        {
            List<Food> FoodList = FoodDAO.Instance.LoadFoodWithFixedExtras();

            foreach (Food food in FoodList)
            {
                if(FoodNameTb.Text == food.Ten_mon.ToString())
                {
                    return food.MaMN;
                } 
            }
            return 0;
        }

        float GetDonGia()
        {
            List<Food> FoodList = FoodDAO.Instance.LoadFoodWithFixedExtras();

            foreach (Food food in FoodList)
            {
                if (FoodNameTb.Text == food.Ten_mon.ToString())
                {
                    return food.Don_gia;
                }
            }
            return 0;
        }

        #endregion

        #region events
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            float khach_dua = float.Parse(MoneyGivingByCustomerTb.Text);
            float tong_tien = float.Parse(TotalMoneyTb.Text);

            if (khach_dua < tong_tien)
            {
                MessageBox.Show("Số tiền khách đưa không đủ để chốt đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn chốt đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    Order order = OrderDAO.Instance.GetOrderWithIDMax();
                    FoodDAO.Instance.UpdateToCompleteOrder(order.MaDH, khach_dua, tong_tien, (khach_dua - tong_tien));
                    MoneyGivingByCustomerTb.Text = "0";
                    TotalMoneyTb.Text = "0";
                    ChangeTb.Text = "0";
                    NoteTb.Text = "Không có ghi chú";
                    AmountOfFoodNud.Value = 1;
                    OrderLv.Items.Clear();
                    FoodDAO.Instance.CreateNewOrder();
                }
            }
        }

        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            int so_luong = (int)AmountOfFoodNud.Value;
            string ghi_chu = NoteTb.Text;
            Order order = OrderDAO.Instance.GetOrderWithIDMax();

            if (order != null && order.Khach_dua == 0)
            {
                FoodDAO.Instance.AddFoodToOrder(order.MaDH, GetMaMN(), so_luong, ghi_chu, GetDonGia());
            }
            LoadOrderFood();
        }
        private int selectedMaCTDH;
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedMaCTDH != 0) 
            {
                FoodDAO.Instance.DeleteFoodFromOrderByMaCTDH(selectedMaCTDH);
                selectedMaCTDH = 0; 
            }
            LoadOrderFood();
        }

        private void MenuLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;

            if(lsv.SelectedItems.Count > 0 )
            {
                ListViewItem selectedItem = MenuLv.SelectedItems[0];

                string Ten_mon_Column = selectedItem.SubItems[0].Text;
                string Don_gia_Column = selectedItem.SubItems[1].Text;

                //MessageBox.Show($"{Ten_mon_Column} : {Don_gia_Column}");
                FoodNameTb.Text = Ten_mon_Column;
                NoteTb.Text = "Không có ghi chú";
            }
        }
        private void MoneyGivingByCustomerTb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (string.IsNullOrWhiteSpace(TotalMoneyTb.Text) || string.IsNullOrWhiteSpace(tb.Text))
            {
                ChangeTb.Text = string.Empty;
                return;
            }

            float totalMoney;
            float moneyGiving;

            if (float.TryParse(TotalMoneyTb.Text, out totalMoney) && float.TryParse(tb.Text, out moneyGiving))
            {
                float change = moneyGiving - totalMoney;

                ChangeTb.Text = change.ToString();

                float tongTien = float.Parse(TotalMoneyTb.Text);
                float khachDua = float.Parse(tb.Text);
                float tienThua = khachDua - tongTien;
                
            }
            else
            {
                if (MessageBox.Show("Kí tự không hợp lệ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                {
                    MoneyGivingByCustomerTb.Text = "0";
                }
            }
        }

        private void OrderLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;

            if (lsv.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = OrderLv.SelectedItems[0];

                string maCTDHValue = selectedItem.SubItems[5].Text;

                selectedMaCTDH = Convert.ToInt32(maCTDHValue); 
            }
        }
        #endregion
    }
}

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
    public partial class UcThucDon : UserControl
    {
        public UcThucDon()
        {
            InitializeComponent();
            LoadFood();
        }

        void LoadFood()
        {
            List<Food> FoodList = FoodDAO.Instance.LoadFoodWithFixedExtras();
            FoodDataGridView.DataSource = FoodList;
        }
        
        private void ResetTb()
        {
            FoodIdTb.Text = "0";
            FoodNameTb.Text = "";
            PriceNud.Value = 0;
        }

        private enum EditStage
        {
            Initial, 
            Editable 
        }

        private EditStage editStage = EditStage.Initial;

        private int MaMN = -1;

        private void FoodDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                string maMN = selectedRow.Cells[0].Value.ToString();
                double Don_gia = Convert.ToDouble(selectedRow.Cells[1].Value);
                string Ten_mon = selectedRow.Cells[2].Value.ToString();

                MaMN = (int)selectedRow.Cells[0].Value;
                //MessageBox.Show(MaMN.ToString());

                FoodNameTb.ReadOnly = true;
                PriceNud.ReadOnly = true;
                FoodIdTb.Text = maMN;
                FoodNameTb.Text = Ten_mon;
                PriceNud.Value = (decimal)Don_gia;
            }
        }

        private bool isFirstClick = true;

        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            if (isFirstClick)
            {
                FoodNameTb.ReadOnly = false;
                PriceNud.ReadOnly = false;

                ResetTb();

                isFirstClick = false; 
            }
            else
            {
                FoodNameTb.ReadOnly = true;
                PriceNud.ReadOnly = true;

                if (!string.IsNullOrEmpty(FoodNameTb.Text) && PriceNud.Value != 0)
                {
                    FoodDAO.Instance.InsertFoodToThucDon(FoodNameTb.Text, (float)PriceNud.Value);
                    ResetTb();
                    LoadFood();
                }
                isFirstClick = true;
            }
        }

        private void DeleteFoodButton_Click(object sender, EventArgs e)
        {
            if(MaMN != -1)
            {
                FoodDAO.Instance.DeleteFoodFromThucDon(MaMN);
                LoadFood();
                MaMN = -1;
            }
        }
        private void EditFoodButton_Click(object sender, EventArgs e)
        {
            if (editStage == EditStage.Initial)
            {
                FoodNameTb.ReadOnly = false;
                PriceNud.ReadOnly = false;
                editStage = EditStage.Editable;
            }
            else if (editStage == EditStage.Editable)
            {
                if (FoodNameTb.Text != "" && PriceNud.Value != 0)
                {
                    FoodDAO.Instance.UpdateFood(MaMN, FoodNameTb.Text, (float)PriceNud.Value);
                    LoadFood();
                    MaMN = -1;
                    editStage = EditStage.Initial; 
                }
            }
        }
    }
}

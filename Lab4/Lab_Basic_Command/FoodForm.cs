using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Basic_Command
{
    public partial class FoodForm : Form
    {
        int currentCategoryID;
        public FoodForm()
        {
            InitializeComponent();
        }      
        public void LoadForm(int categoryID)
        {
            Food food = new Food();
            dvgFood.AutoGenerateColumns = false;
            dvgFood.DataSource = food.ListCategory(categoryID);
            currentCategoryID = categoryID;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgFood.CurrentRow != null)
            {
                int id = Convert.ToInt32(dvgFood.CurrentRow.Cells["ID"].Value);
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa món này?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Food food = new Food();
                    if (food.XoaFood(id))
                    {
                        MessageBox.Show("Đã xóa món ăn");
                        LoadForm(currentCategoryID);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa món ăn");
                    }
                }
            }

        }   

        private void btnSave_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            DataTable dt = (DataTable)dvgFood.DataSource;

            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    food.ThemFood(
                        row["Name"].ToString(),
                        row["Unit"].ToString(),
                        Convert.ToInt32(row["FoodCategoryID"]),
                        Convert.ToDecimal(row["Price"]),
                        row["Notes"].ToString());
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    food.UpdateFood(
                        Convert.ToInt32(row["ID"]),
                        row["Name"].ToString(),
                        row["Unit"].ToString(),
                        Convert.ToInt32(row["FoodCategoryID"]),
                        Convert.ToDecimal(row["Price"]),
                        row["Notes"].ToString());
                }
            }

            MessageBox.Show("Đã lưu những thay đổi");
            LoadForm(currentCategoryID);
        }
    }
}

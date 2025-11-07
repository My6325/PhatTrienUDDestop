using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Lab_Basic_Command
{
    public partial class CategoryForm : Form
    {
        private List<Category> categories = new List<Category>();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void DisplayCategory()
        {
            lvCategory.Items.Clear();
            /*while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());

                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
                l
            vCategory.Items.Add(item);
            }*/
            foreach (var category in categories)
            {
                ListViewItem item = new ListViewItem(category.ID.ToString());
                item.SubItems.Add(category.Name);
                item.SubItems.Add(category.Type.ToString());
                lvCategory.Items.Add(item);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /*string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();  

            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            *//*sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplayCategory(sqlDataReader);
            sqlConnection.Close();*//*
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Lấy dữ liệu từ SQL và chuyển thành các đối tượng Category
                categories.Clear();  // Xóa danh sách cũ
                while (sqlDataReader.Read())
                {
                    Category category = new Category
                    {
                        ID = Convert.ToInt32(sqlDataReader["ID"]),
                        Name = sqlDataReader["Name"].ToString(),
                        Type = Convert.ToInt32(sqlDataReader["Type"])
                    };
                    categories.Add(category);
                }

                // Hiển thị dữ liệu vào ListView
                this.DisplayCategory(sqlDataReader);
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                sqlConnection.Close();
            }*/
            try
            {
                categories = Category.GetAll();
                DisplayCategory();

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category
            {
                Name = txtName.Text,
                Type = Convert.ToInt32(txtType.Text)
            };

            if (newCategory.ThemCategory())
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");
                btnLoad.PerformClick();
                txtName.Clear();
                txtType.Clear();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];
            Category selectedCategory = new Category
            {
                ID = Convert.ToInt32(item.Text),
                Name = item.SubItems[1].Text,    
                Type = Convert.ToInt32(item.SubItems[2].Text) 
            };

            txtID.Text = selectedCategory.ID.ToString();
            txtName.Text = selectedCategory.Name;
            txtType.Text = selectedCategory.Type == 0 ? "Đồ uống" : "Món ăn";
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int type;
            if (string.IsNullOrWhiteSpace(txtType.Text))
            {
                type = Convert.ToInt32(lvCategory.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                if (!int.TryParse(txtType.Text.Trim(), out type))
                {
                    MessageBox.Show("Giá trị loại (Type) phải là số!");
                    return;
                }
            }
            Category updated = new Category
            {
                ID = Convert.ToInt32(txtID.Text),
                Name = txtName.Text,
                Type = Convert.ToInt32(txtType.Text)
            };

            if (updated.UpdateCatergory())
            {
                MessageBox.Show("Cập nhật thành công");
                btnLoad.PerformClick();
            }
            else
                MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm món ăn cần xóa");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa nhóm món ăn này?","Xác nhận xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
                return;

            Category categoryToDelete = new Category
            {
                ID = Convert.ToInt32(txtID.Text)
            };

            if (categoryToDelete.XoaCategory())
            {
                lvCategory.Items.Remove(lvCategory.SelectedItems[0]);
                MessageBox.Show("Xóa nhóm món ăn thành công");
                txtID.Clear();
                txtName.Clear();
                txtType.Clear();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi xóa. Vui lòng thử lại");
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if(lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if(txtID.Text!="")
            {
                FoodForm foodForm = new FoodForm();
                foodForm.Show();
                foodForm.LoadForm(Convert.ToInt32(txtID.Text));

            }    
        }
    }
}

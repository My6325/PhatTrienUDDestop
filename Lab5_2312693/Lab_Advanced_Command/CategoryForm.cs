using System;
using System.Collections;
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

namespace Lab_Advanced_Command
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategoryComboBox();
        }
        private void LoadCategoryComboBox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT Type FROM Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            dt.Columns.Add("TypeName", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["TypeName"] = (int)row["Type"] == 0 ? "Đồ uống" : "Thức ăn";
            }

            cbbType.DataSource = dt;
            cbbType.DisplayMember = "TypeName";
            cbbType.ValueMember = "Type";
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Category(Name, Type) VALUES (@name, @type)";

                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = txtName.Text;
                //cmd.Parameters.Add("@type", SqlDbType.Int).Value = cbbType.SelectedIndex;
                int typeValue = (int)cbbType.SelectedValue; 
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = typeValue;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm nhóm món ăn thành công", "Thông báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Không thể thêm nhóm món ăn!", "Lỗi");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


    }
}

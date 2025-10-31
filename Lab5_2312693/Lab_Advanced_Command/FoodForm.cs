using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Lab_Advanced_Command
{
    public partial class FoodForm : Form
    {
        private DataTable foodTable;
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            LoadCateGory();
        }

        private void LoadCateGory()
        {
            string connectionString= ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();//tạo lệnh SQL gắn với kết nối conn
            cmd.CommandText = "Select ID, Name from Category";
            SqlDataAdapter adapter=new SqlDataAdapter(cmd); //cầu nối giữa SQL và bộ nhớ
            DataTable dt = new DataTable();
            conn.Open();//Mở kết nối
            adapter.Fill(dt);// Thực hiện câu lệnh SELECT và đổ kết quả vào DataTable
            conn.Close();
            conn.Dispose();
            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";

        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kiểm tra xem có mục Category nào được chọn hay không
            if (cbbCategory.SelectedIndex == -1) return;

            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();//tạo lệnh SQL gắn với kết nối conn
            cmd.CommandText = "Select * from Food where FoodCategoryID=@categoryId";
            //SQL cho biết kiểu dữ liệu của tham số là int
            cmd.Parameters.Add("@categoryId", SqlDbType.Int);

            //Kiểm tra vì SelectedValue chưa trả về ID, mà chứa toàn bộ dòng dữ liệu.
            if (cbbCategory.SelectedValue is DataRowView)//tức là comboBox bind trực tiếp đến Datatable
            {
                DataRowView rowView=cbbCategory.SelectedValue as DataRowView;//ép kiểu truy cập các cột trong dòng
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                //nếu là giá trị int thì trực tiếp gán vào
                cmd.Parameters["@categoryId"].Value=cbbCategory.SelectedValue;
            }
            SqlDataAdapter adapter=new SqlDataAdapter(cmd);
            foodTable = new DataTable();

            conn.Open();
            adapter.Fill(foodTable);
            conn.Close();
            conn.Dispose();

            dgvFoodList.DataSource = foodTable;
            dgvFoodList.Columns["ID"].HeaderText = "Mã món ăn";
            dgvFoodList.Columns["Name"].HeaderText = "Tên món ăn";
            dgvFoodList.Columns["Unit"].HeaderText = "Đơn vị tính";
            dgvFoodList.Columns["FoodCategoryID"].HeaderText = "Mã nhóm món ăn";
            dgvFoodList.Columns["Price"].HeaderText = "Đơn giá";
            dgvFoodList.Columns["Notes"].HeaderText = "Ghi chú";
            lblQuantity.Text=foodTable.Rows.Count.ToString();
            lblCatName.Text=cbbCategory.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select @numSaleFood = sum(Quantity) from BillDetails where FoodID=@foodId";
            
            if (dgvFoodList.SelectedRows.Count > 0)//xem có dòng nào đc chọn không
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                //Mỗi dòng trong DataGridView khi bind tới DataTable sẽ có DataBoundItem là một DataRowView,
                //đại diện cho một dòng trong DataTable.
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                cmd.Parameters.Add("@foodId", SqlDbType.Int).Value = rowView["ID"];
                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                string result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + result + " " + rowView[" Unit"]);
                conn.Close();
            }
            cmd.Dispose();
            conn.Dispose();
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if(dgvFoodList.SelectedRows.Count>0)
            {
                DataGridViewRow selectRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView=selectRow.DataBoundItem as DataRowView; 

                FoodInfoForm foodInfoForm = new FoodInfoForm();
                foodInfoForm.FormClosed += new FormClosedEventHandler(FoodForm_FormClosed);
                foodInfoForm.Show();
                foodInfoForm.DisplayFoodInfo(rowView);
            }
        }
        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodInfoForm = new FoodInfoForm();
            foodInfoForm.FormClosed += new FormClosedEventHandler(FoodForm_FormClosed);
            foodInfoForm.Show();
        }

        private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int i=cbbCategory.SelectedIndex;
            LoadCateGory();
            //cbbCategory.SelectedIndex = -1;
            if (i >= 0 && i < cbbCategory.Items.Count)
                cbbCategory.SelectedIndex = i;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExpression="Name like '%"+txtTimKiem.Text+"%'";
            string sortExpression = "Price DESC";
            DataViewRowState dataViewRowState = DataViewRowState.OriginalRows;
            DataView foodView=new DataView(foodTable,filterExpression,sortExpression,dataViewRowState);
            dgvFoodList.DataSource = foodView;
        }
    }
}

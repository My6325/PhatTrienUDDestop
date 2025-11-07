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

namespace Lab_Basic_Command
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void LoadTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                dgvTable.DataSource = dt;
            }
        }


        private void xóaBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTable.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa bàn này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", id);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Đã xóa bàn thành công", "Thông báo");
                            LoadTable();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa bàn này", "Lỗi");
                        }

                        conn.Close();
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;

            DataTable dt = (DataTable)dgvTable.DataSource;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        SqlCommand cmdAdd = new SqlCommand(@"
                    INSERT INTO [Table] (Name, Status, Capacity)
                    VALUES (@Name, @Status, @Capacity)", conn);

                        cmdAdd.Parameters.AddWithValue("@Name", row["Name"]);
                        cmdAdd.Parameters.AddWithValue("@Status", Convert.ToInt32(row["Status"]));
                        cmdAdd.Parameters.AddWithValue("@Capacity", Convert.ToInt32(row["Capacity"]));
                        cmdAdd.ExecuteNonQuery();
                    }

                    else if (row.RowState == DataRowState.Modified)
                    {
                        SqlCommand cmdUpdate = new SqlCommand(@"
                    UPDATE [Table]
                    SET Name = @Name, Status = @Status, Capacity = @Capacity
                    WHERE ID = @ID", conn);

                        cmdUpdate.Parameters.AddWithValue("@Name", row["Name"]);
                        cmdUpdate.Parameters.AddWithValue("@Status", Convert.ToInt32(row["Status"]));
                        cmdUpdate.Parameters.AddWithValue("@Capacity", Convert.ToInt32(row["Capacity"]));
                        cmdUpdate.Parameters.AddWithValue("@ID", Convert.ToInt32(row["ID"]));
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }

            MessageBox.Show("Đã lưu những thay đổi", "Thông báo");
            LoadTable();

        }

        private void xemDanhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                int tableId = Convert.ToInt32(dgvTable.SelectedRows[0].Cells["ID"].Value);
                MainHD form = new MainHD(tableId);
                form.ShowDialog();
            }

        }

        private void xemNhậtKíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                int tableId = Convert.ToInt32(dgvTable.SelectedRows[0].Cells["ID"].Value);
                MainNhatKi form = new MainNhatKi(tableId);
                form.ShowDialog();
            }
        }
    }
}

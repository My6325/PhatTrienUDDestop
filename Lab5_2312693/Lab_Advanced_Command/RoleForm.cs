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

namespace Lab_Advanced_Command
{
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Role( RoleName, Path, Notes) VALUES (@name, @path,@notes)";

                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = txtRoleName.Text;
                cmd.Parameters.Add("@path", SqlDbType.NVarChar, 3000).Value = txtPath.Text;
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000).Value = txtNote.Text;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm vai trò thành công", "Thông báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm vai trò!", "Lỗi");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}

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

namespace Lab_Advanced_Command
{
    public partial class RoleAccount : Form
    {
        private string currentAccount;

        public RoleAccount(string currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
        }

        private void RoleAccount_Load(object sender, EventArgs e)
        {
            LoadRolesAccount();
        }

        private void LoadRolesAccount()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, RoleName, Notes FROM Role", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dt.Columns.Add("Assigned", typeof(bool));

            SqlCommand cmd = new SqlCommand("SELECT RoleID FROM RoleAccount WHERE AccountName = @acc", conn);
            cmd.Parameters.AddWithValue("@acc", currentAccount);
            SqlDataReader reader = cmd.ExecuteReader();

            var listRoleID = new List<int>();
            while (reader.Read())
            {
                listRoleID.Add(Convert.ToInt32(reader["RoleID"]));
            }
            reader.Close();

            foreach (DataRow r in dt.Rows)
            {
                int roleID = Convert.ToInt32(r["ID"]);
                r["Assigned"] = listRoleID.Contains(roleID);
            }

            dgvRoleAccount.DataSource = dt;
            dgvRoleAccount.Columns["Assigned"].DisplayIndex = 0;
            dgvRoleAccount.Columns["Assigned"].HeaderText = "Gán";
            conn.Close();
            conn.Dispose();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvRoleAccount.EndEdit();
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM RoleAccount WHERE AccountName = @acc", conn);
            cmd.Parameters.AddWithValue("@acc", currentAccount);
            cmd.ExecuteNonQuery();

            foreach (DataGridViewRow row in dgvRoleAccount.Rows)
            {
                bool assigned = Convert.ToBoolean(row.Cells["Assigned"].Value);
                int roleID = Convert.ToInt32(row.Cells["ID"].Value);

                if (assigned)
                {
                    SqlCommand cmdIns = new SqlCommand(
                        "INSERT INTO RoleAccount (RoleID, AccountName, Actived) VALUES (@roleID, @acount, 1)", conn);
                    cmdIns.Parameters.AddWithValue("@roleID", roleID);
                    cmdIns.Parameters.AddWithValue("@acount", currentAccount);
                    cmdIns.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật vai trò thành công");
            conn.Close();
            conn.Dispose();
        }

        private void btnAddVT_Click(object sender, EventArgs e)
        {
            RoleForm roleForm = new RoleForm();
            if(roleForm.ShowDialog() == DialogResult.OK)
            {
                LoadRolesAccount();
            }    
        }
    }
}

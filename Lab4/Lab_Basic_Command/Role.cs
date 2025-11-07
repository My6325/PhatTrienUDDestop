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
    public partial class Role : Form
    {
        private string currentAccount;
        public Role(string currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Role_Load(object sender, EventArgs e)
        {
            LoadRolesAccount();
        }

        private void LoadRolesAccount()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
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
    }
}

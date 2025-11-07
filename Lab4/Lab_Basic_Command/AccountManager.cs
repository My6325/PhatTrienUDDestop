using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Basic_Command
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }
        private void AccountManager_Load(object sender, EventArgs e)
        {
            LoadRolesToComboBox();
            LoadActiveToComBoBox();
            LoadAccountsByRole();
        }
      
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            AccountInfoForm accountInfoForm = new AccountInfoForm(AccountInfoForm.Account.Add);
            if (accountInfoForm.ShowDialog() == DialogResult.OK)
            {
                LoadAccountsByRole(); 
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRow = dgvAccount.SelectedRows[0];
                DataRowView rowView = selectRow.DataBoundItem as DataRowView;

                AccountInfoForm accountInfoForm = new AccountInfoForm(AccountInfoForm.Account.Update);
                accountInfoForm.DisplayAccountInfo(rowView);
                if (accountInfoForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAccountsByRole(); 
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRow = dgvAccount.SelectedRows[0];
                DataRowView rowView = selectRow.DataBoundItem as DataRowView;

                AccountInfoForm accountInfoForm = new AccountInfoForm(AccountInfoForm.Account.ResetPassword);
                accountInfoForm.DisplayAccountInfo(rowView);
                if (accountInfoForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAccountsByRole();
                }

            }
        }

        private void xemDanhSáchVaiTròToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAccount.SelectedRows[0];

                string accountName = selectedRow.Cells["AccountName"].Value.ToString();

                Role roleaccount = new Role(accountName);
                roleaccount.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản", "Thông báo");
            }
        }


        private void LoadRolesToComboBox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID, RoleName FROM Role";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                cbbNhom.DataSource = dt;
                cbbNhom.DisplayMember = "RoleName";
                cbbNhom.ValueMember = "ID";
                cbbNhom.SelectedIndex = -1;
            }
        }

        private void LoadActiveToComBoBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text", typeof(string));
            dt.Columns.Add("Value", typeof(bool));

            dt.Rows.Add("1", true);
            dt.Rows.Add("0", false);

            cbbActive.DataSource = dt;
            cbbActive.DisplayMember = "Text";
            cbbActive.ValueMember = "Value";
            cbbActive.SelectedIndex = -1;
        }
        private void LoadAccountsByRole()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
            SELECT distinct a.*
            FROM Account a
            Left JOIN RoleAccount ra ON a.AccountName = ra.AccountName
            WHERE (@RoleID IS NULL OR ra.RoleID = @RoleID)
              AND (@Actived IS NULL OR ra.Actived = @Actived )";

                object roleId = DBNull.Value;
                if (cbbNhom.SelectedIndex != -1 && cbbNhom.SelectedValue != null)
                {
                    if (cbbNhom.SelectedValue is DataRowView rowView)
                    {
                        roleId = rowView["ID"];
                    }
                    else
                    {
                        roleId = cbbNhom.SelectedValue;
                    }
                }

                object actived = DBNull.Value;
                if (cbbActive.SelectedIndex != -1 && cbbActive.SelectedValue != null)
                {
                    if (cbbActive.SelectedValue is DataRowView rowView)
                    {
                        actived = rowView["Value"];
                    }
                    else
                    {
                        actived = cbbActive.SelectedValue;
                    }
                }

                cmd.Parameters.Add("@RoleID",SqlDbType.Int).Value=roleId;
                cmd.Parameters.Add("@Actived", SqlDbType.Bit).Value=actived;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                dgvAccount.DataSource = dt;
            }
        }

        private void cbbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNhom.SelectedValue == null)
                return;
            LoadAccountsByRole();
        }

        private void cbbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbActive.SelectedValue == null)
                return;
            LoadAccountsByRole();
        }
        private void DisableAccountRoles(string accountName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "UPDATE RoleAccount SET Actived = 0 WHERE AccountName = @accountName";
                    cmd.Parameters.AddWithValue("@accountName", accountName);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Đã vô hiệu hóa thành công {rowsAffected} vai trò của tài khoản '{accountName}'.", "Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy vai trò nào để vô hiệu hóa","Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi vô hiệu hóa tài khoản: {ex.Message}", "Lỗi SQL");
            }
        }
        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAccount.SelectedRows[0];

                string accountName = selectedRow.Cells["AccountName"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn vô hiệu hóa tài khoản '{accountName}' không?",
                    "Xác nhận vô hiệu hóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DisableAccountRoles(accountName);
                    LoadAccountsByRole();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để vô hiệu hóa", "Thông báo");
            }
        }
    }
}

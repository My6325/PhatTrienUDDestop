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
    public partial class AccountInfoForm : Form
    {
        public enum Account
        {
            Add,
            Update,
            ResetPassword
        }
        private Account current;

        public AccountInfoForm(Account account)
        {
            InitializeComponent();
            this.current = account;
        }
        private void InitValues()
        {
            string connectionSting = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionSting);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID, RoleName from Role";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);

            ckbVaiTro.DataSource = dt;
            ckbVaiTro.DisplayMember = "RoleName";
            ckbVaiTro.ValueMember = "ID";
            conn.Close();
            conn.Dispose();
        }
        private void LoadRolesAccount(string accountName)
        {
            List<int> roleIDAccount = new List<int>();
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT RoleID FROM RoleAccount WHERE AccountName = @acc AND Actived = 1";

            cmd.Parameters.AddWithValue("@acc", accountName);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int roleId = Convert.ToInt32(reader["RoleID"]);
                roleIDAccount.Add(roleId);
            }
            conn.Close();

            for (int i = 0; i < ckbVaiTro.Items.Count; i++)
            {
                DataRowView row = ckbVaiTro.Items[i] as DataRowView;

                int roleId = Convert.ToInt32(row["ID"]);

                if (roleIDAccount.Contains(roleId))
                    ckbVaiTro.SetItemChecked(i, true);
                else
                    ckbVaiTro.SetItemChecked(i, false);
            }
            conn.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            InitValues();
            switch (current)
            {
                case Account.Add:
                    btnUpdate.Enabled = false;
                    break;

                case Account.Update:
                    btnAdd.Enabled = false;
                    txtAccountName.Enabled = false; 
                    txtPassword.Enabled = false;   
                    break;

                case Account.ResetPassword:
                    btnAdd.Enabled=false;
                    txtAccountName.Enabled = false;
                    txtFullName.Enabled = false;
                    txtEmail.Enabled = false;
                    mtbTell.Enabled = false;
                    dtpDateCreated.Enabled = false;
                    ckbVaiTro.Enabled = false;
                    txtPassword.Enabled = true; 
                    break;
            }
        }

        private void btnAddVTNew_Click(object sender, EventArgs e)
        {
            RoleForm roleForm = new RoleForm();
            if(roleForm.ShowDialog() == DialogResult.OK)
            {
                InitValues();
            }    
        }
        private void ResetText()
        {
            txtAccountName.ResetText();
            txtPassword.ResetText();
            txtFullName.ResetText();
            txtEmail.ResetText();
            mtbTell.ResetText();
            dtpDateCreated.ResetText();
            for (int i = 0; i < ckbVaiTro.Items.Count; i++)
                ckbVaiTro.SetItemChecked(i, false);
        }
        public void DisplayAccountInfo(DataRowView dataRowView)
        {
            try
            {
                txtAccountName.Text = dataRowView["AccountName"].ToString();
                txtPassword.Text = dataRowView["Password"].ToString();
                /*if (dataRowView.DataView.Table.Columns.Contains("Password"))
                    txtPassword.Text = dataRowView["Password"].ToString();
                else
                    txtPassword.Text = "********";*/
                txtFullName.Text = dataRowView["FullName"].ToString();
                txtEmail.Text = dataRowView["Email"].ToString();
                mtbTell.Text = dataRowView["Tell"].ToString();
                dtpDateCreated.Text = dataRowView["DateCreated"].ToString();

                /*ckbVaiTro.SelectedIndex = -1;

                for (int i = 0; i < ckbVaiTro.Items.Count; i++)
                {
                    DataRowView cat = ckbVaiTro.Items[i] as DataRowView;
                    if (cat["ID"].ToString() == dataRowView["Role"].ToString())
                    {
                        ckbVaiTro.SelectedIndex = i;
                        break;
                    }
                }*/
                LoadRolesAccount(txtAccountName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
                SqlConnection conn = new SqlConnection(connetionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Execute InsertAccount @accountname, @password, @fullname, @email, @tell, @date";

                cmd.Parameters.Add("@accountname", SqlDbType.NVarChar,100).Value = txtAccountName.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 200).Value = txtPassword.Text;
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000).Value = txtFullName.Text;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000).Value = txtEmail.Text;
                cmd.Parameters.Add("@Tell", SqlDbType.NVarChar, 200).Value = mtbTell.Text.Replace(".", "");
                cmd.Parameters.Add("@date", SqlDbType.SmallDateTime).Value = dtpDateCreated.Value;

                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    foreach (DataRowView row in ckbVaiTro.CheckedItems)
                    {
                        int roleID = Convert.ToInt32(row["ID"]);

                        SqlCommand cmdIns = new SqlCommand(
                                "INSERT INTO RoleAccount (RoleID, AccountName, Actived) VALUES (@roleID, @acount, 1)", conn);
                        cmdIns.Parameters.AddWithValue("@roleID", roleID);
                        cmdIns.Parameters.AddWithValue("@acount", txtAccountName.Text);
                        cmdIns.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm tài khoản thành công");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!");
                }
                conn.Close();
                conn.Dispose();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                if (current == Account.ResetPassword)
                {
                    SqlCommand cmdReset = conn.CreateCommand();
                    cmdReset.CommandText = "UPDATE Account SET Password = @password WHERE AccountName = @accountname";

                    cmdReset.Parameters.AddWithValue("@accountname", txtAccountName.Text);
                    cmdReset.Parameters.AddWithValue("@password", txtPassword.Text);

                    int rows = cmdReset.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo");
                    else
                        MessageBox.Show("Không thể đặt lại mật khẩu!", "Lỗi");

                    conn.Close();
                    conn.Dispose();
                    this.Close(); 
                    return; 
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Execute UpdateAccount @accountname, @password, @fullname, @email, @tell, @date";

                cmd.Parameters.Add("@accountname", SqlDbType.NVarChar, 100).Value = txtAccountName.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 200).Value = txtPassword.Text;
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000).Value = txtFullName.Text;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000).Value = txtEmail.Text;
                cmd.Parameters.Add("@Tell", SqlDbType.NVarChar, 200).Value = mtbTell.Text.Replace(".", "");
                cmd.Parameters.Add("@date", SqlDbType.SmallDateTime).Value = dtpDateCreated.Value;

               
                cmd.ExecuteNonQuery();
                SqlCommand cmdVT = new SqlCommand("DELETE FROM RoleAccount WHERE AccountName = @acc", conn);
                cmdVT.Parameters.AddWithValue("@acc", txtAccountName.Text);
                cmdVT.ExecuteNonQuery();

                foreach (DataRowView row in ckbVaiTro.CheckedItems)
                {
                    int roleID = Convert.ToInt32(row["ID"]);

                    SqlCommand cmdIns = new SqlCommand(
                            "INSERT INTO RoleAccount (RoleID, AccountName, Actived) VALUES (@roleID, @acount, 1)", conn);
                    cmdIns.Parameters.AddWithValue("@roleID", roleID);
                    cmdIns.Parameters.AddWithValue("@acount", txtAccountName.Text);
                    cmdIns.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật thành công tài khoản");
                conn.Close();
                conn.Dispose();
                this.Close();
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

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
using static Lab_Advanced_Command.AccountInfoForm;

namespace Lab_Advanced_Command
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void LoadAccount()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Account";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            dgvAccount.DataSource = dt;

        }


        private void btnThemTK_Click(object sender, EventArgs e)
        {
            AccountInfoForm accountInfoForm = new AccountInfoForm(Account.Add);
            accountInfoForm.FormClosed += AccountForm_FormClosed;
            accountInfoForm.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        { 
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRow = dgvAccount.SelectedRows[0];
                DataRowView rowView = selectRow.DataBoundItem as DataRowView;

                AccountInfoForm accountInfoForm = new AccountInfoForm(Account.Update);
                accountInfoForm.FormClosed += AccountForm_FormClosed;
                accountInfoForm.Show();
                accountInfoForm.DisplayAccountInfo(rowView);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRow = dgvAccount.SelectedRows[0];
                DataRowView rowView = selectRow.DataBoundItem as DataRowView;

                AccountInfoForm accountInfoForm = new AccountInfoForm(Account.ResetPassword);
                accountInfoForm.FormClosed += AccountForm_FormClosed;
                accountInfoForm.Show();
                accountInfoForm.DisplayAccountInfo(rowView);
            }
        }

        private void xemDanhSáchCácVaiTròToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAccount.SelectedRows[0];

                string accountName = selectedRow.Cells["AccountName"].Value.ToString();

                RoleAccount roleaccount = new RoleAccount(accountName);
                roleaccount.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản", "Thông báo");
            }

        }

        private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int selectedIndex = -1;
            if (dgvAccount.CurrentCell != null)
            {
                selectedIndex = dgvAccount.CurrentCell.RowIndex;
            }
            LoadAccount(); 

            if (selectedIndex >= 0 && selectedIndex < dgvAccount.Rows.Count)
            {
                dgvAccount.Rows[selectedIndex].Selected = true;
            }
        }

        private void xemNhậtKýHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                string account = dgvAccount.SelectedRows[0].Cells["AccountName"].Value.ToString();
                AccountActivity form = new AccountActivity(account);
                form.ShowDialog();
            }
        }
    }
}

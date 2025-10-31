using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Lab_Advanced_Command.AccountInfoForm;

namespace Lab_Advanced_Command
{
    public partial class AccountActivity : Form
    {
        private string accountName;

        public AccountActivity(string account)
        {
            InitializeComponent();
            this.accountName = account;
        }
        private void AccountActivity_Load(object sender, EventArgs e)
        {
            LoadDates();
        }
        private void LoadDates()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
    
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, CheckoutDate FROM Bills WHERE Account = @Account ORDER BY CheckoutDate DESC";
            cmd.Parameters.AddWithValue("@Account", accountName);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            lbDate.DisplayMember = "CheckoutDate";
            lbDate.ValueMember = "ID";
            lbDate.DataSource = dt;

            
            SqlCommand cmdStats = new SqlCommand(
            "SELECT COUNT(*) AS SoHoaDon, SUM(Amount - Amount * Discount) AS TongTien FROM Bills WHERE Account = @Account",
            conn);
            cmdStats.Parameters.AddWithValue("@Account", accountName);

            SqlDataReader reader = cmdStats.ExecuteReader();
            //di chuyển con trỏ về dòng đầu nếu có dữ liệu
            if (reader.Read())
            {
                txtSL.Text = reader["SoHoaDon"].ToString();
                txtTongTien.Text = string.Format("{0:N0}", reader["TongTien"] == DBNull.Value ? 0 : reader["TongTien"]);
            }
            reader.Close();

            conn.Close();
            conn.Dispose();

        }
        private void LoadBillDetails(int billId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                    SELECT f.Name AS[Tên món],
                           f.Unit AS[Đơn vị],
                           bd.Quantity AS[Số lượng],
                           f.Price AS[Đơn giá],
                           (f.Price * bd.Quantity) AS[Thành tiền]
                    FROM BillDetails bd
                    JOIN Food f ON bd.FoodID = f.ID
                    WHERE bd.InvoiceID = @BillID";

            cmd.Parameters.AddWithValue("@BillID", billId);

            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            dgvAccountActivity.DataSource = dt;

        }

        private void lbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDate.SelectedValue == null) return;
            // Nếu vẫn là DataRowView thì thoát ra (đang load dữ liệu)
            if (lbDate.SelectedValue is DataRowView) return;
            int billId = Convert.ToInt32(lbDate.SelectedValue);
            LoadBillDetails(billId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

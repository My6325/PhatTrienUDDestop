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
    public partial class MainHD : Form
    {
        private int tableId;

        public MainHD(int tableId)
        {
            InitializeComponent();
            this.tableId = tableId;
        }

        private void MainHD_Load(object sender, EventArgs e)
        {
            LoadBillDates();
        }
        private void LoadBillDates()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT ID, CheckoutDate FROM Bills WHERE TableID = @TableID AND CheckoutDate IS NOT NULL ORDER BY CheckoutDate DESC",
                    conn);
                cmd.Parameters.AddWithValue("@TableID", tableId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lbDate.DisplayMember = "CheckoutDate";
                lbDate.ValueMember = "ID";
                lbDate.DataSource = dt;
            }
        }

        private void LoadBillDetails(int billId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT f.Name AS [Tên món],
                           f.Unit AS [Đơn vị],
                           bd.Quantity AS [Số lượng],
                           f.Price AS [Đơn giá],
                           (f.Price * bd.Quantity) AS [Thành tiền]
                    FROM BillDetails bd
                    JOIN Food f ON bd.FoodID = f.ID
                    WHERE bd.InvoiceID = @BillID", conn);

                cmd.Parameters.AddWithValue("@BillID", billId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMainHD.DataSource = dt;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDate.SelectedValue == null || lbDate.SelectedValue is DataRowView)
                return;

            int billId = Convert.ToInt32(lbDate.SelectedValue);
            LoadBillDetails(billId);
        }
    }
}

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
    public partial class BillDetailsForm : Form
    {
        int billID;
        public BillDetailsForm(int billID)
        {
            InitializeComponent();
            this.billID = billID;
        }

        private void BillDetailsForm_Load(object sender, EventArgs e)
        {
            LoadBillDetails();
        }
        private void LoadBillDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT f.Name AS [Tên món], f.Unit AS [Đơn vị], bd.Quantity AS [Số lượng], f.Price AS [Đơn giá],
                (f.Price * bd.Quantity) AS [Thành tiền] FROM BillDetails bd JOIN Food f ON bd.FoodID = f.ID WHERE bd.InvoiceID = @InvoiceID";

            cmd.Parameters.AddWithValue("@InvoiceID", billID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            dgvBillDetail.DataSource = dt;
        }
    }
}

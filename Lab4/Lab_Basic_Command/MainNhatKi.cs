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
    public partial class MainNhatKi : Form
    {
        private int tableId;
        public MainNhatKi(int tableId)
        {
            InitializeComponent();
            this.tableId = tableId;
        }

        private void MainNhatKi_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void LoadTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"select ID, Name, TableID,Amount,Discount,Tax,Status,CheckoutDate,Account from Bills
 where TableID = @TableID and CheckoutDate is not null order by CheckoutDate DESC", conn);

                cmd.Parameters.AddWithValue("@TableID", tableId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMainNhatKi.DataSource = dt;
                txtSL.Text = dt.Rows.Count.ToString();

                CalculateTotals();
            }
        }
        private void CalculateTotals()
        {
            double totalAmount = 0, totalDiscount = 0, totalSum = 0;

            foreach (DataGridViewRow row in dgvMainNhatKi.Rows)
            {
                if (row.Cells["Amount"].Value != null)
                {
                    double amount = Convert.ToDouble(row.Cells["Amount"].Value);
                    double discount = Convert.ToDouble(row.Cells["Discount"].Value ?? 0);
                    totalAmount += amount;
                    totalDiscount += amount * discount;
                    totalSum += amount - (amount * discount);
                }
            }

            txtTienChuaGiam.Text = totalAmount.ToString();
            txtThue.Text = totalDiscount.ToString();
            txtTienDaGiam.Text = totalSum.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

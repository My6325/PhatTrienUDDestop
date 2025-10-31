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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-1000); 
            dtpTo.Value = DateTime.Today;
            LoadBills(dtpFrom.Value,dtpTo.Value);
        }
        private void LoadBills(DateTime fromDate, DateTime toDate)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID, Name, TableID, Amount, Discount, Tax, Status, CheckoutDate, Account from Bills where (CONVERT(DATE, CheckoutDate) between @From and @To) OR (CheckoutDate IS NULL) ORDER BY CheckoutDate ";
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

            cmd.Parameters.AddWithValue("@From", from); 
            cmd.Parameters.AddWithValue("@To", to);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            conn.Open();
            MessageBox.Show($"From = {fromDate:dd/MM/yyyy HH:mm:ss}\nTo = {toDate:dd/MM/yyyy HH:mm:ss}");

            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            dvgBill.DataSource = dt;
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            double totalAmount = 0, totalDiscount = 0, totalSum = 0;

            foreach (DataGridViewRow row in dvgBill.Rows)
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
            txtSTGiam.Text =totalDiscount.ToString();
            txtTienDaGiam.Text = totalSum.ToString();
        }

        private void dvgBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int billId = Convert.ToInt32(dvgBill.Rows[e.RowIndex].Cells["ID"].Value);
                OrderDetailsForm detailsForm = new OrderDetailsForm(billId);
                detailsForm.Show();
            }
        }
    }
}

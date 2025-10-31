using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Lab_Advanced_Command
{
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }
        private void InitValues()
        {
            string connectionSting = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionSting);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID, Name from Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); //chứa 1 hoặc nhiều bảng 

            conn.Open();
            adapter.Fill(ds,"Category");

            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";
            conn.Close();
            conn.Dispose();
        }
        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            dudPrice.ResetText();
        }
        //Thêm món ăn
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
                SqlConnection conn = new SqlConnection(connetionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Execute InsertFood @id output, @name, @unit, @foodCategoryID, @price, @notes";

                cmd.Parameters.Add("@id", SqlDbType.Int).Direction=ParameterDirection.Output;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 3000).Value= txtName.Text;
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 3000).Value = txtUnit.Text;
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int).Value = cbbCatName.SelectedValue;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = dudPrice.Text;
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000).Value = txtNotes.Text;

                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Successfully adding new food, Food ID = " + foodID, "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding food failed");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void DisplayFoodInfo(DataRowView dataRowView)
        {
            try
            {
                txtFoodID.Text = dataRowView["ID"].ToString();
                txtName.Text = dataRowView["Name"].ToString();
                txtUnit.Text = dataRowView["Unit"].ToString();
                txtNotes.Text = dataRowView["Notes"].ToString();
                dudPrice.Text = dataRowView["Price"].ToString();

                cbbCatName.SelectedIndex = -1;

                for(int i = 0;i<cbbCatName.Items.Count;i++)
                {
                    DataRowView cat = cbbCatName.Items[i] as DataRowView;
                    if (cat["ID"].ToString() == dataRowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RestaurantManagement"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Exec UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(txtFoodID.Text);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 3000).Value = txtName.Text;
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 3000).Value = txtUnit.Text;
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int).Value = cbbCatName.SelectedValue;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = dudPrice.Text;
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000).Value = txtNotes.Text;

                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    MessageBox.Show("Successfully updating food", "Message");
                    ///this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating food failed");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            //categoryForm.Show();
            if(categoryForm.ShowDialog() == DialogResult.OK)
            {
                InitValues();
            }
        }
    }
}

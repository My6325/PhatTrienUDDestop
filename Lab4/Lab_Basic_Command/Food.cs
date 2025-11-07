using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Basic_Command
{
    public class Food
    {
        public int ID { get; set; }         
        public string Name { get; set; }       
        public string Unit { get; set; }        
        public int FoodCategoryID { get; set; }
        public int Price { get; set; }        
        public string Notes { get; set; }
        public Food() { }
        public Food(int iD, string nameFood, string unit, int foodCategoryID, int price, string notes)
        {
            ID = iD;
            Name = nameFood;
            Unit = unit;
            FoodCategoryID = foodCategoryID;
            Price = price;
            Notes = notes;
        }
        private static string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
        public DataTable ListCategory(int categoryID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT ID, Name, Unit, FoodCategoryID, Price, Notes FROM Food WHERE FoodCategoryID = @categoryID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@categoryID", categoryID);
                adapter.Fill(dt);
            }

            return dt;
        }
        public bool ThemFood(string name, string unit, int categoryID, decimal price, string notes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes)
                                 VALUES (@name, @unit, @categoryID, @price, @notes)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@categoryID", categoryID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@notes", notes ?? "");

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool UpdateFood(int id,string name, string unit, int categoryID, decimal price, string notes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Food 
                                 SET Name=@name, Unit=@unit, FoodCategoryID=@categoryID, Price=@price, Notes=@notes 
                                 WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@categoryID", categoryID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@notes", notes ?? "");

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool XoaFood(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Food WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

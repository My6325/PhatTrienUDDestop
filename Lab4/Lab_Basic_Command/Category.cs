using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Basic_Command
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        private static string connectionString = ConfigurationManager.ConnectionStrings["Restaurant"].ConnectionString;
        public static List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Name, Type FROM Category";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Category
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Name"].ToString(),
                        Type = Convert.ToInt32(reader["Type"])
                    });
                }
            }
            return categories;
        }
        public bool ThemCategory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Category(Name, [Type]) VALUES (@Name, @Type)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Type", Type);

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                connection.Close();
                return result == 1;

            }
        }
            
        public bool XoaCategory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Category WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                connection.Close();
                return result == 1;

            }
        }
        public bool UpdateCatergory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Category SET Name = @Name, Type = @Type WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Type", Type);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;

            }
        }
    }
}


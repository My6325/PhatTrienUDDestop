using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FoodDA
    {
        public List<Food> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionStrinng);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Food_GetAll;

            SqlDataReader dr = cmd.ExecuteReader();
            List<Food> list = new List<Food>();
            while (dr.Read())
            {
                Food food = new Food();
                food.ID = Convert.ToInt32(dr["ID"]);
                food.Name = dr["Name"].ToString();
                food.Unit = dr["Unit"].ToString();
                food.FoodCategoryID = Convert.ToInt32(dr["FoodCategoryID"]);
                food.Price = Convert.ToInt32(dr["Price"]);
                food.Notes = dr["Notes"].ToString();

                list.Add(food);
            }
            conn.Close();
            return list;
        }
        public int Insert_Update_Delete(Food food, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionStrinng);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Food_InsertUpdateDelete;

            SqlParameter sqlParameter = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(sqlParameter).Value = food.ID;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = food.Name;
            cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 1000).Value = food.Unit;
            cmd.Parameters.Add("@FoodCategoryID", SqlDbType.Int).Value = food.FoodCategoryID;
            cmd.Parameters.Add("@Price", SqlDbType.Int).Value = food.Price;
            cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = food.Notes;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return (int)cmd.Parameters["@ID"].Value;
            return 0;
        }
    }
}

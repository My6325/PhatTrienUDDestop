using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataAccess
{
    public class CategoryDA
    {
        public List<Category> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionStrinng);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.CommandText=Ultilities.Category_GetAll;

            SqlDataReader dr = cmd.ExecuteReader();
            List<Category> list = new List<Category>();
            while(dr.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(dr["ID"]);
                category.Name = dr["Name"].ToString();
                category.Type= Convert.ToInt32(dr["Type"]);
                list.Add(category);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(Category category,int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionStrinng);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Category_InsertUpdateDelete;

            SqlParameter sqlParameter = new SqlParameter("@ID",SqlDbType.Int);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(sqlParameter).Value=category.ID;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = category.Name;
            cmd.Parameters.Add("@Type", SqlDbType.Int).Value = category.Type;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result= cmd.ExecuteNonQuery();
            if(result>0)
                return (int)cmd.Parameters["@ID"].Value;
            return 0;
        }
    }
}

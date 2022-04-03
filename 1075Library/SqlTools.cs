using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1075Library
{
    public class SqlTools
    {
        static string connString = _1075Library.GlobalConfig.GetConnString("Strekov1075");

        public static bool CheckUsernameExists(string username)
        {
            using (SqlConnection sqlCon = new SqlConnection(connString))
            {
                DataTable dt = new DataTable();

                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("dbo.GetAllUsers", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);

                DataRow resultRow = dt.AsEnumerable().FirstOrDefault(x => (x["username"].ToString().Trim()) == username);
                if (resultRow == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public static bool CheckValidLogin(string username, string password)
        {
            using (SqlConnection sqlCon = new SqlConnection(connString))
            {
                DataTable dt = new DataTable();

                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("dbo.GetAllUsers", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    if (row["username"].ToString().Trim() == username && row["password"].ToString().Trim() == password)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
        public static void Register(string username, string password)
        {
            using (SqlConnection sqlCon = new SqlConnection(connString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("dbo.User_Add", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", username);
                sqlCmd.Parameters.AddWithValue("@password", password);
                sqlCmd.ExecuteNonQuery(); 
            }
        }
    }
}

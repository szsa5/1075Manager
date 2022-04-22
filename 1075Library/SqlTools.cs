﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _1075Library
{
    public class SqlTools
    {
        static string connString = _1075Library.GlobalConfig.GetConnString("Strekov1075");

        public static bool CheckUsernameExists(string username)
        {
            
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                DataTable dt = new DataTable();

                conn.Open();
                MySqlCommand sqlCmd = new MySqlCommand("GetAllUsers", conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd);
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
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                DataTable dt = new DataTable();

                conn.Open();
                MySqlCommand sqlCmd = new MySqlCommand("GetAllUsers", conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd);
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
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("RegisterUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_username", username);
                cmd.Parameters["@p_username"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_password", password);
                cmd.Parameters["@p_password"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }
    }
}

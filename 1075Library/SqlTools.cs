using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using _1075Library.Models;
using System.IO;
using System.Drawing;

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

        public static List<WineModel> GetWines()
        {
            List<WineModel> wines = new List<WineModel>();
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand("GetWines", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    WineModel wine = new WineModel();
                    Image wineImage = null;

                    //1. bor_id
                    wine.bor_id = Convert.ToInt32(row["bor_id"]);
                    //2. bor_nev
                    wine.bor_nev = row["bor_nev"].ToString();
                    //3. bor_evjarat
                    wine.bor_nev = row["bor_nev"].ToString();
                    //4. bor_szolo
                    wine.bor_szolo = row["bor_szolo"].ToString();
                    //5. bor_ken
                    wine.bor_ken = row["bor_ken"].ToString();
                    //6. bor_alkohol
                    wine.bor_alkohol = row["bor_alkohol"].ToString();
                    //7. bor_cukor
                    wine.bor_cukor = row["bor_cukor"].ToString();
                    //8. bor_extrakt
                    wine.bor_extrakt = row["bor_extrakt"].ToString();
                    //9. bor_pdatum
                    wine.bor_pdatum = row["bor_pdatum"].ToString();
                    //10. bor_ar
                    wine.bor_ar = row["bor_ar"].ToString();
                    //11. bor_raktar
                    wine.bor_raktar = Convert.ToInt32(row["bor_raktar"]);
                    //12. bor_picture
                    if (row["picturepath"].ToString() != "")
                    {
                        string wineDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + row["picturepath"].ToString();
                        try
                        {
                            wineImage = Image.FromFile(wineDirectory);
                        }
                        catch (System.IO.FileNotFoundException)
                        {
                            Console.WriteLine("Image not found for wine " + wine.bor_nev + " with path: " + row["picturepath"].ToString());
                        }

                        wine.Image = wineImage;
                    }

                    //add to wine object
                    wines.Add(wine);
                }
            }
            return wines;
        }

        public static int CreateWine(string bor_nev, string bor_evjarat, string bor_szolo, string bor_ken, string bor_alkohol, string bor_cukor, 
            string bor_extrakt, string bor_pdatum, string bor_ar, int bor_raktar, string in_picturepath)
        {
            int id=0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("CreateWine", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@bor_nev", bor_nev);
                cmd.Parameters["@bor_nev"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_evjarat", bor_evjarat);
                cmd.Parameters["@bor_evjarat"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_szolo", bor_szolo);
                cmd.Parameters["@bor_szolo"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_ken", bor_ken);
                cmd.Parameters["@bor_ken"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_alkohol", bor_alkohol);
                cmd.Parameters["@bor_alkohol"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_cukor", bor_cukor);
                cmd.Parameters["@bor_cukor"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_extrakt", bor_extrakt);
                cmd.Parameters["@bor_extrakt"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_pdatum", bor_pdatum);
                cmd.Parameters["@bor_pdatum"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_ar", bor_ar);
                cmd.Parameters["@bor_ar"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@bor_raktar", bor_raktar);
                cmd.Parameters["@bor_raktar"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@in_picturepath", in_picturepath);
                cmd.Parameters["@in_picturepath"].IsNullable = true;
                cmd.Parameters["@in_picturepath"].Direction = ParameterDirection.Input;
                

                cmd.Parameters.Add(new MySqlParameter("?out_id", MySqlDbType.Int32));
                cmd.Parameters["?out_id"].Direction = ParameterDirection.Output;

                id = Convert.ToInt32(cmd.Parameters["?out_id"].Value);

                cmd.ExecuteNonQuery();
            }

            return id;
            //continue
        }
    }
}

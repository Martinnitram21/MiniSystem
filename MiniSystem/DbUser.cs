using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSystem
{
    internal class DbUser
    {
        public static MySqlConnection GetConnection()
        {
            string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void AddClient(User user)
        {
            string sql = "INSERT INTO hotel_login (hotel_user, hotel_pass) VALUES (@Username, @Password)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = user.Username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = user.Password;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account Not Added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateClient(User user, string id)
        {
            string sql = "UPDATE hotel_login SET hotel_user = @Username, hotel_password = @Password WHERE hotel_id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = user.Username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = user.Password;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account Not Updated \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteClient(string hotelId)
        {
            string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string query = "DELETE FROM hotel_login WHERE hotel_id = @hotelId";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@hotelId", hotelId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}

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
    internal class DbGuest
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
        public static void AddClient(Client clt)
        {
            string sql = "INSERT INTO hotel_guest (guest_lastname, guest_firstname, guest_phoneno, guest_email, guest_address) VALUES (@LastName, @FirstName, @PhoneNo, @Email, @Address)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = clt.LastName;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = clt.FirstName;
            cmd.Parameters.Add("@PhoneNo", MySqlDbType.VarChar).Value = clt.PhoneNo;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = clt.Email;
            cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = clt.Address;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Guest Not Added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateClient(Client clt, string id)
        {
            string sql = "UPDATE hotel_guest SET guest_lastname = @LastName, guest_firstname = @FirstName, guest_phoneno = @PhoneNo, guest_email = @Email, guest_address = @Address WHERE guest_id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = clt.LastName;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = clt.FirstName;
            cmd.Parameters.Add("@PhoneNo", MySqlDbType.VarChar).Value = clt.PhoneNo;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = clt.Email;
            cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = clt.Address;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Guest Not Updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        //public static void DeleteClient(string id)
        //{
        //    string sql = "DELETE FROM hotel_guest WHERE guest_id = @ID";
        //    MySqlConnection con = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, con);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Client Not Deleted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    con.Close();
        //}
        public static void DeleteClient(string guestId)
        {
            string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string query = "DELETE FROM hotel_guest WHERE guest_id = @guestId";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@guestId", guestId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void DisplayAndSearch(string query, DataGridView dgv, string searchTerm)
        {
            // Construct the search query
            string sql = query + " WHERE guest_lastname LIKE @searchTerm " +
                                 "OR guest_firstname LIKE @searchTerm " +
                                 "OR guest_phoneno LIKE @searchTerm " +
                                 "OR guest_email LIKE @searchTerm " +
                                 "OR guest_address LIKE @searchTerm";

            // Open a connection to the database
            using (MySqlConnection con = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    // Add the search term as a parameter
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    // Execute the query and fill the DataTable
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable tbl = new DataTable();
                    adp.Fill(tbl);

                    // Bind the data to the DataGridView
                    dgv.DataSource = tbl;
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

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
    internal class DbReservation
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
            string sql = "INSERT INTO hotel_reservation (client_name, room_type, room_number, date_in, date_out) VALUES (@Name, @RoomType, @RoomNumber, @DateIn, @DateOut)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = clt.FullName;
            cmd.Parameters.Add("@RoomType", MySqlDbType.VarChar).Value = clt.RoomType;
            cmd.Parameters.Add("@RoomNumber", MySqlDbType.VarChar).Value = clt.RoomNumber;
            cmd.Parameters.Add("@DateIn", MySqlDbType.DateTime).Value = clt.DateIn;
            cmd.Parameters.Add("@DateOut", MySqlDbType.DateTime).Value = clt.DateOut;

            try
            {
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client Not Added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            //string sql = "INSERT INTO hotel_reservation (client_name, room_type, room_number, date_in, date_out) VALUES (@Name, @RoomType, @RoomNumber, @DateIn, @DateOut)";
            ////string sql = "INSERT INTO student_table VALUES (NULL, @student_name, @student_reg, @student_class, @student_section)";
            //MySqlConnection con = GetConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = clt.Name;
            //cmd.Parameters.Add("@RoomType", MySqlDbType.VarChar).Value = clt.RoomType;
            //cmd.Parameters.Add("@RoomNumber", MySqlDbType.VarChar).Value = clt.RoomNumber;
            //cmd.Parameters.Add("@DateIn", MySqlDbType.VarChar).Value = clt.DateIn;
            //cmd.Parameters.Add("@DateOut", MySqlDbType.VarChar).Value = clt.DateOut;
            ///*cmd.Parameters.Add("@student_name", MySqlDbType.VarChar).Value = std.Name;
            //cmd.Parameters.Add("@student_reg", MySqlDbType.VarChar).Value = std.Reg;
            //cmd.Parameters.Add("@student_class", MySqlDbType.VarChar).Value = std.Class;
            //cmd.Parameters.Add("@student_section", MySqlDbType.VarChar).Value = std.Section;
            //*/
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Client Not Added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //con.Close();
        }
        public static void UpdateClient(Client clt, string id)
        {
            //string sql = "UPDATE hotel_reservation SET client_name = @Name, room_type = @RoomType, room_number = @RoomNumber, date_in = @DateIn, date_out = @DateOut WHERE reservation_id = @id";
            ////string sql = "INSERT INTO student_table VALUES (NULL, @student_name, @student_reg, @student_class, @student_section)";
            //MySqlConnection con = GetConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            //cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = clt.Name;
            //cmd.Parameters.Add("@RoomType", MySqlDbType.VarChar).Value = clt.RoomType;
            //cmd.Parameters.Add("@RoomNumber", MySqlDbType.VarChar).Value = clt.RoomNumber;
            //cmd.Parameters.Add("@DateIn", MySqlDbType.VarChar).Value = clt.DateIn;
            //cmd.Parameters.Add("@DateOut", MySqlDbType.VarChar).Value = clt.DateOut;
            ///*cmd.Parameters.Add("@student_name", MySqlDbType.VarChar).Value = std.Name;
            //cmd.Parameters.Add("@student_reg", MySqlDbType.VarChar).Value = std.Reg;
            //cmd.Parameters.Add("@student_class", MySqlDbType.VarChar).Value = std.Class;
            //cmd.Parameters.Add("@student_section", MySqlDbType.VarChar).Value = std.Section;
            //*/
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Client Not Updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //con.Close();
            string sql = "UPDATE hotel_reservation SET client_name = @Name, room_type = @RoomType, room_number = @RoomNumber, date_in = @DateIn, date_out = @DateOut WHERE reservation_id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = clt.FullName;
            cmd.Parameters.Add("@RoomType", MySqlDbType.VarChar).Value = clt.RoomType;
            cmd.Parameters.Add("@RoomNumber", MySqlDbType.VarChar).Value = clt.RoomNumber;
            cmd.Parameters.Add("@DateIn", MySqlDbType.DateTime).Value = clt.DateIn;
            cmd.Parameters.Add("@DateOut", MySqlDbType.DateTime).Value = clt.DateOut;

            try
            {
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client Not Updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        //public static void DeleteClient(string id)
        //{
        //    string sql = "DELETE FROM hotel_reservation WHERE reservation_id = @ID";
        //    MySqlConnection con = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, con);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        //MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Client Not Deleted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    con.Close();
        //}
        public static void DeleteClient(string reservationId)
        {
            string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string query = "DELETE FROM hotel_reservation WHERE reservation_id = @reservationId";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@reservationId", reservationId);
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
        public static void DisplayAndSearch(string query, DataGridView dgv, string searchTerm)
        {
            // Construct the search query
            string sql = query + " WHERE client_name LIKE @searchTerm " +
                                 "OR room_type LIKE @searchTerm " +
                                 "OR room_number LIKE @searchTerm " +
                                 "OR date_in LIKE @searchTerm " +
                                 "OR date_out LIKE @searchTerm";

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
    }
}

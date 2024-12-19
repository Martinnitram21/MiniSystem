using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSystem.User_Control
{
    public partial class UserControlDashBoard : UserControl
    {
        public UserControlDashBoard()
        {
            InitializeComponent();
            GetConnection();
            GetGuestCount();
        }
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
        public static int GetGuestCount()
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM hotel_guest";

            using (MySqlConnection con = GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return count;
        }
        public void DisplayTotalEarnings(Label lblEarnings)
        {
            string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string query = "SELECT earning_total FROM hotel_earning WHERE earning_id = 1";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    decimal totalEarnings = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    lblEarning.Text = totalEarnings.ToString("C");  // "C" formats as currency
                }
            }
        }
        private void lblGuest_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDashBoard_Load(object sender, EventArgs e)
        {
            int guestCount = GetGuestCount();
            int result = 10 - guestCount;
            lblGuest.Text = GetGuestCount().ToString();
            lblRoom.Text = result.ToString();
            DisplayTotalEarnings(lblEarning);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int guestCount = GetGuestCount();
            int result = 10 - guestCount;
            lblGuest.Text = GetGuestCount().ToString();
            lblRoom.Text = result.ToString();
            DisplayTotalEarnings(lblEarning);
        }
    }
}

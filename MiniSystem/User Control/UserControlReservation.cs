using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniSystem.User_Control
{
    public partial class UserControlReservation : UserControl
    {
        internal string id, name, roomtype, roomnumber, datein, dateout;

        private List<string> availableRooms = new List<string> { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110"};
        public UserControlReservation()
        {
            InitializeComponent();
            InitializeComboBox();
            //PopulateComboBox();
        }
        public static void RefreshData(DataGridView dgv)
        {
            string query = "SELECT * FROM hotel_reservation";
            DbReservation.DisplayAndSearch(query, dgv);
        }
        private void PopulateComboBox()
        {
            //string connectionString = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
            //string query = "SELECT CONCAT(guest_lastname, ' ', guest_firstname) AS full_name FROM hotel_guest;";

            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        MySqlCommand command = new MySqlCommand(query, connection);
            //        MySqlDataReader reader = command.ExecuteReader();

            //        while (reader.Read())
            //        {
            //            string value = reader.GetString("full_name"); // Assuming the concatenated name is retrieved with the alias 'full_name'
            //            clientTXT.Items.Add(value); // Add each value to the ComboBox
            //        }

            //        reader.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
            string connectionString = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
            string query = "SELECT guest_lastname FROM hotel_guest;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string value = reader.GetString(0); // Assuming the column is of type string. Adjust accordingly.
                        clientTXT.Items.Add(value); // Add each value to the ComboBox
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void InitializeComboBox()
        {
            roomNumberTXT.DataSource = availableRooms;
        }
        public void Clear()
        {

            //clientTXT.Clear();
            //tabControlReservation.SelectedTab = tabPageAddReservation;
        }
        public void Clear1()
        {
            //reservIdTXT.Clear();
            //clientTXT.Clear();
        }
        public void Display()
        {
            DbReservation.DisplayAndSearch("SELECT reservation_id, client_name, room_type, room_number, date_in, date_out FROM hotel_reservation", dataGridView1);
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            Display();
            dateInTXT.Format = DateTimePickerFormat.Custom;

            dateInTXT.CustomFormat = "yyyy-MM-dd";
            dateOutTXT.CustomFormat = "yyyy-MM-dd";
        }

        private void btnAddReserve_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.SelectedRows[0].Cells["reservation_id"].Value.ToString();
                DbReservation.DeleteClient(id);
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Select a record to delete");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dateInTXT.Value <= dateOutTXT.Value && clientTXT.Text != "")
            {
                id = dataGridView1.SelectedRows[0].Cells["reservation_id"].Value.ToString();
                Client clt = new Client(clientTXT.Text.Trim(), roomTypeTXT.Text.Trim(), roomNumberTXT.Text.Trim(), dateInTXT.Value, dateOutTXT.Value);
                DbReservation.UpdateClient(clt, id);
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Invalid Selection or Date");
            }
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                clientTXT.Text = row.Cells["client_name"].Value.ToString();
                roomTypeTXT.Text = row.Cells["room_type"].Value.ToString();
                roomNumberTXT.Text = row.Cells["room_number"].Value.ToString();
                dateInTXT.Value = Convert.ToDateTime(row.Cells["date_in"].Value);
                dateOutTXT.Value = Convert.ToDateTime(row.Cells["date_out"].Value);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = "SELECT reservation_id, client_name, room_type, room_number, date_in, date_out FROM hotel_reservation WHERE client_name LIKE '%" + txtSearch.Text + "%'";
            DbReservation.DisplayAndSearch(searchQuery, dataGridView1);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData(dataGridView1);
            PopulateComboBox();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            string query = "SELECT reservation_id, client_name, room_type, room_number, date_in, date_out FROM hotel_reservation";
            DbReservation.DisplayAndSearch(query, dataGridView1, searchTerm);
        }

        private void btnAddReserve_Click_1(object sender, EventArgs e)
        {
            if (dateInTXT.Value <= dateOutTXT.Value && clientTXT.Text != "")
            {
                Client clt = new Client(clientTXT.Text.Trim(), roomTypeTXT.Text.Trim(), roomNumberTXT.Text.Trim(), dateInTXT.Value, dateOutTXT.Value);
                DbReservation.AddClient(clt);
                string selectedRoom = roomNumberTXT.SelectedItem as string;
                if (selectedRoom != null)
                {
                    availableRooms.Remove(selectedRoom);
                    roomNumberTXT.DataSource = null;
                    roomNumberTXT.DataSource = availableRooms;
                }
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Invalid Date or Client Name");
            }
            Clear();
        }

        private void roomNumberTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void UserControlReservation_Leave(object sender, EventArgs e)
        {
            InitializeComboBox();
        }

        private void listViewReservation_MouseClick(object sender, MouseEventArgs e)
        {
            //if (listViewReservation.SelectedItems.Count > 0)
            //{
            //    reservIdTXT.Text = listViewReservation.SelectedItems[0].SubItems[0].Text;
            //    clientTXT.Text = listViewReservation.SelectedItems[0].SubItems[1].Text;
            //    roomTypeTXT.Text = listViewReservation.SelectedItems[0].SubItems[2].Text;
            //    roomNumberTXT.Text = listViewReservation.SelectedItems[0].SubItems[3].Text;
            //    dateInTXT.Text = listViewReservation.SelectedItems[0].SubItems[4].Text;
            //    dateOutTXT.Text = listViewReservation.SelectedItems[0].SubItems[5].Text;
            //}
            //else
            //{
            //    MessageBox.Show("Hakdog");
            //}
        }

        private void listViewReservation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

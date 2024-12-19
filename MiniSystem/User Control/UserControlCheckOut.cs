using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSystem
{
    public partial class UserControlCheckOut : UserControl
    {
        public UserControlCheckOut()
        {
            InitializeComponent();
        }
        public class RoomRate
        {
            public string RoomType { get; set; }
            public decimal Rate { get; set; }
        }

        public class RoomRateManager
        {
            private LinkedList<RoomRate> roomRates;

            public RoomRateManager()
            {
                roomRates = new LinkedList<RoomRate>();
                roomRates.AddLast(new RoomRate { RoomType = "Single", Rate = 100 });
                roomRates.AddLast(new RoomRate { RoomType = "Double", Rate = 175 });
                roomRates.AddLast(new RoomRate { RoomType = "Deluxe", Rate = 300 });
                roomRates.AddLast(new RoomRate { RoomType = "Studio", Rate = 350 });
                roomRates.AddLast(new RoomRate { RoomType = "Suite", Rate = 500 });
            }

            public decimal GetRoomRate(string roomType)
            {
                foreach (var rate in roomRates)
                {
                    if (rate.RoomType == roomType)
                    {
                        return rate.Rate;
                    }
                }
                throw new ArgumentException("Room type not found");
            }
        }
        public void Display()
        {
            DbReservation.DisplayAndSearch("Select reservation_id, client_name, room_type, room_number, date_in, date_out From hotel_reservation", dataGridView1);
        }
        public static void RefreshData(DataGridView dgv)
        {
            string query = "SELECT * FROM hotel_reservation";
            DbReservation.DisplayAndSearch(query, dgv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string reservationId = selectedRow.Cells["reservation_id"].Value.ToString();
                string clientName = selectedRow.Cells["client_name"].Value.ToString();
                string roomType = selectedRow.Cells["room_type"].Value.ToString();
                string roomNumber = selectedRow.Cells["room_number"].Value.ToString();
                string dateInStr = selectedRow.Cells["date_in"].Value.ToString();
                string dateOutStr = selectedRow.Cells["date_out"].Value.ToString();

                // Parse date strings into DateTime objects
                DateTime dateIn = DateTime.Parse(dateInStr);
                DateTime dateOut = DateTime.Parse(dateOutStr);

                // Calculate duration of stay in days
                TimeSpan duration = dateOut - dateIn;
                int numberOfDays = (int)duration.TotalDays;

                // Retrieve room rate using RoomRateManager
                RoomRateManager rateManager = new RoomRateManager();
                decimal roomRate = rateManager.GetRoomRate(roomType);

                // Calculate total cost
                decimal totalCost = roomRate + (roomRate * numberOfDays);

                FormBill billForm = new FormBill(dataGridView1);
                billForm.id = reservationId;
                billForm.clientname = clientName;
                billForm.roomtype = roomType;
                billForm.RoomNumber = roomNumber;
                billForm.datein = dateInStr;
                billForm.dateout = dateOutStr;
                billForm.TotalCost = totalCost;
                billForm.ShowDialog();
            }
            else
            {
                // Inform the user if no row is selected
                MessageBox.Show("Please select a row to generate the bill.", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //form.Clear();
            //form.SaveInfo();
            //form.ShowDialog();
        }

        private void UserControlCheckOut_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            Display();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData(dataGridView1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchQuery = "SELECT reservation_id, client_name, room_type, room_number, date_in, date_out FROM hotel_reservation WHERE client_name LIKE '%" + txtSearch.Text + "%'";
            DbReservation.DisplayAndSearch(searchQuery, dataGridView1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

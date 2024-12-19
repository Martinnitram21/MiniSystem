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

namespace MiniSystem
{
    public partial class FormBill : Form
    {
        internal string id, clientname, roomtype, datein, dateout;

        private DataGridView reservationDataGridView;
        private DataGridView guestDataGridView;
        public decimal TotalCost { get; set; }

        public FormBill(DataGridView reservationDataGridView)
        {
            InitializeComponent();
            this.reservationDataGridView = reservationDataGridView; // Store reference to the reservation DataGridView
            //this.guestDataGridView = guestDataGridView; // Store reference to the guest DataGridView
        }

        private void txtPaymentAmount_TextChanged(object sender, EventArgs e)
        {
            // Get the payment amount entered by the user
            if (decimal.TryParse(txtPaymentAmount.Text, out decimal paymentAmount))
            {
                // Calculate change
                decimal change = paymentAmount - TotalCost;
                if (change >= 0)
                {
                    lblChange.Text = change.ToString(); // Display the change
                }
                else
                {
                    lblChange.Text = ""; // Clear change if payment is insufficient
                }
            }
            else
            {
                lblChange.Text = ""; // Clear change if payment amount is invalid
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Get the payment amount entered by the user
            if (decimal.TryParse(txtPaymentAmount.Text, out decimal paymentAmount))
            {
                // Check if payment is sufficient
                if (paymentAmount >= TotalCost)
                {
                    // Remove the selected client from the DataGridView
                    if (reservationDataGridView.SelectedRows.Count > 00)
                    {
                        DataGridViewRow selectedReservationRow = reservationDataGridView.SelectedRows[0];
                        //DataGridViewRow selectedGuestRow = guestDataGridView.SelectedRows[0];

                        // Retrieve the unique identifier (e.g., primary key) of the record
                        string reservationId = selectedReservationRow.Cells["reservation_id"].Value.ToString();
                        //string guestId = selectedGuestRow.Cells["guest_id"].Value.ToString();

                        // Remove the row from the DataGridView
                        reservationDataGridView.Rows.Remove(selectedReservationRow);
                        //guestDataGridView.Rows.Remove(selectedGuestRow);

                        // Delete the corresponding record from the database
                        DbReservation.DeleteClient(reservationId);
                        DbGuest.DeleteClient(reservationId);
                    }
                    UpdateEarnings(TotalCost);

                    // Payment successful, show receipt
                    MessageBox.Show("Payment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Payment amount is insufficient.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid payment amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void UpdateEarnings(decimal amount)
        {
            string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string query = "UPDATE hotel_earning SET earning_total = earning_total + @amount WHERE earning_id = 1";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void lblChange_Click(object sender, EventArgs e)
        {

        }

        public FormBill()
        {
            InitializeComponent();
        }

        public string RoomNumber { get; internal set; }

        //public string Name { get; set; }
        //public string RoomType { get; set; }
        //public string RoomNumber { get; set; }
        //public string DateIn { get; set; }
        //public string DateOut { get; set; }
        //public FormBill(string name, string roomtype, string roomnumber, string datein, string dateout)
        //{
        //    Name = name;
        //    RoomType = roomtype;
        //    RoomNumber = roomnumber;
        //    DateIn = datein;
        //    DateOut = dateout;
        //}

        private void FormBill_Load(object sender, EventArgs e)
        {
            lblName.Text = clientname;
            lblRoomType.Text = roomtype;
            lblDateIn.Text = datein;
            lblDateOut.Text = dateout;
            lblTotal.Text = TotalCost.ToString();

            txtPaymentAmount.TextChanged += txtPaymentAmount_TextChanged;
        }
    }
}

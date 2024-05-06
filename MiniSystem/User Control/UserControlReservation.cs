using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniSystem.User_Control
{
    public partial class UserControlReservation : UserControl
    {
        private List<string> availableRooms = new List<string> { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110"};
        public UserControlReservation()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            roomNumberTXT.DataSource = availableRooms;
        }
        public void Clear()
        {
            reservIdTXT.Clear();
            clientTXT.Clear();
            //tabControlReservation.SelectedTab = tabPageAddReservation;
        }
        public void Clear1()
        {
            reservIdTXT.Clear();
            clientTXT.Clear();
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            listViewReservation.Columns.Add("ReservationID", 120);
            listViewReservation.Columns.Add("ClientName", 130);
            listViewReservation.Columns.Add("RoomType", 110);
            listViewReservation.Columns.Add("RoomNumber", 100);
            listViewReservation.Columns.Add("DateIn", 100);
            listViewReservation.Columns.Add("DateoOut", 130);
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
            if (listViewReservation.SelectedItems.Count > 0)
            {
                listViewReservation.Items.Remove(listViewReservation.SelectedItems[0]);

                MessageBox.Show("Successfully Deleted!!!", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                MessageBox.Show("Error!!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (listViewReservation.SelectedItems.Count > 0)
            {
                listViewReservation.SelectedItems[0].SubItems[0].Text = reservIdTXT.Text;
                listViewReservation.SelectedItems[0].SubItems[1].Text = clientTXT.Text;
                listViewReservation.SelectedItems[0].SubItems[2].Text = roomTypeTXT.Text;
                listViewReservation.SelectedItems[0].SubItems[3].Text = roomNumberTXT.Text;
                listViewReservation.SelectedItems[0].SubItems[4].Text = dateInTXT.Text;
                listViewReservation.SelectedItems[0].SubItems[5].Text = dateOutTXT.Text;
                Clear();
                MessageBox.Show("Data Successfully Updated!!!", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAddReserve_Click_1(object sender, EventArgs e)
        {
            if (reservIdTXT.Text == "")
            {
                MessageBox.Show("Reservation ID's are Required!!!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ListViewItem newitem = new ListViewItem(reservIdTXT.Text);
                newitem.SubItems.Add(clientTXT.Text);
                newitem.SubItems.Add(roomTypeTXT.Text);
                newitem.SubItems.Add(roomNumberTXT.Text);
                newitem.SubItems.Add(dateInTXT.Text);
                newitem.SubItems.Add(dateOutTXT.Text);
                string selectedRoom = roomNumberTXT.SelectedItem as string;
                if (selectedRoom != null)
                {
                    availableRooms.Remove(selectedRoom);
                    roomNumberTXT.DataSource = null;
                    roomNumberTXT.DataSource = availableRooms;
                }
                Clear();
                listViewReservation.Items.Add(newitem);
                MessageBox.Show("Successfully Save", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
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
            if (listViewReservation.SelectedItems.Count > 0)
            {
                reservIdTXT.Text = listViewReservation.SelectedItems[0].SubItems[0].Text;
                clientTXT.Text = listViewReservation.SelectedItems[0].SubItems[1].Text;
                roomTypeTXT.Text = listViewReservation.SelectedItems[0].SubItems[2].Text;
                roomNumberTXT.Text = listViewReservation.SelectedItems[0].SubItems[3].Text;
                dateInTXT.Text = listViewReservation.SelectedItems[0].SubItems[4].Text;
                dateOutTXT.Text = listViewReservation.SelectedItems[0].SubItems[5].Text;
            }
            else
            {
                MessageBox.Show("Hakdog");
            }
        }
    }
}

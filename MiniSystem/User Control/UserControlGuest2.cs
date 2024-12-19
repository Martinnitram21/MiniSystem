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
    public partial class UserControlGuest2 : UserControl
    {
        public UserControlGuest2()
        {
            InitializeComponent();
        }
        internal string id, name, phoneno, email, address;
        public void Clear()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }
        public void Display()
        {
            DbGuest.DisplayAndSearch("Select guest_id, guest_lastname, guest_firstname, guest_phoneno, guest_email, guest_address FROM hotel_guest", dataGridView1);
        }
        public static void RefreshData(DataGridView dgv)
        {
            string query = "SELECT * FROM hotel_guest";
            DbReservation.DisplayAndSearch(query, dgv);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void UserControlGuest2_Load(object sender, EventArgs e)
        {
            //listViewGuest.Columns.Add("GuestID", 100);
            //listViewGuest.Columns.Add("LastName", 100);
            //listViewGuest.Columns.Add("FirstName", 150);
            //listViewGuest.Columns.Add("Phone#", 145);
            //listViewGuest.Columns.Add("Address", 145);
            Display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            //if (listViewGuest.SelectedItems.Count > 0)
            //{
            //    listViewGuest.SelectedItems[0].SubItems[0].Text = guestIDTXT.Text;
            //    listViewGuest.SelectedItems[0].SubItems[1].Text = lastNameTXT.Text;
            //    listViewGuest.SelectedItems[0].SubItems[2].Text = firstNameTXT.Text;
            //    listViewGuest.SelectedItems[0].SubItems[3].Text = phoneNoTXT.Text;
            //    listViewGuest.SelectedItems[0].SubItems[4].Text = addressTXT.Text;
            //    Clear();
            //    MessageBox.Show("Data Successfully Updated!!!", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.SelectedRows[0].Cells["guest_id"].Value.ToString();
                Client clt = new Client(txtLastName.Text.Trim(), txtFirstName.Text.Trim(),
                                        txtPhoneNo.Text.Trim(), txtEmail.Text.Trim(),
                                        txtAddress.Text.Trim());
                DbGuest.UpdateClient(clt, id);
                Clear();
                MessageBox.Show("Guest Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            //if (guestIDTXT.Text == "")
            //{
            //    MessageBox.Show("Guest ID's are Required!!!");
            //}
            //else
            //{
            //    ListViewItem newitem = new ListViewItem(guestIDTXT.Text);
            //    newitem.SubItems.Add(lastNameTXT.Text);
            //    newitem.SubItems.Add(firstNameTXT.Text);
            //    newitem.SubItems.Add(phoneNoTXT.Text);
            //    newitem.SubItems.Add(addressTXT.Text);
            //    Clear();
            //    listViewGuest.Items.Add(newitem);
            //    MessageBox.Show("Successfully Save", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string searchQuery = "SELECT guest_id, guest_lastname, guest_firstname, guest_phoneno, guest_email, guest_address FROM hotel_guest WHERE guest_lastname LIKE '%" + txtSearch.Text + "%'";
            //DbGuest.DisplayAndSearch(searchQuery, dataGridView1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            string query = "SELECT guest_id, guest_lastname, guest_firstname, guest_phoneno, guest_email, guest_address FROM hotel_guest";
            DbGuest.DisplayAndSearch(query, dataGridView1, searchTerm);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtLastName.Text = row.Cells["guest_lastname"].Value.ToString();
                txtFirstName.Text = row.Cells["guest_firstname"].Value.ToString();
                txtPhoneNo.Text = row.Cells["guest_phoneno"].Value.ToString();
                txtEmail.Text = row.Cells["guest_email"].Value.ToString();
                txtAddress.Text = row.Cells["guest_address"].Value.ToString();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.SelectedRows[0].Cells["guest_id"].Value.ToString();
                DbGuest.DeleteClient(id);
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (listViewGuest.SelectedItems.Count > 0)
            //{
            //    listViewGuest.Items.Remove(listViewGuest.SelectedItems[0]);

            //    MessageBox.Show("Successfully Deleted!!!", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);

            //}
            //else
            //{
            //    MessageBox.Show("Error!!!");
            //}
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //    {
            //        dataGridView1.Rows.Remove(row);
            //    }
            //    MessageBox.Show("Successfully Deleted!!!", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);

            //}
            //else
            //{
            //    MessageBox.Show("Error!!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void listViewGuest_MouseClick(object sender, MouseEventArgs e)
        {
            //if (listViewGuest.SelectedItems.Count > 0)
            //{
            //    //guestIDTXT.Text = listViewGuest.SelectedItems[0].SubItems[0].Text;
            //    lastNameTXT.Text = listViewGuest.SelectedItems[0].SubItems[1].Text;
            //    firstNameTXT.Text = listViewGuest.SelectedItems[0].SubItems[2].Text;
            //    phoneNoTXT.Text = listViewGuest.SelectedItems[0].SubItems[3].Text;
            //    addressTXT.Text = listViewGuest.SelectedItems[0].SubItems[4].Text;
            //}
            //else
            //{
            //    MessageBox.Show("Hakdog");
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_2(object sender, EventArgs e)
        {
            if (txtLastName.Text != "" || txtPhoneNo.Text != "" || txtEmail.Text != "" || txtAddress.Text != "" || txtFirstName.Text != "")
            {
                Client clt = new Client(txtLastName.Text.Trim(), txtFirstName.Text.Trim(),
                                        txtPhoneNo.Text.Trim(), txtEmail.Text.Trim(),
                                        txtAddress.Text.Trim());
                DbGuest.AddClient(clt);
                MessageBox.Show("Guest Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

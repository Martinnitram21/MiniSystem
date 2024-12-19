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

namespace MiniSystem
{
    public partial class FormReservation : Form
    {
        public FormReservation()
        {
            InitializeComponent();
        }
        private void FormReservation_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("reservId", 100);
            listView1.Columns.Add("clientId", 100);
            listView1.Columns.Add("roomNumber", 150);
            listView1.Columns.Add("DateIn", 145);
            listView1.Columns.Add("DateOut", 145);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reservIdTXT.Text == "")
            {
                MessageBox.Show("Reservation ID's are Required!!!");
            }
            else
            {
                ListViewItem newitem = new ListViewItem(reservIdTXT.Text);
                newitem.SubItems.Add(clientTXT.Text);
                newitem.SubItems.Add(roomTypeTXT.Text);
                newitem.SubItems.Add(roomNumberTXT.Text);
                newitem.SubItems.Add(dateInTXT.Text);
                newitem.SubItems.Add(dateOutTXT.Text);

                listView1.Items.Add(newitem);
                MessageBox.Show("Successfully Save");
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reservIdTXT.Text = "";
            clientTXT.Text = "";
            roomTypeTXT.Text = "";
            roomNumberTXT.Text = "";
            dateInTXT.Text = "";
            dateOutTXT.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = reservIdTXT.Text;
                listView1.SelectedItems[0].SubItems[1].Text = clientTXT.Text;
                listView1.SelectedItems[0].SubItems[2].Text = roomTypeTXT.Text;
                listView1.SelectedItems[0].SubItems[3].Text = roomNumberTXT.Text;
                listView1.SelectedItems[0].SubItems[4].Text = dateInTXT.Text;
                listView1.SelectedItems[0].SubItems[5].Text = dateOutTXT.Text;
                MessageBox.Show("Data Successfully Updated!!!");
            } 
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

                MessageBox.Show("Successfully Deleted!!!");

            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                reservIdTXT.Text = listView1.SelectedItems[0].SubItems[0].Text;
                clientTXT.Text = listView1.SelectedItems[0].SubItems[1].Text;
                roomTypeTXT.Text = listView1.SelectedItems[0].SubItems[2].Text;
                roomNumberTXT.Text = listView1.SelectedItems[0].SubItems[3].Text;
                dateInTXT.Text = listView1.SelectedItems[0].SubItems[4].Text;
                dateOutTXT.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
            else
            {
                MessageBox.Show("Hakdog");
            }
        }
    }
}

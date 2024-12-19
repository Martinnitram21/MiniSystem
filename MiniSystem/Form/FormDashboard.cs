using MiniSystem.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiniSystem
{
    public partial class FormDashboard : Form
    {
        UserControlDashBoard UserControlDashBoard = new UserControlDashBoard();
        UserControlComingSoon userControlComingSoon = new UserControlComingSoon();
        UserControlGuest2 userControlGuest = new UserControlGuest2();
        UserControlReservation userControlReservation = new UserControlReservation();
        UserControlRoom userControlRoom = new UserControlRoom();
        //UserControlGuest userControlGuest11 = new UserControlGuest();
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        public void Display()
        {
            //DbReservation.DisplayAndSearch("Select reservation_id, client_name, room_type, room_number, date_in, date_out From hotel_reservation", dataGridView1);
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin fl = new FormLogin();
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                fl.ShowDialog();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
            userControlDashBoard1.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlGuest21.Hide();
            userControlReservation1.Hide();
            userControlRoom1.Hide();
            userControlCheckOut1.Hide();
            userControlDashBoard1.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonGuest);
            userControlReservation1.Hide();
            userControlComingSoon1.Hide();
            userControlDashBoard1.Hide();
            userControlRoom1.Hide();
            userControlCheckOut1.Hide();
            userControlGuest21.Clear();
            userControlGuest21.Show();
            //userControlGuest11.Clear1();
            //userControlGuest11.Show();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            userControlGuest21.Hide();
            userControlReservation1.Hide();
            userControlDashBoard1.Hide();
            userControlComingSoon1.Hide();
            userControlCheckOut1.Hide();
            userControlRoom1.Show();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlGuest21.Hide();
            userControlComingSoon1.Hide();
            userControlDashBoard1.Hide();
            userControlRoom1.Hide();
            userControlCheckOut1.Hide();
            userControlReservation1.Clear();
            userControlReservation1.Show();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSetting);
            userControlGuest21.Hide();
            userControlReservation1.Hide();
            userControlDashBoard1.Hide();
            userControlRoom1.Hide();
            userControlCheckOut1.Hide();
            userControlComingSoon1.Show();
        }

        private void userControlGuest1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlReservation1_Load(object sender, EventArgs e)
        {

        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void userControlRoom1_Load(object sender, EventArgs e)
        {

        }

        private void checkOutBTN_Click(object sender, EventArgs e)
        {
            MovePanel(checkOutBTN);
            userControlGuest21.Hide();
            userControlComingSoon1.Hide();
            userControlDashBoard1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            //Display();
            userControlCheckOut1.Show();
        }
    }
}

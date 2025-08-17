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
        //readonly UserControlDashBoard UserControlDashBoard = new UserControlDashBoard();
        //readonly UserControlComingSoon userControlComingSoon = new UserControlComingSoon();
        //readonly UserControlGuest2 userControlGuest = new UserControlGuest2();
        //readonly UserControlReservation userControlReservation = new UserControlReservation();
        //readonly UserControlRoom userControlRoom = new UserControlRoom();
        //UserControlGuest userControlGuest11 = new UserControlGuest();
        readonly UserControlDashBoard ucDash = new UserControlDashBoard();
        readonly UserControlComingSoon ucComingSoon = new UserControlComingSoon();
        readonly UserControlGuest2 ucGuest = new UserControlGuest2();
        readonly UserControlReservation ucReservation = new UserControlReservation();
        readonly UserControlRoom ucRoom = new UserControlRoom();
        readonly UserControlCheckOut ucCheck = new UserControlCheckOut();

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
                //this.Hide();
                // This will forcibly kill the current process:
                System.Environment.Exit(0);
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
            panel6.Controls.Add(ucDash);
            ucDash.Dock = DockStyle.Fill;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            panel6.Controls.Clear();
            panel6.Controls.Add(ucDash);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonGuest);
            panel6.Controls.Clear();
            panel6.Controls.Add(ucGuest);
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            panel6.Controls.Clear();
            panel6.Controls.Add(ucRoom);
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            panel6.Controls.Clear();
            panel6.Controls.Add(ucReservation);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSetting);
            panel6.Controls.Clear();
            panel6.Controls.Add(ucComingSoon);
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
            panel6.Controls.Clear();
            panel6.Controls.Add(ucCheck);
        }
    }
}

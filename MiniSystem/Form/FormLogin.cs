using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MiniSystem.Class1;

namespace MiniSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
        }
        UserManager userpass = new UserManager();
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //old login
            
            if (userpass.validate(userTXT.Text, passTXT.Text))
            {
                FormDashboard fd = new FormDashboard();
                MessageBox.Show("Log-In Succesfully", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);
                fd.Username = userTXT.Text; 
                this.Hide();
                fd.Show();      
            }
            else
            {
                userTXT.Text = "";
                passTXT.Text = "";
                MessageBox.Show("Incorrect User or Password", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //string connString = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem;port=3306";
            //using (MySqlConnection con = new MySqlConnection(connString))
            //{
            //    try
            //    {


            //        string username = userTXT.Text.Trim().ToString();
            //        string password = passTXT.Text.Trim().ToString();

            //        if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            //        {
            //            MessageBox.Show("Username and Password are Required");
            //            return;
            //        }
            //        else
            //        {
            //            con.Open();
            //            string query = "SELECT COUNT(*) FROM hotel_login WHERE hotel_user = @username AND hotel_pass = @password";
            //            using (MySqlCommand cmd = new MySqlCommand(query, con))
            //            {
            //                cmd.Parameters.AddWithValue("@username", username);
            //                cmd.Parameters.AddWithValue("@password", password);

            //                int count = Convert.ToInt32(cmd.ExecuteScalar());

            //                if (count > 0)
            //                {
            //                    MessageBox.Show("Log-In Succesfully", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);
            //                    FormDashboard fd = new FormDashboard();
            //                    fd.Username = username;
            //                    fd.Show();
            //                    this.Hide();
            //                }
            //                con.Open();
            //                MySqlCommand cmd = new MySqlCommand("Select COUNT(*) from hotel_login", con);
            //                MySqlDataReader reader = cmd.ExecuteReader();
            //                while (reader.Read())
            //                {
            //                    if (username.Equals(reader.GetString("hotel_user")) &&
            //                   password.Equals(reader.GetString("hotel_pass")))
            //                    {
            //                        MessageBox.Show("Success alright!");
            //                        FormDashboard fd = new FormDashboard();
            //                        fd.Username = username;
            //                        fd.Show();
            //                        this.Hide();
            //                        return;
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Username or Password are Incorrect!");
            //                    }
            //                }
            //            }
            //            con.Close();
            //        }
            //    catch (MySqlException ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message);
            //    }
            //}
        }
        private void linkLabelNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignup signup = new FormSignup();
            signup.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            passTXT.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            passTXT.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void passwordTXT_TextChanged(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}

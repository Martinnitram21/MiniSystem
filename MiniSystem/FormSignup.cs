using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static MiniSystem.Class1;

namespace MiniSystem
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }
        //UserManager userManager = new UserManager();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpBTN_Click(object sender, EventArgs e)
        {   
            //old sign-up
            /*
            String user = userTXT.Text;
            String pass = passTXT.Text;
            if (userTXT.Text != "" && passTXT.Text != "" || passTXT.Text != "" && passTXT.Text != "")
            {
                if (passTXT.Text == rePassTXT.Text)
                {
                    userManager.addAccount(user, pass);
                    MessageBox.Show("Sign-up Successfully", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Re-Enter Password", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fields Required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
             try
            {
                string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=minisystem";
                string sql = "INSERT INTO login_table (login_user,login_pass) VALUES('" + userTXT.Text + " ' , '" + passTXT.Text + "')";
                MySqlConnection con = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader;

                con.ConnectionString = connstring;

                String username = userTXT.Text;
                String password = passTXT.Text;

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password are Required");
                }
                else
                {
                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("Sign-up Complete");
                        con.Close();
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
             }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            passTXT.UseSystemPasswordChar = false;
            rePassTXT.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            passTXT.UseSystemPasswordChar = true;
            rePassTXT.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void userTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=minisystem";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from login_table";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Connected!");
                    MessageBox.Show("Name " + reader["login_user"] + " Pass: " + reader["login_pass"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

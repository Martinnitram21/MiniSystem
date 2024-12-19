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

namespace MiniSystem.User_Control
{
    public partial class UserControlComingSoon : UserControl
    {

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=martinjericho22@2002;database=hotelsystem";
                string sql = "INSERT INTO hotel_login (hotel_user, hotel_pass) VALUES('" + txtUser.Text + " ' , '" + txtPass.Text + "')";
                MySqlConnection con = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader;

                con.ConnectionString = connstring;

                String username = txtUser.Text.Trim().ToString();
                String password = txtPass.Text.Trim().ToString();

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password are Required");
                }
                else
                {
                    if (txtPass.Text == txtRePass.Text)
                        try
                        {
                            con.Open();
                            reader = cmd.ExecuteReader();
                            MessageBox.Show("Sign-up Successfully", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.None);
                            con.Close();
                            Display();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    else
                    {
                        MessageBox.Show("Re-Enter Password", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public UserControlComingSoon()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DbUser.DisplayAndSearch("SELECT hotel_id, hotel_user, hotel_pass FROM hotel_login", dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["hotel_id"].Value.ToString();
                DbUser.DeleteClient(id);
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Select a record to delete");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (txtPass.Text == txtRePass.Text)
                {
                    string id = dataGridView1.SelectedRows[0].Cells["hotel_id"].Value.ToString();
                    User user = new User(txtUser.Text.Trim(), txtPass.Text.Trim());
                    DbUser.UpdateClient(user, id);
                    MessageBox.Show("Guest Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                }
                else
                {
                    MessageBox.Show("Re-Enter Password", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Hotel Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserControlComingSoon_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtPass.Text = "";
        }
    }
}

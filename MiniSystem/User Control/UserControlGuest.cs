﻿using System;
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
    public partial class UserControlGuest : UserControl
    {
        public UserControlGuest()
        {
            InitializeComponent();
        }
        public void Clear() 
        {
            guestIDTXT.Clear();
            lastNameTXT.Clear();
            firstNameTXT.Clear();
            phoneNoTXT.Clear();
            addressTXT.Clear();
            tabControlGuest.SelectedTab = tabPageAddGuest;
        }
        public void Clear1() 
        {
            guestIDTXT1.Clear();
            lastNameTXT1.Clear();
            firstNameTXT1.Clear();
            phoneNoTXT1.Clear();
            addressTXT1.Clear();
        }
        private void UserControlSetting_Load(object sender, EventArgs e)
        {
            listViewGuest.Columns.Add("GuestID", 100);
            listViewGuest.Columns.Add("LastName", 100);
            listViewGuest.Columns.Add("FirstName", 150);
            listViewGuest.Columns.Add("Phone#", 145);
            listViewGuest.Columns.Add("Address", 145);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (guestIDTXT.Text == "")
            {
                MessageBox.Show("Reservation ID's are Required!!!");
            }
            else
            {
                ListViewItem newitem = new ListViewItem(guestIDTXT.Text);
                newitem.SubItems.Add(lastNameTXT.Text);
                newitem.SubItems.Add(firstNameTXT.Text);
                newitem.SubItems.Add(phoneNoTXT.Text);
                newitem.SubItems.Add(addressTXT.Text);
                Clear();
                listViewGuest.Items.Add(newitem);
                MessageBox.Show("Successfully Save");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                listViewGuest.SelectedItems[0].SubItems[0].Text = guestIDTXT.Text;
                listViewGuest.SelectedItems[0].SubItems[1].Text = lastNameTXT.Text;
                listViewGuest.SelectedItems[0].SubItems[2].Text = firstNameTXT.Text;
                listViewGuest.SelectedItems[0].SubItems[3].Text = phoneNoTXT.Text;
                listViewGuest.SelectedItems[0].SubItems[4].Text = addressTXT.Text;
                Clear();
                MessageBox.Show("Data Successfully Updated!!!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                listViewGuest.Items.Remove(listViewGuest.SelectedItems[0]);

                MessageBox.Show("Successfully Deleted!!!");

            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void listViewGuest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewGuest_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewGuest.SelectedItems.Count > 0)
            {
                guestIDTXT.Text = listViewGuest.SelectedItems[0].SubItems[0].Text;
                lastNameTXT.Text = listViewGuest.SelectedItems[0].SubItems[1].Text;
                firstNameTXT.Text = listViewGuest.SelectedItems[0].SubItems[2].Text;
                phoneNoTXT.Text = listViewGuest.SelectedItems[0].SubItems[3].Text;
                addressTXT.Text = listViewGuest.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                MessageBox.Show("Hakdog");
            }
        }

        private void tabControlGuest_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageUpdateDeleteGuest_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageAddGuest_Click(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateDeleteGuest_Click(object sender, EventArgs e)
        {

        }
    }
}
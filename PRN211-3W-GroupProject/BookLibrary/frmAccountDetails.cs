using BookLibrary_Repository.Models;
using BookLibrary_Repository.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class frmAccountDetails : Form
    {
        public TblUser tblUser { get; set; }
        IUserRepository userRepository = new UserTable();

        public frmAccountDetails(TblUser user)
        {
            InitializeComponent();
            this.tblUser = user;
            LoadUser();
            txtUsername.Enabled = true;
            btnAccSave.Text = "Save";
            btnAccSave.Click += btnUpdate_Click;
        }

        private bool MessageBoxQuestion(string content)
        {
            DialogResult result = MessageBox.Show(content, Text + " - Notification", MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            return result == DialogResult.OK;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0 || txtFirstName.Text.Length == 0 ||
                txtPassword.Text.Length == 0 || txtLastName.Text.Length == 0 || txtPhone.Text.Length == 0)
            {
                MessageBox.Show("Invalid Input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool OK = MessageBoxQuestion("Do you want to update the user?");
            if (OK)
            {
                // Update the properties of tblUser with the textbox values
                tblUser.Username = txtUsername.Text; 
                tblUser.FirstName = txtFirstName.Text; 
                tblUser.Password = txtPassword.Text;
                tblUser.FirstName = txtFirstName.Text;
                tblUser.LastName = txtLastName.Text;
                tblUser.Password = txtPassword.Text;
                tblUser.Phone = txtPhone.Text;

                // Assuming the userRepository has an UpdateUser method
                userRepository.UpdateUser(tblUser);

                MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void LoadUser()
        {
            txtUsername.Text = tblUser.Username;
            txtPassword.Text = tblUser.Password;
            txtFirstName.Text = tblUser.FirstName;
            txtLastName.Text = tblUser.LastName;
            txtPhone.Text = tblUser.Phone;

            // Set Date of Birth value if it's available
            dtDoB.Value = tblUser.DoB ?? DateTime.Today;
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccSave_Click(object sender, EventArgs e)
        {
            
            // Assuming you want to save changes here
            // Update the detached entity with the new values

            tblUser.Username = txtUsername.Text;
            tblUser.Password = txtPassword.Text;
            tblUser.FirstName = txtFirstName.Text;
            tblUser.LastName = txtLastName.Text;
            tblUser.Phone = txtPhone.Text;

            // Update the entity in the database
            userRepository.UpdateUser(tblUser);

            MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); ;
        }
    }
}
   
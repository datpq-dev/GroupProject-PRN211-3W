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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string firstname = txtFirstName.Text;
                string lastname = txtLastName.Text;
                string phone = txtPhone.Text;
                DateTime dbDoB = dtDoB.Value;
                string gender = cboGender.SelectedItem?.ToString();

                // Validation
                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new ArgumentException("Username is required.");
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("Password is required.");
                }

                if (string.IsNullOrWhiteSpace(firstname))
                {
                    throw new ArgumentException("Firstname is required.");
                }

                if (string.IsNullOrWhiteSpace(lastname))
                {
                    throw new ArgumentException("Lastname is required.");
                }

                if (string.IsNullOrWhiteSpace(phone))
                {
                    throw new ArgumentException("Phone number is required.");
                }

                if (dbDoB > DateTime.Now)
                {
                    throw new ArgumentException("Invalid date of birth.");
                }

                if (string.IsNullOrWhiteSpace(gender))
                {
                    throw new ArgumentException("Gender is required.");
                }

                // Create UserAccount instance
                TblUser newAccount = new TblUser()
                {
                    Username = username,
                    Password = password,
                    FirstName = firstname,
                    LastName = lastname,
                    Phone = phone,
                    DoB = dbDoB,
                    Gender = gender
                };

                // Perform any necessary actions with the new account
                // For example, you can save it to a database or display a success message
                MessageBox.Show("Account created successfully!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

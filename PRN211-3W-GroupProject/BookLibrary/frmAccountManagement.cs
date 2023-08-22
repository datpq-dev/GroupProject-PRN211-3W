using BookLibrary_Repository.Models;
using BookLibrary_Repository.Repository;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmAccountManagement : Form
    {
        IUserRepository userRepository = new UserTable();

        public frmAccountManagement()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = userRepository.GetUsers();
            dataGridView1.DataSource = users.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAccountDetails accountDetailsForm = new frmAccountDetails(new TblUser());
            accountDetailsForm.ShowDialog();
            LoadUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedUsername = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                TblUser user = userRepository.GetUser(selectedUsername);

                if (user != null)
                {
                    frmAccountDetails accountDetailsForm = new frmAccountDetails(user);
                    accountDetailsForm.ShowDialog();
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Selected user not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedUsername = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();

                DialogResult result = MessageBox.Show($"Do you want to delete the user with username: {selectedUsername}?",
                                                      "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    userRepository.DeleteUser(selectedUsername);
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

/*IUserRepository userRepository;
public frmAccountManagement()
{
    InitializeComponent();
    Load();

}
private bool MessageBoxQuestion(string content)
{
    bool OK = false;
    DialogResult d = MessageBox.Show(content, Text + " - Notification", MessageBoxButtons.OKCancel,
                                     MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
    if (d == DialogResult.OK)
    {
        OK = true;
    }
    return OK;
}
private void Load()
{
    var members = userRepository.GetUsers();
    BindingSource bindingSource = new BindingSource();
    bindingSource.DataSource = members;


    txtAUsername.DataBindings.Clear();
    txtAPassword.DataBindings.Clear();
    txtAPhone.DataBindings.Clear();
    txtAFirstName.DataBindings.Clear();
    txtALastName.DataBindings.Clear();
    dateTimePicker1.DataBindings.Clear();

    txtAUsername.DataBindings.Add("Text", bindingSource, "Username");
    txtAPassword.DataBindings.Add("Text", bindingSource, "Password");
    txtAFirstName.DataBindings.Add("Text", bindingSource, "FirstName");
    txtALastName.DataBindings.Add("Text", bindingSource, "LastName");
    txtAPhone.DataBindings.Add("Text", bindingSource, "Phone");



    dataGridView1.DataSource = bindingSource;


}

private void btnAdd_Click(object sender, EventArgs e)
{
    frmAccountDetails frmAccountDetails = new frmAccountDetails(user);
    frmAccountDetails.Text = "Update User";
    frmAccountDetails.ShowDialog();
    Load();


}

private void btnUpdate_Click(object sender, EventArgs e)
{
    string selectedUsername = dataGridView1.CurrentRow.Cells["Username"].Value.ToString();

    // Retrieve the corresponding user from the repository
    TblUser user = userRepositorygicGetUserByUserName(selectedUsername);

    if (user != null) // Ensure the user exists
    {
        frmAccountDetails frmAccountDetails = new frmAccountDetails(user);
        frmAccountDetails.Text = "Update User";
        frmAccountDetails.ShowDialog();
        Load();
    }
    else
    {
        MessageBox.Show("Selected user not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

    private void btnDelete_Click(object sender, EventArgs e)
{

}

private void btnExit_Click(object sender, EventArgs e)
{
    bool OK = MessageBoxQuestion("Do you want to exit?");
    if (OK == true)
    {
        this.Close();
    }
}
}
}*/

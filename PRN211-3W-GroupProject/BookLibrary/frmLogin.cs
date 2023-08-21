using BookLibrary_Repository.Repository;
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
    public partial class frmLogin : Form
    {
        private UserTable _userTable;
        public frmLogin()
        {
            InitializeComponent();
            _userTable = new UserTable();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //check xem null
            if (txtUsername.Text == "")
            {
                MessageBox.Show("You Must Input Username");
                txtUsername.Focus();
                return;
            }


            if (txtPassword.Text == "")
            {
                MessageBox.Show("You Must Input Password");
                txtPassword.Focus();
                return;
            }

            //check mat khau va user 1
            var member = _userTable.GetUsers()
                .FirstOrDefault(m => m.Username == txtUsername.Text && m.Password == txtPassword.Text);
            // Kiểm tra theo RoleId sử dụng switch case
            switch (member.RoleId)
            {
                case 1: // Admin
                    frmAccountManagement frmAccountManagement = new();
                    this.Hide();
                    frmAccountManagement.Show();
                    // Thực hiện các hành động cho Admin
                    break;
                case 2: // Librarian
                    frmBookManagement frmBookManagement = new();
                    this.Hide();
                    frmBookManagement.Show();
                    // Thực hiện các hành động cho Librarian
                    break;
                case 3: // Member
                    frmCategory frmCategory = new();
                    this.Hide();
                    frmCategory.Show();
                    
                    // Thực hiện các hành động cho Member
                    break;
                default:
                    MessageBox.Show("Unknown Role");
                    break;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

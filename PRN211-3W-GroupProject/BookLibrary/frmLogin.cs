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
        private UserRepository _userRepository;
        public frmLogin()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
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
            var member = _userRepository.GetAll()
                .FirstOrDefault(m => m.Username == txtUsername.Text && m.Password == txtPassword.Text);
            // Kiểm tra theo RoleId sử dụng switch case
            switch (member.RoleId)
            {
                case 1: // Admin
                    frmAccountManagement frmAccountManagement = new();
                    frmAccountManagement.ShowDialog();
                    frmAccountManagement.Hide();
                    // Thực hiện các hành động cho Admin
                    break;
                case 2: // Librarian
                    frmBookManagement frmBookManagement = new();
                    frmBookManagement.ShowDialog();
                    frmBookManagement.Hide();
                    // Thực hiện các hành động cho Librarian
                    break;
                case 3: // Member
                    
                    // Thực hiện các hành động cho Member
                    break;
                default:
                    MessageBox.Show("Unknown Role");
                    break;
            }
            /*if (member == null)
            {
                MessageBox.Show("Username or Pass invalid...");
            }
            else
            {
                if (member.RoleId == 2)
                {
                    frmBookManagement frmBookManagement = new();
                    frmBookManagement.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You are not allow to login");
                }

            }*/
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

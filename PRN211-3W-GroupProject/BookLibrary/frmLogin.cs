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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            frmBookManagement frmBookManagement = new();
            frmBookManagement.ShowDialog();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            frmBookList frmBookList = new();
            frmBookList.ShowDialog();
            this.Hide();
        }
    }
}

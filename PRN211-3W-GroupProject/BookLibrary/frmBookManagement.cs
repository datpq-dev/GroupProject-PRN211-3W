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
    public partial class frmBookManagement : Form
    {
        public frmBookManagement()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmBookDetails frm = new frmBookDetails();
            frm.ShowDialog();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            frmBookDetails frmBookDetails = new();
            frmBookDetails.ShowDialog();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void btnExitBook_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        private void btnBookingList_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {

        }
    }
}

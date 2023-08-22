using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

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

        private void btnBookingList_Click(object sender, EventArgs e)
        {
            frmBookingList frmBookingList = new();
            this.Close();
            frmBookingList.ShowDialog();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmBookingList : Form
    {
        public frmBookingList()
        {
            InitializeComponent();
        }

        private void btnBookingSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBookManagement frmBookManagement = new();
            frmBookManagement.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmBookingHistory frmBookingHistory = new();
            frmBookingHistory.Show();
            this.Hide();
        }
    }
}

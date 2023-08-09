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
    public partial class frmBookingHistory : Form
    {
        public frmBookingHistory()
        {
            InitializeComponent();
        }

        private void btnBLBack_Click(object sender, EventArgs e)
        {
            frmBookingList frm = new();
            frm.ShowDialog();
            this.Hide();
        }
    }
}

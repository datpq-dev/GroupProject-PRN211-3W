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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            frmBookCart frmBookCart = new frmBookCart();
            frmBookCart.ShowDialog();
            this.Hide();
        }

        private void btnBookingList_Click(object sender, EventArgs e)
        {
            
        }
    }
}

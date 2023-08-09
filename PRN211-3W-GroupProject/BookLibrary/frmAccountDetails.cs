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
    public partial class frmAccountDetails : Form
    {
        public frmAccountDetails()
        {
            InitializeComponent();
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            frmAccountManagement frmAccountManagement = new();
            frmAccountManagement.ShowDialog();
            this.Hide();
        }

        private void btnAccSave_Click(object sender, EventArgs e)
        {

        }
    }
}

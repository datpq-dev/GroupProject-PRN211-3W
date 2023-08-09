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
    public partial class frmBookDetails : Form
    {
        public frmBookDetails()
        {
            InitializeComponent();
        }

        private void frmBookDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnBDCancel_Click(object sender, EventArgs e)
        {
            frmBookManagement frmBookManagement = new frmBookManagement();
            frmBookManagement.ShowDialog();
            this.Hide();
        }

        private void btnBDSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

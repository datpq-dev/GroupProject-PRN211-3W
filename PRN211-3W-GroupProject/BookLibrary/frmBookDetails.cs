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
    public partial class frmBookDetails : Form
    {
        private readonly IBookDetailRepository _repository;
        public frmBookDetails()
        {
            InitializeComponent();
            _repository = new BookDetailRepository();
        }

        private void btnBDCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBDSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCheck_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            if (isbn.Length == 0)
            {
                return;
            }

        }
    }
}

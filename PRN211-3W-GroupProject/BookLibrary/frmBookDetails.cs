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
            var categories = BookRepository.GetAllCategories();
            var items = categories.Select(c => c.CategoryName).ToArray();
            this.cboCategory.Items.Clear();
            this.cboCategory.Items.AddRange(items);
            if (this.cboCategory.Items.Count > 0)
            {
                this.cboCategory.SelectedIndex = 0;
        }

                txtISBN.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_validation())
            {
                MessageBox.Show("Invalid value...");
                txtISBN.Focus();
                return;
            }

            TblBook book = new TblBook()
            {
                Isbn = txtISBN.Text,
                Title = txtTitle.Text,
                Author = txtAuth.Text,
                BookingPeriod = int.Parse(txtBookingPeriod.Text),
                Price = double.Parse(txtPrice.Text),
                Description = txtDescriptions.Text,

                Categories = BookRepository.GetAllCategories()
                    .FirstOrDefault(c => c.CategoryName.Equals(cboCategory.Text))
                    .CategoryId,
            };
            if (UpdateOrInsert)
            {
                BookRepository.UpdateBook(book);
                MessageBox.Show("Update Ok !");
            }
            else
        {
            this.Close();
        }
    }
}

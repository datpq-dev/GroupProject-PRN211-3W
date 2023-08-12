namespace BookLibrary
{
    partial class frmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearchBook = new Button();
            txtSearch = new TextBox();
            dgvBookList = new DataGridView();
            btnAddBook = new Button();
            btnViewCart = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnBookingList = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(36, 30);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(72, 29);
            btnSearchBook.TabIndex = 24;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(114, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 27);
            txtSearch.TabIndex = 23;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(37, 85);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(865, 351);
            dgvBookList.TabIndex = 28;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(90, 458);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(105, 47);
            btnAddBook.TabIndex = 29;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(323, 458);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(105, 47);
            btnViewCart.TabIndex = 30;
            btnViewCart.Text = "ViewCart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // btnBookingList
            // 
            btnBookingList.Location = new Point(553, 458);
            btnBookingList.Name = "btnBookingList";
            btnBookingList.Size = new Size(105, 47);
            btnBookingList.TabIndex = 31;
            btnBookingList.Text = "BookingList";
            btnBookingList.UseVisualStyleBackColor = true;
            btnBookingList.Click += btnBookingList_Click;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 531);
            Controls.Add(btnBookingList);
            Controls.Add(btnViewCart);
            Controls.Add(btnAddBook);
            Controls.Add(dgvBookList);
            Controls.Add(btnSearchBook);
            Controls.Add(txtSearch);
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategory";
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearchBook;
        private TextBox txtSearch;
        private DataGridView dgvBookList;
        private Button btnAddBook;
        private Button btnViewCart;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnBookingList;
    }
}
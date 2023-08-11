namespace BookLibrary
{
    partial class frmBookManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtBookID = new TextBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtStatus = new TextBox();
            cboCategory = new ComboBox();
            dgvBookList = new DataGridView();
            btnAddBook = new Button();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnExitBook = new Button();
            txtSearch = new TextBox();
            btnBookingList = new Button();
            btnSearchBook = new Button();
            txtAuth = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 49);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "BookID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 121);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 190);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 49);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 121);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(435, 190);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(158, 42);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(243, 27);
            txtBookID.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(158, 114);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(243, 27);
            txtTitle.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(526, 42);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(243, 27);
            txtDescription.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(526, 183);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(243, 27);
            txtStatus.TabIndex = 12;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(526, 113);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(243, 28);
            cboCategory.TabIndex = 13;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(61, 251);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(969, 235);
            dgvBookList.TabIndex = 15;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(265, 500);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(119, 63);
            btnAddBook.TabIndex = 16;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(476, 500);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(119, 63);
            btnUpdateBook.TabIndex = 17;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(700, 500);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(119, 63);
            btnDeleteBook.TabIndex = 18;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnExitBook
            // 
            btnExitBook.Location = new Point(911, 500);
            btnExitBook.Name = "btnExitBook";
            btnExitBook.Size = new Size(119, 63);
            btnExitBook.TabIndex = 19;
            btnExitBook.Text = "Exit";
            btnExitBook.UseVisualStyleBackColor = true;
            btnExitBook.Click += btnExitBook_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(867, 183);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 27);
            txtSearch.TabIndex = 20;
            // 
            // btnBookingList
            // 
            btnBookingList.Location = new Point(61, 500);
            btnBookingList.Name = "btnBookingList";
            btnBookingList.Size = new Size(119, 63);
            btnBookingList.TabIndex = 21;
            btnBookingList.Text = "Booking List";
            btnBookingList.UseVisualStyleBackColor = true;
            btnBookingList.Click += btnBookingList_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(789, 181);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(72, 29);
            btnSearchBook.TabIndex = 22;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // txtAuth
            // 
            txtAuth.Location = new Point(158, 183);
            txtAuth.Name = "txtAuth";
            txtAuth.Size = new Size(243, 27);
            txtAuth.TabIndex = 8;
            // 
            // frmBookManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 587);
            Controls.Add(btnSearchBook);
            Controls.Add(btnBookingList);
            Controls.Add(txtSearch);
            Controls.Add(btnExitBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnAddBook);
            Controls.Add(dgvBookList);
            Controls.Add(cboCategory);
            Controls.Add(txtStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(txtAuth);
            Controls.Add(txtBookID);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBookManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookManagement";
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtBookID;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtStatus;
        private ComboBox cboCategory;
        private DataGridView dgvBookList;
        private Button btnAddBook;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private Button btnExitBook;
        private TextBox txtSearch;
        private Button btnBookingList;
        private Button btnSearchBook;
        private TextBox txtAuth;
    }
}
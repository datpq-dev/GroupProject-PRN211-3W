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
            cboTitle = new ComboBox();
            label5 = new Label();
            btnSearchBook = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            txtQuantity = new TextBox();
            dgvBookList = new DataGridView();
            btnBookList = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // cboTitle
            // 
            cboTitle.FormattingEnabled = true;
            cboTitle.Location = new Point(162, 90);
            cboTitle.Name = "cboTitle";
            cboTitle.Size = new Size(254, 28);
            cboTitle.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 98);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 15;
            label5.Text = "Category";
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(84, 30);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(72, 29);
            btnSearchBook.TabIndex = 24;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(162, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 27);
            txtSearch.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 38);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 26;
            label2.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(648, 31);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(254, 27);
            txtQuantity.TabIndex = 27;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(37, 158);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(865, 278);
            dgvBookList.TabIndex = 28;
            // 
            // btnBookList
            // 
            btnBookList.Location = new Point(427, 457);
            btnBookList.Name = "btnBookList";
            btnBookList.Size = new Size(105, 47);
            btnBookList.TabIndex = 29;
            btnBookList.Text = "Book List";
            btnBookList.UseVisualStyleBackColor = true;
            btnBookList.Click += btnBookList_Click;
            // 
            // frmBookShelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 531);
            Controls.Add(btnBookList);
            Controls.Add(dgvBookList);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(btnSearchBook);
            Controls.Add(txtSearch);
            Controls.Add(cboTitle);
            Controls.Add(label5);
            Name = "frmBookShelf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookShelf";
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboTitle;
        private Label label5;
        private Button btnSearchBook;
        private TextBox txtSearch;
        private Label label2;
        private TextBox txtQuantity;
        private DataGridView dgvBookList;
        private Button btnBookList;
    }
}
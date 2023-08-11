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
            btnBookList = new Button();
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
            // btnBookList
            // 
            btnBookList.Location = new Point(427, 457);
            btnBookList.Name = "btnBookList";
            btnBookList.Size = new Size(105, 47);
            btnBookList.TabIndex = 29;
            btnBookList.Text = "ViewDetails";
            btnBookList.UseVisualStyleBackColor = true;
            btnBookList.Click += btnViewDetails_Click;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 531);
            Controls.Add(btnBookList);
            Controls.Add(dgvBookList);
            Controls.Add(btnSearchBook);
            Controls.Add(txtSearch);
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookShelf";
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearchBook;
        private TextBox txtSearch;
        private DataGridView dgvBookList;
        private Button btnBookList;
    }
}
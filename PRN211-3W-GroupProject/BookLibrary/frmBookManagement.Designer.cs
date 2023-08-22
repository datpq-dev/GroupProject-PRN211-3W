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
            txtStatus = new TextBox();
            dgvBookList = new DataGridView();
            txtSearch = new TextBox();
            btnSearchBook = new Button();
            txtAuth = new TextBox();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            BookInformation = new GroupBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            grSearch = new GroupBox();
            grAction = new GroupBox();
            btnAddBook = new Button();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnExitBook = new Button();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            BookInformation.SuspendLayout();
            grSearch.SuspendLayout();
            grAction.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "BookID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 19);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 19);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(706, 19);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 50);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(437, 47);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(67, 16);
            txtBookID.Margin = new Padding(3, 2, 3, 2);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(107, 23);
            txtBookID.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(218, 16);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(213, 23);
            txtTitle.TabIndex = 9;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(487, 47);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(213, 23);
            txtStatus.TabIndex = 12;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Dock = DockStyle.Fill;
            dgvBookList.Location = new Point(0, 0);
            dgvBookList.Margin = new Padding(3, 2, 3, 2);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(1083, 410);
            dgvBookList.TabIndex = 15;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(3, 19);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(173, 23);
            txtSearch.TabIndex = 20;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Dock = DockStyle.Bottom;
            btnSearchBook.Location = new Point(3, 46);
            btnSearchBook.Margin = new Padding(3, 2, 3, 2);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(173, 42);
            btnSearchBook.TabIndex = 22;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // txtAuth
            // 
            txtAuth.Location = new Point(487, 16);
            txtAuth.Margin = new Padding(3, 2, 3, 2);
            txtAuth.Name = "txtAuth";
            txtAuth.Size = new Size(213, 23);
            txtAuth.TabIndex = 8;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvBookList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(1269, 410);
            splitContainer1.SplitterDistance = 1083;
            splitContainer1.TabIndex = 23;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label6);
            splitContainer2.Panel1.Controls.Add(BookInformation);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer1);
            splitContainer2.Size = new Size(1269, 579);
            splitContainer2.SplitterDistance = 165;
            splitContainer2.TabIndex = 24;
            // 
            // BookInformation
            // 
            BookInformation.Controls.Add(richTextBox1);
            BookInformation.Controls.Add(textBox1);
            BookInformation.Controls.Add(label1);
            BookInformation.Controls.Add(label4);
            BookInformation.Controls.Add(label2);
            BookInformation.Controls.Add(label3);
            BookInformation.Controls.Add(label7);
            BookInformation.Controls.Add(txtBookID);
            BookInformation.Controls.Add(label5);
            BookInformation.Controls.Add(txtStatus);
            BookInformation.Controls.Add(txtTitle);
            BookInformation.Controls.Add(txtAuth);
            BookInformation.Dock = DockStyle.Bottom;
            BookInformation.Location = new Point(0, 79);
            BookInformation.Name = "BookInformation";
            BookInformation.Size = new Size(1269, 86);
            BookInformation.TabIndex = 23;
            BookInformation.TabStop = false;
            BookInformation.Text = "Book Information";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 23);
            textBox1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(779, 16);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(328, 54);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(txtSearch);
            grSearch.Controls.Add(btnSearchBook);
            grSearch.Location = new Point(3, 3);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(179, 91);
            grSearch.TabIndex = 24;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // grAction
            // 
            grAction.Controls.Add(btnAddBook);
            grAction.Controls.Add(btnUpdateBook);
            grAction.Controls.Add(btnDeleteBook);
            grAction.Controls.Add(btnExitBook);
            grAction.Location = new Point(3, 100);
            grAction.Name = "grAction";
            grAction.Size = new Size(179, 218);
            grAction.TabIndex = 25;
            grAction.TabStop = false;
            grAction.Text = "Action";
            // 
            // btnAddBook
            // 
            btnAddBook.Dock = DockStyle.Bottom;
            btnAddBook.Location = new Point(3, 27);
            btnAddBook.Margin = new Padding(3, 2, 3, 2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(173, 47);
            btnAddBook.TabIndex = 20;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Dock = DockStyle.Bottom;
            btnUpdateBook.Location = new Point(3, 74);
            btnUpdateBook.Margin = new Padding(3, 2, 3, 2);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(173, 47);
            btnUpdateBook.TabIndex = 21;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Dock = DockStyle.Bottom;
            btnDeleteBook.Location = new Point(3, 121);
            btnDeleteBook.Margin = new Padding(3, 2, 3, 2);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(173, 47);
            btnDeleteBook.TabIndex = 22;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnExitBook
            // 
            btnExitBook.Dock = DockStyle.Bottom;
            btnExitBook.Location = new Point(3, 168);
            btnExitBook.Margin = new Padding(3, 2, 3, 2);
            btnExitBook.Name = "btnExitBook";
            btnExitBook.Size = new Size(173, 47);
            btnExitBook.TabIndex = 23;
            btnExitBook.Text = "Exit";
            btnExitBook.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(451, 9);
            label6.Name = "label6";
            label6.Size = new Size(409, 59);
            label6.TabIndex = 24;
            label6.Text = "Book Management";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(grSearch);
            flowLayoutPanel1.Controls.Add(grAction);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(182, 410);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // frmBookManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 579);
            Controls.Add(splitContainer2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBookManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookManagement";
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            BookInformation.ResumeLayout(false);
            BookInformation.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grAction.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox txtSearch;
        private Button btnSearchBook;
        private TextBox txtAuth;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox BookInformation;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private GroupBox grSearch;
        private GroupBox grAction;
        private Button btnAddBook;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private Button btnExitBook;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
    }
}
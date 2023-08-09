namespace BookLibrary
{
    partial class frmBookingList
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtBookID = new TextBox();
            txtAuth = new TextBox();
            txtMemName = new TextBox();
            txtBookName = new TextBox();
            txtDescription = new TextBox();
            dtBookingDay = new DateTimePicker();
            dtExpiredDay = new DateTimePicker();
            cboTitle = new ComboBox();
            txtSearch = new TextBox();
            btnBookingSearch = new Button();
            dgvBookingList = new DataGridView();
            btnHistory = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookingList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 47);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "BookID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 114);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 184);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "Member Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 47);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 114);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 184);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 5;
            label6.Text = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(692, 47);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 6;
            label7.Text = "Booking Day";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(692, 114);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 7;
            label8.Text = "Expired Day";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(142, 40);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(158, 27);
            txtBookID.TabIndex = 9;
            // 
            // txtAuth
            // 
            txtAuth.Location = new Point(439, 40);
            txtAuth.Name = "txtAuth";
            txtAuth.Size = new Size(158, 27);
            txtAuth.TabIndex = 10;
            // 
            // txtMemName
            // 
            txtMemName.Location = new Point(142, 177);
            txtMemName.Name = "txtMemName";
            txtMemName.Size = new Size(158, 27);
            txtMemName.TabIndex = 11;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(142, 107);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(158, 27);
            txtBookName.TabIndex = 12;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(439, 107);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(158, 27);
            txtDescription.TabIndex = 13;
            // 
            // dtBookingDay
            // 
            dtBookingDay.Location = new Point(802, 42);
            dtBookingDay.Name = "dtBookingDay";
            dtBookingDay.Size = new Size(250, 27);
            dtBookingDay.TabIndex = 14;
            // 
            // dtExpiredDay
            // 
            dtExpiredDay.Location = new Point(802, 105);
            dtExpiredDay.Name = "dtExpiredDay";
            dtExpiredDay.Size = new Size(250, 27);
            dtExpiredDay.TabIndex = 15;
            // 
            // cboTitle
            // 
            cboTitle.FormattingEnabled = true;
            cboTitle.Location = new Point(439, 177);
            cboTitle.Name = "cboTitle";
            cboTitle.Size = new Size(158, 28);
            cboTitle.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(802, 177);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 17;
            // 
            // btnBookingSearch
            // 
            btnBookingSearch.Location = new Point(692, 177);
            btnBookingSearch.Name = "btnBookingSearch";
            btnBookingSearch.Size = new Size(90, 28);
            btnBookingSearch.TabIndex = 18;
            btnBookingSearch.Text = "Search";
            btnBookingSearch.UseVisualStyleBackColor = true;
            btnBookingSearch.Click += btnBookingSearch_Click;
            // 
            // dgvBookingList
            // 
            dgvBookingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingList.Location = new Point(21, 240);
            dgvBookingList.Name = "dgvBookingList";
            dgvBookingList.RowHeadersWidth = 51;
            dgvBookingList.RowTemplate.Height = 29;
            dgvBookingList.Size = new Size(1031, 297);
            dgvBookingList.TabIndex = 19;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(294, 549);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(108, 54);
            btnHistory.TabIndex = 20;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(653, 549);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(108, 54);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmBookingList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 615);
            Controls.Add(btnBack);
            Controls.Add(btnHistory);
            Controls.Add(dgvBookingList);
            Controls.Add(btnBookingSearch);
            Controls.Add(txtSearch);
            Controls.Add(cboTitle);
            Controls.Add(dtExpiredDay);
            Controls.Add(dtBookingDay);
            Controls.Add(txtDescription);
            Controls.Add(txtBookName);
            Controls.Add(txtMemName);
            Controls.Add(txtAuth);
            Controls.Add(txtBookID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBookingList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookingList";
            ((System.ComponentModel.ISupportInitialize)dgvBookingList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtBookID;
        private TextBox txtAuth;
        private TextBox txtMemName;
        private TextBox txtBookName;
        private TextBox txtDescription;
        private DateTimePicker dtBookingDay;
        private DateTimePicker dtExpiredDay;
        private ComboBox cboTitle;
        private TextBox txtSearch;
        private Button btnBookingSearch;
        private DataGridView dgvBookingList;
        private Button btnHistory;
        private Button btnBack;
    }
}
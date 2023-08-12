namespace BookLibrary
{
    partial class frmMemberBookingList
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
            btnBookingSearch = new Button();
            txtSearch = new TextBox();
            cboCategory = new ComboBox();
            dtExpiredDay = new DateTimePicker();
            dtBookingDay = new DateTimePicker();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            txtAuth = new TextBox();
            txtBookID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMemberBookingList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMemberBookingList).BeginInit();
            SuspendLayout();
            // 
            // btnBookingSearch
            // 
            btnBookingSearch.Location = new Point(749, 179);
            btnBookingSearch.Name = "btnBookingSearch";
            btnBookingSearch.Size = new Size(90, 28);
            btnBookingSearch.TabIndex = 36;
            btnBookingSearch.Text = "Search";
            btnBookingSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(859, 179);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 35;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(199, 178);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(158, 28);
            cboCategory.TabIndex = 34;
            // 
            // dtExpiredDay
            // 
            dtExpiredDay.Location = new Point(859, 107);
            dtExpiredDay.Name = "dtExpiredDay";
            dtExpiredDay.Size = new Size(250, 27);
            dtExpiredDay.TabIndex = 33;
            // 
            // dtBookingDay
            // 
            dtBookingDay.Location = new Point(859, 44);
            dtBookingDay.Name = "dtBookingDay";
            dtBookingDay.Size = new Size(250, 27);
            dtBookingDay.TabIndex = 32;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(496, 109);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(158, 27);
            txtDescription.TabIndex = 31;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(199, 109);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(158, 27);
            txtTitle.TabIndex = 30;
            // 
            // txtAuth
            // 
            txtAuth.Location = new Point(496, 42);
            txtAuth.Name = "txtAuth";
            txtAuth.Size = new Size(158, 27);
            txtAuth.TabIndex = 28;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(199, 42);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(158, 27);
            txtBookID.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(749, 116);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 26;
            label8.Text = "Expired Day";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(749, 49);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 25;
            label7.Text = "Booking Day";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 186);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 24;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 116);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 23;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 49);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 22;
            label4.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 116);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 20;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 49);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 19;
            label1.Text = "BookID";
            // 
            // dgvMemberBookingList
            // 
            dgvMemberBookingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberBookingList.Location = new Point(64, 246);
            dgvMemberBookingList.Name = "dgvMemberBookingList";
            dgvMemberBookingList.RowHeadersWidth = 51;
            dgvMemberBookingList.RowTemplate.Height = 29;
            dgvMemberBookingList.Size = new Size(1061, 339);
            dgvMemberBookingList.TabIndex = 37;
            // 
            // frmMemberBookingList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 700);
            Controls.Add(dgvMemberBookingList);
            Controls.Add(btnBookingSearch);
            Controls.Add(txtSearch);
            Controls.Add(cboCategory);
            Controls.Add(dtExpiredDay);
            Controls.Add(dtBookingDay);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(txtAuth);
            Controls.Add(txtBookID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberBookingList";
            Text = "frmMemberBookingList";
            ((System.ComponentModel.ISupportInitialize)dgvMemberBookingList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBookingSearch;
        private TextBox txtSearch;
        private ComboBox cboCategory;
        private DateTimePicker dtExpiredDay;
        private DateTimePicker dtBookingDay;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private TextBox txtAuth;
        private TextBox txtBookID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dgvMemberBookingList;
    }
}
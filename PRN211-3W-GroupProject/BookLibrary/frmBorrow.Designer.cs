namespace BookLibrary
{
    partial class frmBorrow
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
            dgvBorrowDetail = new DataGridView();
            splitContainer1 = new SplitContainer();
            lblTitle = new Label();
            gbMember = new GroupBox();
            label1 = new Label();
            btnVerify = new Button();
            txtMemberID = new TextBox();
            label2 = new Label();
            txtGender = new TextBox();
            label3 = new Label();
            txtMemberName = new TextBox();
            splitContainer2 = new SplitContainer();
            gbAction = new GroupBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnRemoveBook = new Button();
            btnAddBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            gbAction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBorrowDetail
            // 
            dgvBorrowDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowDetail.Dock = DockStyle.Fill;
            dgvBorrowDetail.Location = new Point(0, 0);
            dgvBorrowDetail.Name = "dgvBorrowDetail";
            dgvBorrowDetail.ReadOnly = true;
            dgvBorrowDetail.RowTemplate.Height = 25;
            dgvBorrowDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowDetail.Size = new Size(972, 481);
            dgvBorrowDetail.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblTitle);
            splitContainer1.Panel1.Controls.Add(gbMember);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1115, 606);
            splitContainer1.SplitterDistance = 121;
            splitContainer1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(407, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(289, 59);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Borrow Book";
            // 
            // gbMember
            // 
            gbMember.Controls.Add(label1);
            gbMember.Controls.Add(btnVerify);
            gbMember.Controls.Add(txtMemberID);
            gbMember.Controls.Add(label2);
            gbMember.Controls.Add(txtGender);
            gbMember.Controls.Add(label3);
            gbMember.Controls.Add(txtMemberName);
            gbMember.Dock = DockStyle.Bottom;
            gbMember.Location = new Point(0, 70);
            gbMember.Name = "gbMember";
            gbMember.Size = new Size(1115, 51);
            gbMember.TabIndex = 12;
            gbMember.TabStop = false;
            gbMember.Text = "Member Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 24);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(241, 20);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(75, 23);
            btnVerify.TabIndex = 11;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.BackColor = SystemColors.Control;
            txtMemberID.Location = new Point(81, 20);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(154, 23);
            txtMemberID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 23);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Member Name";
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.LightGray;
            txtGender.Location = new Point(622, 20);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(153, 23);
            txtGender.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 23);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // txtMemberName
            // 
            txtMemberName.BackColor = Color.LightGray;
            txtMemberName.Location = new Point(411, 20);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(154, 23);
            txtMemberName.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvBorrowDetail);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(gbAction);
            splitContainer2.Size = new Size(1115, 481);
            splitContainer2.SplitterDistance = 972;
            splitContainer2.TabIndex = 1;
            // 
            // gbAction
            // 
            gbAction.Controls.Add(btnSave);
            gbAction.Controls.Add(btnCancel);
            gbAction.Controls.Add(btnRemoveBook);
            gbAction.Controls.Add(btnAddBook);
            gbAction.Dock = DockStyle.Fill;
            gbAction.Location = new Point(0, 0);
            gbAction.Name = "gbAction";
            gbAction.Size = new Size(139, 481);
            gbAction.TabIndex = 13;
            gbAction.TabStop = false;
            gbAction.Text = "Action";
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(3, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 50);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Bottom;
            btnCancel.Location = new Point(3, 428);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 50);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRemoveBook
            // 
            btnRemoveBook.Dock = DockStyle.Top;
            btnRemoveBook.Location = new Point(3, 69);
            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Size = new Size(133, 50);
            btnRemoveBook.TabIndex = 7;
            btnRemoveBook.Text = "Remove Book";
            btnRemoveBook.UseVisualStyleBackColor = true;
            btnRemoveBook.Click += btnRemoveBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Dock = DockStyle.Top;
            btnAddBook.Location = new Point(3, 19);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(133, 50);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // frmBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 606);
            Controls.Add(splitContainer1);
            Name = "frmBorrow";
            Text = "frmBorrow";
            ((System.ComponentModel.ISupportInitialize)dgvBorrowDetail).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbMember.ResumeLayout(false);
            gbMember.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            gbAction.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBorrowDetail;
        private SplitContainer splitContainer1;
        private Button btnAddBook;
        private TextBox txtGender;
        private TextBox txtMemberName;
        private TextBox txtMemberID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRemoveBook;
        private Button btnSave;
        private Button btnCancel;
        private Button btnVerify;
        private GroupBox gbAction;
        private GroupBox gbMember;
        private Label lblTitle;
        private SplitContainer splitContainer2;
    }
}
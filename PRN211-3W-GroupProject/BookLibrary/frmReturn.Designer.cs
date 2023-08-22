namespace BookLibrary
{
    partial class frmReturn
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
            splitContainer1 = new SplitContainer();
            gbMember = new GroupBox();
            label2 = new Label();
            btnVerify = new Button();
            txtMemberID = new TextBox();
            label3 = new Label();
            txtGender = new TextBox();
            label4 = new Label();
            txtMemberName = new TextBox();
            label1 = new Label();
            splitContainer2 = new SplitContainer();
            dgvReturnList = new DataGridView();
            gbAction = new GroupBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnRemoveBook = new Button();
            btnAddBook = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnList).BeginInit();
            gbAction.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gbMember);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1070, 607);
            splitContainer1.SplitterDistance = 120;
            splitContainer1.TabIndex = 0;
            // 
            // gbMember
            // 
            gbMember.Controls.Add(label2);
            gbMember.Controls.Add(btnVerify);
            gbMember.Controls.Add(txtMemberID);
            gbMember.Controls.Add(label3);
            gbMember.Controls.Add(txtGender);
            gbMember.Controls.Add(label4);
            gbMember.Controls.Add(txtMemberName);
            gbMember.Dock = DockStyle.Bottom;
            gbMember.Location = new Point(0, 69);
            gbMember.Name = "gbMember";
            gbMember.Size = new Size(1070, 51);
            gbMember.TabIndex = 13;
            gbMember.TabStop = false;
            gbMember.Text = "Member Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 24);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Member ID";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 23);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 1;
            label3.Text = "Member Name";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 23);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Gender";
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
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(400, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 59);
            label1.TabIndex = 0;
            label1.Text = "Book Return";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvReturnList);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(gbAction);
            splitContainer2.Size = new Size(1070, 483);
            splitContainer2.SplitterDistance = 851;
            splitContainer2.TabIndex = 1;
            // 
            // dgvReturnList
            // 
            dgvReturnList.AllowUserToAddRows = false;
            dgvReturnList.AllowUserToDeleteRows = false;
            dgvReturnList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnList.Dock = DockStyle.Fill;
            dgvReturnList.Location = new Point(0, 0);
            dgvReturnList.MultiSelect = false;
            dgvReturnList.Name = "dgvReturnList";
            dgvReturnList.ReadOnly = true;
            dgvReturnList.RowTemplate.Height = 25;
            dgvReturnList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturnList.Size = new Size(851, 483);
            dgvReturnList.TabIndex = 0;
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
            gbAction.Size = new Size(215, 483);
            gbAction.TabIndex = 14;
            gbAction.TabStop = false;
            gbAction.Text = "Action";
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(3, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(209, 50);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Bottom;
            btnCancel.Location = new Point(3, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(209, 50);
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
            btnRemoveBook.Size = new Size(209, 50);
            btnRemoveBook.TabIndex = 7;
            btnRemoveBook.Text = "Remove Book From Return List";
            btnRemoveBook.UseVisualStyleBackColor = true;
            btnRemoveBook.Click += btnRemoveBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Dock = DockStyle.Top;
            btnAddBook.Location = new Point(3, 19);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(209, 50);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Select Book To Return";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // frmReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 607);
            Controls.Add(splitContainer1);
            Name = "frmReturn";
            Text = "frmReturn";
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
            ((System.ComponentModel.ISupportInitialize)dgvReturnList).EndInit();
            gbAction.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvReturnList;
        private Label label1;
        private SplitContainer splitContainer2;
        private GroupBox gbMember;
        private Label label2;
        private Button btnVerify;
        private TextBox txtMemberID;
        private Label label3;
        private TextBox txtGender;
        private Label label4;
        private TextBox txtMemberName;
        private GroupBox gbAction;
        private Button btnSave;
        private Button btnCancel;
        private Button btnRemoveBook;
        private Button btnAddBook;
    }
}
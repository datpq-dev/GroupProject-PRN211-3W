namespace BookLibrary
{
    partial class frmBorrowBookDetail
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
            txtBookID = new TextBox();
            txtStatus = new TextBox();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtDescription = new RichTextBox();
            txtPeriod = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            label8 = new Label();
            txtCategory = new TextBox();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 183);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 285);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 6;
            label7.Text = "Booking Period";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(125, 6);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(582, 23);
            txtBookID.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.LightGray;
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.Location = new Point(125, 35);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(663, 23);
            txtStatus.TabIndex = 8;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.LightGray;
            txtISBN.BorderStyle = BorderStyle.FixedSingle;
            txtISBN.Location = new Point(125, 64);
            txtISBN.Name = "txtISBN";
            txtISBN.ReadOnly = true;
            txtISBN.Size = new Size(663, 23);
            txtISBN.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.LightGray;
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(125, 93);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(663, 23);
            txtTitle.TabIndex = 10;
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.LightGray;
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Location = new Point(125, 122);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(663, 23);
            txtAuthor.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.LightGray;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(125, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(663, 96);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // txtPeriod
            // 
            txtPeriod.BackColor = Color.LightGray;
            txtPeriod.BorderStyle = BorderStyle.FixedSingle;
            txtPeriod.Location = new Point(125, 282);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.ReadOnly = true;
            txtPeriod.Size = new Size(663, 23);
            txtPeriod.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(674, 343);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add to borrow list";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(593, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 154);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 16;
            label8.Text = "Category";
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.LightGray;
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Location = new Point(125, 151);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(663, 23);
            txtCategory.TabIndex = 17;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(713, 6);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 18;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // frmBorrowBookDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 378);
            Controls.Add(btnCheck);
            Controls.Add(txtCategory);
            Controls.Add(label8);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtPeriod);
            Controls.Add(txtDescription);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtISBN);
            Controls.Add(txtStatus);
            Controls.Add(txtBookID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBorrowBookDetail";
            Text = "frmBorrowBookDetail";
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
        private TextBox txtBookID;
        private TextBox txtStatus;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private RichTextBox txtDescription;
        private TextBox txtPeriod;
        private Button btnAdd;
        private Button btnCancel;
        private Label label8;
        private TextBox txtCategory;
        private Button btnCheck;
    }
}
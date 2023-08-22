namespace BookLibrary
{
    partial class frmReturnBookDetail
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
            txtCategory = new TextBox();
            label8 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            txtDescription = new RichTextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtISBN = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            cbBookID = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            txtFineAmount = new TextBox();
            cbCondition = new ComboBox();
            dtpDueDay = new DateTimePicker();
            label2 = new Label();
            rtbFineReason = new RichTextBox();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.LightGray;
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Location = new Point(125, 122);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(663, 23);
            txtCategory.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 125);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 35;
            label8.Text = "Category";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(582, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(674, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 23);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add to return list";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.LightGray;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(125, 151);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(663, 96);
            txtDescription.TabIndex = 31;
            txtDescription.Text = "";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.LightGray;
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Location = new Point(125, 93);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(663, 23);
            txtAuthor.TabIndex = 30;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.LightGray;
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(125, 64);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(663, 23);
            txtTitle.TabIndex = 29;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.LightGray;
            txtISBN.BorderStyle = BorderStyle.FixedSingle;
            txtISBN.Location = new Point(125, 35);
            txtISBN.Name = "txtISBN";
            txtISBN.ReadOnly = true;
            txtISBN.Size = new Size(663, 23);
            txtISBN.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 256);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 25;
            label7.Text = "Due Day";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 24;
            label6.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 96);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 23;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 22;
            label4.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 38);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 21;
            label3.Text = "ISBN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 19;
            label1.Text = "Book ID";
            // 
            // cbBookID
            // 
            cbBookID.FormattingEnabled = true;
            cbBookID.Location = new Point(125, 6);
            cbBookID.Name = "cbBookID";
            cbBookID.Size = new Size(663, 23);
            cbBookID.TabIndex = 37;
            cbBookID.SelectedIndexChanged += cbBookID_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 288);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 39;
            label9.Text = "Book Condition";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 317);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 40;
            label10.Text = "Fine Amount";
            // 
            // txtFineAmount
            // 
            txtFineAmount.BackColor = Color.LightGray;
            txtFineAmount.Location = new Point(125, 314);
            txtFineAmount.Name = "txtFineAmount";
            txtFineAmount.ReadOnly = true;
            txtFineAmount.Size = new Size(200, 23);
            txtFineAmount.TabIndex = 41;
            // 
            // cbCondition
            // 
            cbCondition.FormattingEnabled = true;
            cbCondition.Items.AddRange(new object[] { "Normal", "Damaged" });
            cbCondition.Location = new Point(125, 285);
            cbCondition.Name = "cbCondition";
            cbCondition.Size = new Size(200, 23);
            cbCondition.TabIndex = 42;
            cbCondition.SelectedIndexChanged += cbCondittion_SelectedIndexChanged;
            // 
            // dtpDueDay
            // 
            dtpDueDay.Enabled = false;
            dtpDueDay.Location = new Point(125, 253);
            dtpDueDay.Name = "dtpDueDay";
            dtpDueDay.Size = new Size(200, 23);
            dtpDueDay.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 256);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 44;
            label2.Text = "Fine Reason";
            // 
            // rtbFineReason
            // 
            rtbFineReason.Location = new Point(407, 253);
            rtbFineReason.Name = "rtbFineReason";
            rtbFineReason.ReadOnly = true;
            rtbFineReason.Size = new Size(381, 79);
            rtbFineReason.TabIndex = 45;
            rtbFineReason.Text = "";
            // 
            // frmReturnBookDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(rtbFineReason);
            Controls.Add(label2);
            Controls.Add(dtpDueDay);
            Controls.Add(cbCondition);
            Controls.Add(txtFineAmount);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cbBookID);
            Controls.Add(txtCategory);
            Controls.Add(label8);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtISBN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmReturnBookDetail";
            Text = "Return Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategory;
        private Label label8;
        private Button btnCancel;
        private Button btnAdd;
        private RichTextBox txtDescription;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox txtISBN;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox cbBookID;
        private Label label9;
        private Label label10;
        private TextBox txtFineAmount;
        private ComboBox cbCondition;
        private DateTimePicker dtpDueDay;
        private Label label2;
        private RichTextBox rtbFineReason;
    }
}
namespace BookLibrary
{
    partial class frmBookDetails
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
            txtTitle = new TextBox();
            txtAuth = new TextBox();
            txtISBN = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnBDCancel = new Button();
            txtPrice = new TextBox();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            txtCheck = new Button();
            label7 = new Label();
            nudQuantity = new NumericUpDown();
            label8 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.LightGray;
            txtTitle.Location = new Point(83, 35);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(452, 23);
            txtTitle.TabIndex = 15;
            // 
            // txtAuth
            // 
            txtAuth.BackColor = Color.LightGray;
            txtAuth.Location = new Point(83, 65);
            txtAuth.Margin = new Padding(3, 2, 3, 2);
            txtAuth.Name = "txtAuth";
            txtAuth.Size = new Size(452, 23);
            txtAuth.TabIndex = 14;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(83, 6);
            txtISBN.Margin = new Padding(3, 2, 3, 2);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(213, 23);
            txtISBN.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 12;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 11;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 10;
            label1.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 17;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 16;
            label4.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(98, 369);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 38);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnBDSave_Click;
            // 
            // btnBDCancel
            // 
            btnBDCancel.Location = new Point(351, 369);
            btnBDCancel.Margin = new Padding(3, 2, 3, 2);
            btnBDCancel.Name = "btnBDCancel";
            btnBDCancel.Size = new Size(91, 38);
            btnBDCancel.TabIndex = 23;
            btnBDCancel.Text = "Cancel";
            btnBDCancel.UseVisualStyleBackColor = true;
            btnBDCancel.Click += btnBDCancel_Click;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.LightGray;
            txtPrice.Location = new Point(83, 189);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(452, 23);
            txtPrice.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 192);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 24;
            label6.Text = "Price";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LightGray;
            richTextBox1.Location = new Point(83, 93);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(452, 91);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(83, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 23);
            textBox1.TabIndex = 27;
            // 
            // txtCheck
            // 
            txtCheck.Location = new Point(312, 6);
            txtCheck.Name = "txtCheck";
            txtCheck.Size = new Size(75, 23);
            txtCheck.TabIndex = 28;
            txtCheck.Text = "Check";
            txtCheck.UseVisualStyleBackColor = true;
            txtCheck.Click += txtCheck_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 279);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 29;
            label7.Text = "Quantity";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(83, 277);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Location = new Point(14, 251);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 31;
            label8.Text = "ID Prefix";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Location = new Point(83, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 23);
            textBox2.TabIndex = 32;
            // 
            // frmBookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 443);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(nudQuantity);
            Controls.Add(label7);
            Controls.Add(txtCheck);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(btnBDCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(txtAuth);
            Controls.Add(txtISBN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBookDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookDetails";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuth;
        private TextBox txtISBN;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button btnSave;
        private Button btnBDCancel;
        private TextBox txtPrice;
        private Label label6;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button txtCheck;
        private Label label7;
        private NumericUpDown nudQuantity;
        private Label label8;
        private TextBox textBox2;
    }
}
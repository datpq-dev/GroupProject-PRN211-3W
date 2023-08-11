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
            txtBookID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboCategory = new ComboBox();
            txtDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnBDCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(236, 127);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(243, 27);
            txtTitle.TabIndex = 15;
            // 
            // txtAuth
            // 
            txtAuth.Location = new Point(236, 196);
            txtAuth.Name = "txtAuth";
            txtAuth.Size = new Size(243, 27);
            txtAuth.TabIndex = 14;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(236, 55);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(243, 27);
            txtBookID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 203);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 12;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 134);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 11;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 62);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 10;
            label1.Text = "BookID";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(236, 334);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(243, 28);
            cboCategory.TabIndex = 21;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(236, 263);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(243, 27);
            txtDescription.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 342);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 17;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 270);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 16;
            label4.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 449);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 51);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnBDSave_Click;
            // 
            // btnBDCancel
            // 
            btnBDCancel.Location = new Point(409, 449);
            btnBDCancel.Name = "btnBDCancel";
            btnBDCancel.Size = new Size(104, 51);
            btnBDCancel.TabIndex = 23;
            btnBDCancel.Text = "Cancel";
            btnBDCancel.UseVisualStyleBackColor = true;
            btnBDCancel.Click += btnBDCancel_Click;
            // 
            // frmBookDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 591);
            Controls.Add(btnBDCancel);
            Controls.Add(btnSave);
            Controls.Add(cboCategory);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(txtAuth);
            Controls.Add(txtBookID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBookDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookDetails";
            Load += frmBookDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuth;
        private TextBox txtBookID;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboCategory;
        private TextBox txtDescription;
        private Label label5;
        private Label label4;
        private Button btnSave;
        private Button btnBDCancel;
    }
}
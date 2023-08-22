namespace BookLibrary
{
    partial class frmAccountManagement
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbRole = new Label();
            cboRole = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtAPassword = new TextBox();
            txtAPhone = new TextBox();
            txtAUsername = new TextBox();
            label6 = new Label();
            txtALastName = new TextBox();
            txtAFirstName = new TextBox();
            label4 = new Label();
            cboGender = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1031, 251);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 172);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(850, 168);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(39, 20);
            lbRole.TabIndex = 4;
            lbRole.Text = "Role";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(921, 164);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(142, 28);
            cboRole.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(125, 492);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 50);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(360, 492);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 50);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(616, 492);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(835, 492);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 50);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 173);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Phone";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(822, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // txtAPassword
            // 
            txtAPassword.Location = new Point(154, 97);
            txtAPassword.Name = "txtAPassword";
            txtAPassword.Size = new Size(161, 27);
            txtAPassword.TabIndex = 23;
            // 
            // txtAPhone
            // 
            txtAPhone.Location = new Point(154, 164);
            txtAPhone.Name = "txtAPhone";
            txtAPhone.Size = new Size(161, 27);
            txtAPhone.TabIndex = 22;
            // 
            // txtAUsername
            // 
            txtAUsername.Location = new Point(154, 19);
            txtAUsername.Name = "txtAUsername";
            txtAUsername.Size = new Size(161, 27);
            txtAUsername.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 96);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 46;
            label6.Text = "Last name";
            // 
            // txtALastName
            // 
            txtALastName.Location = new Point(463, 89);
            txtALastName.Name = "txtALastName";
            txtALastName.Size = new Size(179, 27);
            txtALastName.TabIndex = 45;
            // 
            // txtAFirstName
            // 
            txtAFirstName.Location = new Point(463, 19);
            txtAFirstName.Name = "txtAFirstName";
            txtAFirstName.Size = new Size(179, 27);
            txtAFirstName.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 26);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 43;
            label4.Text = "First name";
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(463, 162);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(142, 28);
            cboGender.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(700, 26);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 48;
            label7.Text = "Date of Birth";
            // 
            // frmAccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 583);
            Controls.Add(label7);
            Controls.Add(cboGender);
            Controls.Add(label6);
            Controls.Add(txtALastName);
            Controls.Add(txtAFirstName);
            Controls.Add(label4);
            Controls.Add(txtAPassword);
            Controls.Add(txtAPhone);
            Controls.Add(txtAUsername);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cboRole);
            Controls.Add(lbRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmAccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAccountManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbRole;
        private ComboBox cboRole;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private ComboBox cboGender;
        private Label label7;
        private TextBox txtAPassword;
        private TextBox txtAPhone;
        private TextBox txtAUsername;
        private TextBox txtALastName;
        private TextBox txtAFirstName;
    }
}
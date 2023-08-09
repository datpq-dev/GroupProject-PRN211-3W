namespace BookLibrary
{
    partial class frmAccountDetails
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
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGender = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dtDoB = new DateTimePicker();
            label7 = new Label();
            cboRole = new ComboBox();
            lbRole = new Label();
            btnAccSave = new Button();
            btnAccCancel = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(198, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 29;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(198, 358);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(241, 27);
            txtPhone.TabIndex = 28;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(198, 34);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 27);
            txtUsername.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 365);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 26;
            label5.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 25;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 24;
            label1.Text = "Username";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(198, 419);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(241, 27);
            txtGender.TabIndex = 35;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(198, 233);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(241, 27);
            txtLastName.TabIndex = 34;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(198, 163);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(241, 27);
            txtFirstName.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 170);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 31;
            label4.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 426);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 30;
            label3.Text = "Gender";
            // 
            // dtDoB
            // 
            dtDoB.Location = new Point(198, 295);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(241, 27);
            dtDoB.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 302);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 36;
            label7.Text = "Date of Birth";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(198, 481);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(142, 28);
            cboRole.TabIndex = 39;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(86, 489);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(39, 20);
            lbRole.TabIndex = 38;
            lbRole.Text = "Role";
            // 
            // btnAccSave
            // 
            btnAccSave.Location = new Point(108, 537);
            btnAccSave.Name = "btnAccSave";
            btnAccSave.Size = new Size(98, 47);
            btnAccSave.TabIndex = 40;
            btnAccSave.Text = "Save";
            btnAccSave.UseVisualStyleBackColor = true;
            btnAccSave.Click += btnAccSave_Click;
            // 
            // btnAccCancel
            // 
            btnAccCancel.Location = new Point(327, 537);
            btnAccCancel.Name = "btnAccCancel";
            btnAccCancel.Size = new Size(98, 47);
            btnAccCancel.TabIndex = 41;
            btnAccCancel.Text = "Cancel";
            btnAccCancel.UseVisualStyleBackColor = true;
            btnAccCancel.Click += btnAccCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 240);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 42;
            label6.Text = "Last name";
            // 
            // frmAccountDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 596);
            Controls.Add(label6);
            Controls.Add(btnAccCancel);
            Controls.Add(btnAccSave);
            Controls.Add(cboRole);
            Controls.Add(lbRole);
            Controls.Add(dtDoB);
            Controls.Add(label7);
            Controls.Add(txtGender);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAccountDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAccountDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox txtGender;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private DateTimePicker dtDoB;
        private Label label7;
        private ComboBox cboRole;
        private Label lbRole;
        private Button btnAccSave;
        private Button btnAccCancel;
        private Label label6;
    }
}
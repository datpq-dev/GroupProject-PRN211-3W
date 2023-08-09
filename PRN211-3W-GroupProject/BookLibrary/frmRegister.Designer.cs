﻿namespace BookLibrary
{
    partial class frmRegister
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
            lbUsername = new Label();
            lbPassword = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtFullname = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            cboGender = new ComboBox();
            dtDoB = new DateTimePicker();
            btnCreate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(70, 33);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(70, 87);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 142);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Full name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 300);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 8;
            label7.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 245);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 7;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 191);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 6;
            label9.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 352);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 9;
            label4.Text = "Gender";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(205, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 27);
            txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(205, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(205, 135);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(230, 27);
            txtFullname.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(205, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 27);
            txtPhone.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(205, 238);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(230, 27);
            txtAddress.TabIndex = 16;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(205, 344);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(230, 28);
            cboGender.TabIndex = 17;
            // 
            // dtDoB
            // 
            dtDoB.Location = new Point(205, 295);
            dtDoB.Name = "dtDoB";
            dtDoB.Size = new Size(230, 27);
            dtDoB.TabIndex = 18;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(120, 444);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(103, 59);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(350, 444);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 59);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 583);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(dtDoB);
            Controls.Add(cboGender);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtFullname);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbPassword;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtFullname;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ComboBox cboGender;
        private DateTimePicker dtDoB;
        private Button btnCreate;
        private Button btnExit;
    }
}
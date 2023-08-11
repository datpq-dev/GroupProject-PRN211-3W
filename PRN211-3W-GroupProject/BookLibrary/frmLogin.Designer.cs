namespace BookLibrary
{
    partial class frmLogin
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
            btnCancel = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(516, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 53);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(225, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 53);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(315, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(291, 27);
            txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(315, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 27);
            txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 189);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 112);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 12;
            label1.Text = "Username";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
    }
}
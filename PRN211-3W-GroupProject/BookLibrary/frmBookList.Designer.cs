namespace BookLibrary
{
    partial class frmBookList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearchAvai = new Button();
            btnRegister = new Button();
            dgvBLAvailable = new DataGridView();
            txtSearch = new TextBox();
            btnLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBLAvailable).BeginInit();
            SuspendLayout();
            // 
            // btnSearchAvai
            // 
            btnSearchAvai.Location = new Point(34, 25);
            btnSearchAvai.Name = "btnSearchAvai";
            btnSearchAvai.Size = new Size(89, 27);
            btnSearchAvai.TabIndex = 11;
            btnSearchAvai.Text = "Search";
            btnSearchAvai.UseVisualStyleBackColor = true;
            btnSearchAvai.Click += btnSearchAvai_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(505, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 58);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // 
            // dgvBLAvailable
            // 
            dgvBLAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBLAvailable.Location = new Point(34, 67);
            dgvBLAvailable.Name = "dgvBLAvailable";
            dgvBLAvailable.RowHeadersWidth = 51;
            dgvBLAvailable.RowTemplate.Height = 29;
            dgvBLAvailable.Size = new Size(733, 278);
            dgvBLAvailable.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(152, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(219, 27);
            txtSearch.TabIndex = 7;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(161, 368);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(110, 58);
            btnLog.TabIndex = 12;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += BtnLog_Click;
            // 
            // frmBookList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLog);
            Controls.Add(btnSearchAvai);
            Controls.Add(btnRegister);
            Controls.Add(dgvBLAvailable);
            Controls.Add(txtSearch);
            Name = "frmBookList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookList";
            ((System.ComponentModel.ISupportInitialize)dgvBLAvailable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnSearchAvai;
        private Button btnRegister;
        private DataGridView dgvBLAvailable;
        private TextBox txtSearch;
        private Button btnLog;
    }
}
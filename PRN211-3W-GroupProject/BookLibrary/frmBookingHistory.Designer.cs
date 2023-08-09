namespace BookLibrary
{
    partial class frmBookingHistory
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
            dgvBookingHistory = new DataGridView();
            btnBLBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookingHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvBookingHistory
            // 
            dgvBookingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingHistory.Location = new Point(39, 35);
            dgvBookingHistory.Name = "dgvBookingHistory";
            dgvBookingHistory.RowHeadersWidth = 51;
            dgvBookingHistory.RowTemplate.Height = 29;
            dgvBookingHistory.Size = new Size(789, 513);
            dgvBookingHistory.TabIndex = 0;
            // 
            // btnBLBack
            // 
            btnBLBack.Location = new Point(366, 563);
            btnBLBack.Name = "btnBLBack";
            btnBLBack.Size = new Size(111, 57);
            btnBLBack.TabIndex = 1;
            btnBLBack.Text = "Back";
            btnBLBack.UseVisualStyleBackColor = true;
            btnBLBack.Click += btnBLBack_Click;
            // 
            // frmBookingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 632);
            Controls.Add(btnBLBack);
            Controls.Add(dgvBookingHistory);
            Name = "frmBookingHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBookingHistory";
            ((System.ComponentModel.ISupportInitialize)dgvBookingHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBookingHistory;
        private Button btnBLBack;
    }
}
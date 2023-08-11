namespace BookLibrary
{
    partial class frmCategoryDetails
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
            dgvBookList = new DataGridView();
            btnBooking = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(29, 12);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(738, 355);
            dgvBookList.TabIndex = 0;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(325, 389);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(145, 49);
            btnBooking.TabIndex = 1;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.ClientSizeChanged += btnBooking_Click;
            // 
            // frmCategoryDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBooking);
            Controls.Add(dgvBookList);
            Name = "frmCategoryDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoryDetails";
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBookList;
        private Button btnBooking;
    }
}
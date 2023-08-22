namespace BookLibrary
{
    partial class frmBorrowingList
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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            dgbBorrowing = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbBorrowing).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgbBorrowing);
            splitContainer1.Size = new Size(958, 491);
            splitContainer1.SplitterDistance = 72;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 59);
            label1.TabIndex = 0;
            label1.Text = "Borrow List";
            // 
            // dgbBorrowing
            // 
            dgbBorrowing.AllowUserToAddRows = false;
            dgbBorrowing.AllowUserToDeleteRows = false;
            dgbBorrowing.AllowUserToOrderColumns = true;
            dgbBorrowing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbBorrowing.Dock = DockStyle.Fill;
            dgbBorrowing.Location = new Point(0, 0);
            dgbBorrowing.MultiSelect = false;
            dgbBorrowing.Name = "dgbBorrowing";
            dgbBorrowing.ReadOnly = true;
            dgbBorrowing.RowTemplate.Height = 25;
            dgbBorrowing.Size = new Size(958, 415);
            dgbBorrowing.TabIndex = 0;
            // 
            // frmBorrowingList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 491);
            Controls.Add(splitContainer1);
            Name = "frmBorrowingList";
            Text = "frmBorrowingList";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgbBorrowing).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private DataGridView dgbBorrowing;
    }
}
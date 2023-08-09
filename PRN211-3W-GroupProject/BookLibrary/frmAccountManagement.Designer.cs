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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(938, 251);
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
            label3.Location = new Point(383, 102);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(788, 168);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(39, 20);
            lbRole.TabIndex = 4;
            lbRole.Text = "Role";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(859, 164);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 26);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 10;
            label4.Text = "Full name";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 173);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 12;
            label6.Text = "Address";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(462, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 27);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(462, 165);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(161, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(462, 19);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(161, 27);
            textBox6.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(648, 24);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 19;
            label7.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(760, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 21);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 27);
            textBox3.TabIndex = 21;
            // 
            // frmAccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 574);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
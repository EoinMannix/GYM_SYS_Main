namespace GYMSYS
{
    partial class frmScheduleClass
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
            lblSelectRoom = new Label();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            dgvScheduleClass = new DataGridView();
            clmClassID = new DataGridViewTextBoxColumn();
            clmClassName = new DataGridViewTextBoxColumn();
            clmInstructorName = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            clmTime = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cboRoom = new ComboBox();
            txtClassTime = new TextBox();
            txtClassPrice = new TextBox();
            dtpClassDate = new DateTimePicker();
            txtInstructorName = new TextBox();
            label10 = new Label();
            txtClassName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnConfirm = new Button();
            label9 = new Label();
            cboRoom1 = new ComboBox();
            dtpClassDate1 = new DateTimePicker();
            lblDate1 = new Label();
            btnViewTimetable = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduleClass).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelectRoom
            // 
            lblSelectRoom.AutoSize = true;
            lblSelectRoom.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectRoom.Location = new Point(45, 38);
            lblSelectRoom.Name = "lblSelectRoom";
            lblSelectRoom.Size = new Size(118, 24);
            lblSelectRoom.TabIndex = 0;
            lblSelectRoom.Text = "Select Room";
            lblSelectRoom.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1144, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // dgvScheduleClass
            // 
            dgvScheduleClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScheduleClass.Columns.AddRange(new DataGridViewColumn[] { clmClassID, clmClassName, clmInstructorName, clmDate, clmTime });
            dgvScheduleClass.Location = new Point(221, 96);
            dgvScheduleClass.Name = "dgvScheduleClass";
            dgvScheduleClass.RowHeadersWidth = 51;
            dgvScheduleClass.RowTemplate.Height = 24;
            dgvScheduleClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScheduleClass.Size = new Size(703, 199);
            dgvScheduleClass.TabIndex = 2;
            dgvScheduleClass.CellClick += dgvScheduleClass_CellClick;
            dgvScheduleClass.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clmClassID
            // 
            clmClassID.HeaderText = "Class ID";
            clmClassID.MinimumWidth = 6;
            clmClassID.Name = "clmClassID";
            clmClassID.Width = 125;
            // 
            // clmClassName
            // 
            clmClassName.HeaderText = "Class Name";
            clmClassName.MinimumWidth = 6;
            clmClassName.Name = "clmClassName";
            clmClassName.Width = 125;
            // 
            // clmInstructorName
            // 
            clmInstructorName.HeaderText = "Instructor Name";
            clmInstructorName.MinimumWidth = 6;
            clmInstructorName.Name = "clmInstructorName";
            clmInstructorName.Width = 125;
            // 
            // clmDate
            // 
            clmDate.HeaderText = "Date";
            clmDate.MinimumWidth = 6;
            clmDate.Name = "clmDate";
            clmDate.Width = 125;
            // 
            // clmTime
            // 
            clmTime.HeaderText = "Time";
            clmTime.MinimumWidth = 6;
            clmTime.Name = "clmTime";
            clmTime.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboRoom);
            groupBox1.Controls.Add(txtClassTime);
            groupBox1.Controls.Add(txtClassPrice);
            groupBox1.Controls.Add(dtpClassDate);
            groupBox1.Controls.Add(txtInstructorName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtClassName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(200, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 248);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Booking Details";
            // 
            // cboRoom
            // 
            cboRoom.FormattingEnabled = true;
            cboRoom.Location = new Point(504, 168);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(200, 23);
            cboRoom.TabIndex = 24;
            cboRoom.SelectedIndexChanged += cboRoom_SelectedIndexChanged;
            // 
            // txtClassTime
            // 
            txtClassTime.Location = new Point(504, 108);
            txtClassTime.Name = "txtClassTime";
            txtClassTime.Size = new Size(200, 23);
            txtClassTime.TabIndex = 23;
            // 
            // txtClassPrice
            // 
            txtClassPrice.Location = new Point(504, 44);
            txtClassPrice.Name = "txtClassPrice";
            txtClassPrice.Size = new Size(200, 23);
            txtClassPrice.TabIndex = 22;
            // 
            // dtpClassDate
            // 
            dtpClassDate.Location = new Point(147, 100);
            dtpClassDate.Name = "dtpClassDate";
            dtpClassDate.Size = new Size(200, 23);
            dtpClassDate.TabIndex = 21;
            // 
            // txtInstructorName
            // 
            txtInstructorName.Location = new Point(147, 170);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Size = new Size(200, 23);
            txtInstructorName.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(395, 167);
            label10.Name = "label10";
            label10.Size = new Size(61, 24);
            label10.TabIndex = 17;
            label10.Text = "Room";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(147, 46);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(200, 23);
            txtClassName.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(338, 164);
            label8.Name = "label8";
            label8.Size = new Size(0, 24);
            label8.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(395, 105);
            label7.Name = "label7";
            label7.Size = new Size(53, 24);
            label7.TabIndex = 9;
            label7.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(395, 43);
            label6.Name = "label6";
            label6.Size = new Size(53, 24);
            label6.TabIndex = 8;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 164);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 7;
            label5.Text = "Instructor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 100);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 46);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 5;
            label3.Text = "Class Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(564, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 4;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(470, 586);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(178, 44);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 96);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 18;
            // 
            // cboRoom1
            // 
            cboRoom1.FormattingEnabled = true;
            cboRoom1.Location = new Point(200, 41);
            cboRoom1.Name = "cboRoom1";
            cboRoom1.Size = new Size(200, 23);
            cboRoom1.TabIndex = 25;
            // 
            // dtpClassDate1
            // 
            dtpClassDate1.Location = new Point(513, 41);
            dtpClassDate1.Name = "dtpClassDate1";
            dtpClassDate1.Size = new Size(200, 23);
            dtpClassDate1.TabIndex = 27;
            // 
            // lblDate1
            // 
            lblDate1.AutoSize = true;
            lblDate1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate1.Location = new Point(425, 40);
            lblDate1.Name = "lblDate1";
            lblDate1.Size = new Size(48, 24);
            lblDate1.TabIndex = 28;
            lblDate1.Text = "Date";
            // 
            // btnViewTimetable
            // 
            btnViewTimetable.Location = new Point(777, 35);
            btnViewTimetable.Name = "btnViewTimetable";
            btnViewTimetable.Size = new Size(103, 38);
            btnViewTimetable.TabIndex = 29;
            btnViewTimetable.Text = "View Timetable";
            btnViewTimetable.UseVisualStyleBackColor = true;
            btnViewTimetable.Click += btnViewTimetable_Click;
            // 
            // frmScheduleClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 642);
            Controls.Add(btnViewTimetable);
            Controls.Add(lblDate1);
            Controls.Add(dtpClassDate1);
            Controls.Add(cboRoom1);
            Controls.Add(label9);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(dgvScheduleClass);
            Controls.Add(lblSelectRoom);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmScheduleClass";
            Text = "frmScheduleClass";
            Load += frmScheduleClass_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduleClass).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvScheduleClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInstructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
        private DateTimePicker dtpClassDate;
        private TextBox txtClassTime;
        private TextBox txtClassPrice;
        private ComboBox cboRoom;
        private ComboBox cboRoom1;
        private DateTimePicker dtpClassDate1;
        private Label lblDate1;
        private Button btnViewTimetable;
    }
}
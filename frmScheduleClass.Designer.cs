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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            dgvScheduleClass = new DataGridView();
            clmClassID = new DataGridViewTextBoxColumn();
            clmClassName = new DataGridViewTextBoxColumn();
            clmInstructorName = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            clmTime = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtInstructorName = new TextBox();
            txtTime = new TextBox();
            txtRoom = new TextBox();
            label10 = new Label();
            txtPrice = new TextBox();
            txtDate = new TextBox();
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
            txtSelectClass = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduleClass).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 55);
            label1.Name = "label1";
            label1.Size = new Size(147, 29);
            label1.TabIndex = 0;
            label1.Text = "Select Class";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1042, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // dgvScheduleClass
            // 
            dgvScheduleClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScheduleClass.Columns.AddRange(new DataGridViewColumn[] { clmClassID, clmClassName, clmInstructorName, clmDate, clmTime });
            dgvScheduleClass.Location = new Point(165, 128);
            dgvScheduleClass.Margin = new Padding(3, 4, 3, 4);
            dgvScheduleClass.Name = "dgvScheduleClass";
            dgvScheduleClass.RowHeadersWidth = 51;
            dgvScheduleClass.RowTemplate.Height = 24;
            dgvScheduleClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScheduleClass.Size = new Size(678, 265);
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
            groupBox1.Controls.Add(txtInstructorName);
            groupBox1.Controls.Add(txtTime);
            groupBox1.Controls.Add(txtRoom);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(txtClassName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(113, 436);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(803, 299);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Booking Details";
            // 
            // txtInstructorName
            // 
            txtInstructorName.Location = new Point(195, 226);
            txtInstructorName.Margin = new Padding(3, 4, 3, 4);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Size = new Size(162, 27);
            txtInstructorName.TabIndex = 20;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(568, 142);
            txtTime.Margin = new Padding(3, 4, 3, 4);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(162, 27);
            txtTime.TabIndex = 19;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(568, 229);
            txtRoom.Margin = new Padding(3, 4, 3, 4);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(162, 27);
            txtRoom.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(386, 218);
            label10.Name = "label10";
            label10.Size = new Size(78, 29);
            label10.TabIndex = 17;
            label10.Text = "Room";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(568, 61);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(162, 27);
            txtPrice.TabIndex = 16;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(195, 142);
            txtDate.Margin = new Padding(3, 4, 3, 4);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(162, 27);
            txtDate.TabIndex = 12;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(195, 61);
            txtClassName.Margin = new Padding(3, 4, 3, 4);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(162, 27);
            txtClassName.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(386, 218);
            label8.Name = "label8";
            label8.Size = new Size(0, 29);
            label8.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(386, 134);
            label7.Name = "label7";
            label7.Size = new Size(69, 29);
            label7.TabIndex = 9;
            label7.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(386, 52);
            label6.Name = "label6";
            label6.Size = new Size(69, 29);
            label6.TabIndex = 8;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 218);
            label5.Name = "label5";
            label5.Size = new Size(111, 29);
            label5.TabIndex = 7;
            label5.Text = "Instructor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 134);
            label4.Name = "label4";
            label4.Size = new Size(63, 29);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 52);
            label3.Name = "label3";
            label3.Size = new Size(144, 29);
            label3.TabIndex = 5;
            label3.Text = "Class Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(644, 55);
            label2.Name = "label2";
            label2.Size = new Size(0, 29);
            label2.TabIndex = 4;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(392, 754);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(204, 59);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 128);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 18;
            // 
            // txtSelectClass
            // 
            txtSelectClass.Location = new Point(484, 64);
            txtSelectClass.Margin = new Padding(3, 4, 3, 4);
            txtSelectClass.Name = "txtSelectClass";
            txtSelectClass.Size = new Size(234, 27);
            txtSelectClass.TabIndex = 19;
            txtSelectClass.TextChanged += textBox5_TextChanged;
            txtSelectClass.KeyDown += txtSelectClass_KeyDown;
            // 
            // frmScheduleClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 856);
            Controls.Add(txtSelectClass);
            Controls.Add(label9);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(dgvScheduleClass);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInstructorName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtSelectClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
    }
}
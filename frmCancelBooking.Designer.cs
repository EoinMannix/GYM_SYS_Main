namespace GYMSYS
{
    partial class frmCancelBooking
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
            dgvCancelBooking = new DataGridView();
            clmClassID = new DataGridViewTextBoxColumn();
            clmClassName = new DataGridViewTextBoxColumn();
            clmInstructorName = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            clmTime = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtSelectClass = new TextBox();
            lblBalance = new Label();
            txtBalance = new TextBox();
            txtDate = new TextBox();
            label2 = new Label();
            txtRoom = new TextBox();
            txtPrice = new TextBox();
            txtInstructor = new TextBox();
            txtTime = new TextBox();
            txtClassName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnConfirm = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCancelBooking).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCancelBooking
            // 
            dgvCancelBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCancelBooking.Columns.AddRange(new DataGridViewColumn[] { clmClassID, clmClassName, clmInstructorName, clmDate, clmTime });
            dgvCancelBooking.Location = new Point(165, 158);
            dgvCancelBooking.Margin = new Padding(3, 4, 3, 4);
            dgvCancelBooking.Name = "dgvCancelBooking";
            dgvCancelBooking.RowHeadersWidth = 51;
            dgvCancelBooking.RowTemplate.Height = 24;
            dgvCancelBooking.Size = new Size(677, 209);
            dgvCancelBooking.TabIndex = 3;
            dgvCancelBooking.CellClick += dgvCancelBooking_CellClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 61);
            label1.Name = "label1";
            label1.Size = new Size(147, 29);
            label1.TabIndex = 9;
            label1.Text = "Select Class";
            // 
            // txtSelectClass
            // 
            txtSelectClass.Location = new Point(255, 70);
            txtSelectClass.Margin = new Padding(3, 4, 3, 4);
            txtSelectClass.Name = "txtSelectClass";
            txtSelectClass.Size = new Size(191, 27);
            txtSelectClass.TabIndex = 9;
            txtSelectClass.KeyDown += txtSelectClass_KeyDown;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(549, 61);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(100, 29);
            lblBalance.TabIndex = 10;
            lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(703, 70);
            txtBalance.Margin = new Padding(3, 4, 3, 4);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(256, 27);
            txtBalance.TabIndex = 11;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(228, 170);
            txtDate.Margin = new Padding(3, 4, 3, 4);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(200, 27);
            txtDate.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 161);
            label2.Name = "label2";
            label2.Size = new Size(63, 29);
            label2.TabIndex = 22;
            label2.Text = "Date";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(659, 278);
            txtRoom.Margin = new Padding(3, 4, 3, 4);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(200, 27);
            txtRoom.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(659, 69);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 20;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(228, 281);
            txtInstructor.Margin = new Padding(3, 4, 3, 4);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(200, 27);
            txtInstructor.TabIndex = 19;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(659, 170);
            txtTime.Margin = new Padding(3, 4, 3, 4);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(200, 27);
            txtTime.TabIndex = 18;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(228, 69);
            txtClassName.Margin = new Padding(3, 4, 3, 4);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(200, 27);
            txtClassName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(513, 272);
            label3.Name = "label3";
            label3.Size = new Size(78, 29);
            label3.TabIndex = 16;
            label3.Text = "Room";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(513, 60);
            label4.Name = "label4";
            label4.Size = new Size(69, 29);
            label4.TabIndex = 14;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 272);
            label5.Name = "label5";
            label5.Size = new Size(111, 29);
            label5.TabIndex = 12;
            label5.Text = "Instructor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(513, 161);
            label6.Name = "label6";
            label6.Size = new Size(69, 29);
            label6.TabIndex = 10;
            label6.Text = "Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 60);
            label7.Name = "label7";
            label7.Size = new Size(144, 29);
            label7.TabIndex = 8;
            label7.Text = "Class Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtRoom);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtInstructor);
            groupBox1.Controls.Add(txtTime);
            groupBox1.Controls.Add(txtClassName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(27, 394);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(968, 362);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Booking Details";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(371, 785);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(204, 59);
            btnConfirm.TabIndex = 25;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1020, 28);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // frmCancelBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 884);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox1);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(txtSelectClass);
            Controls.Add(label1);
            Controls.Add(dgvCancelBooking);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCancelBooking";
            Text = "frmCancelBooking";
            Load += frmCancelBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCancelBooking).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCancelBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectClass;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirm;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}
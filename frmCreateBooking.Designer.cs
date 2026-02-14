namespace GYMSYS
{
    partial class frmCreateBooking
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
            lblSelectClass = new Label();
            dgvCreateBooking = new DataGridView();
            clmClassID = new DataGridViewTextBoxColumn();
            clmClassName = new DataGridViewTextBoxColumn();
            clmInstructorName = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            clmTime = new DataGridViewTextBoxColumn();
            txtSelectClass = new TextBox();
            label2 = new Label();
            lblBalance = new Label();
            txtBalance = new TextBox();
            grpCreateBooking = new GroupBox();
            txtDate = new TextBox();
            lblDate = new Label();
            txtRoom = new TextBox();
            txtPrice = new TextBox();
            txtInstructor = new TextBox();
            txtTime = new TextBox();
            txtClassName = new TextBox();
            lblRoom = new Label();
            lblPrice = new Label();
            lblInstructor = new Label();
            lblTime = new Label();
            lblClassName = new Label();
            btnConfirm = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCreateBooking).BeginInit();
            grpCreateBooking.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelectClass
            // 
            lblSelectClass.AutoSize = true;
            lblSelectClass.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectClass.Location = new Point(57, 52);
            lblSelectClass.Name = "lblSelectClass";
            lblSelectClass.Size = new Size(147, 29);
            lblSelectClass.TabIndex = 1;
            lblSelectClass.Text = "Select Class";
            // 
            // dgvCreateBooking
            // 
            dgvCreateBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreateBooking.Columns.AddRange(new DataGridViewColumn[] { clmClassID, clmClassName, clmInstructorName, clmDate, clmTime });
            dgvCreateBooking.Location = new Point(223, 128);
            dgvCreateBooking.Margin = new Padding(3, 4, 3, 4);
            dgvCreateBooking.Name = "dgvCreateBooking";
            dgvCreateBooking.RowHeadersWidth = 51;
            dgvCreateBooking.RowTemplate.Height = 24;
            dgvCreateBooking.Size = new Size(677, 209);
            dgvCreateBooking.TabIndex = 2;
            dgvCreateBooking.CellClick += dgvCreateBooking_CellClick;
            dgvCreateBooking.CellContentClick += dgvCreateBooking_CellClick;
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
            // txtSelectClass
            // 
            txtSelectClass.Location = new Point(282, 61);
            txtSelectClass.Margin = new Padding(3, 4, 3, 4);
            txtSelectClass.Name = "txtSelectClass";
            txtSelectClass.Size = new Size(191, 27);
            txtSelectClass.TabIndex = 3;
            txtSelectClass.KeyDown += txtSelectClass_KeyDown;
            txtSelectClass.KeyUp += txtSelectClass_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(597, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 29);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(597, 52);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(100, 29);
            lblBalance.TabIndex = 5;
            lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(785, 61);
            txtBalance.Margin = new Padding(3, 4, 3, 4);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(256, 27);
            txtBalance.TabIndex = 6;
            // 
            // grpCreateBooking
            // 
            grpCreateBooking.Controls.Add(txtDate);
            grpCreateBooking.Controls.Add(lblDate);
            grpCreateBooking.Controls.Add(txtRoom);
            grpCreateBooking.Controls.Add(txtPrice);
            grpCreateBooking.Controls.Add(txtInstructor);
            grpCreateBooking.Controls.Add(txtTime);
            grpCreateBooking.Controls.Add(txtClassName);
            grpCreateBooking.Controls.Add(lblRoom);
            grpCreateBooking.Controls.Add(lblPrice);
            grpCreateBooking.Controls.Add(lblInstructor);
            grpCreateBooking.Controls.Add(lblTime);
            grpCreateBooking.Controls.Add(lblClassName);
            grpCreateBooking.Location = new Point(73, 344);
            grpCreateBooking.Margin = new Padding(3, 4, 3, 4);
            grpCreateBooking.Name = "grpCreateBooking";
            grpCreateBooking.Padding = new Padding(3, 4, 3, 4);
            grpCreateBooking.Size = new Size(968, 362);
            grpCreateBooking.TabIndex = 7;
            grpCreateBooking.TabStop = false;
            grpCreateBooking.Text = "Booking Details";
            grpCreateBooking.Enter += grpCreateBooking_Enter;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(228, 170);
            txtDate.Margin = new Padding(3, 4, 3, 4);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(200, 27);
            txtDate.TabIndex = 23;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(31, 161);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(63, 29);
            lblDate.TabIndex = 22;
            lblDate.Text = "Date";
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
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(513, 272);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(78, 29);
            lblRoom.TabIndex = 16;
            lblRoom.Text = "Room";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(513, 60);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 29);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructor.Location = new Point(31, 272);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(111, 29);
            lblInstructor.TabIndex = 12;
            lblInstructor.Text = "Instructor";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(513, 161);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(69, 29);
            lblTime.TabIndex = 10;
            lblTime.Text = "Time";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(31, 60);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(144, 29);
            lblClassName.TabIndex = 8;
            lblClassName.Text = "Class Name";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(414, 746);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(204, 59);
            btnConfirm.TabIndex = 8;
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
            menuStrip1.Size = new Size(1118, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // frmCreateBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 848);
            Controls.Add(btnConfirm);
            Controls.Add(grpCreateBooking);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(label2);
            Controls.Add(txtSelectClass);
            Controls.Add(dgvCreateBooking);
            Controls.Add(lblSelectClass);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCreateBooking";
            Text = "frmCreateBooking";
            Load += frmCreateBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCreateBooking).EndInit();
            grpCreateBooking.ResumeLayout(false);
            grpCreateBooking.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.DataGridView dgvCreateBooking;
        private System.Windows.Forms.TextBox txtSelectClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.GroupBox grpCreateBooking;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}
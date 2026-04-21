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
            grpCancelBooking = new GroupBox();
            btnConfirm = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            lblBalance = new Label();
            txtBalance = new TextBox();
            lblMemberID = new Label();
            txtMemberID = new TextBox();
            lblDirections = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCancelBooking).BeginInit();
            grpCancelBooking.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCancelBooking
            // 
            dgvCancelBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCancelBooking.Columns.AddRange(new DataGridViewColumn[] { clmClassID, clmClassName, clmInstructorName, clmDate, clmTime });
            dgvCancelBooking.Location = new Point(157, 167);
            dgvCancelBooking.Name = "dgvCancelBooking";
            dgvCancelBooking.RowHeadersWidth = 51;
            dgvCancelBooking.RowTemplate.Height = 24;
            dgvCancelBooking.Size = new Size(592, 157);
            dgvCancelBooking.TabIndex = 3;
            dgvCancelBooking.CellClick += dgvCancelBooking_CellClick;
            dgvCancelBooking.CellContentClick += this.dgvCancelBooking_CellContentClick;
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
            // txtDate
            // 
            txtDate.Location = new Point(200, 128);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(176, 23);
            txtDate.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 121);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 22;
            label2.Text = "Date";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(577, 208);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(176, 23);
            txtRoom.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(577, 52);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(176, 23);
            txtPrice.TabIndex = 20;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(200, 211);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(176, 23);
            txtInstructor.TabIndex = 19;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(577, 128);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(176, 23);
            txtTime.TabIndex = 18;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(200, 52);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(176, 23);
            txtClassName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 204);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 16;
            label3.Text = "Room";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(449, 45);
            label4.Name = "label4";
            label4.Size = new Size(53, 24);
            label4.TabIndex = 14;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 204);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 12;
            label5.Text = "Instructor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(449, 121);
            label6.Name = "label6";
            label6.Size = new Size(53, 24);
            label6.TabIndex = 10;
            label6.Text = "Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 45);
            label7.Name = "label7";
            label7.Size = new Size(111, 24);
            label7.TabIndex = 8;
            label7.Text = "Class Name";
            // 
            // grpCancelBooking
            // 
            grpCancelBooking.Controls.Add(txtDate);
            grpCancelBooking.Controls.Add(label2);
            grpCancelBooking.Controls.Add(txtRoom);
            grpCancelBooking.Controls.Add(txtPrice);
            grpCancelBooking.Controls.Add(txtInstructor);
            grpCancelBooking.Controls.Add(txtTime);
            grpCancelBooking.Controls.Add(txtClassName);
            grpCancelBooking.Controls.Add(label3);
            grpCancelBooking.Controls.Add(label4);
            grpCancelBooking.Controls.Add(label5);
            grpCancelBooking.Controls.Add(label6);
            grpCancelBooking.Controls.Add(label7);
            grpCancelBooking.Location = new Point(36, 360);
            grpCancelBooking.Name = "grpCancelBooking";
            grpCancelBooking.Size = new Size(847, 272);
            grpCancelBooking.TabIndex = 24;
            grpCancelBooking.TabStop = false;
            grpCancelBooking.Text = "Booking Details";
            grpCancelBooking.Enter += grpCancelBooking_Enter;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(360, 638);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(178, 44);
            btnConfirm.TabIndex = 25;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(892, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(447, 61);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(78, 24);
            lblBalance.TabIndex = 24;
            lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(560, 64);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(176, 23);
            txtBalance.TabIndex = 24;
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemberID.Location = new Point(79, 64);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(103, 24);
            lblMemberID.TabIndex = 27;
            lblMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(241, 64);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(176, 23);
            txtMemberID.TabIndex = 28;
            txtMemberID.Leave += txtMemberID_Leave;
            // 
            // lblDirections
            // 
            lblDirections.AutoSize = true;
            lblDirections.Font = new Font("Segoe UI", 12F);
            lblDirections.Location = new Point(320, 114);
            lblDirections.Name = "lblDirections";
            lblDirections.Size = new Size(243, 21);
            lblDirections.TabIndex = 30;
            lblDirections.Text = "Please enter a valid ID and Hit Tab";
            // 
            // frmCancelBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 783);
            Controls.Add(lblDirections);
            Controls.Add(txtMemberID);
            Controls.Add(lblMemberID);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(btnConfirm);
            Controls.Add(grpCancelBooking);
            Controls.Add(dgvCancelBooking);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCancelBooking";
            Text = "frmCancelBooking";
            Load += frmCancelBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCancelBooking).EndInit();
            grpCancelBooking.ResumeLayout(false);
            grpCancelBooking.PerformLayout();
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
        private Label lblBalance;
        private TextBox txtBalance;
        private Label lblMemberID;
        private TextBox txtMemberID;
        private GroupBox grpCancelBooking;
        private Label lblDirections;
    }
}
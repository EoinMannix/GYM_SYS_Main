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
            dgvCreateBooking = new DataGridView();
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
            txtMemberID = new TextBox();
            lblMemberID = new Label();
            dgvMembers = new DataGridView();
            txtSearchMember = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCreateBooking).BeginInit();
            grpCreateBooking.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // dgvCreateBooking
            // 
            dgvCreateBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreateBooking.Location = new Point(564, 89);
            dgvCreateBooking.Name = "dgvCreateBooking";
            dgvCreateBooking.RowHeadersWidth = 51;
            dgvCreateBooking.RowTemplate.Height = 24;
            dgvCreateBooking.Size = new Size(882, 162);
            dgvCreateBooking.TabIndex = 2;
            dgvCreateBooking.CellClick += dgvCreateBooking_CellClick;
            dgvCreateBooking.CellContentClick += dgvCreateBooking_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(532, 140);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(845, 44);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(78, 24);
            lblBalance.TabIndex = 5;
            lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(948, 45);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(224, 23);
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
            grpCreateBooking.Location = new Point(371, 313);
            grpCreateBooking.Name = "grpCreateBooking";
            grpCreateBooking.Size = new Size(847, 272);
            grpCreateBooking.TabIndex = 7;
            grpCreateBooking.TabStop = false;
            grpCreateBooking.Text = "Booking Details";
            grpCreateBooking.Enter += grpCreateBooking_Enter;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(200, 121);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(176, 23);
            txtDate.TabIndex = 23;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(27, 121);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 24);
            lblDate.TabIndex = 22;
            lblDate.Text = "Date";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(577, 208);
            txtRoom.Name = "txtRoom";
            txtRoom.ReadOnly = true;
            txtRoom.Size = new Size(176, 23);
            txtRoom.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(577, 45);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(176, 23);
            txtPrice.TabIndex = 20;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(200, 205);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.ReadOnly = true;
            txtInstructor.Size = new Size(176, 23);
            txtInstructor.TabIndex = 19;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(577, 128);
            txtTime.Name = "txtTime";
            txtTime.ReadOnly = true;
            txtTime.Size = new Size(176, 23);
            txtTime.TabIndex = 18;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(200, 48);
            txtClassName.Name = "txtClassName";
            txtClassName.ReadOnly = true;
            txtClassName.Size = new Size(176, 23);
            txtClassName.TabIndex = 17;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(449, 204);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(61, 24);
            lblRoom.TabIndex = 16;
            lblRoom.Text = "Room";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(449, 45);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 24);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructor.Location = new Point(27, 204);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(86, 24);
            lblInstructor.TabIndex = 12;
            lblInstructor.Text = "Instructor";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(449, 121);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(53, 24);
            lblTime.TabIndex = 10;
            lblTime.Text = "Time";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(27, 45);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(111, 24);
            lblClassName.TabIndex = 8;
            lblClassName.Text = "Class Name";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(695, 647);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(178, 44);
            btnConfirm.TabIndex = 8;
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
            menuStrip1.Size = new Size(1470, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(627, 45);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(176, 23);
            txtMemberID.TabIndex = 24;
            txtMemberID.Leave += txtMemberID_Leave;
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemberID.Location = new Point(496, 44);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(103, 24);
            lblMemberID.TabIndex = 24;
            lblMemberID.Text = "Memebr ID";
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(40, 89);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.Size = new Size(404, 162);
            dgvMembers.TabIndex = 32;
            dgvMembers.CellClick += dgvMembers_CellClick;
            dgvMembers.CellContentClick += dgvMembers_CellContentClick;
            // 
            // txtSearchMember
            // 
            txtSearchMember.Location = new Point(238, 45);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.Size = new Size(176, 23);
            txtSearchMember.TabIndex = 33;
            txtSearchMember.KeyUp += txtSearchMember_KeyUp;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(40, 45);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(146, 24);
            lblSearch.TabIndex = 34;
            lblSearch.Text = "Search Member";
            lblSearch.Click += label1_Click;
            // 
            // frmCreateBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1470, 1057);
            Controls.Add(lblSearch);
            Controls.Add(txtSearchMember);
            Controls.Add(dgvMembers);
            Controls.Add(lblMemberID);
            Controls.Add(txtMemberID);
            Controls.Add(btnConfirm);
            Controls.Add(grpCreateBooking);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(label2);
            Controls.Add(dgvCreateBooking);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCreateBooking";
            Text = "frmCreateBooking";
            Load += frmCreateBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCreateBooking).EndInit();
            grpCreateBooking.ResumeLayout(false);
            grpCreateBooking.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCreateBooking;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private TextBox txtMemberID;
        private Label lblMemberID;
        private DataGridView dgvMembers;
        private TextBox txtSearchMember;
        private Label lblSearch;
    }
}
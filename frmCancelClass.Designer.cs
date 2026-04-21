namespace GYMSYS
{
    partial class frmCancelClass
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
            dgvCancelClass = new DataGridView();
            clmClassID = new DataGridViewTextBoxColumn();
            clmClassName = new DataGridViewTextBoxColumn();
            clmInstructorName = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            clmTime = new DataGridViewTextBoxColumn();
            lblClassName = new Label();
            label4 = new Label();
            grpCancelDetails = new GroupBox();
            txtRoom = new TextBox();
            lblRoom = new Label();
            txtPrice = new TextBox();
            txtTime = new TextBox();
            lblTime = new Label();
            lblPrice = new Label();
            label7 = new Label();
            txtDate = new TextBox();
            txtInstructor = new TextBox();
            txtClassName = new TextBox();
            lblDate = new Label();
            lblInstructor = new Label();
            btnConfirm = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCancelClass).BeginInit();
            grpCancelDetails.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // dgvCancelClass
            // 
            dgvCancelClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCancelClass.Columns.AddRange(new DataGridViewColumn[] { clmClassID, clmClassName, clmInstructorName, clmDate, clmTime });
            dgvCancelClass.Location = new Point(123, 88);
            dgvCancelClass.Name = "dgvCancelClass";
            dgvCancelClass.RowHeadersWidth = 51;
            dgvCancelClass.RowTemplate.Height = 24;
            dgvCancelClass.Size = new Size(734, 206);
            dgvCancelClass.TabIndex = 3;
            dgvCancelClass.CellClick += dgvCancelClass_CellClick;
            dgvCancelClass.CellContentClick += dgvCancelClass_CellClick;
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
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(27, 38);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(111, 24);
            lblClassName.TabIndex = 4;
            lblClassName.Text = "Class Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 348);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // grpCancelDetails
            // 
            grpCancelDetails.Controls.Add(txtRoom);
            grpCancelDetails.Controls.Add(lblRoom);
            grpCancelDetails.Controls.Add(txtPrice);
            grpCancelDetails.Controls.Add(txtTime);
            grpCancelDetails.Controls.Add(lblTime);
            grpCancelDetails.Controls.Add(lblPrice);
            grpCancelDetails.Controls.Add(label7);
            grpCancelDetails.Controls.Add(txtDate);
            grpCancelDetails.Controls.Add(txtInstructor);
            grpCancelDetails.Controls.Add(txtClassName);
            grpCancelDetails.Controls.Add(lblDate);
            grpCancelDetails.Controls.Add(lblInstructor);
            grpCancelDetails.Controls.Add(lblClassName);
            grpCancelDetails.Location = new Point(123, 348);
            grpCancelDetails.Name = "grpCancelDetails";
            grpCancelDetails.Size = new Size(734, 278);
            grpCancelDetails.TabIndex = 6;
            grpCancelDetails.TabStop = false;
            grpCancelDetails.Text = "Class Details";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(488, 178);
            txtRoom.Name = "txtRoom";
            txtRoom.ReadOnly = true;
            txtRoom.Size = new Size(141, 23);
            txtRoom.TabIndex = 16;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(381, 172);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(61, 24);
            lblRoom.TabIndex = 15;
            lblRoom.Text = "Room";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(488, 45);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(141, 23);
            txtPrice.TabIndex = 14;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(488, 112);
            txtTime.Name = "txtTime";
            txtTime.ReadOnly = true;
            txtTime.Size = new Size(141, 23);
            txtTime.TabIndex = 13;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(381, 106);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(53, 24);
            lblTime.TabIndex = 12;
            lblTime.Text = "Time";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(381, 38);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 24);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(338, 38);
            label7.Name = "label7";
            label7.Size = new Size(0, 24);
            label7.TabIndex = 10;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(176, 112);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(141, 23);
            txtDate.TabIndex = 9;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(174, 178);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.ReadOnly = true;
            txtInstructor.Size = new Size(141, 23);
            txtInstructor.TabIndex = 8;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(174, 45);
            txtClassName.Name = "txtClassName";
            txtClassName.ReadOnly = true;
            txtClassName.Size = new Size(141, 23);
            txtClassName.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(27, 106);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 24);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructor.Location = new Point(27, 178);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(86, 24);
            lblInstructor.TabIndex = 5;
            lblInstructor.Text = "Instructor";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(396, 651);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(178, 44);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1042, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // frmCancelClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 728);
            Controls.Add(btnConfirm);
            Controls.Add(grpCancelDetails);
            Controls.Add(label4);
            Controls.Add(dgvCancelClass);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCancelClass";
            Text = "frmCancelClass";
            Load += frmCancelClass_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCancelClass).EndInit();
            grpCancelDetails.ResumeLayout(false);
            grpCancelDetails.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCancelClass;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpCancelDetails;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnConfirm;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}
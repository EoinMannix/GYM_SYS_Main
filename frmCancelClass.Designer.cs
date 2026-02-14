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
            lblSelectCancel = new Label();
            txtSelcetCancel = new TextBox();
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
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblSelectCancel
            // 
            lblSelectCancel.AutoSize = true;
            lblSelectCancel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectCancel.Location = new Point(259, 79);
            lblSelectCancel.Name = "lblSelectCancel";
            lblSelectCancel.Size = new Size(244, 29);
            lblSelectCancel.TabIndex = 1;
            lblSelectCancel.Text = "Select class to cancel";
            // 
            // txtSelcetCancel
            // 
            txtSelcetCancel.Location = new Point(581, 88);
            txtSelcetCancel.Margin = new Padding(3, 4, 3, 4);
            txtSelcetCancel.Name = "txtSelcetCancel";
            txtSelcetCancel.Size = new Size(218, 27);
            txtSelcetCancel.TabIndex = 2;
            // 
            // dgvCancelClass
            // 
            dgvCancelClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCancelClass.Columns.AddRange(new DataGridViewColumn[] { clmClassID, clmClassName, clmInstructorName, clmDate, clmTime });
            dgvCancelClass.Location = new Point(254, 182);
            dgvCancelClass.Margin = new Padding(3, 4, 3, 4);
            dgvCancelClass.Name = "dgvCancelClass";
            dgvCancelClass.RowHeadersWidth = 51;
            dgvCancelClass.RowTemplate.Height = 24;
            dgvCancelClass.Size = new Size(659, 240);
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
            lblClassName.Location = new Point(31, 51);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(144, 29);
            lblClassName.TabIndex = 4;
            lblClassName.Text = "Class Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 464);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
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
            grpCancelDetails.Location = new Point(141, 464);
            grpCancelDetails.Margin = new Padding(3, 4, 3, 4);
            grpCancelDetails.Name = "grpCancelDetails";
            grpCancelDetails.Padding = new Padding(3, 4, 3, 4);
            grpCancelDetails.Size = new Size(839, 371);
            grpCancelDetails.TabIndex = 6;
            grpCancelDetails.TabStop = false;
            grpCancelDetails.Text = "Class Details";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(558, 238);
            txtRoom.Margin = new Padding(3, 4, 3, 4);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(161, 27);
            txtRoom.TabIndex = 16;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(435, 229);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(78, 29);
            lblRoom.TabIndex = 15;
            lblRoom.Text = "Room";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(558, 60);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(161, 27);
            txtPrice.TabIndex = 14;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(558, 150);
            txtTime.Margin = new Padding(3, 4, 3, 4);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(161, 27);
            txtTime.TabIndex = 13;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(435, 141);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(69, 29);
            lblTime.TabIndex = 12;
            lblTime.Text = "Time";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(435, 51);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 29);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(386, 51);
            label7.Name = "label7";
            label7.Size = new Size(0, 29);
            label7.TabIndex = 10;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(201, 150);
            txtDate.Margin = new Padding(3, 4, 3, 4);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(161, 27);
            txtDate.TabIndex = 9;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(199, 238);
            txtInstructor.Margin = new Padding(3, 4, 3, 4);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(161, 27);
            txtInstructor.TabIndex = 8;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(199, 60);
            txtClassName.Margin = new Padding(3, 4, 3, 4);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(161, 27);
            txtClassName.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(31, 141);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(63, 29);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructor.Location = new Point(31, 238);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(111, 29);
            lblInstructor.TabIndex = 5;
            lblInstructor.Text = "Instructor";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(452, 868);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(204, 59);
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
            menuStrip1.Size = new Size(1191, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // frmCancelClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 970);
            Controls.Add(btnConfirm);
            Controls.Add(grpCancelDetails);
            Controls.Add(label4);
            Controls.Add(dgvCancelClass);
            Controls.Add(txtSelcetCancel);
            Controls.Add(lblSelectCancel);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label lblSelectCancel;
        private System.Windows.Forms.TextBox txtSelcetCancel;
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
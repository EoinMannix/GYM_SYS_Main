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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectCancel = new System.Windows.Forms.Label();
            this.txtSelcetCancel = new System.Windows.Forms.TextBox();
            this.dgvCancelClass = new System.Windows.Forms.DataGridView();
            this.lblClassName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCancelDetails = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.clmClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInstructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelClass)).BeginInit();
            this.grpCancelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // lblSelectCancel
            // 
            this.lblSelectCancel.AutoSize = true;
            this.lblSelectCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCancel.Location = new System.Drawing.Point(259, 63);
            this.lblSelectCancel.Name = "lblSelectCancel";
            this.lblSelectCancel.Size = new System.Drawing.Size(244, 29);
            this.lblSelectCancel.TabIndex = 1;
            this.lblSelectCancel.Text = "Select class to cancel";
            // 
            // txtSelcetCancel
            // 
            this.txtSelcetCancel.Location = new System.Drawing.Point(581, 70);
            this.txtSelcetCancel.Name = "txtSelcetCancel";
            this.txtSelcetCancel.Size = new System.Drawing.Size(218, 22);
            this.txtSelcetCancel.TabIndex = 2;
            // 
            // dgvCancelClass
            // 
            this.dgvCancelClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClassID,
            this.clmClassName,
            this.clmInstructorName,
            this.clmDate,
            this.clmTime});
            this.dgvCancelClass.Location = new System.Drawing.Point(254, 146);
            this.dgvCancelClass.Name = "dgvCancelClass";
            this.dgvCancelClass.RowHeadersWidth = 51;
            this.dgvCancelClass.RowTemplate.Height = 24;
            this.dgvCancelClass.Size = new System.Drawing.Size(659, 192);
            this.dgvCancelClass.TabIndex = 3;
            this.dgvCancelClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancelClass_CellClick);
            this.dgvCancelClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancelClass_CellClick);
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(31, 41);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(144, 29);
            this.lblClassName.TabIndex = 4;
            this.lblClassName.Text = "Class Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // grpCancelDetails
            // 
            this.grpCancelDetails.Controls.Add(this.txtRoom);
            this.grpCancelDetails.Controls.Add(this.lblRoom);
            this.grpCancelDetails.Controls.Add(this.txtPrice);
            this.grpCancelDetails.Controls.Add(this.txtTime);
            this.grpCancelDetails.Controls.Add(this.lblTime);
            this.grpCancelDetails.Controls.Add(this.lblPrice);
            this.grpCancelDetails.Controls.Add(this.label7);
            this.grpCancelDetails.Controls.Add(this.txtDate);
            this.grpCancelDetails.Controls.Add(this.txtInstructor);
            this.grpCancelDetails.Controls.Add(this.txtClassName);
            this.grpCancelDetails.Controls.Add(this.lblDate);
            this.grpCancelDetails.Controls.Add(this.lblInstructor);
            this.grpCancelDetails.Controls.Add(this.lblClassName);
            this.grpCancelDetails.Location = new System.Drawing.Point(141, 371);
            this.grpCancelDetails.Name = "grpCancelDetails";
            this.grpCancelDetails.Size = new System.Drawing.Size(839, 297);
            this.grpCancelDetails.TabIndex = 6;
            this.grpCancelDetails.TabStop = false;
            this.grpCancelDetails.Text = "Class Details";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(558, 48);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(161, 22);
            this.txtPrice.TabIndex = 14;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(558, 120);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(161, 22);
            this.txtTime.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(435, 113);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 29);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(435, 41);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 29);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 29);
            this.label7.TabIndex = 10;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(201, 120);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(161, 22);
            this.txtDate.TabIndex = 9;
            // 
            // txtInstructor
            // 
            this.txtInstructor.Location = new System.Drawing.Point(199, 190);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(161, 22);
            this.txtInstructor.TabIndex = 8;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(199, 48);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(161, 22);
            this.txtClassName.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(31, 113);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 29);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(31, 190);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(111, 29);
            this.lblInstructor.TabIndex = 5;
            this.lblInstructor.Text = "Instructor";
            // 
            // clmClassID
            // 
            this.clmClassID.HeaderText = "Class ID";
            this.clmClassID.MinimumWidth = 6;
            this.clmClassID.Name = "clmClassID";
            this.clmClassID.Width = 125;
            // 
            // clmClassName
            // 
            this.clmClassName.HeaderText = "Class Name";
            this.clmClassName.MinimumWidth = 6;
            this.clmClassName.Name = "clmClassName";
            this.clmClassName.Width = 125;
            // 
            // clmInstructorName
            // 
            this.clmInstructorName.HeaderText = "Instructor Name";
            this.clmInstructorName.MinimumWidth = 6;
            this.clmInstructorName.Name = "clmInstructorName";
            this.clmInstructorName.Width = 125;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.MinimumWidth = 6;
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 125;
            // 
            // clmTime
            // 
            this.clmTime.HeaderText = "Time";
            this.clmTime.MinimumWidth = 6;
            this.clmTime.Name = "clmTime";
            this.clmTime.Width = 125;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(435, 183);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(98, 36);
            this.lblRoom.TabIndex = 15;
            this.lblRoom.Text = "Room";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(558, 190);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(161, 22);
            this.txtRoom.TabIndex = 16;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(452, 694);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(204, 47);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // frmCancelClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 776);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpCancelDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCancelClass);
            this.Controls.Add(this.txtSelcetCancel);
            this.Controls.Add(this.lblSelectCancel);
            this.Controls.Add(this.label1);
            this.Name = "frmCancelClass";
            this.Text = "frmCancelClass";
            this.Load += new System.EventHandler(this.frmCancelClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelClass)).EndInit();
            this.grpCancelDetails.ResumeLayout(false);
            this.grpCancelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
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
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.dgvCreateBooking = new System.Windows.Forms.DataGridView();
            this.txtSelectClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.grpCreateBooking = new System.Windows.Forms.GroupBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.clmClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInstructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateBooking)).BeginInit();
            this.grpCreateBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClass.Location = new System.Drawing.Point(57, 42);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(147, 29);
            this.lblSelectClass.TabIndex = 1;
            this.lblSelectClass.Text = "Select Class";
            // 
            // dgvCreateBooking
            // 
            this.dgvCreateBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreateBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClassID,
            this.clmClassName,
            this.clmInstructorName,
            this.clmDate,
            this.clmTime});
            this.dgvCreateBooking.Location = new System.Drawing.Point(223, 102);
            this.dgvCreateBooking.Name = "dgvCreateBooking";
            this.dgvCreateBooking.RowHeadersWidth = 51;
            this.dgvCreateBooking.RowTemplate.Height = 24;
            this.dgvCreateBooking.Size = new System.Drawing.Size(677, 167);
            this.dgvCreateBooking.TabIndex = 2;
            this.dgvCreateBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreateBooking_CellClick);
            this.dgvCreateBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreateBooking_CellClick);
            // 
            // txtSelectClass
            // 
            this.txtSelectClass.Location = new System.Drawing.Point(282, 49);
            this.txtSelectClass.Name = "txtSelectClass";
            this.txtSelectClass.Size = new System.Drawing.Size(191, 22);
            this.txtSelectClass.TabIndex = 3;
            this.txtSelectClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectClass_KeyDown);
            this.txtSelectClass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSelectClass_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(597, 42);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 29);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(785, 49);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(256, 22);
            this.txtBalance.TabIndex = 6;
            // 
            // grpCreateBooking
            // 
            this.grpCreateBooking.Controls.Add(this.txtDate);
            this.grpCreateBooking.Controls.Add(this.lblDate);
            this.grpCreateBooking.Controls.Add(this.txtRoom);
            this.grpCreateBooking.Controls.Add(this.txtPrice);
            this.grpCreateBooking.Controls.Add(this.txtInstructor);
            this.grpCreateBooking.Controls.Add(this.txtTime);
            this.grpCreateBooking.Controls.Add(this.txtClassName);
            this.grpCreateBooking.Controls.Add(this.lblRoom);
            this.grpCreateBooking.Controls.Add(this.lblPrice);
            this.grpCreateBooking.Controls.Add(this.lblInstructor);
            this.grpCreateBooking.Controls.Add(this.lblTime);
            this.grpCreateBooking.Controls.Add(this.lblClassName);
            this.grpCreateBooking.Location = new System.Drawing.Point(73, 275);
            this.grpCreateBooking.Name = "grpCreateBooking";
            this.grpCreateBooking.Size = new System.Drawing.Size(968, 290);
            this.grpCreateBooking.TabIndex = 7;
            this.grpCreateBooking.TabStop = false;
            this.grpCreateBooking.Text = "Booking Details";
            this.grpCreateBooking.Enter += new System.EventHandler(this.grpCreateBooking_Enter);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(513, 218);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(78, 29);
            this.lblRoom.TabIndex = 16;
            this.lblRoom.Text = "Room";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(513, 48);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 29);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(31, 218);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(111, 29);
            this.lblInstructor.TabIndex = 12;
            this.lblInstructor.Text = "Instructor";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(513, 129);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 29);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(31, 48);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(180, 36);
            this.lblClassName.TabIndex = 8;
            this.lblClassName.Text = "Class Name";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(228, 55);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(200, 22);
            this.txtClassName.TabIndex = 17;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(659, 136);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 22);
            this.txtTime.TabIndex = 18;
            // 
            // txtInstructor
            // 
            this.txtInstructor.Location = new System.Drawing.Point(228, 225);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(200, 22);
            this.txtInstructor.TabIndex = 19;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(659, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 20;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(659, 222);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(200, 22);
            this.txtRoom.TabIndex = 21;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(31, 129);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 36);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(228, 136);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 22);
            this.txtDate.TabIndex = 23;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(414, 597);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(204, 47);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // frmCreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 678);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpCreateBooking);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelectClass);
            this.Controls.Add(this.dgvCreateBooking);
            this.Controls.Add(this.lblSelectClass);
            this.Name = "frmCreateBooking";
            this.Text = "frmCreateBooking";
            this.Load += new System.EventHandler(this.frmCreateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateBooking)).EndInit();
            this.grpCreateBooking.ResumeLayout(false);
            this.grpCreateBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
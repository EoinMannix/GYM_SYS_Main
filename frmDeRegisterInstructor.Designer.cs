namespace GYMSYS
{
    partial class frmDeRegisterInstructor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInstructorName = new System.Windows.Forms.Label();
            this.grpDeRegisterInstructor = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lsbGender = new System.Windows.Forms.ListBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnterInstructorName = new System.Windows.Forms.TextBox();
            this.dvgDeRegisterInstructor = new System.Windows.Forms.DataGridView();
            this.clmMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.grpDeRegisterInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeRegisterInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // lblInstructorName
            // 
            this.lblInstructorName.AutoSize = true;
            this.lblInstructorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorName.Location = new System.Drawing.Point(228, 27);
            this.lblInstructorName.Name = "lblInstructorName";
            this.lblInstructorName.Size = new System.Drawing.Size(239, 32);
            this.lblInstructorName.TabIndex = 1;
            this.lblInstructorName.Text = "Enter Instructor Name";
            this.lblInstructorName.UseCompatibleTextRendering = true;
            // 
            // grpDeRegisterInstructor
            // 
            this.grpDeRegisterInstructor.Controls.Add(this.dateTimePicker);
            this.grpDeRegisterInstructor.Controls.Add(this.lsbGender);
            this.grpDeRegisterInstructor.Controls.Add(this.txtPhone);
            this.grpDeRegisterInstructor.Controls.Add(this.txtEmail);
            this.grpDeRegisterInstructor.Controls.Add(this.txtSurname);
            this.grpDeRegisterInstructor.Controls.Add(this.txtForename);
            this.grpDeRegisterInstructor.Controls.Add(this.lblGender);
            this.grpDeRegisterInstructor.Controls.Add(this.lblPhone);
            this.grpDeRegisterInstructor.Controls.Add(this.lblEmail);
            this.grpDeRegisterInstructor.Controls.Add(this.lblDOB);
            this.grpDeRegisterInstructor.Controls.Add(this.lblSurname);
            this.grpDeRegisterInstructor.Controls.Add(this.lblForename);
            this.grpDeRegisterInstructor.Location = new System.Drawing.Point(116, 229);
            this.grpDeRegisterInstructor.Name = "grpDeRegisterInstructor";
            this.grpDeRegisterInstructor.Size = new System.Drawing.Size(867, 282);
            this.grpDeRegisterInstructor.TabIndex = 2;
            this.grpDeRegisterInstructor.TabStop = false;
            this.grpDeRegisterInstructor.Text = "De-Register an Instructor";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(235, 211);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker.TabIndex = 11;
            // 
            // lsbGender
            // 
            this.lsbGender.FormattingEnabled = true;
            this.lsbGender.ItemHeight = 16;
            this.lsbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.lsbGender.Location = new System.Drawing.Point(648, 215);
            this.lsbGender.Name = "lsbGender";
            this.lsbGender.Size = new System.Drawing.Size(167, 20);
            this.lsbGender.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(648, 136);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(167, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(648, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(236, 136);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(167, 22);
            this.txtSurname.TabIndex = 7;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(236, 56);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(167, 22);
            this.txtForename.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(441, 206);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(94, 29);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(441, 129);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(176, 29);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(441, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 29);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(39, 206);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(144, 29);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(39, 129);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(124, 29);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surename";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(39, 49);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(124, 29);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 5;
            // 
            // txtEnterInstructorName
            // 
            this.txtEnterInstructorName.Location = new System.Drawing.Point(511, 31);
            this.txtEnterInstructorName.Name = "txtEnterInstructorName";
            this.txtEnterInstructorName.Size = new System.Drawing.Size(231, 22);
            this.txtEnterInstructorName.TabIndex = 6;
            this.txtEnterInstructorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnterInstructorName_KeyDown);
            // 
            // dvgDeRegisterInstructor
            // 
            this.dvgDeRegisterInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDeRegisterInstructor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMemberID,
            this.clmName,
            this.clmPhone,
            this.clmEmail});
            this.dvgDeRegisterInstructor.Location = new System.Drawing.Point(301, 73);
            this.dvgDeRegisterInstructor.Name = "dvgDeRegisterInstructor";
            this.dvgDeRegisterInstructor.RowHeadersWidth = 51;
            this.dvgDeRegisterInstructor.RowTemplate.Height = 24;
            this.dvgDeRegisterInstructor.Size = new System.Drawing.Size(551, 150);
            this.dvgDeRegisterInstructor.TabIndex = 4;
            this.dvgDeRegisterInstructor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDeRegisterInstructor_CellClick);
            this.dvgDeRegisterInstructor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmMemberID
            // 
            this.clmMemberID.HeaderText = "MemberID";
            this.clmMemberID.MinimumWidth = 6;
            this.clmMemberID.Name = "clmMemberID";
            this.clmMemberID.Width = 125;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.Width = 125;
            // 
            // clmPhone
            // 
            this.clmPhone.HeaderText = "Phone";
            this.clmPhone.MinimumWidth = 6;
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.Width = 125;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.MinimumWidth = 6;
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.Width = 125;
            // 
            // frmDeRegisterInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 629);
            this.Controls.Add(this.txtEnterInstructorName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dvgDeRegisterInstructor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpDeRegisterInstructor);
            this.Controls.Add(this.lblInstructorName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDeRegisterInstructor";
            this.Text = "De-register Instructor";
            this.Load += new System.EventHandler(this.frmDeRegisterInstructor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDeRegisterInstructor.ResumeLayout(false);
            this.grpDeRegisterInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeRegisterInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblInstructorName;
        private System.Windows.Forms.GroupBox grpDeRegisterInstructor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox lsbGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnterInstructorName;
        private System.Windows.Forms.DataGridView dvgDeRegisterInstructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
    }
}
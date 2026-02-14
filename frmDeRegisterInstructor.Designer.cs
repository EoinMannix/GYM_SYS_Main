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
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            lblInstructorName = new Label();
            grpDeRegisterInstructor = new GroupBox();
            dateTimePicker = new DateTimePicker();
            lsbGender = new ListBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtForename = new TextBox();
            lblGender = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblDOB = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            button1 = new Button();
            label8 = new Label();
            txtEnterInstructorName = new TextBox();
            dvgDeRegisterInstructor = new DataGridView();
            clmMemberID = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmPhone = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            grpDeRegisterInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDeRegisterInstructor).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1065, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // lblInstructorName
            // 
            lblInstructorName.AutoSize = true;
            lblInstructorName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructorName.Location = new Point(228, 34);
            lblInstructorName.Name = "lblInstructorName";
            lblInstructorName.Size = new Size(239, 32);
            lblInstructorName.TabIndex = 1;
            lblInstructorName.Text = "Enter Instructor Name";
            lblInstructorName.UseCompatibleTextRendering = true;
            // 
            // grpDeRegisterInstructor
            // 
            grpDeRegisterInstructor.Controls.Add(dateTimePicker);
            grpDeRegisterInstructor.Controls.Add(lsbGender);
            grpDeRegisterInstructor.Controls.Add(txtPhone);
            grpDeRegisterInstructor.Controls.Add(txtEmail);
            grpDeRegisterInstructor.Controls.Add(txtSurname);
            grpDeRegisterInstructor.Controls.Add(txtForename);
            grpDeRegisterInstructor.Controls.Add(lblGender);
            grpDeRegisterInstructor.Controls.Add(lblPhone);
            grpDeRegisterInstructor.Controls.Add(lblEmail);
            grpDeRegisterInstructor.Controls.Add(lblDOB);
            grpDeRegisterInstructor.Controls.Add(lblSurname);
            grpDeRegisterInstructor.Controls.Add(lblForename);
            grpDeRegisterInstructor.Location = new Point(116, 286);
            grpDeRegisterInstructor.Margin = new Padding(3, 4, 3, 4);
            grpDeRegisterInstructor.Name = "grpDeRegisterInstructor";
            grpDeRegisterInstructor.Padding = new Padding(3, 4, 3, 4);
            grpDeRegisterInstructor.Size = new Size(867, 352);
            grpDeRegisterInstructor.TabIndex = 2;
            grpDeRegisterInstructor.TabStop = false;
            grpDeRegisterInstructor.Text = "De-Register an Instructor";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(235, 264);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(168, 27);
            dateTimePicker.TabIndex = 11;
            // 
            // lsbGender
            // 
            lsbGender.FormattingEnabled = true;
            lsbGender.Items.AddRange(new object[] { "Male", "Female" });
            lsbGender.Location = new Point(648, 269);
            lsbGender.Margin = new Padding(3, 4, 3, 4);
            lsbGender.Name = "lsbGender";
            lsbGender.Size = new Size(167, 24);
            lsbGender.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(648, 170);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(167, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(648, 70);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(167, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(236, 170);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(167, 27);
            txtSurname.TabIndex = 7;
            // 
            // txtForename
            // 
            txtForename.Location = new Point(236, 70);
            txtForename.Margin = new Padding(3, 4, 3, 4);
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(167, 27);
            txtForename.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(441, 258);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(94, 29);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(441, 161);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(176, 29);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(441, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 29);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(39, 258);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 29);
            lblDOB.TabIndex = 2;
            lblDOB.Text = "Date of Birth";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSurname.Location = new Point(39, 161);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(124, 29);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Surename";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForename.Location = new Point(39, 61);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(124, 29);
            lblForename.TabIndex = 0;
            lblForename.Text = "Forename";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(475, 672);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(176, 51);
            button1.TabIndex = 3;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(505, 54);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 5;
            // 
            // txtEnterInstructorName
            // 
            txtEnterInstructorName.Location = new Point(511, 39);
            txtEnterInstructorName.Margin = new Padding(3, 4, 3, 4);
            txtEnterInstructorName.Name = "txtEnterInstructorName";
            txtEnterInstructorName.Size = new Size(231, 27);
            txtEnterInstructorName.TabIndex = 6;
            txtEnterInstructorName.KeyDown += txtEnterInstructorName_KeyDown;
            // 
            // dvgDeRegisterInstructor
            // 
            dvgDeRegisterInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDeRegisterInstructor.Columns.AddRange(new DataGridViewColumn[] { clmMemberID, clmName, clmPhone, clmEmail });
            dvgDeRegisterInstructor.Location = new Point(301, 91);
            dvgDeRegisterInstructor.Margin = new Padding(3, 4, 3, 4);
            dvgDeRegisterInstructor.Name = "dvgDeRegisterInstructor";
            dvgDeRegisterInstructor.RowHeadersWidth = 51;
            dvgDeRegisterInstructor.RowTemplate.Height = 24;
            dvgDeRegisterInstructor.Size = new Size(551, 188);
            dvgDeRegisterInstructor.TabIndex = 4;
            dvgDeRegisterInstructor.CellClick += dvgDeRegisterInstructor_CellClick;
            dvgDeRegisterInstructor.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clmMemberID
            // 
            clmMemberID.HeaderText = "MemberID";
            clmMemberID.MinimumWidth = 6;
            clmMemberID.Name = "clmMemberID";
            clmMemberID.Width = 125;
            // 
            // clmName
            // 
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.Width = 125;
            // 
            // clmPhone
            // 
            clmPhone.HeaderText = "Phone";
            clmPhone.MinimumWidth = 6;
            clmPhone.Name = "clmPhone";
            clmPhone.Width = 125;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.MinimumWidth = 6;
            clmEmail.Name = "clmEmail";
            clmEmail.Width = 125;
            // 
            // frmDeRegisterInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 786);
            Controls.Add(txtEnterInstructorName);
            Controls.Add(label8);
            Controls.Add(dvgDeRegisterInstructor);
            Controls.Add(button1);
            Controls.Add(grpDeRegisterInstructor);
            Controls.Add(lblInstructorName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDeRegisterInstructor";
            Text = "De-register Instructor";
            Load += frmDeRegisterInstructor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpDeRegisterInstructor.ResumeLayout(false);
            grpDeRegisterInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDeRegisterInstructor).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
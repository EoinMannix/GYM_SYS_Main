namespace GYMSYS
{
    partial class frmeditInstructor
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
            dgvEditInstructors = new DataGridView();
            clmMember = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            grpInstructorDetails = new GroupBox();
            txtWorkdays = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            dtpDOB = new DateTimePicker();
            txtSurname = new TextBox();
            txtForename = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblForename = new Label();
            btnConfirm = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtEnterName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEditInstructors).BeginInit();
            grpInstructorDetails.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEditInstructors
            // 
            dgvEditInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEditInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditInstructors.Columns.AddRange(new DataGridViewColumn[] { clmMember, clmName, Column3, Column1 });
            dgvEditInstructors.Location = new Point(274, 91);
            dgvEditInstructors.Margin = new Padding(3, 4, 3, 4);
            dgvEditInstructors.Name = "dgvEditInstructors";
            dgvEditInstructors.RowHeadersWidth = 51;
            dgvEditInstructors.RowTemplate.Height = 24;
            dgvEditInstructors.Size = new Size(545, 192);
            dgvEditInstructors.TabIndex = 0;
            dgvEditInstructors.CellClick += dgvEditInstructors_CellClick;
            dgvEditInstructors.CellContentClick += dgvInstructors_CellContentClick;
            // 
            // clmMember
            // 
            clmMember.HeaderText = "MemberID";
            clmMember.MinimumWidth = 6;
            clmMember.Name = "clmMember";
            clmMember.Width = 109;
            // 
            // clmName
            // 
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.Width = 78;
            // 
            // Column3
            // 
            Column3.HeaderText = "Phone";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 79;
            // 
            // Column1
            // 
            Column1.HeaderText = "Email";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // grpInstructorDetails
            // 
            grpInstructorDetails.Controls.Add(txtWorkdays);
            grpInstructorDetails.Controls.Add(txtPhone);
            grpInstructorDetails.Controls.Add(txtEmail);
            grpInstructorDetails.Controls.Add(dtpDOB);
            grpInstructorDetails.Controls.Add(txtSurname);
            grpInstructorDetails.Controls.Add(txtForename);
            grpInstructorDetails.Controls.Add(label6);
            grpInstructorDetails.Controls.Add(label5);
            grpInstructorDetails.Controls.Add(label4);
            grpInstructorDetails.Controls.Add(label3);
            grpInstructorDetails.Controls.Add(label2);
            grpInstructorDetails.Controls.Add(lblForename);
            grpInstructorDetails.Location = new Point(119, 294);
            grpInstructorDetails.Margin = new Padding(3, 4, 3, 4);
            grpInstructorDetails.Name = "grpInstructorDetails";
            grpInstructorDetails.Padding = new Padding(3, 4, 3, 4);
            grpInstructorDetails.Size = new Size(839, 351);
            grpInstructorDetails.TabIndex = 1;
            grpInstructorDetails.TabStop = false;
            grpInstructorDetails.Text = "Instructor Details";
            // 
            // txtWorkdays
            // 
            txtWorkdays.Location = new Point(625, 264);
            txtWorkdays.Margin = new Padding(3, 4, 3, 4);
            txtWorkdays.Name = "txtWorkdays";
            txtWorkdays.Size = new Size(176, 27);
            txtWorkdays.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(625, 171);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(176, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(625, 80);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 27);
            txtEmail.TabIndex = 9;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(200, 261);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 27);
            dtpDOB.TabIndex = 8;
            dtpDOB.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(200, 171);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(200, 27);
            txtSurname.TabIndex = 7;
            // 
            // txtForename
            // 
            txtForename.Location = new Point(200, 74);
            txtForename.Margin = new Padding(3, 4, 3, 4);
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(200, 27);
            txtForename.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(438, 252);
            label6.Name = "label6";
            label6.Size = new Size(119, 29);
            label6.TabIndex = 5;
            label6.Text = "Workdays";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(438, 162);
            label5.Name = "label5";
            label5.Size = new Size(176, 29);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(438, 74);
            label4.Name = "label4";
            label4.Size = new Size(74, 29);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 255);
            label3.Name = "label3";
            label3.Size = new Size(73, 29);
            label3.TabIndex = 2;
            label3.Text = "Class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 162);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForename.Location = new Point(46, 71);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(124, 29);
            lblForename.TabIndex = 0;
            lblForename.Text = "Forename";
            lblForename.Click += label1_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(437, 676);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(214, 50);
            btnConfirm.TabIndex = 2;
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
            menuStrip1.Size = new Size(1130, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 38);
            label1.Name = "label1";
            label1.Size = new Size(141, 29);
            label1.TabIndex = 4;
            label1.Text = "Enter Name";
            label1.Click += label1_Click_1;
            // 
            // txtEnterName
            // 
            txtEnterName.Location = new Point(519, 46);
            txtEnterName.Margin = new Padding(3, 4, 3, 4);
            txtEnterName.Name = "txtEnterName";
            txtEnterName.Size = new Size(214, 27);
            txtEnterName.TabIndex = 5;
            txtEnterName.TextChanged += txtEnterName_TextChanged;
            txtEnterName.KeyDown += txtEnterName_KeyDown;
            // 
            // frmeditInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 886);
            Controls.Add(txtEnterName);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(grpInstructorDetails);
            Controls.Add(dgvEditInstructors);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmeditInstructor";
            Text = "Edit Instructor";
            Load += frmeditInstructor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditInstructors).EndInit();
            grpInstructorDetails.ResumeLayout(false);
            grpInstructorDetails.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditInstructors;
        private System.Windows.Forms.GroupBox grpInstructorDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInstructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.TextBox txtWorkdays;
    }
}
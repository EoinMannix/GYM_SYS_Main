namespace GYMSYS
{
    partial class frmCreateMember
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
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            lblFname = new Label();
            lblSname = new Label();
            lblDOB = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblGender = new Label();
            btnConfirm = new Button();
            txtForename = new TextBox();
            txtSurname = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            dtpDOB = new DateTimePicker();
            lstGender = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 44);
            label1.Name = "label1";
            label1.Size = new Size(254, 29);
            label1.TabIndex = 0;
            label1.Text = "Create New Member";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 1;
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
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFname.Location = new Point(58, 128);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(91, 22);
            lblFname.TabIndex = 2;
            lblFname.Text = "Forename";
            // 
            // lblSname
            // 
            lblSname.AutoSize = true;
            lblSname.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSname.Location = new Point(58, 188);
            lblSname.Name = "lblSname";
            lblSname.Size = new Size(92, 22);
            lblSname.TabIndex = 3;
            lblSname.Text = "Surename";
            lblSname.Click += label3_Click;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(58, 246);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(49, 22);
            lblDOB.TabIndex = 4;
            lblDOB.Text = "DOB\r\n";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(58, 303);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 22);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(58, 356);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 22);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(58, 411);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(70, 22);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender";
            lblGender.Click += label7_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(242, 474);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(167, 44);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtForename
            // 
            txtForename.Location = new Point(351, 131);
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(227, 23);
            txtForename.TabIndex = 10;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(351, 188);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(227, 23);
            txtSurname.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(351, 308);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(227, 23);
            txtPhone.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(351, 359);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 23);
            txtEmail.TabIndex = 14;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(351, 249);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(227, 23);
            dtpDOB.TabIndex = 16;
            // 
            // lstGender
            // 
            lstGender.FormattingEnabled = true;
            lstGender.ItemHeight = 15;
            lstGender.Items.AddRange(new object[] { "Male", "Female" });
            lstGender.Location = new Point(351, 411);
            lstGender.Margin = new Padding(3, 2, 3, 2);
            lstGender.Name = "lstGender";
            lstGender.Size = new Size(227, 19);
            lstGender.TabIndex = 18;
            // 
            // frmCreateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 634);
            Controls.Add(lstGender);
            Controls.Add(dtpDOB);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtSurname);
            Controls.Add(txtForename);
            Controls.Add(btnConfirm);
            Controls.Add(lblGender);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblDOB);
            Controls.Add(lblSname);
            Controls.Add(lblFname);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCreateMember";
            Text = "GYMSYS_Create_Member";
            Load += frmCreateMember_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private DateTimePicker dtpDOB;
        private ListBox lstGender;
    }
}
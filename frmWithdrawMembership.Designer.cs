namespace GYMSYS
{
    partial class frmWithdrawMembership
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
            lblEnterMembersName = new Label();
            dgvWithdrawMembership = new DataGridView();
            clmMemberID = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtMemberName = new TextBox();
            groupBox1 = new GroupBox();
            lstGender = new ListBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            dtpDOB = new DateTimePicker();
            txtSurname = new TextBox();
            txtForename = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblForename = new Label();
            btnUpdateWithdraw = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWithdrawMembership).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(948, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // lblEnterMembersName
            // 
            lblEnterMembersName.AutoSize = true;
            lblEnterMembersName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterMembersName.Location = new Point(172, 72);
            lblEnterMembersName.Name = "lblEnterMembersName";
            lblEnterMembersName.Size = new Size(196, 24);
            lblEnterMembersName.TabIndex = 1;
            lblEnterMembersName.Text = "Enter Members Name";
            // 
            // dgvWithdrawMembership
            // 
            dgvWithdrawMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWithdrawMembership.Columns.AddRange(new DataGridViewColumn[] { clmMemberID, clmName, clmEmail, Column4 });
            dgvWithdrawMembership.Location = new Point(176, 135);
            dgvWithdrawMembership.MultiSelect = false;
            dgvWithdrawMembership.Name = "dgvWithdrawMembership";
            dgvWithdrawMembership.RowHeadersWidth = 51;
            dgvWithdrawMembership.RowTemplate.Height = 24;
            dgvWithdrawMembership.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWithdrawMembership.Size = new Size(485, 164);
            dgvWithdrawMembership.TabIndex = 2;
            dgvWithdrawMembership.CellContentClick += dgvWithdrawMembership_CellClick;
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
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.MinimumWidth = 6;
            clmEmail.Name = "clmEmail";
            clmEmail.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(421, 79);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(225, 23);
            txtMemberName.TabIndex = 3;
            txtMemberName.TextChanged += txtMemberName_TextChanged;
            txtMemberName.KeyDown += txtEnterName_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstGender);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtForename);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblForename);
            groupBox1.Location = new Point(77, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 202);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Member Details";
            // 
            // lstGender
            // 
            lstGender.FormattingEnabled = true;
            lstGender.ItemHeight = 15;
            lstGender.Items.AddRange(new object[] { "Male", "Female" });
            lstGender.Location = new Point(563, 158);
            lstGender.Name = "lstGender";
            lstGender.Size = new Size(139, 19);
            lstGender.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(563, 94);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(139, 23);
            txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(563, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 9;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(201, 157);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(139, 23);
            dtpDOB.TabIndex = 8;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(201, 100);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(139, 23);
            txtSurname.TabIndex = 7;
            // 
            // txtForename
            // 
            txtForename.Location = new Point(201, 44);
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(139, 23);
            txtForename.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(374, 150);
            label5.Name = "label5";
            label5.Size = new Size(74, 24);
            label5.TabIndex = 5;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(374, 94);
            label4.Name = "label4";
            label4.Size = new Size(140, 24);
            label4.TabIndex = 4;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(374, 37);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 150);
            label2.Name = "label2";
            label2.Size = new Size(110, 24);
            label2.TabIndex = 2;
            label2.Text = "Date of Birth";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 94);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 1;
            label1.Text = "Surename";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForename.Location = new Point(49, 37);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(98, 24);
            lblForename.TabIndex = 0;
            lblForename.Text = "Forename";
            // 
            // btnUpdateWithdraw
            // 
            btnUpdateWithdraw.Location = new Point(381, 522);
            btnUpdateWithdraw.Name = "btnUpdateWithdraw";
            btnUpdateWithdraw.Size = new Size(152, 42);
            btnUpdateWithdraw.TabIndex = 5;
            btnUpdateWithdraw.Text = "Update";
            btnUpdateWithdraw.UseVisualStyleBackColor = true;
            btnUpdateWithdraw.Click += btnUpdateWithdraw_Click;
            // 
            // frmWithdrawMembership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 589);
            Controls.Add(btnUpdateWithdraw);
            Controls.Add(groupBox1);
            Controls.Add(txtMemberName);
            Controls.Add(dgvWithdrawMembership);
            Controls.Add(lblEnterMembersName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmWithdrawMembership";
            Text = "frmWithdrawMembership";
            Load += frmWithdrawMembership_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWithdrawMembership).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblEnterMembersName;
        private System.Windows.Forms.DataGridView dgvWithdrawMembership;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateWithdraw;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ListBox lstGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
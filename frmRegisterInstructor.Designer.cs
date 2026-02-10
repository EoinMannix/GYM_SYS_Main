namespace GYMSYS
{
    partial class frmRegisterInstructor
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
            components = new System.ComponentModel.Container();
            lblForename = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtForename = new TextBox();
            txtSurname = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtGender = new TextBox();
            lblRegisterInstrructor = new Label();
            btnConfirm = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            dtpDOB = new DateTimePicker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForename.Location = new Point(66, 121);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(124, 29);
            lblForename.TabIndex = 0;
            lblForename.Text = "Forename";
            lblForename.Click += lblForename_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 470);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 1;
            label2.Text = "Gender";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 401);
            label3.Name = "label3";
            label3.Size = new Size(72, 29);
            label3.TabIndex = 2;
            label3.Text = "email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 266);
            label4.Name = "label4";
            label4.Size = new Size(65, 29);
            label4.TabIndex = 3;
            label4.Text = "DOB";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 196);
            label5.Name = "label5";
            label5.Size = new Size(124, 29);
            label5.TabIndex = 4;
            label5.Text = "Surename";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 332);
            label6.Name = "label6";
            label6.Size = new Size(83, 29);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            label6.Click += label6_Click;
            // 
            // txtForename
            // 
            txtForename.Location = new Point(279, 130);
            txtForename.Margin = new Padding(3, 4, 3, 4);
            txtForename.Name = "txtForename";
            txtForename.Size = new Size(240, 27);
            txtForename.TabIndex = 6;
            txtForename.TextChanged += txtForename_TextChanged;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(279, 205);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(240, 27);
            txtSurname.TabIndex = 7;
            txtSurname.TextChanged += textBox2_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(279, 341);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 27);
            txtPhone.TabIndex = 9;
            txtPhone.TextChanged += textBox4_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(279, 410);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 27);
            txtEmail.TabIndex = 10;
            txtEmail.TextChanged += textBox5_TextChanged;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(279, 479);
            txtGender.Margin = new Padding(3, 4, 3, 4);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(240, 27);
            txtGender.TabIndex = 11;
            txtGender.TextChanged += textBox6_TextChanged;
            // 
            // lblRegisterInstrructor
            // 
            lblRegisterInstrructor.AutoSize = true;
            lblRegisterInstrructor.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterInstrructor.Location = new Point(215, 35);
            lblRegisterInstrructor.Name = "lblRegisterInstrructor";
            lblRegisterInstrructor.Size = new Size(322, 36);
            lblRegisterInstrructor.TabIndex = 12;
            lblRegisterInstrructor.Text = "Register an Instructor";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(279, 532);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(240, 59);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confim";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(279, 278);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(240, 27);
            dtpDOB.TabIndex = 15;
            // 
            // frmRegisterInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 630);
            Controls.Add(dtpDOB);
            Controls.Add(btnConfirm);
            Controls.Add(lblRegisterInstrructor);
            Controls.Add(txtGender);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtSurname);
            Controls.Add(txtForename);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblForename);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegisterInstructor";
            Text = "Register Instructor";
            Load += frmRegInstructor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblRegisterInstrructor;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DateTimePicker dtpDOB;
    }
}
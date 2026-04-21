namespace GYMSYS
{
    partial class frmAddFunds
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
            lblCurrentBalance = new Label();
            groupBox1 = new GroupBox();
            txtMemberID = new TextBox();
            radioButton80 = new RadioButton();
            radioButton40 = new RadioButton();
            radioButton20 = new RadioButton();
            radioButton10 = new RadioButton();
            txtCardNumber = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtCVV = new TextBox();
            lblCVV = new Label();
            txtNameOnCard = new TextBox();
            txtAmountToAdd = new Label();
            lblExpireyDate = new Label();
            lblCardNumber = new Label();
            lblMemberID = new Label();
            lblNameOnCard = new Label();
            txtCurrentBalance = new TextBox();
            btnConfirm_Click = new Button();
            menuStrip1.SuspendLayout();
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
            menuStrip1.Size = new Size(844, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBalance.Location = new Point(210, 61);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(186, 24);
            lblCurrentBalance.TabIndex = 1;
            lblCurrentBalance.Text = "Your current balance";
            lblCurrentBalance.Click += lblCurrentBalance_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMemberID);
            groupBox1.Controls.Add(radioButton80);
            groupBox1.Controls.Add(radioButton40);
            groupBox1.Controls.Add(radioButton20);
            groupBox1.Controls.Add(radioButton10);
            groupBox1.Controls.Add(txtCardNumber);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtCVV);
            groupBox1.Controls.Add(lblCVV);
            groupBox1.Controls.Add(txtNameOnCard);
            groupBox1.Controls.Add(txtAmountToAdd);
            groupBox1.Controls.Add(lblExpireyDate);
            groupBox1.Controls.Add(lblCardNumber);
            groupBox1.Controls.Add(lblMemberID);
            groupBox1.Controls.Add(lblNameOnCard);
            groupBox1.Location = new Point(81, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 337);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Payment Details";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(211, 41);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(175, 23);
            txtMemberID.TabIndex = 26;
            // 
            // radioButton80
            // 
            radioButton80.AutoSize = true;
            radioButton80.Location = new Point(434, 270);
            radioButton80.Name = "radioButton80";
            radioButton80.Size = new Size(43, 19);
            radioButton80.TabIndex = 25;
            radioButton80.TabStop = true;
            radioButton80.Text = "£80";
            radioButton80.UseVisualStyleBackColor = true;
            // 
            // radioButton40
            // 
            radioButton40.AutoSize = true;
            radioButton40.Location = new Point(365, 270);
            radioButton40.Name = "radioButton40";
            radioButton40.Size = new Size(43, 19);
            radioButton40.TabIndex = 24;
            radioButton40.TabStop = true;
            radioButton40.Text = "£40";
            radioButton40.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            radioButton20.AutoSize = true;
            radioButton20.Location = new Point(296, 270);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(43, 19);
            radioButton20.TabIndex = 23;
            radioButton20.TabStop = true;
            radioButton20.Text = "£20";
            radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(234, 270);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(43, 19);
            radioButton10.TabIndex = 22;
            radioButton10.TabStop = true;
            radioButton10.Text = "£10";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(211, 145);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(175, 23);
            txtCardNumber.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(211, 205);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(489, 145);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(109, 23);
            txtCVV.TabIndex = 19;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCVV.Location = new Point(416, 145);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(49, 24);
            lblCVV.TabIndex = 18;
            lblCVV.Text = "CVV";
            // 
            // txtNameOnCard
            // 
            txtNameOnCard.Location = new Point(211, 93);
            txtNameOnCard.Name = "txtNameOnCard";
            txtNameOnCard.Size = new Size(314, 23);
            txtNameOnCard.TabIndex = 17;
            // 
            // txtAmountToAdd
            // 
            txtAmountToAdd.AutoSize = true;
            txtAmountToAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountToAdd.Location = new Point(36, 270);
            txtAmountToAdd.Name = "txtAmountToAdd";
            txtAmountToAdd.Size = new Size(144, 24);
            txtAmountToAdd.TabIndex = 16;
            txtAmountToAdd.Text = "Amount To Add";
            // 
            // lblExpireyDate
            // 
            lblExpireyDate.AutoSize = true;
            lblExpireyDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpireyDate.Location = new Point(36, 204);
            lblExpireyDate.Name = "lblExpireyDate";
            lblExpireyDate.Size = new Size(123, 24);
            lblExpireyDate.TabIndex = 15;
            lblExpireyDate.Text = "Expirery Date";
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardNumber.Location = new Point(36, 145);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(124, 24);
            lblCardNumber.TabIndex = 14;
            lblCardNumber.Text = "Card Number";
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemberID.Location = new Point(36, 41);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(98, 24);
            lblMemberID.TabIndex = 13;
            lblMemberID.Text = "MemberID";
            // 
            // lblNameOnCard
            // 
            lblNameOnCard.AutoSize = true;
            lblNameOnCard.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameOnCard.Location = new Point(36, 93);
            lblNameOnCard.Name = "lblNameOnCard";
            lblNameOnCard.Size = new Size(137, 24);
            lblNameOnCard.TabIndex = 13;
            lblNameOnCard.Text = "Name On Card";
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(478, 67);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.ReadOnly = true;
            txtCurrentBalance.Size = new Size(88, 23);
            txtCurrentBalance.TabIndex = 3;
            txtCurrentBalance.TextChanged += txtCurrentBalance_TextChanged;
            // 
            // btnConfirm_Click
            // 
            btnConfirm_Click.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm_Click.Location = new Point(302, 486);
            btnConfirm_Click.Name = "btnConfirm_Click";
            btnConfirm_Click.Size = new Size(175, 38);
            btnConfirm_Click.TabIndex = 4;
            btnConfirm_Click.Text = "Confirm";
            btnConfirm_Click.UseVisualStyleBackColor = true;
            btnConfirm_Click.Click += button1_Click;
            // 
            // frmAddFunds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 582);
            Controls.Add(btnConfirm_Click);
            Controls.Add(txtCurrentBalance);
            Controls.Add(groupBox1);
            Controls.Add(lblCurrentBalance);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAddFunds";
            Text = "Add Funds";
            Load += frmAddFunds_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Button btnConfirm_Click;
        private TextBox txtMemberID;
        private RadioButton radioButton80;
        private RadioButton radioButton40;
        private RadioButton radioButton20;
        private RadioButton radioButton10;
        private TextBox txtCardNumber;
        private DateTimePicker dateTimePicker1;
        private TextBox txtCVV;
        private Label lblCVV;
        private TextBox txtNameOnCard;
        private Label txtAmountToAdd;
        private Label lblExpireyDate;
        private Label lblCardNumber;
        private Label lblMemberID;
        private Label lblNameOnCard;
    }
}
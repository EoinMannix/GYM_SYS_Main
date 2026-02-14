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
            lblNameOnCard = new Label();
            txtCurrentBalance = new TextBox();
            btnConfirm_Click = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(964, 28);
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
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBalance.Location = new Point(231, 104);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(235, 29);
            lblCurrentBalance.TabIndex = 1;
            lblCurrentBalance.Text = "Your current balance";
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(lblNameOnCard);
            groupBox1.Location = new Point(92, 185);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(727, 369);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Payment Details";
            // 
            // radioButton80
            // 
            radioButton80.AutoSize = true;
            radioButton80.Location = new Point(496, 311);
            radioButton80.Margin = new Padding(3, 4, 3, 4);
            radioButton80.Name = "radioButton80";
            radioButton80.Size = new Size(54, 24);
            radioButton80.TabIndex = 12;
            radioButton80.TabStop = true;
            radioButton80.Text = "£80";
            radioButton80.UseVisualStyleBackColor = true;
            // 
            // radioButton40
            // 
            radioButton40.AutoSize = true;
            radioButton40.Location = new Point(409, 311);
            radioButton40.Margin = new Padding(3, 4, 3, 4);
            radioButton40.Name = "radioButton40";
            radioButton40.Size = new Size(54, 24);
            radioButton40.TabIndex = 11;
            radioButton40.TabStop = true;
            radioButton40.Text = "£40";
            radioButton40.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            radioButton20.AutoSize = true;
            radioButton20.Location = new Point(325, 311);
            radioButton20.Margin = new Padding(3, 4, 3, 4);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(54, 24);
            radioButton20.TabIndex = 10;
            radioButton20.TabStop = true;
            radioButton20.Text = "£20";
            radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(254, 311);
            radioButton10.Margin = new Padding(3, 4, 3, 4);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(54, 24);
            radioButton10.TabIndex = 9;
            radioButton10.TabStop = true;
            radioButton10.Text = "£10";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(226, 138);
            txtCardNumber.Margin = new Padding(3, 4, 3, 4);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(199, 27);
            txtCardNumber.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(226, 226);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(548, 138);
            txtCVV.Margin = new Padding(3, 4, 3, 4);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(124, 27);
            txtCVV.TabIndex = 6;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCVV.Location = new Point(449, 129);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(60, 29);
            lblCVV.TabIndex = 5;
            lblCVV.Text = "CVV";
            // 
            // txtNameOnCard
            // 
            txtNameOnCard.Location = new Point(226, 50);
            txtNameOnCard.Margin = new Padding(3, 4, 3, 4);
            txtNameOnCard.Name = "txtNameOnCard";
            txtNameOnCard.Size = new Size(358, 27);
            txtNameOnCard.TabIndex = 4;
            // 
            // txtAmountToAdd
            // 
            txtAmountToAdd.AutoSize = true;
            txtAmountToAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountToAdd.Location = new Point(26, 301);
            txtAmountToAdd.Name = "txtAmountToAdd";
            txtAmountToAdd.Size = new Size(179, 29);
            txtAmountToAdd.TabIndex = 3;
            txtAmountToAdd.Text = "Amount To Add";
            // 
            // lblExpireyDate
            // 
            lblExpireyDate.AutoSize = true;
            lblExpireyDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpireyDate.Location = new Point(27, 218);
            lblExpireyDate.Name = "lblExpireyDate";
            lblExpireyDate.Size = new Size(157, 29);
            lblExpireyDate.TabIndex = 2;
            lblExpireyDate.Text = "Expirery Date";
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardNumber.Location = new Point(26, 129);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(158, 29);
            lblCardNumber.TabIndex = 1;
            lblCardNumber.Text = "Card Number";
            // 
            // lblNameOnCard
            // 
            lblNameOnCard.AutoSize = true;
            lblNameOnCard.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameOnCard.Location = new Point(26, 41);
            lblNameOnCard.Name = "lblNameOnCard";
            lblNameOnCard.Size = new Size(174, 29);
            lblNameOnCard.TabIndex = 0;
            lblNameOnCard.Text = "Name On Card";
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(537, 112);
            txtCurrentBalance.Margin = new Padding(3, 4, 3, 4);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(100, 27);
            txtCurrentBalance.TabIndex = 3;
            txtCurrentBalance.Text = "£25.50";
            // 
            // btnConfirm_Click
            // 
            btnConfirm_Click.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm_Click.Location = new Point(350, 609);
            btnConfirm_Click.Margin = new Padding(3, 4, 3, 4);
            btnConfirm_Click.Name = "btnConfirm_Click";
            btnConfirm_Click.Size = new Size(200, 51);
            btnConfirm_Click.TabIndex = 4;
            btnConfirm_Click.Text = "Confirm";
            btnConfirm_Click.UseVisualStyleBackColor = true;
            btnConfirm_Click.Click += button1_Click;
            // 
            // frmAddFunds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 706);
            Controls.Add(btnConfirm_Click);
            Controls.Add(txtCurrentBalance);
            Controls.Add(groupBox1);
            Controls.Add(lblCurrentBalance);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.Label txtAmountToAdd;
        private System.Windows.Forms.Label lblExpireyDate;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.RadioButton radioButton40;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton80;
        private System.Windows.Forms.Button btnConfirm_Click;
    }
}
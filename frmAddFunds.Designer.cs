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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton80 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.txtAmountToAdd = new System.Windows.Forms.Label();
            this.lblExpireyDate = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.btnConfirm_Click = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.Location = new System.Drawing.Point(231, 83);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(235, 29);
            this.lblCurrentBalance.TabIndex = 1;
            this.lblCurrentBalance.Text = "Your current balance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton80);
            this.groupBox1.Controls.Add(this.radioButton40);
            this.groupBox1.Controls.Add(this.radioButton20);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.txtCardNumber);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtCVV);
            this.groupBox1.Controls.Add(this.lblCVV);
            this.groupBox1.Controls.Add(this.txtNameOnCard);
            this.groupBox1.Controls.Add(this.txtAmountToAdd);
            this.groupBox1.Controls.Add(this.lblExpireyDate);
            this.groupBox1.Controls.Add(this.lblCardNumber);
            this.groupBox1.Controls.Add(this.lblNameOnCard);
            this.groupBox1.Location = new System.Drawing.Point(92, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Payment Details";
            // 
            // radioButton80
            // 
            this.radioButton80.AutoSize = true;
            this.radioButton80.Location = new System.Drawing.Point(496, 249);
            this.radioButton80.Name = "radioButton80";
            this.radioButton80.Size = new System.Drawing.Size(49, 20);
            this.radioButton80.TabIndex = 12;
            this.radioButton80.TabStop = true;
            this.radioButton80.Text = "£80";
            this.radioButton80.UseVisualStyleBackColor = true;
            // 
            // radioButton40
            // 
            this.radioButton40.AutoSize = true;
            this.radioButton40.Location = new System.Drawing.Point(409, 249);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(49, 20);
            this.radioButton40.TabIndex = 11;
            this.radioButton40.TabStop = true;
            this.radioButton40.Text = "£40";
            this.radioButton40.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(325, 249);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(49, 20);
            this.radioButton20.TabIndex = 10;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "£20";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(254, 249);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(49, 20);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "£10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(226, 110);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(199, 22);
            this.txtCardNumber.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(548, 110);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(124, 22);
            this.txtCVV.TabIndex = 6;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.Location = new System.Drawing.Point(449, 103);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(60, 29);
            this.lblCVV.TabIndex = 5;
            this.lblCVV.Text = "CVV";
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(226, 40);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(358, 22);
            this.txtNameOnCard.TabIndex = 4;
            // 
            // txtAmountToAdd
            // 
            this.txtAmountToAdd.AutoSize = true;
            this.txtAmountToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToAdd.Location = new System.Drawing.Point(26, 241);
            this.txtAmountToAdd.Name = "txtAmountToAdd";
            this.txtAmountToAdd.Size = new System.Drawing.Size(179, 29);
            this.txtAmountToAdd.TabIndex = 3;
            this.txtAmountToAdd.Text = "Amount To Add";
            // 
            // lblExpireyDate
            // 
            this.lblExpireyDate.AutoSize = true;
            this.lblExpireyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireyDate.Location = new System.Drawing.Point(27, 174);
            this.lblExpireyDate.Name = "lblExpireyDate";
            this.lblExpireyDate.Size = new System.Drawing.Size(157, 29);
            this.lblExpireyDate.TabIndex = 2;
            this.lblExpireyDate.Text = "Expirery Date";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(26, 103);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(158, 29);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnCard.Location = new System.Drawing.Point(26, 33);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(174, 29);
            this.lblNameOnCard.TabIndex = 0;
            this.lblNameOnCard.Text = "Name On Card";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Location = new System.Drawing.Point(537, 90);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentBalance.TabIndex = 3;
            this.txtCurrentBalance.Text = "£25.50";
            // 
            // btnConfirm_Click
            // 
            this.btnConfirm_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm_Click.Location = new System.Drawing.Point(350, 487);
            this.btnConfirm_Click.Name = "btnConfirm_Click";
            this.btnConfirm_Click.Size = new System.Drawing.Size(200, 41);
            this.btnConfirm_Click.TabIndex = 4;
            this.btnConfirm_Click.Text = "Confirm";
            this.btnConfirm_Click.UseVisualStyleBackColor = true;
            this.btnConfirm_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 565);
            this.Controls.Add(this.btnConfirm_Click);
            this.Controls.Add(this.txtCurrentBalance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddFunds";
            this.Text = "Add Funds";
            this.Load += new System.EventHandler(this.frmAddFunds_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
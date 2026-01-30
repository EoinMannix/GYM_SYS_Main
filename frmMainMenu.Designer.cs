namespace GYMSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertYearlyRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.alertYearlyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxMainMenu = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructorsToolStripMenuItem,
            this.membersToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(922, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // instructorsToolStripMenuItem
            // 
            this.instructorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerInstructorToolStripMenuItem,
            this.editInToolStripMenuItem,
            this.deRegisterInstructorToolStripMenuItem});
            this.instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            this.instructorsToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.instructorsToolStripMenuItem.Text = "Instructors";
            this.instructorsToolStripMenuItem.Click += new System.EventHandler(this.instructorsToolStripMenuItem_Click);
            // 
            // registerInstructorToolStripMenuItem
            // 
            this.registerInstructorToolStripMenuItem.Name = "registerInstructorToolStripMenuItem";
            this.registerInstructorToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.registerInstructorToolStripMenuItem.Text = "Register Instructor";
            this.registerInstructorToolStripMenuItem.Click += new System.EventHandler(this.registerInstructorToolStripMenuItem_Click);
            // 
            // editInToolStripMenuItem
            // 
            this.editInToolStripMenuItem.Name = "editInToolStripMenuItem";
            this.editInToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.editInToolStripMenuItem.Text = "Edit Instructor";
            this.editInToolStripMenuItem.Click += new System.EventHandler(this.editInToolStripMenuItem_Click);
            // 
            // deRegisterInstructorToolStripMenuItem
            // 
            this.deRegisterInstructorToolStripMenuItem.Name = "deRegisterInstructorToolStripMenuItem";
            this.deRegisterInstructorToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.deRegisterInstructorToolStripMenuItem.Text = "De-Register Instructor";
            this.deRegisterInstructorToolStripMenuItem.Click += new System.EventHandler(this.deRegisterInstructorToolStripMenuItem_Click);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFundsToolStripMenuItem,
            this.withdrawMembershipToolStripMenuItem,
            this.createMemberToolStripMenuItem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // addFundsToolStripMenuItem
            // 
            this.addFundsToolStripMenuItem.Name = "addFundsToolStripMenuItem";
            this.addFundsToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.addFundsToolStripMenuItem.Text = "Add Funds";
            this.addFundsToolStripMenuItem.Click += new System.EventHandler(this.addFundsToolStripMenuItem_Click);
            // 
            // withdrawMembershipToolStripMenuItem
            // 
            this.withdrawMembershipToolStripMenuItem.Name = "withdrawMembershipToolStripMenuItem";
            this.withdrawMembershipToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.withdrawMembershipToolStripMenuItem.Text = "Withdraw Membership";
            this.withdrawMembershipToolStripMenuItem.Click += new System.EventHandler(this.withdrawMembershipToolStripMenuItem_Click);
            // 
            // createMemberToolStripMenuItem
            // 
            this.createMemberToolStripMenuItem.Name = "createMemberToolStripMenuItem";
            this.createMemberToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.createMemberToolStripMenuItem.Text = "Create Member";
            this.createMemberToolStripMenuItem.Click += new System.EventHandler(this.createMemberToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleClassToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // scheduleClassToolStripMenuItem
            // 
            this.scheduleClassToolStripMenuItem.Name = "scheduleClassToolStripMenuItem";
            this.scheduleClassToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.scheduleClassToolStripMenuItem.Text = "Schedule Class";
            this.scheduleClassToolStripMenuItem.Click += new System.EventHandler(this.scheduleClassToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.cancelToolStripMenuItem.Text = "Cancel class";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBookingToolStripMenuItem,
            this.cancelBookingToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            this.bookingsToolStripMenuItem.Click += new System.EventHandler(this.bookingsToolStripMenuItem_Click);
            // 
            // createBookingToolStripMenuItem
            // 
            this.createBookingToolStripMenuItem.Name = "createBookingToolStripMenuItem";
            this.createBookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createBookingToolStripMenuItem.Text = "Create Booking";
            this.createBookingToolStripMenuItem.Click += new System.EventHandler(this.createBookingToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            this.cancelBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelBookingToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertYearlyRevenue,
            this.alertYearlyClass});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // alertYearlyRevenue
            // 
            this.alertYearlyRevenue.Name = "alertYearlyRevenue";
            this.alertYearlyRevenue.Size = new System.Drawing.Size(254, 26);
            this.alertYearlyRevenue.Text = "Yearly revenue analysis";
            this.alertYearlyRevenue.Click += new System.EventHandler(this.yeToolStripMenuItem_Click);
            // 
            // alertYearlyClass
            // 
            this.alertYearlyClass.Name = "alertYearlyClass";
            this.alertYearlyClass.Size = new System.Drawing.Size(254, 26);
            this.alertYearlyClass.Text = "Yearly class type analysis";
            this.alertYearlyClass.Click += new System.EventHandler(this.alertYearlyClass_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBoxMainMenu
            // 
            this.pictureBoxMainMenu.ErrorImage = null;
            this.pictureBoxMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainMenu.Image")));
            this.pictureBoxMainMenu.Location = new System.Drawing.Point(12, 46);
            this.pictureBoxMainMenu.Name = "pictureBoxMainMenu";
            this.pictureBoxMainMenu.Size = new System.Drawing.Size(898, 466);
            this.pictureBoxMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMainMenu.TabIndex = 1;
            this.pictureBoxMainMenu.TabStop = false;
            this.pictureBoxMainMenu.Click += new System.EventHandler(this.pictureBoxMainMenu_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 524);
            this.Controls.Add(this.pictureBoxMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.GYMSYS_Main_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxMainMenu;
        private System.Windows.Forms.ToolStripMenuItem registerInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertYearlyRevenue;
        private System.Windows.Forms.ToolStripMenuItem alertYearlyClass;
    }
}


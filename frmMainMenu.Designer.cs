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
            menuStrip1 = new MenuStrip();
            instructorsToolStripMenuItem = new ToolStripMenuItem();
            registerInstructorToolStripMenuItem = new ToolStripMenuItem();
            editInToolStripMenuItem = new ToolStripMenuItem();
            deRegisterInstructorToolStripMenuItem = new ToolStripMenuItem();
            membersToolStripMenuItem = new ToolStripMenuItem();
            addFundsToolStripMenuItem = new ToolStripMenuItem();
            withdrawMembershipToolStripMenuItem = new ToolStripMenuItem();
            createMemberToolStripMenuItem = new ToolStripMenuItem();
            classesToolStripMenuItem = new ToolStripMenuItem();
            scheduleClassToolStripMenuItem = new ToolStripMenuItem();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            bookingsToolStripMenuItem = new ToolStripMenuItem();
            createBookingToolStripMenuItem = new ToolStripMenuItem();
            cancelBookingToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            alertYearlyRevenue = new ToolStripMenuItem();
            alertYearlyClass = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxMainMenu = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainMenu).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { instructorsToolStripMenuItem, membersToolStripMenuItem, classesToolStripMenuItem, bookingsToolStripMenuItem, adminToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(807, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // instructorsToolStripMenuItem
            // 
            instructorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerInstructorToolStripMenuItem, editInToolStripMenuItem, deRegisterInstructorToolStripMenuItem });
            instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            instructorsToolStripMenuItem.Size = new Size(75, 20);
            instructorsToolStripMenuItem.Text = "Instructors";
            instructorsToolStripMenuItem.Click += instructorsToolStripMenuItem_Click;
            // 
            // registerInstructorToolStripMenuItem
            // 
            registerInstructorToolStripMenuItem.Name = "registerInstructorToolStripMenuItem";
            registerInstructorToolStripMenuItem.Size = new Size(189, 22);
            registerInstructorToolStripMenuItem.Text = "Register Instructor";
            registerInstructorToolStripMenuItem.Click += registerInstructorToolStripMenuItem_Click;
            // 
            // editInToolStripMenuItem
            // 
            editInToolStripMenuItem.Name = "editInToolStripMenuItem";
            editInToolStripMenuItem.Size = new Size(189, 22);
            editInToolStripMenuItem.Text = "Edit Instructor";
            editInToolStripMenuItem.Click += editInToolStripMenuItem_Click;
            // 
            // deRegisterInstructorToolStripMenuItem
            // 
            deRegisterInstructorToolStripMenuItem.Name = "deRegisterInstructorToolStripMenuItem";
            deRegisterInstructorToolStripMenuItem.Size = new Size(189, 22);
            deRegisterInstructorToolStripMenuItem.Text = "De-Register Instructor";
            deRegisterInstructorToolStripMenuItem.Click += deRegisterInstructorToolStripMenuItem_Click;
            // 
            // membersToolStripMenuItem
            // 
            membersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addFundsToolStripMenuItem, withdrawMembershipToolStripMenuItem, createMemberToolStripMenuItem });
            membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            membersToolStripMenuItem.Size = new Size(69, 20);
            membersToolStripMenuItem.Text = "Members";
            // 
            // addFundsToolStripMenuItem
            // 
            addFundsToolStripMenuItem.Name = "addFundsToolStripMenuItem";
            addFundsToolStripMenuItem.Size = new Size(195, 22);
            addFundsToolStripMenuItem.Text = "Add Funds";
            addFundsToolStripMenuItem.Click += addFundsToolStripMenuItem_Click;
            // 
            // withdrawMembershipToolStripMenuItem
            // 
            withdrawMembershipToolStripMenuItem.Name = "withdrawMembershipToolStripMenuItem";
            withdrawMembershipToolStripMenuItem.Size = new Size(195, 22);
            withdrawMembershipToolStripMenuItem.Text = "Withdraw Membership";
            withdrawMembershipToolStripMenuItem.Click += withdrawMembershipToolStripMenuItem_Click;
            // 
            // createMemberToolStripMenuItem
            // 
            createMemberToolStripMenuItem.Name = "createMemberToolStripMenuItem";
            createMemberToolStripMenuItem.Size = new Size(195, 22);
            createMemberToolStripMenuItem.Text = "Create Member";
            createMemberToolStripMenuItem.Click += createMemberToolStripMenuItem_Click;
            // 
            // classesToolStripMenuItem
            // 
            classesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleClassToolStripMenuItem, cancelToolStripMenuItem });
            classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            classesToolStripMenuItem.Size = new Size(57, 20);
            classesToolStripMenuItem.Text = "Classes";
            // 
            // scheduleClassToolStripMenuItem
            // 
            scheduleClassToolStripMenuItem.Name = "scheduleClassToolStripMenuItem";
            scheduleClassToolStripMenuItem.Size = new Size(152, 22);
            scheduleClassToolStripMenuItem.Text = "Schedule Class";
            scheduleClassToolStripMenuItem.Click += scheduleClassToolStripMenuItem_Click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.Size = new Size(152, 22);
            cancelToolStripMenuItem.Text = "Cancel class";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // bookingsToolStripMenuItem
            // 
            bookingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createBookingToolStripMenuItem, cancelBookingToolStripMenuItem });
            bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            bookingsToolStripMenuItem.Size = new Size(68, 20);
            bookingsToolStripMenuItem.Text = "Bookings";
            bookingsToolStripMenuItem.Click += bookingsToolStripMenuItem_Click;
            // 
            // createBookingToolStripMenuItem
            // 
            createBookingToolStripMenuItem.Name = "createBookingToolStripMenuItem";
            createBookingToolStripMenuItem.Size = new Size(157, 22);
            createBookingToolStripMenuItem.Text = "Create Booking";
            createBookingToolStripMenuItem.Click += createBookingToolStripMenuItem_Click;
            // 
            // cancelBookingToolStripMenuItem
            // 
            cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            cancelBookingToolStripMenuItem.Size = new Size(157, 22);
            cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            cancelBookingToolStripMenuItem.Click += cancelBookingToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alertYearlyRevenue, alertYearlyClass });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // alertYearlyRevenue
            // 
            alertYearlyRevenue.Name = "alertYearlyRevenue";
            alertYearlyRevenue.Size = new Size(203, 22);
            alertYearlyRevenue.Text = "Yearly revenue analysis";
            alertYearlyRevenue.Click += yeToolStripMenuItem_Click;
            // 
            // alertYearlyClass
            // 
            alertYearlyClass.Name = "alertYearlyClass";
            alertYearlyClass.Size = new Size(203, 22);
            alertYearlyClass.Text = "Yearly class type analysis";
            alertYearlyClass.Click += alertYearlyClass_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.RightToLeft = RightToLeft.No;
            exitToolStripMenuItem.Size = new Size(37, 20);
            exitToolStripMenuItem.Text = "exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // pictureBoxMainMenu
            // 
            pictureBoxMainMenu.ErrorImage = null;
            pictureBoxMainMenu.Image = (Image)resources.GetObject("pictureBoxMainMenu.Image");
            pictureBoxMainMenu.Location = new Point(10, 43);
            pictureBoxMainMenu.Name = "pictureBoxMainMenu";
            pictureBoxMainMenu.Size = new Size(786, 437);
            pictureBoxMainMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxMainMenu.TabIndex = 1;
            pictureBoxMainMenu.TabStop = false;
            pictureBoxMainMenu.Click += pictureBoxMainMenu_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 491);
            Controls.Add(pictureBoxMainMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMainMenu";
            Text = "Main Menu";
            Load += GYMSYS_Main_Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();

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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void Main_Menu_GYM_Image_Click(object sender, EventArgs e)
        {
            
        }

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmRegisterInstructor frmRegisterInstructor = new frmRegisterInstructor(this))
            {
                frmRegisterInstructor.ShowDialog();
            } ;
            this.Visible = true;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelClass frmCancelClass = new frmCancelClass();
            frmCancelClass.ShowDialog();
        }

        private void yeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("The yearly revenue analysis report will be generated",
                "Please confirm ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult infoResult = MessageBox.Show("Yearly revenue analysis report:\n\n" +
                    "Total Revenue: $500,000\n" +
                    "Average Monthly Revenue: $41,667\n" +
                    "Highest Revenue Month: December ($60,000)\n" +
                    "Lowest Revenue Month: February ($30,000)",
                    "Yearly Revenue Analysis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            else
            {
                // User chose No, do nothing
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Exit ?",
                "Please confirm ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void GYMSYS_Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void createMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateMember fromRegMember = new frmCreateMember();
            fromRegMember.ShowDialog();

        }

        private void editInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmeditInstructor frmEditInstructor = new frmeditInstructor();
            frmEditInstructor.ShowDialog();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deRegisterInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeRegisterInstructor frmDeRegisterInstructor = new frmDeRegisterInstructor();
            frmDeRegisterInstructor.ShowDialog();
        }

        private void withdrawMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWithdrawMembership frmWithdrawMembership = new frmWithdrawMembership();
            frmWithdrawMembership.ShowDialog();
        }

        private void scheduleClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleClass frmScheduleClass = new frmScheduleClass();
            frmScheduleClass.ShowDialog();
        }

        private void addFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddFunds frmAddFunds = new frmAddFunds();
            frmAddFunds.ShowDialog();
        }

        private void createBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateBooking frmCreateBooking = new frmCreateBooking();
            frmCreateBooking.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alertYearlyClass_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("The yearly class type analysis will be generated",
            "Please confirm ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult infoResult = MessageBox.Show("Yearly class analysis report:\n\n" +
                    "Most Popular Class Type: Yoga (1500 bookings)\n" +
                    "Least Popular Class Type: Pilates (300 bookings)\n" +
                    "Average Class Attendance: 25 members per class\n" +
                    "Total Classes Held: 400",
                    "Yearly Class Type Analysis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


            else
            {
                // User chose No, do nothing
            }

        }

        private void pictureBoxMainMenu_Click(object sender, EventArgs e)
        {
            //test for commit

        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelBooking frmCancelBooking = new frmCancelBooking();
            frmCancelBooking.ShowDialog();
        }
    }
}

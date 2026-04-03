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
    public partial class frmCreateBooking : Form
    {
        private Classes selectedClass;

        private Member currentMember;

        public frmCreateBooking()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateBooking_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void dgvCreateBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(
                    dgvCreateBooking.Rows[e.RowIndex].Cells[0].Value);

                selectedClass = Classes.GetClass(id);

                txtClassName.Text = selectedClass.ClassName;
                txtInstructor.Text = selectedClass.InstructorID.ToString();
                txtDate.Text = selectedClass.ClassDate.ToShortDateString();
                txtTime.Text = selectedClass.ClassTime;
                txtRoom.Text = Classes.GetRoomName(selectedClass.RoomId);
                txtPrice.Text = selectedClass.ClassPrice.ToString("0.00");

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class to book.");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to book {selectedClass.ClassName}?",
                "Confirm Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (txtMemberID.Text == "")
                {
                    MessageBox.Show("Please enter your Member ID.");
                    return;
                }

                int memberID = Convert.ToInt32(txtMemberID.Text);
                currentMember = Member.GetMembers(memberID);

                if (currentMember == null)
                {
                    MessageBox.Show("Member not found. Please enter a valid Member ID.");
                    return;
                }

                decimal classPrice = selectedClass.ClassPrice;

                if (currentMember.Balance < classPrice)
                {
                    MessageBox.Show("Insufficient balance. Please top up your account.");
                    return;
                }

                currentMember.Balance -= classPrice;
                currentMember.UpdateBalance();
                
                txtBalance.Text = "€" + currentMember.Balance.ToString("0.00");

                int bookingID = Booking.GetNextBookingID();

                Booking newBooking = new Booking(
                
                   bookingID,
                   memberID,
                   selectedClass.ClassID,
                   DateTime.Now,
                   "Active"

                );

                newBooking.AddBooking();
                MessageBox.Show($"Booking confirmed for {selectedClass.ClassName}. Your new balance is {currentMember.Balance:C}.");

            }

            else
            {
                MessageBox.Show("Booking cancelled.");
            }

        }

        private void txtSelectClass_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSelectClass_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void grpCreateBooking_Enter(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadClasses()
        {
            DataSet ds = Classes.GetAllClasses();
            dgvCreateBooking.DataSource = ds.Tables[0];
        }

    }
}

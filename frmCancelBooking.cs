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
    public partial class frmCancelBooking : Form
    {

        private Booking selectedBooking;
        public frmCancelBooking()
        {
            InitializeComponent();
        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            dgvCancelBooking.Visible = false;
            grpCancelBooking.Visible = false;
        }

        private void dgvCancelBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            object value = dgvCancelBooking.Rows[e.RowIndex].Cells[0].Value;

            if (value != null || value == DBNull.Value)
            {
                MessageBox.Show("Invalid selection. Please select a valid booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                       dgvCancelBooking.Rows[e.RowIndex].Cells[0].Value);

                selectedBooking = Booking.GetBooking(id);

                Classes selectedClass = Classes.GetClass(selectedBooking.ClassID);

                txtClassName.Text = selectedClass.ClassName;
                txtDate.Text = selectedClass.ClassDate.ToShortDateString();
                txtTime.Text = selectedClass.ClassTime;
                txtRoom.Text = Classes.GetRoomName(selectedClass.RoomId);
                txtInstructor.Text = selectedClass.InstructorID.ToString();
                txtPrice.Text = selectedClass.ClassPrice.ToString("0.00");


            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (selectedBooking == null)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?",
                "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int memberID = selectedBooking.MemberID;

                Member member = Member.GetMembers(memberID);

                if (member == null)
                {
                    MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal classPrice = 15.00m;

                member.Balance += classPrice;
                member.UpdateBalance();

                selectedBooking.CancelBooking();

                txtBalance.Text = "€" + member.Balance.ToString("0.00");
                MessageBox.Show("Booking cancelled and balance updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Cancellation aborted.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txtSelectClass_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                bool found = false;

                for (int i = 0; i < dgvCancelBooking.Rows.Count; i++)
                {

                    String className = dgvCancelBooking.Rows[i].Cells[1].Value.ToString().ToLower();

                    dgvCancelBooking.Rows[i].Selected = true;
                    dgvCancelBooking.FirstDisplayedScrollingRowIndex = i;
                    found = true;
                    break;

                }

                if (!found)
                {
                    MessageBox.Show("Class not found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void dgvCancelBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSelectClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMemberID_Leave(object sender, EventArgs e)
        {
            LoadMemberBalance();
        }

        private void LoadMemberBalance()
        {
            int MemberID;

            if (txtMemberID.Text == "")
            {
                MessageBox.Show("Please enter a Member ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MemberID = Convert.ToInt32(txtMemberID.Text);
            }

            catch
            {
                MessageBox.Show("Invalid Member ID. Please enter a vlaid numeric Member ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Member member = Member.GetMembers(MemberID);

            if (member == null)
            {
                MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                dgvCancelBooking.Visible = false;
                grpCancelBooking.Visible = false;
                return;
            }

            txtBalance.Text = "€" + member.Balance.ToString("0.00");

            dgvCancelBooking.Visible = true;
            grpCancelBooking.Visible = true;

            LoadBookingsByMember(MemberID);

        }

        private void LoadBookingsByMember(int memberID)
        {
            DataSet ds = Booking.GetBookingsByMember(memberID);

            if (ds == null || ds.Tables.Count == 0)
            {
                MessageBox.Show("No bookings found for this member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvCancelBooking.DataSource = null;
            dgvCancelBooking.Columns.Clear();
            dgvCancelBooking.AutoGenerateColumns = true;
            dgvCancelBooking.DataSource = ds.Tables[0];
            dgvCancelBooking.Refresh();
        }

        private void grpCancelBooking_Enter(object sender, EventArgs e)
        {

        }
    }
}

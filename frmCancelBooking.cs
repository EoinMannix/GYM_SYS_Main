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
        public frmCancelBooking()
        {
            InitializeComponent();

            dgvCancelBooking.ColumnCount = 5;
            dgvCancelBooking.Columns[0].HeaderText = "Class ID";
            dgvCancelBooking.Columns[1].Name = "Class Name";
            dgvCancelBooking.Columns[2].Name = "Instructor Name";
            dgvCancelBooking.Columns[3].Name = "Date";
            dgvCancelBooking.Columns[4].Name = "Time";

            dgvCancelBooking.Rows.Add("C001", "Yoga", "Aoife Murphy", "2025-07-01", "10:00 AM");
            dgvCancelBooking.Rows.Add("C002", "Pilates", "Ciaran O Donnell", "2025-07-02", "11:00 AM");
            dgvCancelBooking.Rows.Add("C003", "Spinning", "Niamh Kelly", "2025-07-03", "12:00 PM");
            dgvCancelBooking.Rows.Add("C004", "Hyrox", "Darragh Byrne", "2025-07-04", "01:00 PM");
            dgvCancelBooking.Rows.Add("C005", "Pilates", "Siobhan McCarthy", "2025-07-05", "02:00 PM");
            dgvCancelBooking.Rows.Add("C006", "Yoga", "Eimear Walsh", "2025-07-06", "03:00 PM");
            dgvCancelBooking.Rows.Add("C007", "Spinning", "Kevin O Sullivan", "2025-07-07", "04:00 PM");
            dgvCancelBooking.Rows.Add("C008", "Hyrox", "Laura Brennan", "2025-07-08", "05:00 PM");

        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            txtBalance.Text = "€" + BalanceManager.Balance.ToString("0.00");
        }

        private void dgvCancelBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCancelBooking.Rows[e.RowIndex];

                txtClassName.Text = row.Cells[1].Value.ToString();

                txtInstructor.Text = row.Cells[2].Value.ToString();

                txtDate.Text = row.Cells[3].Value.ToString();

                txtTime.Text = row.Cells[4].Value.ToString();

                txtRoom.Text = row.Cells[0].Value.ToString();

                txtPrice.Text = "15.00";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal classPrice = 15.00m;

            DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                BalanceManager.Balance += classPrice;
                MessageBox.Show("Class canceled & Refunded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // User clicked no, do nothing 
            }

        }

        private void txtSelectClass_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                String searchText = txtSelectClass.Text.ToLower();
                bool found = false;

                for (int i = 0; i < dgvCancelBooking.Rows.Count; i++)
                {

                    String className = dgvCancelBooking.Rows[i].Cells[1].Value.ToString().ToLower();

                    if (className.Contains(searchText))
                    {

                        dgvCancelBooking.Rows[i].Selected = true;
                        dgvCancelBooking.FirstDisplayedScrollingRowIndex = i;
                        found = true;
                        break;


                    }

                }


                if (!found)
                {
                    MessageBox.Show("Class not found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }



        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        public frmCreateBooking()
        {
            InitializeComponent();


            txtBalance.Text = "€" + BalanceManager.Balance.ToString("0.00");

            txtSelectClass.AcceptsReturn = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateBooking_Load(object sender, EventArgs e)
        {
            txtBalance.Text = "€" + BalanceManager.Balance.ToString("0.00");
        }

        private void dgvCreateBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCreateBooking.Rows[e.RowIndex];

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

            if (BalanceManager.Balance < classPrice)
            {
                MessageBox.Show("Insufficient balance. Please add funds to continue.");
                return;
            }

            BalanceManager.Balance -= classPrice;

            txtBalance.Text = "€" + BalanceManager.Balance.ToString("0.00");

            MessageBox.Show("Class booked successfully!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtSelectClass_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                String searchText = txtSelectClass.Text.ToLower();
                bool found = false;

                for (int i = 0; i < dgvCreateBooking.Rows.Count; i++)
                {

                    if (dgvCreateBooking.Rows[i].Cells[1].Value != null)
                    {
                        String className = dgvCreateBooking.Rows[i].Cells[1].Value.ToString().ToLower();

                        if (className.Contains(searchText))
                        {
                            dgvCreateBooking.Rows[i].Selected = true;
                            dgvCreateBooking.FirstDisplayedScrollingRowIndex = i;
                            found = true;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Class not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

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
    }
}

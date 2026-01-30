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
    public partial class frmCancelClass : Form
    {
        public frmCancelClass()
        {
            InitializeComponent();

            dgvCancelClass.ColumnCount = 5;
            dgvCancelClass.Columns[0].HeaderText = "Class ID";
            dgvCancelClass.Columns[1].Name = "Class Name";
            dgvCancelClass.Columns[2].Name = "Instructor Name";
            dgvCancelClass.Columns[3].Name = "Date";
            dgvCancelClass.Columns[4].Name = "Time";

            dgvCancelClass.Rows.Add("C001", "Yoga", "Aoife Murphy", "2025-07-01", "10:00 AM");
            dgvCancelClass.Rows.Add("C002", "Pilates", "Ciaran O Donnell", "2025-07-02", "11:00 AM");
            dgvCancelClass.Rows.Add("C003", "Spinning", "Niamh Kelly", "2025-07-03", "12:00 PM");
            dgvCancelClass.Rows.Add("C004", "Hyrox", "Darragh Byrne", "2025-07-04", "01:00 PM");
            dgvCancelClass.Rows.Add("C005", "Pilates", "Siobhan McCarthy", "2025-07-05", "02:00 PM");
            dgvCancelClass.Rows.Add("C006", "Yoga", "Eimear Walsh", "2025-07-06", "03:00 PM");
            dgvCancelClass.Rows.Add("C007", "Spinning", "Kevin O Sullivan", "2025-07-07", "04:00 PM");
            dgvCancelClass.Rows.Add("C008", "Hyrox", "Laura Brennan", "2025-07-08", "05:00 PM");
        }

        private void frmCancelClass_Load(object sender, EventArgs e)
        {

        }

        private void dgvCancelClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // makes sure the user clicked a real row not the header
            {
                DataGridViewRow row = dgvCancelClass.Rows[e.RowIndex]; // gets the clicked row 

                txtClassName.Text = row.Cells[1].Value.ToString();

                txtInstructor.Text = row.Cells[2].Value.ToString();

                txtDate.Text = row.Cells[3].Value.ToString();

                txtTime.Text = row.Cells[4].Value.ToString();

                txtRoom.Text = row.Cells[0].Value.ToString();

                txtPrice.Text = "15.00";

            }
        }


        private void txtSelectCancel_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                String searchText = txtSelcetCancel.Text.ToLower();
                bool found = false;

                for (int i = 0; i < dgvCancelClass.Rows.Count; i++)
                {
                    if (dgvCancelClass.Rows[i].Cells[1].Value != null)
                    {
                        String className = dgvCancelClass.Rows[i].Cells[1].Value.ToString().ToLower();

                        if (className.Contains(searchText))
                        {
                            dgvCancelClass.Rows[i].Selected = true;
                            dgvCancelClass.FirstDisplayedScrollingRowIndex = i;
                            found = true;
                            break;
                        }

                    }


                }

            }

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this class?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Class cancelled successfully.", "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after cancelling
            }
            else
            {
                // User clicked No, do nothing
            }
        }
    }
}

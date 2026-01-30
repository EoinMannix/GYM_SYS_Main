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
    public partial class frmScheduleClass : Form
    {
        public frmScheduleClass()
        {
            InitializeComponent();

            dgvScheduleClass.ColumnCount = 5;
            dgvScheduleClass.Columns[0].HeaderText = "Class ID";
            dgvScheduleClass.Columns[1].Name = "Class Name";
            dgvScheduleClass.Columns[2].Name = "Instructor Name";
            dgvScheduleClass.Columns[3].Name = "Date";
            dgvScheduleClass.Columns[4].Name = "Time";

            dgvScheduleClass.Rows.Add("C001", "Yoga", "Aoife Murphy", "2025-07-01", "10:00 AM");
            dgvScheduleClass.Rows.Add("C002", "Pilates", "Ciaran O Donnell", "2025-07-02", "11:00 AM");
            dgvScheduleClass.Rows.Add("C003", "Spinning", "Niamh Kelly", "2025-07-03", "12:00 PM");
            dgvScheduleClass.Rows.Add("C004", "Hyrox", "Darragh Byrne", "2025-07-04", "01:00 PM");
            dgvScheduleClass.Rows.Add("C005", "Pilates", "Siobhan McCarthy", "2025-07-05", "02:00 PM");
            dgvScheduleClass.Rows.Add("C006", "Yoga", "Eimear Walsh", "2025-07-06", "03:00 PM");
            dgvScheduleClass.Rows.Add("C007", "Spinning", "Kevin O Sullivan", "2025-07-07", "04:00 PM");
            dgvScheduleClass.Rows.Add("C008", "Hyrox", "Laura Brennan", "2025-07-08", "05:00 PM");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvScheduleClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // makes sure the user clicked a real row not the header
            {
                DataGridViewRow row = dgvScheduleClass.Rows[e.RowIndex]; // gets the clicked row 

                txtClassName.Text = row.Cells[1].Value.ToString(); 

                txtInstructorName.Text = row.Cells[2].Value.ToString(); 

                txtDate.Text = row.Cells[3].Value.ToString(); 

                txtTime.Text = row.Cells[4].Value.ToString();

                txtRoom.Text = row.Cells[0].Value.ToString();

                txtPrice.Text = "15.00"; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to schedule this class?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Class scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                // User clicked No, do nothing
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSelectClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                String searchText = txtSelectClass.Text.ToLower();
                bool found = false;

                for (int i = 0; i < dgvScheduleClass.Rows.Count; i++)
                {
                    if (dgvScheduleClass.Rows[i].Cells[1].Value != null)
                                           {
                        String className = dgvScheduleClass.Rows[i].Cells[1].Value.ToString().ToLower();

                        if (className.Contains(searchText))
                        {
                            dgvScheduleClass.Rows[i].Selected = true;
                            dgvScheduleClass.FirstDisplayedScrollingRowIndex = i;
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

        private void frmScheduleClass_Load(object sender, EventArgs e)
        {

        }
    }
}

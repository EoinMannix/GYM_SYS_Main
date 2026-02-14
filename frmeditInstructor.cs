using GYM_SYS;
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
    public partial class frmeditInstructor : Form
    {

        private Instructor Instructor;
        public frmeditInstructor()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvInstructors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (Instructor == null)
            {
                MessageBox.Show("Please select an instructor to edit.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to edit this instructor?",
                "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Instructor.UpdateInstructor();
                LoadInstructors();
                MessageBox.Show("Instructor edited successfully.");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmeditInstructor_Load(object sender, EventArgs e)
        {
            LoadInstructors();
        }

        private void dgvEditInstructors_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(
                dgvEditInstructors.Rows[
                dgvEditInstructors.CurrentCell.RowIndex
                ].Cells[0].Value);

            Instructor = Instructor.GetInstructor(id);

            txtForename.Text = Instructor.InstructorForename;
            txtSurname.Text = Instructor.InstructorSurname;
            dtpDOB.Value = Instructor.InstructorDOB;
            txtPhone.Text = Instructor.InstructorPhone.ToString();
            txtEmail.Text = Instructor.InstructorEmail;
            txtWorkdays.Text = Instructor.InstructorWorkdays;

        }


        //As c# is quite similar to java I used my knowledge of java in my OOP module to create a search function for the instructor edit form
        private void txtEnterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String searchText = txtEnterName.Text.ToLower();
                bool found = false;

                for (int i = 0; i < dgvEditInstructors.Rows.Count; i++)
                {
                    if (dgvEditInstructors.Rows[i].Cells[1].Value != null)
                    {
                        String nameInRow = dgvEditInstructors.Rows[i].Cells[1].Value.ToString().ToLower();

                        if (nameInRow.Contains(searchText))
                        {
                            dgvEditInstructors.Rows[i].Selected = true;
                            dgvEditInstructors.FirstDisplayedScrollingRowIndex = i;
                            found = true;
                            break;
                        }
                    }

                    if (found) break;

                }

                if (!found)
                {
                    MessageBox.Show("Instructor not found.");
                }

            }



        }

        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadInstructors()
        {
            DataSet ds = GYM_SYS.Instructor.GetAllInstructors();

            if (ds == null || ds.Tables.Count == 0)
            {
                MessageBox.Show("No instructors found.");
                return;
            }

            dgvEditInstructors.DataSource = null;
            dgvEditInstructors.Columns.Clear();
            dgvEditInstructors.AutoGenerateColumns = true;

            dgvEditInstructors.DataSource = ds.Tables[0];
            Utility.FormatGrid(dgvEditInstructors);
            dgvEditInstructors.Refresh();

        }
    }
}

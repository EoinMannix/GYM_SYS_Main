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

        private Instructor selectedInstructor;
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

            ValidateEditInputs();

            if (selectedInstructor == null)
            {
                MessageBox.Show("Please select an instructor to edit.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to edit this instructor?",
                "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                selectedInstructor.InstructorForename = txtForename.Text;
                selectedInstructor.InstructorSurname = txtSurname.Text;
                selectedInstructor.InstructorDOB = dtpDOB.Value;
                selectedInstructor.InstructorPhone = txtPhone.Text;
                selectedInstructor.InstructorEmail = txtEmail.Text;
                selectedInstructor.InstructorWorkdays = txtWorkdays.Text;

                selectedInstructor.UpdateInstructor();
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

            UITheme.StyleForm(this);
            UITheme.StyleLabel(this);
            UITheme.StyleButton(btnConfirm);
            UITheme.StyleGrid(dgvEditInstructors);

            LoadInstructors();
        }

        private void dgvEditInstructors_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(
                dgvEditInstructors.Rows[e.RowIndex].Cells[0].Value);

            selectedInstructor = Instructor.GetInstructor(id);

            txtForename.Text = selectedInstructor.InstructorForename;
            txtSurname.Text = selectedInstructor.InstructorSurname;
            dtpDOB.Value = selectedInstructor.InstructorDOB;
            txtPhone.Text = selectedInstructor.InstructorPhone.ToString();
            txtEmail.Text = selectedInstructor.InstructorEmail;
            txtWorkdays.Text = selectedInstructor.InstructorWorkdays;

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
            DataSet ds = Instructor.GetAllInstructors();

            if (ds == null || ds.Tables.Count == 0)
            {
                MessageBox.Show("No instructors found.");
                return;
            }

            dgvEditInstructors.DataSource = null;
            dgvEditInstructors.Columns.Clear();
            dgvEditInstructors.AutoGenerateColumns = true;

            dgvEditInstructors.DataSource = ds.Tables[0];
            UtilityInstructor.FormatGrid(dgvEditInstructors);
            dgvEditInstructors.Refresh();

        }

        private bool ValidateEditInputs()
        {
            if (txtForename.Text == "")
            {
                MessageBox.Show("please enter a name. ");
                return false;
            }

            if (txtSurname.Text == "")
            {
                MessageBox.Show("please enter a surname. ");
                return false;
            }

            if (dtpDOB.Value > DateTime.Now && dtpDOB.Value.Year > 18)
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return false;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter an email.");
                return false;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            // used a for each to validate all digits in the phone number https://www.w3schools.com/cs/cs_foreach_loop.php

            foreach (char c in txtPhone.Text)
            {

                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Phone number must conain number only. ");
                    return false;
                }

            }

            if (txtWorkdays.Text == "")
            {
                MessageBox.Show("Please enter at least one workday.");
                return false;
            }



            return true;
        }
    }
}

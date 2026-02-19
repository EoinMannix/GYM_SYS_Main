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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYMSYS
{
    public partial class frmDeRegisterInstructor : Form
    {
        private Instructor selectedInstructor;
        public frmDeRegisterInstructor()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDeRegisterInstructor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedInstructor == null)
            {
                MessageBox.Show("Please select an instructor to de-register.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to de-register the selected instructor?",
                "Confirm De-Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                selectedInstructor.DeleteInstructor();

                MessageBox.Show("Instructor de-registered successfully.");
                
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing, user cancelled the de-registration
            }
        }

        private void dvgDeRegisterInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(
                dvgDeRegisterInstructor.Rows[e.RowIndex].Cells[0].Value);

            selectedInstructor = Instructor.GetInstructor(id);

            txtForename.Text = selectedInstructor.InstructorForename;
            txtSurname.Text = selectedInstructor.InstructorSurname;
            txtPhone.Text = selectedInstructor.InstructorPhone;
            txtEmail.Text = selectedInstructor.InstructorEmail;
            dtpDOB.Value = selectedInstructor.InstructorDOB;
            lsbGender.Text = selectedInstructor.InstructorGender.Trim();


        }

 


        private void txtEnterInstructorName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                String searchText = txtEnterInstructorName.Text.ToLower();
                bool found = false;

                for (int i = 0; i < dvgDeRegisterInstructor.Rows.Count; i++)
                {
                    if (dvgDeRegisterInstructor.Rows[i].Cells[1].Value != null)
                    {
                        String nameInRow = dvgDeRegisterInstructor.Rows[i].Cells[1].Value.ToString().ToLower();

                        if (nameInRow.Contains(searchText))
                        {
                            dvgDeRegisterInstructor.Rows[i].Selected = true;
                            dvgDeRegisterInstructor.FirstDisplayedScrollingRowIndex = i;
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

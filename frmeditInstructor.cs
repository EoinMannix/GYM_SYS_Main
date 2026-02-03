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
        public frmeditInstructor()
        {
            InitializeComponent();
            //I watched a tutorial on how to create a DataGridView and populate text boxes from that grid.I follow the steps to create one via this link => https://www.youtube.com/watch?v=df5Rb0q0xQQ.
            dgvEditInstructors.RowCount = 10;
            dgvEditInstructors.Columns[0].HeaderText = "Member ID";
            dgvEditInstructors.Columns[1].Name = "InstructorName";
            dgvEditInstructors.Columns[2].Name = "Phone";
            dgvEditInstructors.Columns[3].Name = "Email";

            dgvEditInstructors.Rows[0].Cells[0].Value = "001";
            dgvEditInstructors.Rows[0].Cells[1].Value = "John Doe";
            dgvEditInstructors.Rows[0].Cells[2].Value = "0851234567";
            dgvEditInstructors.Rows[0].Cells[3].Value = "johndoe123@gmail.com";


            dgvEditInstructors.Rows[1].Cells[0].Value = "002";
            dgvEditInstructors.Rows[1].Cells[1].Value = "Joe Bloggs";
            dgvEditInstructors.Rows[1].Cells[2].Value = "0869876543";
            dgvEditInstructors.Rows[1].Cells[3].Value = "JoeBloggs172@gmail.com";


            dgvEditInstructors.Rows[2].Cells[0].Value = "003";
            dgvEditInstructors.Rows[2].Cells[1].Value = "Lucas Carter";
            dgvEditInstructors.Rows[2].Cells[2].Value = "0876543210";
            dgvEditInstructors.Rows[2].Cells[3].Value = "LCarter890@gmail.com";


            dgvEditInstructors.Rows[3].Cells[0].Value = "004";
            dgvEditInstructors.Rows[3].Cells[1].Value = "Zoe Mitchell";
            dgvEditInstructors.Rows[3].Cells[2].Value = "0891234567";
            dgvEditInstructors.Rows[3].Cells[3].Value = "zoeMitchell102@gmail.com";


            dgvEditInstructors.Rows[4].Cells[0].Value = "005";
            dgvEditInstructors.Rows[4].Cells[1].Value = "Padraig Walsh";
            dgvEditInstructors.Rows[4].Cells[2].Value = "0857654321";
            dgvEditInstructors.Rows[4].Cells[3].Value = "PWalsh123@gmail.com";


            dgvEditInstructors.Rows[5].Cells[0].Value = "006";
            dgvEditInstructors.Rows[5].Cells[1].Value = "Maeve O Connor";
            dgvEditInstructors.Rows[5].Cells[2].Value = "0863456789";
            dgvEditInstructors.Rows[5].Cells[3].Value = "MaeveC685@gmail.com";


            dgvEditInstructors.Rows[6].Cells[0].Value = "007";
            dgvEditInstructors.Rows[6].Cells[1].Value = "Niamh O Sullivan";
            dgvEditInstructors.Rows[6].Cells[2].Value = "0879876543";
            dgvEditInstructors.Rows[6].Cells[3].Value = "NiamhOS123@gmail.com";


            dgvEditInstructors.Rows[7].Cells[0].Value = "008";
            dgvEditInstructors.Rows[7].Cells[1].Value = "Eoghan Kelleher";
            dgvEditInstructors.Rows[7].Cells[2].Value = "0894561230";
            dgvEditInstructors.Rows[7].Cells[3].Value = "EoghanKelleher67@gmail.com";


            dgvEditInstructors.Rows[8].Cells[0].Value = "009";
            dgvEditInstructors.Rows[8].Cells[1].Value = "Cian Gallagher";
            dgvEditInstructors.Rows[8].Cells[2].Value = "0856789123";
            dgvEditInstructors.Rows[8].Cells[3].Value = "CGallagher123@gmail.com";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvInstructors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to edit this instructor's details?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Instructor details edited successfully.", "Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after editing
            }
            else
            {
                // User clicked No, do nothing
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

        }

        private void frmeditInstructor_Load(object sender, EventArgs e)
        {

        }

        private void dgvEditInstructors_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // makes sure the user clicked a real row not the header
            {
                DataGridViewRow row = dgvEditInstructors.Rows[e.RowIndex]; // gets the clicked row

                String fulllName = row.Cells[1].Value.ToString(); // gets the name

                String[] nameParts = fulllName.Split(' '); // gets the name and splits into forename and surename

                if (nameParts.Length >= 2)   //puts forename and surname into their respective text boxes
                {
                    textBox1.Text= nameParts[0]; // Forename
                    textBox2.Text= nameParts[1]; // Surname
                }

                if (row.Cells[2].Value != null)
                {
                    textBox4.Text = row.Cells[2].Value.ToString(); // phone
                }

                else
                {
                    textBox4.Text = ""; // Clear Address if null
                }

                if (row.Cells[3].Value != null)
                {
                    textBox3.Text = row.Cells[3].Value.ToString(); // email
                }

                else
                {
                    textBox3.Text = ""; // Clear Specialization if null
                }
            }
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
    }
}

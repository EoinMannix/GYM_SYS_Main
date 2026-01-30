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
        public frmDeRegisterInstructor()
        {
            InitializeComponent();

            //Sets the selection mode of the DataGridView to select full rows. https://stackoverflow.com/questions/13672693/how-do-i-select-a-complete-datagridview-row-when-the-user-clicks-a-cell-of-that
            
            dvgDeRegisterInstructor.Columns.Clear();

            dvgDeRegisterInstructor.Columns.Add("InstructorID", "Instructor ID");
            dvgDeRegisterInstructor.Columns.Add("InstructorName", "Instructor Name");
            dvgDeRegisterInstructor.Columns.Add("Phone", "Phone");
            dvgDeRegisterInstructor.Columns.Add("Email", "Email");

            dvgDeRegisterInstructor.RowCount = 10;
            dvgDeRegisterInstructor.Columns[0].HeaderText = "Instructor ID";
            dvgDeRegisterInstructor.Columns[1].Name = "Instructor Name";
            dvgDeRegisterInstructor.Columns[2].Name = "Phone";
            dvgDeRegisterInstructor.Columns[3].Name = "Email";

            dvgDeRegisterInstructor.Rows[0].Cells[0].Value = "001";
            dvgDeRegisterInstructor.Rows[0].Cells[1].Value = "John Doe";
            dvgDeRegisterInstructor.Rows[0].Cells[2].Value = "0851234567";
            dvgDeRegisterInstructor.Rows[0].Cells[3].Value = "johndoe123@gmail.com";

            dvgDeRegisterInstructor.Rows[1].Cells[0].Value = "002";
            dvgDeRegisterInstructor.Rows[1].Cells[1].Value = "Joe Bloggs";
            dvgDeRegisterInstructor.Rows[1].Cells[2].Value = "0869876543";
            dvgDeRegisterInstructor.Rows[1].Cells[3].Value = "JoeBloggs172@gmail.com";

            dvgDeRegisterInstructor.Rows[2].Cells[0].Value = "003";
            dvgDeRegisterInstructor.Rows[2].Cells[1].Value = "Lucas Carter";
            dvgDeRegisterInstructor.Rows[2].Cells[2].Value = "0876543210";
            dvgDeRegisterInstructor.Rows[2].Cells[3].Value = "LCarter890@gmail.com";

            dvgDeRegisterInstructor.Rows[3].Cells[0].Value = "004";
            dvgDeRegisterInstructor.Rows[3].Cells[1].Value = "Zoe Mitchell";
            dvgDeRegisterInstructor.Rows[3].Cells[2].Value = "0891234567";
            dvgDeRegisterInstructor.Rows[3].Cells[3].Value = "zoeMitchell102@gmail.com";

            dvgDeRegisterInstructor.Rows[4].Cells[0].Value = "005";
            dvgDeRegisterInstructor.Rows[4].Cells[1].Value = "Padraig Walsh";
            dvgDeRegisterInstructor.Rows[4].Cells[2].Value = "0857654321";
            dvgDeRegisterInstructor.Rows[4].Cells[3].Value = "PWalsh123@gmail.com";

            dvgDeRegisterInstructor.Rows[5].Cells[0].Value = "006";
            dvgDeRegisterInstructor.Rows[5].Cells[1].Value = "Maeve O Connor";
            dvgDeRegisterInstructor.Rows[5].Cells[2].Value = "0863456789";
            dvgDeRegisterInstructor.Rows[5].Cells[3].Value = "MaeveC685@gmail.com";

            dvgDeRegisterInstructor.Rows[6].Cells[0].Value = "007";
            dvgDeRegisterInstructor.Rows[6].Cells[1].Value = "Niamh O Sullivan";
            dvgDeRegisterInstructor.Rows[6].Cells[2].Value = "0878901234";
            dvgDeRegisterInstructor.Rows[6].Cells[3].Value = "NiamhOS123@gmail.com";

            dvgDeRegisterInstructor.Rows[7].Cells[0].Value = "008";
            dvgDeRegisterInstructor.Rows[7].Cells[1].Value = "Eoghan Kelleher";
            dvgDeRegisterInstructor.Rows[7].Cells[2].Value = "0894561230";
            dvgDeRegisterInstructor.Rows[7].Cells[3].Value = "EoghanKelleher67@gmail.com";

            dvgDeRegisterInstructor.Rows[8].Cells[0].Value = "009";
            dvgDeRegisterInstructor.Rows[8].Cells[1].Value = "Cian Gallagher";
            dvgDeRegisterInstructor.Rows[8].Cells[2].Value = "0856789123";
            dvgDeRegisterInstructor.Rows[8].Cells[3].Value = "CGallagher123@gmail.com";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDeRegisterInstructor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to de-register the selected instructor?", "Confirm De-Registration", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Instructor de-registered successfully.");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing, user cancelled the de-registration
            }
        }

        private void dvgDeRegisterInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                FillFieldsFromRow(e.RowIndex);

            }
        }

        private void FillFieldsFromRow(int rowIndex)
        {
            DataGridViewRow row = dvgDeRegisterInstructor.Rows[rowIndex];

            String fullName = row.Cells[1].Value.ToString();
            String[] nameParts = fullName.Split(' ');

            if (nameParts.Length >= 2)
            {
                txtForename.Text = nameParts[0];
                txtSurname.Text = nameParts[1];
            }

            txtPhone.Text = row.Cells[2].Value?.ToString();
            txtEmail.Text = row.Cells[3].Value?.ToString();
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
                            dvgDeRegisterInstructor.CurrentCell = dvgDeRegisterInstructor.Rows[i].Cells[1];
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

    }

    
}

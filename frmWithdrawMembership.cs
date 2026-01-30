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
    public partial class frmWithdrawMembership : Form
    {
        public frmWithdrawMembership()
        {
            InitializeComponent();

            dgvWithdrawMembership.RowCount = 10;
            dgvWithdrawMembership.Columns[0].HeaderText = "Member ID";
            dgvWithdrawMembership.Columns[1].Name = "MemberName";
            dgvWithdrawMembership.Columns[2].Name = "Phone";
            dgvWithdrawMembership.Columns[3].Name = "Email";

            dgvWithdrawMembership.Rows[0].Cells[0].Value = "001";
            dgvWithdrawMembership.Rows[0].Cells[1].Value = " John Doe";
            dgvWithdrawMembership.Rows[0].Cells[2].Value = "0851234567";
            dgvWithdrawMembership.Rows[0].Cells[3].Value = "johndoe123@gmail.com";

            dgvWithdrawMembership.Rows[1].Cells[0].Value = "002";
            dgvWithdrawMembership.Rows[1].Cells[1].Value = "Joe Bloggs";
            dgvWithdrawMembership.Rows[1].Cells[2].Value = "0869876543";
            dgvWithdrawMembership.Rows[1].Cells[3].Value = "JoeBloggs172@gmail.com";

            dgvWithdrawMembership.Rows[2].Cells[0].Value = "003";
            dgvWithdrawMembership.Rows[2].Cells[1].Value = "Lucas Carter";
            dgvWithdrawMembership.Rows[2].Cells[2].Value = "0876543210";
            dgvWithdrawMembership.Rows[2].Cells[3].Value = "LCarter890@gmail.com";

            dgvWithdrawMembership.Rows[3].Cells[0].Value = "004";
            dgvWithdrawMembership.Rows[3].Cells[1].Value = "Zoe Mitchell";
            dgvWithdrawMembership.Rows[3].Cells[2].Value = "0891234567";
            dgvWithdrawMembership.Rows[3].Cells[3].Value = "zoeMitchell102@gmail.com";

            dgvWithdrawMembership.Rows[4].Cells[0].Value = "005";
            dgvWithdrawMembership.Rows[4].Cells[1].Value = "Padraig Walsh";
            dgvWithdrawMembership.Rows[4].Cells[2].Value = "0857654321";
            dgvWithdrawMembership.Rows[4].Cells[3].Value = "PWalsh123@gmail.com";

            dgvWithdrawMembership.Rows[5].Cells[0].Value = "006";
            dgvWithdrawMembership.Rows[5].Cells[1].Value = "Maeve O Connor";
            dgvWithdrawMembership.Rows[5].Cells[2].Value = "0863456789";
            dgvWithdrawMembership.Rows[5].Cells[3].Value = "MaeveC685@gmail.com";

            dgvWithdrawMembership.Rows[6].Cells[0].Value = "007";
            dgvWithdrawMembership.Rows[6].Cells[1].Value = "Niamh O Sullivan";
            dgvWithdrawMembership.Rows[6].Cells[2].Value = "0879876543";
            dgvWithdrawMembership.Rows[6].Cells[3].Value = "NiamhOS123@gmail.com";

            dgvWithdrawMembership.Rows[7].Cells[0].Value = "008";
            dgvWithdrawMembership.Rows[7].Cells[1].Value = "Eoghan Kelleher";
            dgvWithdrawMembership.Rows[7].Cells[2].Value = "0894561230";
            dgvWithdrawMembership.Rows[7].Cells[3].Value = "EoghanKelleher67@gmail.com";

            dgvWithdrawMembership.Rows[8].Cells[0].Value = "009";
            dgvWithdrawMembership.Rows[8].Cells[1].Value = "Cian Gallagher";
            dgvWithdrawMembership.Rows[8].Cells[2].Value = "0856789123";
            dgvWithdrawMembership.Rows[8].Cells[3].Value = "CGallagher123@gmail.com";
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvWithdrawMembership_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // makes sure the user clicked a real row not the header
            {
                DataGridViewRow row = dgvWithdrawMembership.Rows[e.RowIndex]; // gets the clicked row

                String fulllName = row.Cells[1].Value.ToString(); // gets the name

                String[] nameParts = fulllName.Split(' '); // gets the name and splits into forename and surename

                if (nameParts.Length >= 2)   //puts forename and surname into their respective text boxes
                {
                    txtForename.Text = nameParts[0]; // Forename
                    txtSurname.Text = nameParts[1]; // Surname
                }

                if (row.Cells[2].Value != null)
                {
                    txtPhone.Text = row.Cells[2].Value.ToString(); // phone
                }

                else
                {
                    txtPhone.Text = ""; // Clear Address if null
                }

                if (row.Cells[3].Value != null)
                {
                    txtEmail.Text = row.Cells[3].Value.ToString(); // email
                }

                else
                {
                    txtEmail.Text = ""; // Clear Specialization if null
                }

            }

        }

        private void txtEnterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String searchText = txtMemberName.Text.ToLower();
                bool found = false;

                for (int i = 0; i < dgvWithdrawMembership.Rows.Count; i++)
                {
                    if (dgvWithdrawMembership.Rows[i].Cells[1].Value != null)
                    {
                        String nameInRow = dgvWithdrawMembership.Rows[i].Cells[1].Value.ToString().ToLower();

                        if (nameInRow.Contains(searchText))
                        {
                            dgvWithdrawMembership.Rows[i].Selected = true;
                            dgvWithdrawMembership.FirstDisplayedScrollingRowIndex = i;
                            found = true;
                            break;
                        }

                    }

                    if (found) break;

                }

                if (!found)
                {
                    MessageBox.Show("Member not found. Please try again.");

                }

            }

        }

        private void btnConfirmWithdraw_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to withdraw this membership?", "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Membership withdrawn successfully.", "Withdrawal Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

            else
            {
                // Do nothing if No is selected
            }
        }

        private void frmWithdrawMembership_Load(object sender, EventArgs e)
        {

        }
    }

}

 


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
    public partial class frmWithdrawMembership : Form
    {

        private Member member;

        public frmWithdrawMembership()
        {
            InitializeComponent();


        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvWithdrawMembership_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32( // converts the value in the first cell of the clicked row to an integer, which is the member ID
                dgvWithdrawMembership.Rows[e.RowIndex].Cells[0].Value);

            member = Member.GetMembers(id);

            txtForename.Text = member.MemberForename;
            txtSurname.Text = member.MemberSurename;
            txtPhone.Text = member.MemberPhone;
            txtEmail.Text = member.MemberEmail;
            dtpDOB.Value = member.MemberDOB;
            lstGender.Text = member.MemberGender.Trim();
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

                }

                if (!found)
                {
                    MessageBox.Show("Member not found. Please try again.");

                }

            }

        }

        private void btnUpdateWithdraw_Click(object sender, EventArgs e)
        {

            if (member == null)
            {
                MessageBox.Show("Please select a member to withdraw.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to withdraw this membership?",
                "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                member.DeleteMember();
                LoadMembers();
                MessageBox.Show("Member Withdrawn successfully.");

            }

            else
            {
                MessageBox.Show("Membership withdrawal cancelled.");
                return;
            }
        }

        private void frmWithdrawMembership_Load(object sender, EventArgs e)
        {
            
            UITheme.StyleForm(this);
            UITheme.StyleLabel(this);
            UITheme.StyleButton(btnUpdateWithdraw);
            UITheme.StyleGrid(dgvWithdrawMembership);
            UITheme.StyleListBox(lstGender);

            LoadMembers();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }



        private void LoadMembers()
        {
            DataSet ds = Member.GetAllMembers(); // runs the method to get all members from the database

            if (ds == null || ds.Tables.Count == 0) // checks if the dataset is null or contains no tables
            {
                MessageBox.Show("No members found."); // shows a message box if no members are found
                return; // exits the method if no members are found
            }

            // Reset grid completely
            dgvWithdrawMembership.DataSource = null;
            dgvWithdrawMembership.Columns.Clear();
            dgvWithdrawMembership.AutoGenerateColumns = true;

            // Bind data
            dgvWithdrawMembership.DataSource = ds.Tables[0]; // sets the data source of the DataGridView to the first table in the dataset

            UtilityMember.FormatGrid(dgvWithdrawMembership);

            dgvWithdrawMembership.Refresh(); // refreshes the DataGridView to display the new data
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

 


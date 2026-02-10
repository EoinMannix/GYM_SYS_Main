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

        /*private void dgvWithdrawMembership_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // makes sure the user clicked a real row not the header
            {
                DataGridViewRow row = dgvWithdrawMembership.Rows[e.RowIndex]; ; // gets the clicked row

                    txtForename.Text = row.Cells["FORENAME"].Value.ToString(); 
                                                                               
                    txtSurname.Text = row.Cells["SURENAME"].Value.ToString(); 


                if (row.Cells["PHONE"].Value != null)
                {
                    txtPhone.Text = row.Cells["PHONE"].Value.ToString(); 
                }

                else
                {
                    txtPhone.Text = "";
                }

                if (row.Cells["EMAIL"].Value != null)
                {
                    txtEmail.Text = row.Cells["EMAIL"].Value.ToString(); // email
                }

                else
                {
                    txtEmail.Text = ""; 
                }

            }

        }*/
        private void dgvWithdrawMembership_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32( // converts the value in the first cell of the clicked row to an integer, which is the member ID
                dgvWithdrawMembership.Rows[
                dgvWithdrawMembership.CurrentCell.RowIndex
                ].Cells[0].Value);

            member = Member.GetMembers(id);

            txtForename.Text = member.MemberForename;
            txtSurname.Text = member.MemberSurename;
            txtPhone.Text = member.MemberPhone;
            txtEmail.Text = member.MemberEmail;
            lstGender.SelectedItem = member.MemberGender;
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

        private void btnUpdateWithdraw_Click(object sender, EventArgs e)
        {

            if (member == null)
            {
                MessageBox.Show("Please select a member to update.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to withdraw this membership?",
                "Confirm Withdrawal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                member.DeleteMember();
                LoadMembers();
                MessageBox.Show("Member information updated successfully.");

            }

            else
            {
                MessageBox.Show("Membership withdrawal cancelled.");
                return;
            }
        }

        private void frmWithdrawMembership_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }


        
        private void LoadMembers()
        {
            DataSet ds = GYM_SYS.Member.GetAllMembers(); // runs the method to get all members from the database

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

            Utility.FormatGrid(dgvWithdrawMembership); 

            dgvWithdrawMembership.Refresh(); // refreshes the DataGridView to display the new data
        }


    }


}

 


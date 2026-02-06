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
        public frmWithdrawMembership()
        {
            InitializeComponent();

            
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvWithdrawMembership_CellClick(object sender, DataGridViewCellEventArgs e)
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
            LoadMembers();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }


        /*private void LoadMembers()
        {

            dgvWithdrawMembership.Visible = false;

            DataSet ds = GYM_SYS.Member.GetAllMembers();


            MessageBox.Show(
                "user : " + GetCurrentUser(),
                "Debug Test");

            MessageBox.Show(
                "Schema: " + GetCurrentSchema(),
                "Debug"
            );


            if (ds == null || ds.Tables.Count == 0)
            {
                MessageBox.Show("No members found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvWithdrawMembership.AutoGenerateColumns = true;

            dgvWithdrawMembership.DataSource = ds.Tables[0];

            dgvWithdrawMembership.Visible = true;



        } */
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

            dgvWithdrawMembership.Refresh(); // refreshes the DataGridView to display the new data

            MessageBox.Show("Rows loaded: " + ds.Tables[0].Rows.Count); // shows a message box with the number of rows loaded for debugging purposes
        }




    }


}

 


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
    public partial class frmCreateMember : Form
    {
        public frmCreateMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateRegisterInputs())
            {
                int newID = Member.GetNextMemberID();

                Member newMember = new Member(newID, txtForename.Text, txtSurname.Text, dtpDOB.Value,
                    txtPhone.Text, txtEmail.Text, lstGender.Text,Convert.ToDecimal(0.0));

                newMember.AddMember();

                MessageBox.Show("Member " + txtForename.Text + " " + txtSurname.Text + "added successfully!");

                this.Close();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        // ValidateRegisterInputs() function provides validation when creating a member.
        private bool ValidateRegisterInputs()
        {
            if (txtForename.Text == "")
            {
                MessageBox.Show("please enter a name. ");
                return false;
            }

            if (txtSurname.Text == "")
            {
                MessageBox.Show("Please enter a surname.");
                return false;
            }

            if (dtpDOB.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth cannot be in the future.");
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

            if (lstGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender");
                return false;
            }

            // used a for each to validate all digits in the phone number https://www.w3schools.com/cs/cs_foreach_loop.php

            if (txtPhone.Text == "")
            {

                foreach (char c in txtPhone.Text)
                {

                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Phone number must conain number only. ");
                        return false;
                    }

                }

            }



            return true;
        }

        private void frmCreateMember_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

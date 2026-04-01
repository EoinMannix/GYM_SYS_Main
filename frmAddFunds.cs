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
    public partial class frmAddFunds : Form
    {

        private Member currentMember;

        public frmAddFunds()
        {
            InitializeComponent();

        }

        private void frmAddFunds_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidatePaymentInputs())
            {
                int memberID = Convert.ToInt32(txtMemberID.Text);

                currentMember = Member.GetMembers(memberID);

                txtCurrentBalance.Text = "£" + currentMember.Balance.ToString("0.00");

                decimal amountToAdd = GetSelectedAmount();

                if (amountToAdd == 0)
                {
                    MessageBox.Show("Please select an amount to add.");
                    return;
                }

                currentMember.Balance += amountToAdd;

                currentMember.UpdateBalance();

                txtCurrentBalance.Text = "£" + currentMember.Balance.ToString("0.00");

                MessageBox.Show("Funds added successfully! Your new balance is: £" + currentMember.Balance);

            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal GetSelectedAmount()
        {
            if (radioButton10.Checked)
            {
                return 10;
            }

            if (radioButton20.Checked)
            {
                return 20;
            }

            if (radioButton40.Checked)
            {
                return 40;
            }

            if (radioButton80.Checked)
            {
                return 80;
            }

            return 0;

        }

        private bool ValidatePaymentInputs()
        {
            if (txtMemberID.Text == "")
            {
                MessageBox.Show("Please enter your member ID.");
                return false;
            }

            if (txtNameOnCard.Text == "")
            {
                MessageBox.Show("Please enter the name on the card.");
                return false;
            }

            if (txtCardNumber.Text == "")
            {
                MessageBox.Show("Please enter the card number.");
                return false;
            }

            if (txtCVV.Text == "")
            {
                MessageBox.Show("Please enter the CVV.");
                return false;
            }

            foreach (char c in txtMemberID.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Member ID must contain only digits.");
                    return false;
                }
            }

            foreach (char c in txtCardNumber.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Card number must contain only digits.");
                    return false;
                }
            }

            foreach (char c in txtCVV.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("CVV must contain only digits.");
                    return false;
                }
            }

            return true;
        }

        private void txtCurrentBalance_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

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

        decimal balance = 0m;
        public frmAddFunds()
        {
            InitializeComponent();

            txtCurrentBalance.Text = "€" + BalanceManager.Balance.ToString("0.00");
        }

        private void frmAddFunds_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal amountToAdd = 0;

            if (radioButton10.Checked)
            {
                amountToAdd = 10;
            }
            else if (radioButton20.Checked)
            {
                amountToAdd = 20;
            }
            else if (radioButton40.Checked)
            {
                amountToAdd = 40;
            }
            else if (radioButton80.Checked)
            {
                amountToAdd = 80;
            }


            if (amountToAdd == 0)
            {
                MessageBox.Show("Please select an amount to add.");
                return;
            }

            BalanceManager.Balance += amountToAdd;

            txtCurrentBalance.Text = "€" + BalanceManager.Balance.ToString("0.00");

            MessageBox.Show("Successfully added €" + amountToAdd.ToString("0.00") + " to your balance.");

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

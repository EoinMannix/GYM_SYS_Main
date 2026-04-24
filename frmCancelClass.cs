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
    public partial class frmCancelClass : Form
    {

        private Classes selectedClass;
        public frmCancelClass()
        {
            InitializeComponent();

        }

        private void frmCancelClass_Load(object sender, EventArgs e)
        {
            UITheme.StyleForm(this);
            UITheme.StyleLabel(this);
            UITheme.StyleButton(btnConfirm);
            UITheme.StyleGrid(dgvCancelClass);

            LoadClasses();
        }

        private void dgvCancelClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // makes sure the user clicked a real row not the header
            {
                int id = Convert.ToInt32(
                    dgvCancelClass.Rows[e.RowIndex].Cells[0].Value);

                selectedClass = Classes.GetClass(id);

                txtClassName.Text = selectedClass.ClassName;
                txtPrice.Text = selectedClass.ClassPrice.ToString("0.00");
                txtDate.Text = selectedClass.ClassDate.ToShortDateString();
                txtTime.Text = selectedClass.ClassTime;
                txtRoom.Text = Classes.GetRoomName(selectedClass.RoomId);
                txtInstructor.Text = selectedClass.InstructorID.ToString();



            }
        }


        private void txtSelectCancel_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (selectedClass == null)
            {
                MessageBox.Show("Please select a class to cancel.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to cancel this class?",
                "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                selectedClass.CancelClass();
                LoadClasses();
                MessageBox.Show("Class cancelled successfully.");

            }

            else
            {
                MessageBox.Show("Class cancellation cancelled.");
                return;
            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadClasses()
        {
            DataSet ds = Classes.GetAllClasses();

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("No classes found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvCancelClass.DataSource = null;
            dgvCancelClass.Columns.Clear();
            dgvCancelClass.AutoGenerateColumns = true;


            dgvCancelClass.DataSource = ds.Tables[0];

            dgvCancelClass.Refresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

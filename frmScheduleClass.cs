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
    public partial class frmScheduleClass : Form
    {
        private Classes selectedClass;
        public frmScheduleClass()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvScheduleClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(
                dgvScheduleClass.Rows[e.RowIndex].Cells[0].Value);

            selectedClass = Classes.GetClass(id);

            Instructor instructor = Instructor.GetInstructor(selectedClass.InstructorID);

            string roomName = Classes.GetRoomName(selectedClass.Room);

            txtClassName.Text = selectedClass.ClassName;
            dtpClassDate.Value = selectedClass.ClassDate;
            txtInstructorName.Text = instructor.InstructorForename + " " + instructor.InstructorSurname;
            txtClassPrice.Text = selectedClass.ClassPrice.ToString();
            txtClassTime.Text = selectedClass.ClassTime;
            cboRoom.SelectedValue = selectedClass.Room;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to schedule this class?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Class scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                // User clicked No, do nothing
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmScheduleClass_Load_1(object sender, EventArgs e)
        {
            LoadClasses();
            LoadRooms();
        }

        private void txtSelectClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String searchText = txtSelectClass.Text.ToLower();
                bool found = false;

                for (int i = 0; i < dgvScheduleClass.Rows.Count; i++)
                {
                    if (dgvScheduleClass.Rows[i].Cells[1].Value != null)
                    {
                        String className = dgvScheduleClass.Rows[i].Cells[1].Value.ToString().ToLower();

                        if (className.Contains(searchText))
                        {
                            dgvScheduleClass.Rows[i].Selected = true;
                            dgvScheduleClass.FirstDisplayedScrollingRowIndex = i;
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Class not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmScheduleClass_Load(object sender, EventArgs e)
        {

        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadClasses()
        {
            DataSet ds = Classes.GetAllClasses();

            if (ds == null || ds.Tables.Count == 0)
            {
                MessageBox.Show("No classes found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvScheduleClass.DataSource = null;
            dgvScheduleClass.Columns.Clear();
            dgvScheduleClass.AutoGenerateColumns = true;

            dgvScheduleClass.DataSource = ds.Tables[0];
            UtilityInstructor.FormatGrid(dgvScheduleClass);
            dgvScheduleClass.Refresh();


        }

        private void LoadRooms()
        {
            DataSet ds = Database.ExecuteMultiRowQuery("SELECT ROOMID, ROOMNAME FROM ROOMS");

            cboRoom.DataSource = ds.Tables[0];
            cboRoom.DisplayMember = "ROOMNAME";
            cboRoom.ValueMember = "ROOMID";
        }

    }
}

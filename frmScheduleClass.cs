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


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!ClassScheduleInputs())
            {
                return;
            }

            int weeks = int.Parse(cboDuration.Text.Substring(0, 1));
            DateTime date = dtpClassDate.Value;

            for (int i = 0; i < weeks; i++) 
            { 
            
                if (Classes.ClassExists((int)cboRoom.SelectedValue, date, txtClassTime.Text))
                {
                    MessageBox.Show("Time already booked! Please select another Time.");
                    return;
                }

                new Classes(Classes.GetNextClassID(), txtClassName.Text, 0, decimal.Parse(txtClassPrice.Text),
                    date, txtClassTime.Text, (int)cboRoom.SelectedValue, "YG").AddClass();

                date = date.AddDays(7);

            }

            MessageBox.Show("Class Successfully Scheduled!");

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmScheduleClass_Load(object sender, EventArgs e)
        {
            LoadRooms();
            LoadDuration();
        }

        private void txtSelectClass_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDuration()
        {
            cboDuration.Items.Add("2 Weeks");
            cboDuration.Items.Add("3 Weeks");
            cboDuration.Items.Add("4 Weeks");

        } 

        private void LoadRooms()
        {
            DataSet ds = Database.ExecuteMultiRowQuery("SELECT ROOMID, ROOMNAME FROM ROOMS");

            cboRoom.DataSource = ds.Tables[0];
            cboRoom.DisplayMember = "ROOMNAME";
            cboRoom.ValueMember = "ROOMID";

            cboRoom1.DataSource = ds.Tables[0];
            cboRoom1.DisplayMember = "ROOMNAME";
            cboRoom1.ValueMember = "ROOMID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool ClassScheduleInputs()
        {
            if (txtClassName.Text == "")
            {
                MessageBox.Show("Please enter a class name.");
                return false;
            }

            if (cboRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room.");
                return false;
            }

            if (txtClassTime.Text == "")
            {
                MessageBox.Show("Please enter a class time.");
                return false;

            }

            if (dtpClassDate.Value < DateTime.Today)
            {
                MessageBox.Show("Class date cannot be in the past.");
                return false;
            }

            if (txtClassPrice.Text == "")
            {
                MessageBox.Show("Please enter a class price.");
                return false;
            }

            if (txtClassPrice.Text == "0")
            {
                MessageBox.Show("Class price cannot be zero.");
                return false;
            }

            if (cboDuration.SelectedIndex == -1)
            {
                MessageBox.Show("Please select duration.");
                return false;
            }

            return true;

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViewTimetable_Click(object sender, EventArgs e)
        {

            int roomID = Convert.ToInt32(cboRoom1.SelectedValue);

            frmTimetableView timetable = new frmTimetableView(roomID, dtpClassDate.Value);
            timetable.ShowDialog();
        }
    }
}

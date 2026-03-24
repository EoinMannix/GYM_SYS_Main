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
    public partial class frmTimetableView : Form
    {
        public frmTimetableView()
        {
            InitializeComponent();
            SetupGrid();
            FillTestData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void SetupGrid()
        {

            dgvTimetable.Columns.Add("Time", "Time");
            dgvTimetable.Columns.Add("Mon", "Monday");
            dgvTimetable.Columns.Add("Tue", "Tuesday");
            dgvTimetable.Columns.Add("Wed", "Wednesday");
            dgvTimetable.Columns.Add("Thu", "Thursday");
            dgvTimetable.Columns.Add("Fri", "Friday");

            dgvTimetable.Rows.Add("9-10");
            dgvTimetable.Rows.Add("10-11");
            dgvTimetable.Rows.Add("11-12");
            dgvTimetable.Rows.Add("12-1");
            dgvTimetable.Rows.Add("1-2");
            dgvTimetable.Rows.Add("2-3");
            dgvTimetable.Rows.Add("3-4");
            dgvTimetable.Rows.Add("4-5");

        }

        public void FillTestData() {             
            dgvTimetable.Rows[0].Cells[1].Value = "Yoga";
            dgvTimetable.Rows[1].Cells[2].Value = "Spinning";
            dgvTimetable.Rows[2].Cells[3].Value = "Pilates";
            dgvTimetable.Rows[3].Cells[4].Value = "Zumba";
            dgvTimetable.Rows[4].Cells[5].Value = "Boxing";
        }
    }
}

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
        public frmTimetableView(int roomId, DateTime selectedDate)
        {

            /********************************
            * 
            * Author: Microsoft
            * Site: learn.microsoft.com
            * Date: 2026 
            * Code Version edited June 2-3 2026
            * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.dockstyle?view=windowsdesktop-10.0
            * Accessed: 30 March 2026
            * Modified: I used Dock Style to fill the DGV over the entier page as i was experiencing UI issues as the timetable is quite large the full time table was never displayed.
            * 
            ********************************/

            InitializeComponent();
            SetupGrid();
            LoadTimetable(roomId, selectedDate);
            dgvTimetable.Dock = DockStyle.Fill;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetupGrid()
        {

            dgvTimetable.Columns.Add("Time", "Time");
            dgvTimetable.Columns.Add("Mon", "Monday");
            dgvTimetable.Columns.Add("Tue", "Tuesday");
            dgvTimetable.Columns.Add("Wed", "Wednesday");
            dgvTimetable.Columns.Add("Thu", "Thursday");
            dgvTimetable.Columns.Add("Fri", "Friday");
            dgvTimetable.Columns.Add("Sat", "Saturday");
            dgvTimetable.Columns.Add("Sun", "Sunday");

            dgvTimetable.Rows.Add("09:00");
            dgvTimetable.Rows.Add("10:00");
            dgvTimetable.Rows.Add("11:00");
            dgvTimetable.Rows.Add("12:00");
            dgvTimetable.Rows.Add("13:00");
            dgvTimetable.Rows.Add("14:00");
            dgvTimetable.Rows.Add("15:00");
            dgvTimetable.Rows.Add("16:00");
            dgvTimetable.Rows.Add("17:00");
            dgvTimetable.Rows.Add("18:00");

        }

        public void FillTestData() {             
            dgvTimetable.Rows[0].Cells[1].Value = "Yoga";
            dgvTimetable.Rows[1].Cells[2].Value = "Spinning";
            dgvTimetable.Rows[2].Cells[3].Value = "Pilates";
            dgvTimetable.Rows[3].Cells[4].Value = "Zumba";
            dgvTimetable.Rows[4].Cells[5].Value = "Boxing";
        }

        public void LoadTimetable(int roomId, DateTime selectedDate)
        {
            DataSet ds = Database.ExecuteMultiRowQuery(
                "SELECT CLASSNAME, CLASSDATE, CLASSTIME FROM CLASSES WHERE ROOMID = " + roomId);

            DataTable dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string Name = dt.Rows[i]["CLASSNAME"].ToString();
                DateTime Date = Convert.ToDateTime(dt.Rows[i]["CLASSDATE"]);
                string Time = dt.Rows[i]["CLASSTIME"].ToString();

                int col = 1;

                if (Date.DayOfWeek == DayOfWeek.Monday) col = 1;
                else if (Date.DayOfWeek == DayOfWeek.Tuesday) col = 2;
                else if (Date.DayOfWeek == DayOfWeek.Wednesday) col = 3;
                else if (Date.DayOfWeek == DayOfWeek.Thursday) col = 4;
                else if (Date.DayOfWeek == DayOfWeek.Friday) col = 5;
                else if (Date.DayOfWeek == DayOfWeek.Saturday) col = 6;
                else if (Date.DayOfWeek == DayOfWeek.Sunday) col = 7;

                for (int r = 0; r < dgvTimetable.Rows.Count; r++)
                {
                    /********************************
                    * 
                    * Author: Microsoft
                    * Site: learn.microsoft.com
                    * Date: 2026 
                    * Code Version edited June 2-3 2026
                    * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview?view=windowsdesktop-10.0
                    * Accessed: 30 March 2026
                    * Modified: In the Examples part of the page the code on line 30 was changed to match my spacific scenario 
                    * 
                    ********************************/

                    if (dgvTimetable.Rows[r].Cells[0].Value.ToString().Trim() == Time.Trim())
                    {
                        dgvTimetable.Rows[r].Cells[col].Value = Name;
                        break;
                    }

                }


            }
        }


    }
}

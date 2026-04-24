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
            * Date: 22/04/2026 
            * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.dockstyle?view=windowsdesktop-10.0
            * Accessed: 30 March 2026
            * Modified: I used Dock Style to fill the DGV over the entier page as i was experiencing UI issues as the timetable is quite large the full time table was never displayed.
            * 
            ********************************/


            /********************************
            * 
            * Author: Microsoft
            * Site: learn.microsoft.com
            * Date: 22/04/2026
            * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.string.substring?view=net-10.0
            * Modified: The substring method is used to extract the first character from the cboDuration text e.g 3 weeks (the 3 is extracted), 
            * This is then converted to an integer and used to determine how many weeks the class should be scheduled for
            * 
            ********************************/

            /********************************
            * 
            * Author: Microsoft
            * Site: learn.microsoft.com
            * Date: 2026 
            * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.datetime.adddays?view=net-10.0
            * Accessed: 22 april 2026
            * Modified: The add days method allowed me to add days to the selected date to find the start and end of the week, this is used to load the timetable for the correct week
            * 
            ********************************/

            /********************************
            * 
            * Author: Microsoft
            * Site: learn.microsoft.com
            * Date: 2026 
            * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcell.value?view=windowsdesktop-10.0
            * Accessed: 22 april 2026
            * Modified: The datagridviewcell value property is used to set the value of the cell to the class name which lets the user know which classes are scheduled for that time slot.
            * 
            ********************************/


            /********************************
            * 
            * Author: Microsoft
            * Site: learn.microsoft.com
            * Date: 2026 
            * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcellstyle.wrapmode?view=windowsdesktop-10.0
            * Accessed: 22 april 2026
            * Modified: The wrap mode property is set to true to allow the class names to be displayed on multiple lines if there are multiple classes scheduled for the same time slot, this improves the readability of the timetable.
            * 
            ********************************/

            /********************************
            * 
            * Author: Microsoft
            * Site: learn.microsoft.com
            * Date: 2026 
            * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.autosizerowsmode?view=windowsdesktop-10.0
            * Accessed: 22 april 2026
            * Modified: The AutoSizeRowsMode property is set to AllCells to automatically adjust the row height to fit the content of the cells, this ensures that all class names are fully visible regardless of how many classes are scheduled for a time slot.
            * 
            ********************************/

            /********************************
            * 
            * Author: Microsoft
            * Site: learn.microsoft.com
            * Date: 2026 
            * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.autosizecolumnsmode?view=windowsdesktop-10.0
            * Accessed: 22 april 2026
            * Modified:The AutoSizeColumnsMode property is set to Fill to automatically adjust the column widths to fill the available space in the DataGridView, this ensures that the timetable is displayed in a clear and organized manner, making it easier for users to read and understand the schedule.
            ********************************/


            InitializeComponent();
            SetupGrid();

            UITheme.StyleForm(this);
            UITheme.StyleLabel(this);
            UITheme.StyleGrid(dgvTimetable);

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

            dgvTimetable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTimetable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



        public void LoadTimetable(int roomId, DateTime selectedDate)
        {
            foreach (DataGridViewRow row in dgvTimetable.Rows)
            {
                for (int i = 1; i < dgvTimetable.Columns.Count; i++)
                {
                    row.Cells[i].Value = "";
                }
            }

            DateTime startOfWeek = selectedDate;

            while (startOfWeek.DayOfWeek != DayOfWeek.Monday)
            {
                startOfWeek = startOfWeek.AddDays(-1);
            }

            DateTime endOfWeek = startOfWeek.AddDays(6);

            string start = startOfWeek.ToString("dd/MM/yyyy");
            string end = endOfWeek.ToString("dd/MM/yyyy");

            string sql = (
                        "SELECT CLASSNAME, CLASSDATE, CLASSTIME FROM CLASSES " +
                        "WHERE ROOMID = " + roomId +
                        " AND CLASSDATE BETWEEN TO_DATE('" + start + "', 'DD/MM/YYYY')" +
                        " AND TO_DATE('" + end + "', 'DD/MM/YYYY')"
                        );

            DataSet ds = Database.ExecuteMultiRowQuery(sql);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                string className = row["CLASSNAME"].ToString();
                DateTime classDate = Convert.ToDateTime(row["CLASSDATE"]);
                string classTime = row["CLASSTIME"].ToString().Substring(0, 5);

                int col = (int)classDate.DayOfWeek;
                if (col == 0)
                {
                    col = 7;
                }

                foreach (DataGridViewRow gridRow in dgvTimetable.Rows)
                {

                    string gridTime = gridRow.Cells[0].Value.ToString();

                    if (gridTime == classTime)
                    {
                        if (gridRow.Cells[col].Value == null)
                        {
                            gridRow.Cells[col].Value = className;
                        }
                        else
                        {
                            gridRow.Cells[col].Value += "\n" + className;
                        }

                        break;
                    }
                }
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No classes found for the selected week.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
        }

        private void frmTimetableView_Load(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Drawing; 

namespace GYM_SYS
{
    internal class UtilityInstructor
    {

        public static void FormatGrid(DataGridView dg)
        {
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dg.Columns["INSTRUCTORID"].DefaultCellStyle.Format = "0000";
            dg.Columns["INSTRUCTORID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

    }
}

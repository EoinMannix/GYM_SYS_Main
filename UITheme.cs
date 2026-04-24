using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GYMSYS
{
    internal class UITheme
    {

        /********************************
        * 
        * Author: Microsoft Corporation
        * Site: Microsoft.com
        * Date: 2025 
        * Code Version edited June 2-3rd, 2026
        * Availablity: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.backcolor?view=windowsdesktop-10.0
        *              https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.forecolor?view=windowsdesktop-10.0
        *              https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.font?view=windowsdesktop-10.0
        * Accessed: 24 April 2026
        * Modified: These are the official Microsoft documentation for the BackColor, ForeColor and Font properties of Windows Forms controls. I used these properties to create a consistent and visually appealing theme for my application.
        *           The BackColor property is used to set the background color of the controls, while the ForeColor property is used to set the text color. The Font property is used to set the font style and size for the controls.
        *           By using these properties, I was able to create a cohesive and professional look for my gym management system application.
        ********************************/

        public static void StyleForm(Form frm) {

            frm.BackColor = Color.FromArgb(44, 62, 80);
            frm.Font = new Font("Segoe UI", 10);

        }

        public static void StyleLabel(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.White;
                }

                if (ctrl.HasChildren)
                {
                    StyleLabel(ctrl);
                }

            }
        }

        public static void StyleTextBox(GroupBox grp)
        {
            grp.BackColor = Color.FromArgb(44, 62, 80);
            grp.ForeColor = Color.White;
        }


        public static void StyleButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 120, 215);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        public static void StyleGrid(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 250);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        public static void StyleListBox(ListBox lst)
        {
            lst.BackColor = Color.FromArgb(230, 240, 255);
            lst.ForeColor = Color.Black;
            lst.BorderStyle = BorderStyle.None;
            lst.Font = new Font("Segoe UI", 10);
        }

    }
}

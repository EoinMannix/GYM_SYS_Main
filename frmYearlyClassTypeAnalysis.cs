using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace GYMSYS
{
    public partial class frmYearlyClassTypeAnalysis : Form
    {

        // Please refer to the frmYearly Revenue Analysis form for comments on the charting library..

        CartesianChart Chart;
        public frmYearlyClassTypeAnalysis()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmYearlyClassTypeAnalysis_Load(object sender, EventArgs e)
        {
            Chart = new CartesianChart
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(Chart);

            LoadClassChart();

        }

        private void LoadClassChart()
        {
            var data = Admin.GetClassCounts(); // Get class type analysis data from the database

            Chart.Series = new ISeries[]
                {
                    new ColumnSeries<int>
                    {
                        Values = data,
                        Name = "Classes booked"
                    }
                };

            Chart.XAxes = new Axis[]
                {
                    new Axis
                    {
                        Labels = new[] { "Yoga", "Pilates", "Spinning"}
                    }
                };
        }


    }
}

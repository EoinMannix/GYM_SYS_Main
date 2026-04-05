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

    /********************************
    * 
    * Author: LiveCharts2 Team
    * Site: LiveCharts.dev
    * Date: 2025 
    * Code Version edited June 25th, 2025
    * Availablity: https://github.com/Live-Charts/LiveCharts2/blob/master/samples/WinFormsSample/Axes/Multiple/View.cs
    * Accessed: 04 April 2026
    * Modified: I did a bit of reasearch on charts in .NET 7 - 9 and found LiveCharts2 to be a good option,
    *           It is an open source charting library that can be downloaded in the NuGet package manager.
    *           In my project I examined the structure contained in the sample above taken from their website and modified it to suit my Yearly Revenue analysis form,
    *           I used a line chart to display the monthly revenue for the year. The data is retrieved from the database using the Admin.GetRevenue() method,
    *           which returns a list of double values representing the revenue for each month. The chart is then populated with this data to visually represent the yearly revenue analysis.
    ********************************/

    public partial class frmYearlyRevenueAnalysis : Form
    {
        CartesianChart chart;
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void YearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {

            chart = new CartesianChart
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(chart);

            LoadRevenueChart();

        }

        private void LoadRevenueChart()
        {
            var data = Admin.GetRevenue(); // Get revenue data from the database

            chart.Series = new ISeries[]
                {
                    new LineSeries<double>
                    {
                        Values = data,
                        Name = "Monthly Revenue"
                    }

                };

            chart.XAxes = new Axis[]
                {
                    new Axis
                    {
                        Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    }
                    // Please note also that I put each booking price in a diffrent month for ease of testing.
                };

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

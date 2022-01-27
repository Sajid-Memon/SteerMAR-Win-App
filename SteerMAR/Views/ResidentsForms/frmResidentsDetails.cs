using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SteerMAR.Views.ResidentsForms
{
    public partial class frmResidentsDetails : Form
    {
        public frmResidentsDetails()
        {
            InitializeComponent();
            FillChart();
        }

        public void FillChart()
        {
            DataTable dtCourse = new DataTable();
            dtCourse.Columns.Add("ID");
            dtCourse.Columns.Add("Name");
            dtCourse.Rows.Add("102", "Fever"); // here
            dtCourse.Rows.Add("85", "Cough"); // here
            dtCourse.Rows.Add("94", "Migrane"); // here

            chart1.DataSource = dtCourse;            
            chart1.Series["VitalName"].ChartType = SeriesChartType.Column;
            chart1.Series["VitalName"].XValueMember = "Name";
            chart1.Series["VitalName"].YValueMembers = "ID";
            chart1.Series["VitalName"].IsValueShownAsLabel = true;

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

        }
    }
}

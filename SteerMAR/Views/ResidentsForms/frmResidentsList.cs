using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteerMAR.Views.ResidentsForms
{
    public partial class frmResidentsList : Form
    {
        public frmResidentsList()
        {
            InitializeComponent();
            FillRptPatientList();
        }
        public void FillRptPatientList()
        {
            //DataTable MyTable = new DataTable(); // 1
            //DataTable MyTableByName = new DataTable("MyTableName"); // 2            
            //MyTable.Columns.Add("Name", typeof(string));
            //DataRow row = MyTable.NewRow();            
            //row["Name"] = "John";
            //row["Name"] = "MARK";
            //row["Name"] = "Willium";
            //MyTable.Rows.Add(row);

            //lblPatientName.DataBindings.Add("Text", MyTable, "Name");                  
            //rptPatientsList.DataSource = MyTable;

            DataTable dtCourse = new DataTable();
            dtCourse.Columns.Add("ID");
            dtCourse.Columns.Add("Name");
            dtCourse.Rows.Add("1", "John"); // here
            dtCourse.Rows.Add("2", "MARK"); // here
            dtCourse.Rows.Add("3", "Willium"); // here
            lblPatientName.DataBindings.Add("Text", dtCourse, "Name");
            rptPatientsList.DataSource = dtCourse;
        }

        private void rptPatientsList_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

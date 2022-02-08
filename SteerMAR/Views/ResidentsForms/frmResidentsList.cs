using SteerMAR.App_Code.BusinessLogics;
using SteerMAR.Views.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteerMAR.Views.ResidentsForms
{
    public partial class frmResidentsList : Form
    {
        NotifyEvent GoToDetails;
        public static int Patient_ID = 0;
        public frmResidentsList(NotifyEvent openDetails)
        {
            InitializeComponent();
            FillDgvPatientList();
            GoToDetails = openDetails;
        }      

        public void FillDgvPatientList(string SearchText="")
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectActiveResidentList(SearchText);
            if (ds.Tables[0].Rows.Count > 0)
            {                
                dgvPatientList.DataSource = ds.Tables[0];
            }
        }
        private void dgvPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPatientList.Columns["Select"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    Patient_ID = Convert.ToInt32(dgvPatientList.Rows[e.RowIndex].Cells[1].Value.ToString());
                    GoToDetails.Invoke();
                    //MessageBox.Show("Patient ID IS : " + Patient_ID);
                }
            }
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchText.Text != null && txtSearchText.Text != string.Empty)
            {
                FillDgvPatientList(txtSearchText.Text.Trim());
            }
            else
            {
                FillDgvPatientList();
            }
        }
    }
}

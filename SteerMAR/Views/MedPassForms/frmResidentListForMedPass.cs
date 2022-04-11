using SteerMAR.App_Code.BusinessLogics;
using SteerMAR.Views.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteerMAR.Views.MedPassForms
{
    public partial class frmResidentListForMedPass : Form
    {
        public static int Patient_ID = 0;
        public frmResidentListForMedPass()
        {
            InitializeComponent();
            FillDgvPatientList();            
        }
        public void FillDgvPatientList(string SearchText = "")
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectActiveResidentList(SearchText);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvPatientList.DataSource = ds.Tables[0];
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

        private void dgvPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Patient_ID = Convert.ToInt32(dgvPatientList.Rows[e.RowIndex].Cells[0].Value.ToString());              
                MessageBox.Show("Patient ID IS : " + Patient_ID);
            }
        }
    }
}

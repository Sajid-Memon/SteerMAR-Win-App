using SteerMAR.App_Code.BusinessLogics;
using SteerMAR.Views.ResidentsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SteerMAR.App_Code.DataAccess.PatientModels;

namespace SteerMAR.Views.popupForms
{
    public partial class frmPatientVitalsDetails : Form
    {
        public frmPatientVitalsDetails()
        {
            InitializeComponent();
        }

        private void btnCloseThis_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        public void FillDgvVial(DateTime vitalDate)
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectPatientVitals(frmResidentsList.Patient_ID);
            if (ds.Tables[0].Rows.Count > 0)
            {              
                DataTable dtVitalData = ds.Tables[0];
                var vitalHistory = from data in dtVitalData.AsEnumerable()
                                   where Convert.ToDateTime(data.Field<DateTime>("Taken_Date").ToShortDateString()) == vitalDate
                                   select new
                                   {
                                       Patient_Vital_ID = data.Field<int>("Patient_Vital_ID"),
                                       Vital_ID = data.Field<int>("Vital_ID"),
                                       Vital_Name = data.Field<string>("Vital_Name"),
                                       Vital_Value = data.Field<string>("Vital_Value"),
                                       Taken_Time = data.Field<DateTime>("Taken_Date").ToShortTimeString()
                                   };
                if (vitalHistory != null)
                {
                    dgvVitalHistory.DataSource = vitalHistory.ToList();
                }
            }
        }
        int Vital_ID = 0;
        int Patient_Vital_ID = 0;
        DateTime vitalDate;
        private void calVitalDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            vitalDate = Convert.ToDateTime(calVitalDate.SelectionRange.Start.ToShortDateString());
            FillDgvVial(vitalDate);
        }      
        private void dgvVitalHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVitalHistory.Columns["Edit"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    
                    Patient_Vital_ID = Convert.ToInt32(dgvVitalHistory.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Vital_ID = Convert.ToInt32(dgvVitalHistory.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtVitalValue.Text = dgvVitalHistory.Rows[e.RowIndex].Cells[4].Value.ToString();
                    pnlEditVitalValue.Visible = true;
                }
            }
        }
        private void btnSaveVital_Click(object sender, EventArgs e)
        {
            PatientVitalMaster PVM = new PatientVitalMaster();
            PVM.Patient_Vital_ID = Patient_Vital_ID;
            PVM.Patient_ID = frmResidentsList.Patient_ID;
            PVM.Vital_ID = Vital_ID;
            PVM.Vital_Value = txtVitalValue.Text.Trim();
            PVM.Taken_Date = vitalDate;
            PatientMethods PM = new PatientMethods();
            byte value = PM.AddUpdatePatientVitals(PVM);
            string msg = value == 0 ? "Vital has been Updated" : "New vital Added";
            FillDgvVial(vitalDate);
            MessageBox.Show(msg);
            pnlEditVitalValue.Visible = false;
                      
        }

       
    }
}

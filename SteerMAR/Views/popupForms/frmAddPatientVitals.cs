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
    public partial class frmAddPatientVitals : Form
    {
        private frmResidentsDetails RD;
        public frmAddPatientVitals(frmResidentsDetails FRD)
        {
            InitializeComponent();
            RD = FRD;
            FilldrpVital();
        }

        public void FilldrpVital()
        {
            setupMethods SM = new setupMethods();
            DataSet ds = SM.SelectActiveVitals();
            if (ds.Tables[0].Rows.Count> 0)
            {
                drpVitals.DataSource = ds.Tables[0];
                drpVitals.DisplayMember = "Vital_Name";
                drpVitals.ValueMember = "Vital_ID";
            }
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {            
            if (drpVitals.Text != "" && txtVitalValue.Text != "")
            {
                PatientVitalMaster pvm = new PatientVitalMaster();
                pvm.Patient_ID = frmResidentsList.Patient_ID;
                pvm.Vital_ID = Convert.ToInt32(drpVitals.SelectedValue);
                pvm.Vital_Value = txtVitalValue.Text.Trim();
                PatientMethods PM = new PatientMethods();
                byte value = PM.AddUpdatePatientVitals(pvm);
                string msg = value == 0 ? "Vital has been Updated" : value == 1 ? "Same vital Already Exists" : "New vital Added";
                if (value == 1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show(msg);
                    RD.FillChart();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select Vital and value for that.");
            }
        }

        private void btnCloseThis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

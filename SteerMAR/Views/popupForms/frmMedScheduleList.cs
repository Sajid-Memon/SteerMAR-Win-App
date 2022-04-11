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

namespace SteerMAR.Views.popupForms
{
    public partial class frmMedScheduleList : Form
    {
        public frmMedScheduleList()
        {
            InitializeComponent();
            if (frmResidentsDetails.MedicationID > 0)
            {
                FillDgvList();
            }
        }
        public void FillDgvList()
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectMedSchedule(frmResidentsDetails.MedicationID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvTimeList.DataSource = ds.Tables[0];
            }
        }
        private void btnCloseThis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

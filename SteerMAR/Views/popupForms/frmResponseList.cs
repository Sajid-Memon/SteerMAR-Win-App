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
    public partial class frmResponseList : Form
    {
        public frmResponseList()
        {
            InitializeComponent();
            if (frmResidentsDetails.TaskID > 0)
            {
                filldgv(frmResidentsDetails.TaskID);
            }
        }
        public void filldgv(int TaskID)
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectUserTaskResponse(TaskID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvResponseList.DataSource = ds.Tables[0];
            }
        }

        private void btnCloseThis_Click(object sender, EventArgs e)
        {
            frmResidentsDetails.TaskID = 0;
            this.Close();
        }
    }
}

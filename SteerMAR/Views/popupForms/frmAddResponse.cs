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
    public partial class frmAddResponse : Form
    {
        public frmAddResponse()
        {
            InitializeComponent();
        }

        private void btnCloseThis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInfoorder.Text == "" && txtInfoorder.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Response Text");
            }
            else
            {
                ResponseMaster RM = new ResponseMaster();
                RM.Response_ID = 0;
                RM.Task_ID = frmResidentsDetails.TaskID;
                RM.Response_Text = txtInfoorder.Text.Trim();               
                RM.Created_By = Convert.ToInt32(Properties.Settings.Default.LoggedUser);
                PatientMethods PM = new PatientMethods();
                byte value = PM.AddUpdateUserTaskResponse(RM);
                string msg = value == 0 ? "Response has been Updated" : "Response has been Submited";
                MessageBox.Show(msg);
                frmResidentsDetails.TaskID = 0;
                this.Close();
            }
        }
    }
}

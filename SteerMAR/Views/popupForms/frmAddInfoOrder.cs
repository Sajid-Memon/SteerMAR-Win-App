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
    public partial class frmAddInfoOrder : Form
    {
        private frmResidentsDetails RD;
        public frmAddInfoOrder(frmResidentsDetails FRD)
        {
            InitializeComponent();
            RD = FRD;
        }

        private void btnCloseThis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInfoorder.Text == "" && txtInfoorder.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Message Text");
            }
            else
            {
                UserTaskMaster UTM = new UserTaskMaster();
                UTM.Task_ID = 0;
                UTM.Patient_ID = frmResidentsList.Patient_ID;
                UTM.Task_Type = lblHeader.Text.Trim();
                UTM.Task_Text = txtInfoorder.Text.Trim();
                UTM.Created_By = Convert.ToInt32(Properties.Settings.Default.LoggedUser);
                PatientMethods PM = new PatientMethods();
                byte value = PM.AddUpdatePatientUserTask(UTM);
                string msg = value == 0 ? lblHeader.Text.Trim() +" has Updated" : "New " +lblHeader.Text.Trim() +" Created";
                MessageBox.Show(msg);
                if (lblHeader.Text.Trim() == "Info Order")
                {
                    RD.FillDgvInfoOrders();
                }
                if (lblHeader.Text.Trim() == "Assignment")
                {
                    RD.fillDgvAssignment();
                }
                else
                {
                    RD.fillDgvComment();
                }
                this.Close();
            }
        }
    }
}

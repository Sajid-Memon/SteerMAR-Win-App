﻿using SteerMAR.App_Code.BusinessLogics;
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
        public frmAddInfoOrder()
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
                MessageBox.Show("Please Enter Info order");
            }
            else
            {
                UserTaskMaster UTM = new UserTaskMaster();
                UTM.Task_ID = 0;
                UTM.Patient_ID = frmResidentsList.Patient_ID;
                UTM.Task_Type = "InfoOrder";
                UTM.Task_Text = txtInfoorder.Text.Trim();
                UTM.Created_By = Convert.ToInt32(Properties.Settings.Default.LoggedUser);
                PatientMethods PM = new PatientMethods();
                byte value = PM.AddUpdatePatientUserTask(UTM);
                string msg = value == 0 ? "Info Order has Updated" : "New Info Order Created";
                MessageBox.Show(msg);
                this.Close();
            }
        }
    }
}

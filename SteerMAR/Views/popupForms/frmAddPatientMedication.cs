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
    public partial class frmAddPatientMedication : Form
    {
        public frmAddPatientMedication()
        {
            InitializeComponent();
            dtpwrittendate.Value = System.DateTime.Now;
            dtpwrittendate.Value = System.DateTime.Now;
            dtTime.Value = Convert.ToDateTime(System.DateTime.Now.ToShortTimeString());
            FillDrpPhysician();
        }
        public void FillDrpPhysician()
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectActivePhysician();
            if (ds.Tables[0].Rows.Count > 0)
            {
                drpPrescriber.DataSource = ds.Tables[0];
                drpPrescriber.DisplayMember = "Physician_Name";
                drpPrescriber.ValueMember = "Physician_ID";
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPNR.Checked == true)
            {
                pnlRoutine.Visible = false;
                pnlPNR.Visible = true;
            }
            else
            {
                pnlRoutine.Visible = true;
                pnlPNR.Visible = false;
            }
        }

        private void btnCloseThis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            fpImage.InitialDirectory = "C://Desktop";
            fpImage.Title = "Select image For Logo.";
            fpImage.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fpImage.ShowDialog() == DialogResult.OK)
            {
                pbPatientProfile.Image = new Bitmap(fpImage.FileName);
                pbPatientProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Medication Name");
            }
            else
            {
                PatientMedicationMaster PM = new PatientMedicationMaster();
                PM.Medication_ID = 0;
                PM.Patient_ID = frmResidentsList.Patient_ID;
                if (pbPatientProfile.Image != null)
                {
                    Image img = pbPatientProfile.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    PM.Medication_Image = arr;
                }
                else
                {
                    PM.Medication_Image = new byte[] { };
                }
                PM.Medication_Name = txtName.Text.Trim();
                PM.Medication_Equilent_To = txtEquilentto.Text.Trim();
                PM.Medication_NDC = txtndcno.Text.Trim();
                PM.Medication_RXNo = txtrxno.Text.Trim();
                PM.Medication_Prescriber = Convert.ToInt32(drpPrescriber.SelectedValue);
                PM.Medication_Diagnosis = txtdiagnosis.Text.Trim();
                PM.Medication_WriteDate = dtpwrittendate.Value;
                PM.Medication_ExpiryDate = dtpExpirydate.Value;
                PM.Medication_Route = drpRoute.Text;
                PM.Medication_Instructions = txtInstruction.Text.Trim();
                if (chkControlledDrug.Checked == true)
                {
                    PM.Controlled_Drugs = true;
                }
                else
                {
                    PM.Controlled_Drugs = false;
                }
                if (chkHomeHealthDrug.Checked == true)
                {
                    PM.Home_Health_Drugs = true;
                }
                else
                {
                    PM.Home_Health_Drugs = false;
                }
                if (chkPNR.Checked == true)
                {
                    PM.Medication_PRN = true;
                    PM.Min_PRN = txtMinTab.Text.Trim();
                    PM.Max_PRN = txtMaxTab.Text.Trim();
                    PM.Medication_Time = dtTime.Value;
                    PM.Medication_Qty = "";
                    PM.Medication_Details = "";
                    PM.Medication_WeekDays = "";
                }
                else
                {
                    PM.Medication_PRN = false;
                    PM.Min_PRN = "";
                    PM.Max_PRN = "";
                    PM.Medication_Time = dtTime.Value;
                    PM.Medication_Qty = drpQuantity.Text;
                    PM.Medication_Details = drpDetails.Text;
                    string WeekDays="";
                    for (int i = 0; i < CBWeekDays.CheckedItems.Count; i++)
                    {
                        WeekDays += CBWeekDays.CheckedItems[i].ToString()+",";

                    }
                    PM.Medication_WeekDays = WeekDays.TrimEnd(',');
                }
                PatientMethods patients = new PatientMethods();
                byte value = patients.AddUpdateMedication(PM);
                string msg = value == 0 ? "Medication has been Updated" : value == 1 ? "Same Medication Already Exists" : "New Medication Added";
                MessageBox.Show(msg);               
                this.Close();
            }
        }     
    }
}

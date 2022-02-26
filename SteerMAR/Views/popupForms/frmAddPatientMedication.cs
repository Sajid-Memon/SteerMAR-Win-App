using SteerMAR.App_Code.BusinessLogics;
using SteerMAR.Views.ResidentsForms;
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
using static SteerMAR.App_Code.DataAccess.PatientModels;

namespace SteerMAR.Views.popupForms
{
    public partial class frmAddPatientMedication : Form
    {
        private frmResidentsDetails RD;
        public frmAddPatientMedication(frmResidentsDetails FRD)
        {
            InitializeComponent();
            RD = FRD;
            dtpwrittendate.Value = System.DateTime.Now;
            dtpwrittendate.Value = System.DateTime.Now;
            dtTime.Value = Convert.ToDateTime(System.DateTime.Now.ToShortTimeString());
            FillDrpPhysician();
            if (frmResidentsDetails.MedicationID > 0)
            {
                EditMedication(frmResidentsDetails.MedicationID);
            }
        }
        public void EditMedication(int MedicationID)
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectPatientMedicationByMedID(MedicationID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                btnSave.Text = "UPDATE";                    
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Medication_Image"]);
                if (ms.Length > 0)
                {                    
                    pbPatientProfile.Image = new Bitmap(ms);
                }                            
                txtName.Text = ds.Tables[0].Rows[0]["Medication_Name"].ToString();
                txtEquilentto.Text = ds.Tables[0].Rows[0]["Medication_Equilent_To"].ToString();
                txtndcno.Text = ds.Tables[0].Rows[0]["Medication_NDC"].ToString();
                txtrxno.Text = ds.Tables[0].Rows[0]["Medication_RXNo"].ToString();
                drpPrescriber.SelectedValue = ds.Tables[0].Rows[0]["Medication_Prescriber"].ToString();
                txtdiagnosis.Text = ds.Tables[0].Rows[0]["Medication_Diagnosis"].ToString();
                dtpwrittendate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["Medication_WriteDate"].ToString());
                dtpExpirydate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["Medication_ExpiryDate"].ToString());
                drpRoute.Text = ds.Tables[0].Rows[0]["Medication_Route"].ToString();
                txtInstruction.Text = ds.Tables[0].Rows[0]["Medication_Instructions"].ToString();
                chkControlledDrug.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Controlled_Drugs"].ToString());
                chkHomeHealthDrug.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Home_Health_Drugs"].ToString());
                chkPNR.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Medication_PRN"].ToString());
                txtMinTab.Text = ds.Tables[0].Rows[0]["Min_PRN"].ToString();
                txtMaxTab.Text = ds.Tables[0].Rows[0]["Max_PRN"].ToString();
                dtTime.Text = ds.Tables[0].Rows[0]["Medication_Time"].ToString();
                drpQuantity.Text = ds.Tables[0].Rows[0]["Medication_Qty"].ToString();
                drpDetails.Text = ds.Tables[0].Rows[0]["Medication_Details"].ToString();
      
                string[] WeekDays = ds.Tables[0].Rows[0]["Medication_WeekDays"].ToString().Split(',');
                foreach (string item in WeekDays)
                {
                    for (int i = 0; i < CBWeekDays.Items.Count; i++)
                    {
                        if (item.ToString() == ((string)CBWeekDays.Items[i]).ToString())
                        {
                            CBWeekDays.SetItemChecked(i, true);
                        }
                    }
                }
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Med_State"]) == true)
                {
                    btnContinue.Text = "CONTINUE";
                }
                else
                {
                    btnContinue.Text = "DISCONTINUE";
                }
            }
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
            frmResidentsDetails.MedicationID = 0;
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
                if (frmResidentsDetails.MedicationID > 0)
                {
                    PM.Medication_ID = frmResidentsDetails.MedicationID;
                }
                else
                {
                    PM.Medication_ID = 0;
                }                
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
                if (btnContinue.Text == "CONTINUE")
                {
                    PM.Med_State = true;
                }
                else
                {
                    PM.Med_State = false;
                }
                PM.Created_By = Convert.ToInt32(Properties.Settings.Default.LoggedUser);
                PatientMethods patients = new PatientMethods();
                byte value = patients.AddUpdateMedication(PM);
                string msg = value == 0 ? "Medication has been Updated" : value == 1 ? "Same Medication Already Exists" : "New Medication Added";
                MessageBox.Show(msg);
                RD.FillDgvMedications();
                frmResidentsDetails.MedicationID = 0;
                btnSave.Text = "SAVE";
                this.Close();
            }
        }     
    }
}

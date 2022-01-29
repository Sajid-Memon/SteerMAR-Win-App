using SteerMAR.App_Code.BusinessLogics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static SteerMAR.App_Code.DataAccess.PatientModels;

namespace SteerMAR.Views.ResidentsForms
{
    public partial class frmResidentsDetails : Form
    {
        public frmResidentsDetails()
        {
            InitializeComponent();
            FillChart();
        }

        public void FillChart()
        {
            DataTable dtCourse = new DataTable();
            dtCourse.Columns.Add("ID");
            dtCourse.Columns.Add("Name");
            dtCourse.Rows.Add("102", "Fever"); // here
            dtCourse.Rows.Add("85", "Cough"); // here
            dtCourse.Rows.Add("94", "Migrane"); // here

            chart1.DataSource = dtCourse;            
            chart1.Series["VitalName"].ChartType = SeriesChartType.Column;
            chart1.Series["VitalName"].XValueMember = "Name";
            chart1.Series["VitalName"].YValueMembers = "ID";
            chart1.Series["VitalName"].IsValueShownAsLabel = true;

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

        }

        private void btnEditResident_Click(object sender, EventArgs e)
        {
            this.tbcMain.SelectedTab = tabProfile;
            this.tbcSecond.SelectedTab = tabPatientProfile;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            fpProfilePic.InitialDirectory = "C://Desktop";
            fpProfilePic.Title = "Select image For Logo.";
            fpProfilePic.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fpProfilePic.ShowDialog() == DialogResult.OK)
            {             
                pbPatientProfile.Image = new Bitmap(fpProfilePic.FileName);
                pbPatientProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            if (txtPatientCode.Text == string.Empty || txtPatientCode.Text == "")
            {
                MessageBox.Show("patient code is required!","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (drpGender.Text == string.Empty || drpGender.Text == "")
            {
                MessageBox.Show("please select patient gender!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (drpPatientStatus.Text == string.Empty || drpPatientStatus.Text == "")
            {
                MessageBox.Show("please select patient status!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtSocialSecurityNo.Text == string.Empty || txtSocialSecurityNo.Text == "")
            {
                MessageBox.Show("please enter patient social security No!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (drpPhysician.Text == string.Empty || drpPhysician.Text == "")
            {
                MessageBox.Show("please select patient Physician!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PatientMaster patinetMaster = new PatientMaster();
                patinetMaster.Patient_ID = 0;
                patinetMaster.Patient_Code = txtPatientCode.Text.Trim();
                patinetMaster.Patient_Image = "demo.png";
                patinetMaster.Patient_Salutation = drpSalutation.Text;
                patinetMaster.First_Name = txtFirstName.Text.Trim();
                patinetMaster.Middle_Name = txtMiddleName.Text.Trim();
                patinetMaster.Last_Name = txtLastName.Text.Trim();
                patinetMaster.Patient_Gender = drpGender.Text;
                patinetMaster.Patient_DOB = dtpBirthDate.Value;
                patinetMaster.Maritial_Status = drpMeritalStatus.Text;
                patinetMaster.Patient_Status = drpPatientStatus.Text;
                patinetMaster.Patient_Physical_ID = txtPhysicalID.Text.Trim();
                patinetMaster.Patient_Medical_Record = txtMedicalRecord.Text.Trim();
                patinetMaster.SocialSecurity_No = txtSocialSecurityNo.Text.Trim();
                patinetMaster.Patient_Admission_Date = dtpAdmissionDate.Value;
                patinetMaster.Patient_Physician = Convert.ToInt32(drpPhysician.Text);
                patinetMaster.Reffered_By = Convert.ToInt32(drpRefferedBy.Text);
                patinetMaster.Patient_Room_No = txtRoomNo.Text.Trim();
                patinetMaster.Patient_Med_Cart = drpMedCart.Text;
                if (chkLivingWill.Checked == true)
                {
                    patinetMaster.Living_Will = true;
                }
                else
                {
                    patinetMaster.Living_Will = false;
                }
                if (chkMobilityDevice.Checked == true)
                {
                    patinetMaster.Mobility_Devices = true;
                }
                else
                {
                    patinetMaster.Mobility_Devices = false;
                }
                if (chkGlasses.Checked == true)
                {
                    patinetMaster.IsGlasses = true;
                }
                else
                {
                    patinetMaster.IsGlasses = false;
                }
                if (chkDenture.Checked == true)
                {
                    patinetMaster.IsDenture = true;
                }
                else
                {
                    patinetMaster.IsDenture = false;
                }
                if (chkInsurance.Checked == true)
                {
                    patinetMaster.Isprimary_Insurance = true;
                }
                else
                {
                    patinetMaster.Isprimary_Insurance = false;
                }
                patinetMaster.Allergy_ID = drpAllergies.Text;
                patinetMaster.Diagnosis_ID = drpDiagnosis.Text;
                patinetMaster.Diet_ID = drpDiet.Text;
                PatientMethods PM = new PatientMethods();
                byte value = PM.AddUpdatePatient(patinetMaster);
                string msg = value == 0 ? "Patient Detail Updated" : value == 1 ? "Same Patient Code Already Exists" : "New Patient Added";
                if (value == 1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show(msg);
                    //frmEntries.EntryID = "";
                    //FE.FilldgvEntry();                    
                }

            }
        }
    }
}

using SteerMAR.App_Code.BusinessLogics;
using SteerMAR.Views.popupForms;
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
using System.Windows.Forms.DataVisualization.Charting;
using static SteerMAR.App_Code.DataAccess.PatientModels;

namespace SteerMAR.Views.ResidentsForms
{
    public partial class frmResidentsDetails : Form
    {
        public int Patient_ID = 0;
        public frmResidentsDetails()
        {
            InitializeComponent();
        }

        private void frmResidentsDetails_Load(object sender, EventArgs e)
        {
            if (frmResidentsList.Patient_ID > 0)
            {
                Patient_ID = frmResidentsList.Patient_ID;
                GetPatientDetails();
                FillDgvContcats();
                FillChart();
                FillDgvInsurance();
                FillDgvMedications();
            }
            FillDrpPhysician();
            FillDrpRefered();
        }

        #region [Patient Vitals]
        private void btnOpenVitalPopup_Click(object sender, EventArgs e)
        {
            frmAddPatientVitals APV = new frmAddPatientVitals(this);
            APV.ShowDialog(this);
        }

        private void btnOpenVitalHistory_Click(object sender, EventArgs e)
        {
            frmPatientVitalsDetails PVD = new frmPatientVitalsDetails();
            PVD.ShowDialog();
        }
        public void FillChart()
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectPatientVitals(Patient_ID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataTable dtVitalHistory = ds.Tables[0];
                var vitalHistory = (from data in dtVitalHistory.AsEnumerable()
                                    orderby data.Field<int>("Patient_Vital_ID")
                                    select data).Take(5).ToList();

                chart1.DataSource = vitalHistory;
                chart1.Series["VitalName"].ChartType = SeriesChartType.Column;
                chart1.Series["VitalName"].XValueMember = "Vital_Name";
                chart1.Series["VitalName"].YValueMembers = "Vital_Value";
                chart1.Series["VitalName"].IsValueShownAsLabel = true;

                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            }

        }
        #endregion

        #region [Patient Profile]

        public void GetPatientDetails()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectResidentByID(Patient_ID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Patient_Image"]);
                    if (ms.Length > 0)
                    {
                        pbMainProfile.Image = new Bitmap(ms);
                        pbPatientProfile.Image = new Bitmap(ms);
                    }
                    lblPatientName.Text = ds.Tables[0].Rows[0]["First_Name"].ToString() + " , " + ds.Tables[0].Rows[0]["Last_Name"].ToString();

                    #region [Main Profile Section]                  
                    txtMainFirstName.Text = ds.Tables[0].Rows[0]["First_Name"].ToString();
                    txtMainLastName.Text = ds.Tables[0].Rows[0]["Last_Name"].ToString();
                    txtMainSalutation.Text = ds.Tables[0].Rows[0]["Patient_Salutation"].ToString();
                    txtMainPreferedName.Text = ds.Tables[0].Rows[0]["First_Name"].ToString() + " , " + ds.Tables[0].Rows[0]["Last_Name"].ToString();
                    txtMainGender.Text = ds.Tables[0].Rows[0]["Patient_Gender"].ToString();
                    txtMainDob.Text = ds.Tables[0].Rows[0]["Patient_DOB"].ToString();
                    txtMainPatientRecord.Text = ds.Tables[0].Rows[0]["Patient_Medical_Record"].ToString();
                    txtMainStatus.Text = ds.Tables[0].Rows[0]["Patient_Status"].ToString();
                    txtMainPhysicalID.Text = ds.Tables[0].Rows[0]["Patient_Physical_ID"].ToString();
                    txtMainPhysician.Text = "Main";
                    txtMainRoomMo.Text = ds.Tables[0].Rows[0]["Patient_Room_No"].ToString();
                    txtMainMedCart.Text = ds.Tables[0].Rows[0]["Patient_Med_Cart"].ToString();
                    txtMainPharmacy.Text = "J S Pharmacy";
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Isprimary_Insurance"].ToString()) == true)
                    {
                        txtMainPrimaryInsurance.Text = "Yes";
                    }
                    else
                    {
                        txtMainPrimaryInsurance.Text = "No";
                    }

                    #endregion

                    #region [Profile Tab Section]
                    txtPatientCode.Text = ds.Tables[0].Rows[0]["Patient_Code"].ToString();
                    drpSalutation.Text = ds.Tables[0].Rows[0]["Patient_Salutation"].ToString();
                    txtFirstName.Text = ds.Tables[0].Rows[0]["First_Name"].ToString();
                    txtMiddleName.Text = ds.Tables[0].Rows[0]["Middle_Name"].ToString();
                    txtLastName.Text = ds.Tables[0].Rows[0]["Last_Name"].ToString();
                    drpGender.Text = ds.Tables[0].Rows[0]["Patient_Gender"].ToString();
                    dtpBirthDate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["Patient_DOB"].ToString());
                    drpMeritalStatus.Text = ds.Tables[0].Rows[0]["Maritial_Status"].ToString();
                    drpPatientStatus.Text = ds.Tables[0].Rows[0]["Patient_Status"].ToString();
                    txtPhysicalID.Text = ds.Tables[0].Rows[0]["Patient_Physical_ID"].ToString();
                    txtMedicalRecord.Text = ds.Tables[0].Rows[0]["Patient_Medical_Record"].ToString();
                    txtSocialSecurityNo.Text = ds.Tables[0].Rows[0]["SocialSecurity_No"].ToString();
                    dtpAdmissionDate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["Patient_Admission_Date"].ToString());
                    drpPhysician.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0]["Patient_Physician"].ToString());
                    drpRefferedBy.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0]["Reffered_By"].ToString());
                    txtRoomNo.Text = ds.Tables[0].Rows[0]["Patient_Room_No"].ToString();
                    drpMedCart.Text = ds.Tables[0].Rows[0]["Patient_Med_Cart"].ToString();
                    txtAllergies.Text = ds.Tables[0].Rows[0]["Patient_Allergies"].ToString();
                    txtDiagnosis.Text = ds.Tables[0].Rows[0]["Patient_Diagnosis"].ToString();
                    txtDiets.Text = ds.Tables[0].Rows[0]["Patient_Diets"].ToString();
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Living_Will"].ToString()) == true)
                    {
                        chkLivingWill.Checked = true;
                    }
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Mobility_Devices"].ToString()) == true)
                    {
                        chkMobilityDevice.Checked = true;
                    }
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["IsGlasses"].ToString()) == true)
                    {
                        chkGlasses.Checked = true;
                    }
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["IsDenture"].ToString()) == true)
                    {
                        chkDenture.Checked = true;
                    }
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Isprimary_Insurance"].ToString()) == true)
                    {
                        chkInsurance.Checked = true;
                    }
                    #endregion
                }
            }
        }

        public void FillDrpPhysician()
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectActivePhysician();
            if (ds.Tables[0].Rows.Count > 0)
            {
                drpPhysician.DataSource = ds.Tables[0];
                drpPhysician.DisplayMember = "Physician_Name";
                drpPhysician.ValueMember = "Physician_ID";
            }
        }

        public void FillDrpRefered()
        {
            PatientMethods PM = new PatientMethods();
            DataSet ds = PM.SelectActivePhysician();
            if (ds.Tables[0].Rows.Count > 0)
            {
                drpRefferedBy.DataSource = ds.Tables[0];
                drpRefferedBy.DisplayMember = "Physician_Name";
                drpRefferedBy.ValueMember = "Physician_ID";
            }
        }

        private void btnEditResident_Click(object sender, EventArgs e)
        {
            this.tbcMain.SelectedTab = tabProfile;
            this.tbcSecond.SelectedTab = tabPatientProfile;
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
                MessageBox.Show("patient code is required!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (drpGender.Text == string.Empty || drpGender.Text == "")
            {
                MessageBox.Show("please select patient gender!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (drpPatientStatus.Text == string.Empty || drpPatientStatus.Text == "")
            {
                MessageBox.Show("please select patient status!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAllergies.Text == string.Empty || txtAllergies.Text == "")
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
                patinetMaster.Patient_ID = Patient_ID;
                patinetMaster.Patient_Code = txtPatientCode.Text.Trim();
                if (pbPatientProfile.Image != null)
                {
                    Image img = pbPatientProfile.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    patinetMaster.Patient_Image = arr;
                }
                else
                {
                    patinetMaster.Patient_Image = new byte[] { };
                }
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
                patinetMaster.Patient_Physician = Convert.ToInt32(drpPhysician.SelectedValue);
                patinetMaster.Reffered_By = Convert.ToInt32(drpRefferedBy.SelectedValue);
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
                patinetMaster.Patient_Allergies = txtAllergies.Text;
                patinetMaster.Patient_Diagnosis = txtDiagnosis.Text;
                patinetMaster.Patient_Diets = txtDiets.Text;
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

        #endregion

        #region [Patient Contacts]
        int Contact_ID = 0;
        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            ClearContacttextBox();
        }

        public void ClearContacttextBox()
        {
            Contact_ID = 0;
            txtPersonName.Text = "";
            drpRelation.Text = "";
            txtMobileNo.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            chkIsPayee.Checked = false;
        }
        public void FillDgvContcats()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectPatientContacts(Patient_ID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvContactsList.DataSource = ds.Tables[0];
                }
            }
        }
        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            if (txtPersonName.Text == "" && txtPersonName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Contact Person Name");
            }
            else if (txtMobileNo.Text == "" && txtMobileNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Contact Person Mobile No");
            }
            else
            {
                ContactMaster CM = new ContactMaster();
                CM.Contact_ID = Contact_ID;
                CM.Patient_ID = Patient_ID;
                CM.Contact_Person = txtPersonName.Text.Trim();
                CM.Patient_Relation = drpRelation.Text;
                if (chkIsPayee.Checked == true)
                {
                    CM.IsPayee = true;
                }
                else
                {
                    CM.IsPayee = false;
                }
                CM.Mobile_No = txtMobileNo.Text.Trim();
                CM.Phone_No = txtPhoneNo.Text.Trim();
                CM.Email_Address = txtEmail.Text.Trim();
                CM.Full_Address = txtAddress.Text.Trim();
                CM.Created_By = 1;
                PatientMethods PM = new PatientMethods();
                byte value = PM.AddUpdateContact(CM);
                string msg = value == 0 ? "Contact Detail Updated" : value == 1 ? "Same Mobile No Already Exists" : "New Contact Added";
                if (value == 1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show(msg);
                    ClearContacttextBox();
                    FillDgvContcats();
                }
            }
        }
        private void dgvContactsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvContactsList.Columns["Edit"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    Contact_ID = Convert.ToInt32(dgvContactsList.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtPersonName.Text = dgvContactsList.Rows[e.RowIndex].Cells[4].Value.ToString();
                    drpRelation.Text = dgvContactsList.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtMobileNo.Text = dgvContactsList.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtPhoneNo.Text = dgvContactsList.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtEmail.Text = dgvContactsList.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtAddress.Text = dgvContactsList.Rows[e.RowIndex].Cells[10].Value.ToString();
                    chkIsPayee.Checked = Convert.ToBoolean(dgvContactsList.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
            }
        }
        #endregion

        #region [Patient Insurance]
        int Insurance_ID = 0;
        public void ClearInsurancetextBox()
        {
            Insurance_ID = 0;
            txtInsuranceName.Text = "";
            txtInsuranceGroupNo.Text = "";
            txtInsuredsId.Text = "";
            txtInsuranceProvider.Text = "";            
        }
        private void btnAddNewInsurance_Click(object sender, EventArgs e)
        {
            ClearInsurancetextBox();
        }
        public void FillDgvInsurance()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectPatientInsurance(Patient_ID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvInsurance.DataSource = ds.Tables[0];
                }
            }
        }
        private void dgvInsurance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvContactsList.Columns["Edit"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    Insurance_ID = Convert.ToInt32(dgvInsurance.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtInsuranceName.Text = dgvInsurance.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtInsuranceGroupNo.Text = dgvInsurance.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtInsuredsId.Text = dgvInsurance.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtInsuranceProvider.Text = dgvInsurance.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
        }
        private void btnSaveInsurance_Click(object sender, EventArgs e)
        {
            if (txtInsuranceGroupNo.Text == "" && txtInsuranceGroupNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Insurance Group No");
            }
            else
            {
                PatientInsuranceMaster PIM = new PatientInsuranceMaster();
                PIM.Insurance_ID = Insurance_ID;
                PIM.Patient_ID = Patient_ID;
                PIM.Insurance_Name = txtInsuranceName.Text.Trim();
                PIM.Insurance_Group_No = txtInsuranceGroupNo.Text.Trim();
                PIM.Insureds_ID = txtInsuredsId.Text.Trim();
                PIM.Insurance_Provider = txtInsuranceProvider.Text.Trim();
                PIM.Created_By = 1;
                PatientMethods PM = new PatientMethods();
                byte value = PM.AddUpdateInsurance(PIM);
                string msg = value == 0 ? "Insurance Detail Updated" : value == 1 ? "Same Insurance Group No Already Exists" : "New Insurance Detail Added";
                if (value == 1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show(msg);
                    ClearInsurancetextBox();
                    FillDgvInsurance();
                }
            }
        }


        #endregion

        #region [Patient Medication]
        public void FillDgvMedications()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectPatientMedication(Patient_ID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvMedicationList.DataSource = ds.Tables[0];
                }
            }
        }
        private void btnAddNewMedication_Click(object sender, EventArgs e)
        {
            frmAddPatientMedication APM = new frmAddPatientMedication();
            APM.ShowDialog();
        }
        #endregion

        private void dgvMedicationList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgvMedicationList.Columns["Edit"].Index)
            //{
            //    if (e.RowIndex >= 0)
            //    {
            //        Insurance_ID = Convert.ToInt32(dgvInsurance.Rows[e.RowIndex].Cells[2].Value.ToString());
            //        txtInsuranceName.Text = dgvInsurance.Rows[e.RowIndex].Cells[4].Value.ToString();
            //        txtInsuranceGroupNo.Text = dgvInsurance.Rows[e.RowIndex].Cells[5].Value.ToString();
            //        txtInsuredsId.Text = dgvInsurance.Rows[e.RowIndex].Cells[6].Value.ToString();
            //        txtInsuranceProvider.Text = dgvInsurance.Rows[e.RowIndex].Cells[7].Value.ToString();
            //    }
            //}
        }
    }
}

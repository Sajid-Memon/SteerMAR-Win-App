using SteerMAR.App_Code.BusinessLogics;
using SteerMAR.Reports;
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
        public static int MedicationID = 0;
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
                FillDgvDiscontinue();
                FillDgvDocuments();
                FillDgvInfoOrders();
                fillDgvAssignment();
                fillDgvComment();
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
                    if (ds.Tables[0].Rows[0]["Patient_Image"] != DBNull.Value)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Patient_Image"]);
                        if (ms.Length > 0)
                        {
                            pbMainProfile.Image = new Bitmap(ms);
                            pbPatientProfile.Image = new Bitmap(ms);
                        }
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
                patinetMaster.FacilityCode = "TA1";
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
                CM.Created_By = Convert.ToInt32(Properties.Settings.Default.LoggedUser);
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
                PIM.Created_By = Convert.ToInt32(Properties.Settings.Default.LoggedUser);
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
                DataSet ds = PM.SelectPatientMedication(Patient_ID, true);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    dt.Columns.Add("MedState", typeof(Image));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["MedState"] = Properties.Resources.active;
                    }
                    dgvMedicationList.DataSource = dt;
                }
            }
        }
        public void FillDgvDiscontinue()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectPatientMedication(Patient_ID, false);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    dt.Columns.Add("MedState", typeof(Image));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["MedState"] = Properties.Resources.inactive;
                    }
                    dgvDiscontinueMedications.DataSource = dt;
                }
            }
        }
        private void btnAddNewMedication_Click(object sender, EventArgs e)
        {
            frmAddPatientMedication APM = new frmAddPatientMedication(this);
            APM.ShowDialog();
        }

        private void dgvMedicationList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMedicationList.Columns["EditMed"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    MedicationID = Convert.ToInt32(dgvMedicationList.Rows[e.RowIndex].Cells[2].Value.ToString());
                    frmAddPatientMedication APM = new frmAddPatientMedication(this);
                    APM.ShowDialog();
                }
            }
            if (e.ColumnIndex == dgvMedicationList.Columns["State"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    string msg = "";
                    DialogResult dialogResult = MessageBox.Show("Are you Sure! You Want To Discontinue this Medication?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MedicationID = Convert.ToInt32(dgvMedicationList.Rows[e.RowIndex].Cells[2].Value.ToString());
                        bool MedState = Convert.ToBoolean(dgvMedicationList.Rows[e.RowIndex].Cells[9].Value.ToString());
                        PatientMethods PM = new PatientMethods();
                        msg = PM.ChangeMedState(MedicationID, false);
                        MessageBox.Show(msg);
                        FillDgvMedications();
                        FillDgvDiscontinue();
                    }
                }
            }
            if (e.ColumnIndex == dgvMedicationList.Columns["ViewMed"].Index)
            {
                if (e.RowIndex >= 0)
                {                    
                    MedicationID = Convert.ToInt32(dgvMedicationList.Rows[e.RowIndex].Cells[2].Value.ToString());
                    frmMedScheduleList FMS = new frmMedScheduleList();
                    FMS.ShowDialog();
                }
            }
        }
        private void dgvDiscontinueMedications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDiscontinueMedications.Columns["disEdit"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    MedicationID = Convert.ToInt32(dgvDiscontinueMedications.Rows[e.RowIndex].Cells[2].Value.ToString());
                    frmAddPatientMedication APM = new frmAddPatientMedication(this);
                    APM.ShowDialog();
                }
            }
            if (e.ColumnIndex == dgvDiscontinueMedications.Columns["disState"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    string msg = "";
                    DialogResult dialogResult = MessageBox.Show("Are you Sure! You Want To Continue This Medication?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MedicationID = Convert.ToInt32(dgvDiscontinueMedications.Rows[e.RowIndex].Cells[2].Value.ToString());
                        bool MedState = Convert.ToBoolean(dgvDiscontinueMedications.Rows[e.RowIndex].Cells[9].Value.ToString());
                        PatientMethods PM = new PatientMethods();
                        msg = PM.ChangeMedState(MedicationID, true);
                        MessageBox.Show(msg);
                        FillDgvMedications();
                        FillDgvDiscontinue();
                    }
                }
            }
        }
        #endregion

        #region [Patient Documents]
        public void FillDgvDocuments()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectPatientDocuments(Patient_ID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvDocuments.DataSource = ds.Tables[0];
                }
            }
        }
        byte[] bytesDoc;
        string FileType = "";
        int DocumentID = 0;

        public void ClearDocumenttextBox()
        {
            txtDocumentName.Text = "";
            txtFileName.Text = "";
            txtDescription.Text = "";
            bytesDoc = null;
            FileType = "";
            DocumentID = 0;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fpDocumentUpload.InitialDirectory = "C://Desktop";
            fpDocumentUpload.Title = "Select Document";
            if (fpDocumentUpload.ShowDialog() == DialogResult.OK)
            {
                string fileName = fpDocumentUpload.FileName;
                txtFileName.Text = fileName.ToString();
                FileType = Path.GetExtension(fileName);
                bytesDoc = File.ReadAllBytes(fileName);
            }
        }
        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            if (txtDocumentName.Text == "" && txtDocumentName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Document Name");
            }
            else if (bytesDoc == null)
            {
                MessageBox.Show("Please Select Document to Upload");
            }
            else
            {
                PatientDocumentMaster PDM = new PatientDocumentMaster();
                PDM.Document_ID = DocumentID;
                PDM.Patient_ID = Patient_ID;
                PDM.Document_Data = bytesDoc;
                PDM.Document_Type = FileType;
                PDM.Document_Name = txtDocumentName.Text.Trim();
                PDM.Document_Description = txtDescription.Text.Trim();
                PDM.Created_By = Convert.ToInt32(Properties.Settings.Default.LoggedUser);
                PatientMethods PM = new PatientMethods();
                byte value = PM.AddUpdateDocument(PDM);
                string msg = value == 0 ? "Document Updated" : value == 1 ? "Same Document Name Already Exists" : "New Document Added";
                if (value == 1)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show(msg);
                    FillDgvDocuments();
                    ClearDocumenttextBox();
                }
            }
        }
        private void dgvDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDocuments.Columns["Download"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    byte[] bytes;
                    string fileName, contentType;
                    bytes = (byte[])dgvDocuments.Rows[e.RowIndex].Cells[5].Value;
                    fileName = dgvDocuments.Rows[e.RowIndex].Cells[4].Value.ToString();
                    contentType = dgvDocuments.Rows[e.RowIndex].Cells[6].Value.ToString();

                    Stream stream;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = fileName + "." + contentType;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        stream = saveFileDialog.OpenFile();
                        stream.Write(bytes, 0, bytes.Length);
                        stream.Close();
                        MessageBox.Show("Downloaded...");
                    }
                }
            }
            if (e.ColumnIndex == dgvContactsList.Columns["Edit"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    DocumentID = Convert.ToInt32(dgvDocuments.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtDocumentName.Text = dgvDocuments.Rows[e.RowIndex].Cells[4].Value.ToString();
                    bytesDoc = (byte[])dgvDocuments.Rows[e.RowIndex].Cells[5].Value;
                    FileType = dgvDocuments.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtDescription.Text = dgvDocuments.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
        }

        private void btnAddNewDoc_Click(object sender, EventArgs e)
        {
            ClearDocumenttextBox();
        }
        #endregion

        #region [Info Orders]
        public static int TaskID = 0;
        private void btnAddNewInfoOrder_Click(object sender, EventArgs e)
        {
            frmAddInfoOrder AIF = new frmAddInfoOrder(this);
            AIF.lblHeader.Text = "Info Order";
            AIF.ShowDialog();
        }
        public void FillDgvInfoOrders()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectPatientUserTask(Patient_ID, "Info Order");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvInfoOrderList.DataSource = ds.Tables[0];
                }
            }
        }
        private void dgvInfoOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInfoOrderList.Columns["Reply"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvInfoOrderList.Rows[e.RowIndex].Cells[3].Value.ToString());
                    frmAddResponse APM = new frmAddResponse();
                    APM.ShowDialog();
                }
            }
            if (e.ColumnIndex == dgvInfoOrderList.Columns["View"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvInfoOrderList.Rows[e.RowIndex].Cells[3].Value.ToString());
                    frmResponseList APM = new frmResponseList();
                    APM.ShowDialog();
                }
            }
            if (e.ColumnIndex == dgvInfoOrderList.Columns["DownloadInfo"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvInfoOrderList.Rows[e.RowIndex].Cells[3].Value.ToString());
                    if (TaskID > 0)
                    {
                        FillReportRes(TaskID, "OrdersResp");
                    }
                }
            }
        }

        #endregion

        #region [Assignment]
        private void btnAddNewAssignMent_Click(object sender, EventArgs e)
        {
            frmAddInfoOrder AIF = new frmAddInfoOrder(this);
            AIF.lblHeader.Text = "Assignment";
            AIF.ShowDialog();
        }
        public void fillDgvAssignment()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectPatientUserTask(Patient_ID, "Assignment");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvAssignment.DataSource = ds.Tables[0];
                }
            }
        }
        private void dgvAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAssignment.Columns["ReplyAssignment"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvAssignment.Rows[e.RowIndex].Cells[3].Value.ToString());
                    frmAddResponse APM = new frmAddResponse();
                    APM.ShowDialog();
                }
            }
            if (e.ColumnIndex == dgvAssignment.Columns["ViewAssignment"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvAssignment.Rows[e.RowIndex].Cells[3].Value.ToString());
                    frmResponseList APM = new frmResponseList();
                    APM.ShowDialog();
                }
            }
            if (e.ColumnIndex == dgvAssignment.Columns["DownloadAssignment"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvAssignment.Rows[e.RowIndex].Cells[3].Value.ToString());
                    if (TaskID > 0)
                    {
                        FillReportRes(TaskID, "AssignmentResp");
                    }
                }
            }
        }
        #endregion

        #region [Comment]
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            frmAddInfoOrder AIF = new frmAddInfoOrder(this);
            AIF.lblHeader.Text = "Comment";
            AIF.ShowDialog();
        }
        public void fillDgvComment()
        {
            if (Patient_ID > 0)
            {
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectPatientUserTask(Patient_ID, "Comment");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvComments.DataSource = ds.Tables[0];
                }
            }
        }
        private void dgvComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvComments.Columns["ReplyComment"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvComments.Rows[e.RowIndex].Cells[3].Value.ToString());
                    frmAddResponse APM = new frmAddResponse();
                    APM.ShowDialog();
                }
            }
            if (e.ColumnIndex == dgvComments.Columns["ViewComment"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvComments.Rows[e.RowIndex].Cells[3].Value.ToString());
                    frmResponseList APM = new frmResponseList();
                    APM.ShowDialog();
                }
            }
            if (e.ColumnIndex == dgvComments.Columns["DownloadComment"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    TaskID = Convert.ToInt32(dgvComments.Rows[e.RowIndex].Cells[3].Value.ToString());
                    if (TaskID > 0)
                    {
                        FillReportRes(TaskID, "CommentsResp");
                    }
                }
            }
        }
        #endregion

        #region [Response Print]
        public void FillReportRes(int TaskID, string type)
        {
            PrintingMethods PM = new PrintingMethods();
            DataSet ds = PM.PrintUserTaskResponse(TaskID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                rptResponses RR = new rptResponses();
                RR.Load(@"~\Reports\rptResponses.rpt");
                RR.SetDataSource(ds.Tables[0]);
                RR.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\" + type + ".pdf");
                MessageBox.Show("Report Downloaded in Download Folder");
            }
        }
        #endregion
    }
}

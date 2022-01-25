using SteerMAR.App_Code;
using SteerMAR.DatabaseHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteerMAR.Views.MainForms
{
    public partial class frmSubscription : Form
    {
        public frmSubscription()
        {
            InitializeComponent();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (txtStoreCode.Text != string.Empty && txtActivationKey.Text != string.Empty)
            {
                if (txtStoreCode.Text == "542233" && txtActivationKey.Text == "542233")
                {
                    btnActivate.Enabled = false;                  
                    progressBar.Style = ProgressBarStyle.Marquee;
                    progressBar.Show();
                    //await(Task.Run(() =>
                    //{
                        System.Threading.Thread.Sleep(3000);
                        GenerateDatabase(txtStoreCode.Text.Trim());
                    //}));                  
                    progressBar.Hide();
                    btnActivate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Data For Proceed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Fields For Proceed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerateDatabase(string StoreCode)
        {
            if (GlobalUtility.CheckForInternetConnection())
            {
                string localConnectionString = ConfigurationManager.ConnectionStrings["local"].ToString();
                string serverConnectionString = "Data Source=3.136.198.247;Initial Catalog=SteerMAR" + StoreCode + ";Persist Security Info=True;User ID=sa;Password=SteerposDB@123";
                //string[] arrTables = new string[] { "Subscriber", "UserMaster", "UserRole", "EmpShiftSchedule", "EmployeeWorkShift" };
                string[] arrTables = new string[] { "DataP$","DCode","DiagnoisiCodesDetails","Comment_Response","DiagnoisiCodesDetailsSS","DiagnosisCode","Assignment","DiagnosisMaster","DiagnosisReportMaster","DocumentMaster","Assignment_Response","Documents","DosageForm",
                "DrugCompoundDetails","InfoOrder","DrugListing","DrugMaster","InfoOrder_Response","DrugPriceChart","EmployeeWorkShift","DrugVenderItem","Employee","EmployeeShiftSetting","EmployeeMaster","EmployeeNotes","EmployeeNotesHistory","EmployeeWorkHour","FacilitiesAdmin","FacilitiesMaster",
                "facility","Facility_Branch","HeaderMenu","TaskMaster","IncrementNumber","InsuranceMaseterForPatient","TaskDetails","InsuranceMasterCompound","InsuranceMasterDualBilling","InsuranceMasterMiscellaneous","InsuranceMasterPricing","InsurancePlanListing","InsyranceMaseter","EmpShiftSchedule",
                "InventoryMaster","Inventry","LoginDetail","MedRouteType","MenuForRole","Misc","NSDocuments","NSPacking","NursingFormManager","NursingHome","NursingHomeImageInfo","OrderImageInfo","OrderManage","OrderMaster","OrderMgt","OrderPhysicianMaster","orderSchedule","RegDevice","OrderStock",
                "OrganisationMaster","PatientAssignment","PatientConsultation","PatientDoseRecord","PatientInfoOrder","PatientMedFill","PatientPreScreening","Permission","PersonData","PersonDrugInfo","TaskHistory","PersonImageInfo","VitalHistory","PersonInfo","VitalRecord","PharmaHeaderMenu","PharmaMenuforRole",
                "PharmaRole","Vital","PhysicianMaster","PlanMaster","PrescribeDOcument","PrescriptionDocs","Remark","ResidentManage","RxPickup","AdditionalDocInformation","RxProfile","SecurityAdmin","ADLInfo","ServicesMaster","AdminMaster","ASLMenu","StockLedger","Barcode","Subscriber","BasicReport","BillingInfo",
                "SubscriptionInfo","BillingReport","TestDemo","BowelActivity","BuildInRoles","UserImageInfo","ChartNotes","UserMaster","ChartNotesHistory","UserRole","cities","ClinicMeasurement","ContactMaster","Coupon","Comment","CustomRoles"};
                foreach (string table in arrTables)
                {
                    try
                    {
                        DataSynchronizer.Synchronize(table, serverConnectionString, localConnectionString);
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                }
                MessageBox.Show("Database has been Created Sucessfully. /nYou are Good to go!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("Active Internet Connection Required for Syncronize Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

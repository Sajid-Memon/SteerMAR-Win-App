using SteerMAR.DatabaseHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SteerMAR.App_Code.DataAccess.PatientModels;

namespace SteerMAR.App_Code.BusinessLogics
{
    public class PatientMethods : SqlConnectionHelper
    {
        #region [Physician Methods]
        public DataSet SelectActivePhysician()
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetActivePhysicianList", con);
                cmd.CommandType = CommandType.StoredProcedure;                
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region [Patients Methods]
        public DataSet SelectResidentByID(int Patient_ID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_ResidentsDetailsById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet SelectActiveResidentList(string SearchText)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_SelectActiveResidentsList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchText", SearchText);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public byte AddUpdatePatient(PatientMaster model)
        {
            localCon();
            cmd = new SqlCommand("Proc_AddUpdateResident", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Patient_ID", model.Patient_ID);
            cmd.Parameters.AddWithValue("@Patient_Code", model.Patient_Code);
            cmd.Parameters.AddWithValue("@Patient_Image", model.Patient_Image);
            cmd.Parameters.AddWithValue("@Patient_Salutation", model.Patient_Salutation);
            cmd.Parameters.AddWithValue("@First_Name", model.First_Name);
            cmd.Parameters.AddWithValue("@Middle_Name", model.Middle_Name);
            cmd.Parameters.AddWithValue("@Last_Name", model.Last_Name);
            cmd.Parameters.AddWithValue("@Patient_Gender", model.Patient_Gender);
            cmd.Parameters.AddWithValue("@Patient_DOB", model.Patient_DOB);
            cmd.Parameters.AddWithValue("@Maritial_Status", model.Maritial_Status);
            cmd.Parameters.AddWithValue("@Patient_Status", model.Patient_Status);
            cmd.Parameters.AddWithValue("@Patient_Physical_ID", model.Patient_Physical_ID);
            cmd.Parameters.AddWithValue("@Patient_Medical_Record", model.Patient_Medical_Record);
            cmd.Parameters.AddWithValue("@SocialSecurity_No", model.SocialSecurity_No);
            cmd.Parameters.AddWithValue("@Patient_Admission_Date", model.Patient_Admission_Date);
            cmd.Parameters.AddWithValue("@Patient_Physician", model.Patient_Physician);
            cmd.Parameters.AddWithValue("@Reffered_By", model.Reffered_By);
            cmd.Parameters.AddWithValue("@Patient_Room_No", model.Patient_Room_No);
            cmd.Parameters.AddWithValue("@Patient_Med_Cart", model.Patient_Med_Cart);
            cmd.Parameters.AddWithValue("@Living_Will", model.Living_Will);
            cmd.Parameters.AddWithValue("@Mobility_Devices", model.Mobility_Devices);
            cmd.Parameters.AddWithValue("@IsGlasses", model.IsGlasses);
            cmd.Parameters.AddWithValue("@IsDenture", model.IsDenture);
            cmd.Parameters.AddWithValue("@Isprimary_Insurance", model.Isprimary_Insurance);
            cmd.Parameters.AddWithValue("@Allergy_ID", model.Patient_Allergies);
            cmd.Parameters.AddWithValue("@Diagnosis_ID", model.Patient_Diagnosis);
            cmd.Parameters.AddWithValue("@Diet_ID", model.Patient_Diets);            
            cmd.Parameters.AddWithValue("@Created_By", 1);                                    
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
        #endregion

        #region [Patients Contacts Methods]
        public DataSet SelectPatientContacts(int Patient_ID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetPatientContactList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public byte AddUpdateContact(ContactMaster model)
        {
            localCon();
            cmd = new SqlCommand("Proc_AddUpdateResidentContacts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Contact_ID", model.Contact_ID);
            cmd.Parameters.AddWithValue("@Patient_ID", model.Patient_ID);
            cmd.Parameters.AddWithValue("@Contact_Person", model.Contact_Person);
            cmd.Parameters.AddWithValue("@Patient_Relation", model.Patient_Relation);
            cmd.Parameters.AddWithValue("@IsPayee", model.IsPayee);
            cmd.Parameters.AddWithValue("@Mobile_No", model.Mobile_No);
            cmd.Parameters.AddWithValue("@Phone_No", model.Phone_No);
            cmd.Parameters.AddWithValue("@Email_Address", model.Email_Address);
            cmd.Parameters.AddWithValue("@Full_Address", model.Full_Address);            
            cmd.Parameters.AddWithValue("@Created_By", model.Created_By);                        
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
        #endregion

        #region [Patients Vitals Methods]
        public DataSet SelectPatientVitals(int Patient_ID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetPatientVitalList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public byte AddUpdatePatientVitals(PatientVitalMaster model)
        {
            localCon();
            cmd = new SqlCommand("Proc_AddUpdateResidentVitals", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Patient_Vital_ID", model.Patient_Vital_ID);
            cmd.Parameters.AddWithValue("@Patient_ID", model.Patient_ID);
            cmd.Parameters.AddWithValue("@Vital_ID", model.Vital_ID);
            cmd.Parameters.AddWithValue("@Vital_Value", model.Vital_Value);
            cmd.Parameters.AddWithValue("@Taken_Date", model.Taken_Date);
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
        #endregion

        #region [Patients Insurance Methods]
        public DataSet SelectPatientInsurance(int Patient_ID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetPatientInsuranceList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public byte AddUpdateInsurance(PatientInsuranceMaster model)
        {
            localCon();
            cmd = new SqlCommand("Proc_AddUpdateResidentInsurance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Insurance_ID", model.Insurance_ID);
            cmd.Parameters.AddWithValue("@Patient_ID", model.Patient_ID);
            cmd.Parameters.AddWithValue("@Insurance_Name", model.Insurance_Name);
            cmd.Parameters.AddWithValue("@Insurance_Group_No", model.Insurance_Group_No);
            cmd.Parameters.AddWithValue("@Insureds_ID", model.Insureds_ID);
            cmd.Parameters.AddWithValue("@Insurance_Provider", model.Insurance_Provider);            
            cmd.Parameters.AddWithValue("@Created_By", model.Created_By);
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
        #endregion

        #region [Patients Documents Methods]
        public DataSet SelectPatientDocuments(int Patient_ID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetPatientDocumentList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public byte AddUpdateDocument(PatientDocumentMaster model)
        {
            localCon();
            cmd = new SqlCommand("Proc_AddUpdateResidentDocuments", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Document_ID", model.Document_ID);
            cmd.Parameters.AddWithValue("@Patient_ID", model.Patient_ID);
            cmd.Parameters.AddWithValue("@Document_Data", model.Document_Data);
            cmd.Parameters.AddWithValue("@Document_Type", model.Document_Type);
            cmd.Parameters.AddWithValue("@Document_Name", model.Document_Name);
            cmd.Parameters.AddWithValue("@Document_Description", model.Document_Description);                      
            cmd.Parameters.AddWithValue("@Created_By", model.Created_By);            
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
        #endregion

        #region [Patients Medications Methods]

        public DataSet SelectPatientMedication(int Patient_ID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetPatientMedicationList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);            
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet SelectPatientMedicationByMedID(int MedicationID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetPatientMedicationByMedID", con);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@MedicationID", MedicationID);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public byte AddUpdateMedication(PatientMedicationMaster model)
        {
            localCon();
            cmd = new SqlCommand("Proc_AddUpdateResidentMedication", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Medication_ID", model.Medication_ID);
            cmd.Parameters.AddWithValue("@Patient_ID", model.Patient_ID);
            cmd.Parameters.AddWithValue("@Medication_Image", model.Medication_Image);
            cmd.Parameters.AddWithValue("@Medication_Name", model.Medication_Name);
            cmd.Parameters.AddWithValue("@Medication_Equilent_To", model.Medication_Equilent_To);
            cmd.Parameters.AddWithValue("@Medication_NDC", model.Medication_NDC);
            cmd.Parameters.AddWithValue("@Medication_RXNo", model.Medication_RXNo);
            cmd.Parameters.AddWithValue("@Medication_Prescriber", model.Medication_Prescriber);
            cmd.Parameters.AddWithValue("@Medication_Diagnosis", model.Medication_Diagnosis);            
            cmd.Parameters.AddWithValue("@Medication_WriteDate", model.Medication_WriteDate);
            cmd.Parameters.AddWithValue("@Medication_ExpiryDate", model.Medication_ExpiryDate);
            cmd.Parameters.AddWithValue("@Medication_Route", model.Medication_Route);
            cmd.Parameters.AddWithValue("@Medication_Instructions", model.Medication_Instructions);
            cmd.Parameters.AddWithValue("@Controlled_Drugs", model.Controlled_Drugs);
            cmd.Parameters.AddWithValue("@Home_Health_Drugs", model.Home_Health_Drugs);
            cmd.Parameters.AddWithValue("@Medication_PRN", model.Medication_PRN);
            cmd.Parameters.AddWithValue("@Min_PRN", model.Min_PRN);
            cmd.Parameters.AddWithValue("@Max_PRN", model.Max_PRN);
            cmd.Parameters.AddWithValue("@Medication_Time", model.Medication_Time);
            cmd.Parameters.AddWithValue("@Medication_Qty", model.Medication_Qty);
            cmd.Parameters.AddWithValue("@Medication_Details", model.Medication_Details);
            cmd.Parameters.AddWithValue("@Medication_WeekDays", model.Medication_WeekDays);
            cmd.Parameters.AddWithValue("@Med_State", model.Med_State);
            cmd.Parameters.AddWithValue("@Created_By", model.Created_By);            
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
        public string ChangeMedState(int MedID,bool State)
        {
            localCon();
            cmd = new SqlCommand("UPDATE Patient_Medication_Master SET Med_State = @State WHERE Medication_ID = @MedID", con);
            cmd.Parameters.AddWithValue("@MedID", MedID);
            cmd.Parameters.AddWithValue("@State", State);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Medication State Has Been Changed !";
        }
        #endregion

        #region [Patients Info Order Methods]

        public DataSet SelectPatientUserTask(int Patient_ID,string TaskType)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetPatientTaskList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                cmd.Parameters.AddWithValue("@Task_Type", TaskType);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public byte AddUpdatePatientUserTask(UserTaskMaster model)
        {
            localCon();
            cmd = new SqlCommand("Proc_AddUpdateResidentUserTask", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Task_ID", model.Task_ID);
            cmd.Parameters.AddWithValue("@Patient_ID", model.Patient_ID);
            cmd.Parameters.AddWithValue("@Task_Type", model.Task_Type);
            cmd.Parameters.AddWithValue("@Task_Text", model.Task_Text);
            cmd.Parameters.AddWithValue("@Created_By", model.Created_By);            
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
        #endregion

        #region [Patients Response Methods]

        public DataSet SelectUserTaskResponse(int TaskID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetTaskResponse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Task_ID", TaskID);                
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public byte AddUpdateUserTaskResponse(ResponseMaster model)
        {
            localCon();
            cmd = new SqlCommand("Proc_AddUpdateResidentTaskResponse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Response_ID", model.Response_ID);
            cmd.Parameters.AddWithValue("@Task_ID", model.Task_ID);
            cmd.Parameters.AddWithValue("@Response_Text", model.Response_Text);            
            cmd.Parameters.AddWithValue("@Created_By", model.Created_By);
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
        #endregion
    }
}

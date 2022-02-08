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
    }
}

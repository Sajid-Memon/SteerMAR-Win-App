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
            cmd.Parameters.AddWithValue("@Allergy_ID", model.Allergy_ID);
            cmd.Parameters.AddWithValue("@Diagnosis_ID", model.Diagnosis_ID);
            cmd.Parameters.AddWithValue("@Diet_ID", model.Diet_ID);            
            cmd.Parameters.AddWithValue("@Created_By", 1);                                    
            SqlParameter spRetVar = new SqlParameter("@retval", SqlDbType.TinyInt);
            spRetVar.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(spRetVar);
            cmd.ExecuteNonQuery();
            byte retVal = Convert.ToByte(cmd.Parameters["@retval"].Value.ToString());
            con.Close();
            return retVal;
        }
    }
}

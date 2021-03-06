using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteerMAR.App_Code.DataAccess
{
    public class PatientModels
    {
        public class PatientMaster
        {
            public int Patient_ID { get; set; }
            public string Patient_Code { get; set; }
            public byte[] Patient_Image { get; set; }
            public string Patient_Salutation { get; set; }
            public string First_Name { get; set; }
            public string Middle_Name { get; set; }
            public string Last_Name { get; set; }
            public string Patient_Gender { get; set; }
            public DateTime Patient_DOB { get; set; }
            public string Maritial_Status { get; set; }
            public string Patient_Status { get; set; }
            public string Patient_Physical_ID { get; set; }
            public string Patient_Medical_Record { get; set; }
            public string SocialSecurity_No { get; set; }
            public DateTime Patient_Admission_Date { get; set; }
            public int Patient_Physician { get; set; }
            public int Reffered_By { get; set; }
            public string Patient_Room_No { get; set; }
            public string Patient_Med_Cart { get; set; }
            public bool Living_Will { get; set; }
            public bool Mobility_Devices { get; set; }
            public bool IsGlasses { get; set; }
            public bool IsDenture { get; set; }
            public bool Isprimary_Insurance { get; set; }
            public string Patient_Allergies { get; set; }
            public string Patient_Diagnosis { get; set; }
            public string Patient_Diets { get; set; }
            public string FacilityCode { get; set; }
            public bool isActive { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_DateTime { get; set; }
            public int UpDateTimed_By { get; set; }
            public DateTime UpDateTimed_DateTime { get; set; }
        }
        public class ContactMaster
        {
            public int Contact_ID { get; set; }
            public int Patient_ID { get; set; }
            public string Contact_Person { get; set; }
            public string Patient_Relation { get; set; }
            public bool IsPayee { get; set; }
            public string Mobile_No { get; set; }
            public string Phone_No { get; set; }
            public string Email_Address { get; set; }
            public string Full_Address { get; set; }
            public bool isActive { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_Date { get; set; }
            public int Updated_By { get; set; }
            public DateTime Updated_Date { get; set; }
        }
        public class PatientVitalMaster
        {
            public int Patient_Vital_ID { get; set; }
            public int Patient_ID { get; set; }
            public int Vital_ID { get; set; }
            public string Vital_Value { get; set; }
            public DateTime Taken_Date { get; set; }
        }
        public class PatientInsuranceMaster
        {
            public int Insurance_ID { get; set; }
            public int Patient_ID { get; set; }
            public string Insurance_Name { get; set; }
            public string Insurance_Group_No { get; set; }
            public string Insureds_ID { get; set; }
            public string Insurance_Provider { get; set; }
            public bool isActive { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_Date { get; set; }
            public int Updated_By { get; set; }
            public DateTime Updated_Date { get; set; }
        }
        public class PatientMedicationMaster
        {
            public int Medication_ID { get; set; }
            public int Patient_ID { get; set; }
            public byte[] Medication_Image { get; set; }
            public string Medication_Name { get; set; }
            public string Med_Strength { get; set; }
            public string Med_Form { get; set; }
            public string Medication_Equilent_To { get; set; }
            public string Medication_NDC { get; set; }
            public string Medication_RXNo { get; set; }
            public int Medication_Prescriber { get; set; }
            public string Medication_Diagnosis { get; set; }            
            public DateTime Medication_WriteDate { get; set; }
            public DateTime Medication_ExpiryDate { get; set; }
            public string Medication_Route { get; set; }
            public string Medication_Instructions { get; set; }
            public bool Controlled_Drugs { get; set; }
            public bool Home_Health_Drugs { get; set; }
            public bool Medication_PRN { get; set; }
            public string Min_PRN { get; set; }
            public string Max_PRN { get; set; }         
            public bool Med_State { get; set; }
            public bool IsActive { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_Date { get; set; }
            public int Updated_By { get; set; }
            public DateTime Updated_Date { get; set; }
        }
        public class MedSchedule
        {
            public int Id { get; set; }
            public int MedId { get; set; }
            public int PatientId { get; set; }
            public string MedTime { get; set; }
            public string Qty { get; set; }
            public string Detail { get; set; }
            public string Weekdays { get; set; }
        }
        public class PatientDocumentMaster
        {
            public int Document_ID { get; set; }
            public int Patient_ID { get; set; }
            public byte[] Document_Data { get; set; }
            public string Document_Type { get; set; }
            public string Document_Name { get; set; }
            public string Document_Description { get; set; }            
            public bool isActive { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_Date { get; set; }
            public int Updated_By { get; set; }
            public DateTime Updated_Date { get; set; }
        }
        public class UserTaskMaster
        {
            public int Task_ID { get; set; }
            public int Patient_ID { get; set; }
            public string Task_Type { get; set; }
            public string Task_Text { get; set; }
            public bool IsActive { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_Date { get; set; }
            public int Updated_By { get; set; }
            public DateTime Updated_Date { get; set; }
        }
        public class ResponseMaster
        {
            public int Response_ID { get; set; }
            public int Task_ID { get; set; }
            public string Response_Text { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_Date { get; set; }
            public int Updated_By { get; set; }
            public DateTime Updated_Date { get; set; }
        }
    }
}

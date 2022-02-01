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
            public string Allergy_ID { get; set; }
            public string Diagnosis_ID { get; set; }
            public string Diet_ID { get; set; }
            public bool isActive { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_DateTime { get; set; }
            public int UpDateTimed_By { get; set; }
            public DateTime UpDateTimed_DateTime { get; set; }
        }
    }
}

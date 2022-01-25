using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteerMAR.App_Code.DataAccess
{
    public class SetupModels
    {
        public class UserModel
        {
            public int User_ID { get; set; }
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string User_Email { get; set; }
            public string User_Phone { get; set; }
            public int Role_ID { get; set; }
            public int Shift_ID { get; set; }
            public string PIN_No { get; set; }
            public string User_Password { get; set; }
            public DateTime User_DOB { get; set; }
            public DateTime User_Joining_Date { get; set; }
            public DateTime User_Anniversary_Date { get; set; }
            public bool isActive { get; set; }
            public int Created_By { get; set; }
            public DateTime Created_Date { get; set; }
            public int Updated_By { get; set; }
            public DateTime Updated_Date { get; set; }
        }
        public class AttendanceModel
        {
            public int Attendance_ID { get; set; }
            public int User_ID { get; set; }
            public DateTime Login_Date { get; set; }
            public DateTime ClockIn_Time { get; set; }
            public DateTime ClockOut_Time { get; set; }
            public DateTime Working_Hour { get; set; }
        }
    }
}

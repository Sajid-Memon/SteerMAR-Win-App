using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SteerMAR.App_Code
{
    class GlobalUtility
    {
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.com/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckDatabaseExists()
        {
            DataSet ds;
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local"].ToString());
            string strCreatecmd = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME LIKE '%UserMaster%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(strCreatecmd, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

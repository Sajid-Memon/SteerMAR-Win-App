using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteerMAR.DatabaseHelper
{
    public class SqlConnectionHelper
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataAdapter da;
        protected DataSet ds;
        protected DataTable dt;

        protected void localCon()
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
                con.Open();
            }
            catch (Exception)
            {

            }
        }
        public void ServerCon()
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["Server"].ToString());
                con.Open();
            }
            catch (Exception)
            {

            }
        }
    }
}

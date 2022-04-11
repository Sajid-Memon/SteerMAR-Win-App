using SteerMAR.DatabaseHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteerMAR.App_Code.BusinessLogics
{
    public class PrintingMethods : SqlConnectionHelper
    {
        public DataSet PrintUserTaskResponse(int TaskID)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_PrintTaskResponse", con);
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
    }
}

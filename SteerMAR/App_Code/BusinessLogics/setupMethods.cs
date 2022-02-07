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
    public class setupMethods : SqlConnectionHelper
    {
        #region [Patients Vitals Methods]
        public DataSet SelectActiveVitals()
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_GetActiveVitalList", con);
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
    }
}
